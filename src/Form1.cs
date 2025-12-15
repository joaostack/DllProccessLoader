using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace DllProccessLoader
{
    public partial class MainForm : Form
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        const int PROCESS_CREATE_THREAD = 0x0002;
        const int PROCESS_QUERY_INFORMATION = 0x0400;
        const int PROCESS_VM_OPERATION = 0x0008;
        const int PROCESS_VM_WRITE = 0x0020;
        const int PROCESS_VM_READ = 0x0010;
        const uint MEM_COMMIT = 0x00001000;
        const uint MEM_RESERVE = 0x00002000;
        const uint PAGE_READWRITE = 4;

        private OpenFileDialog dllDialog;
        private Process[] processes;
        private string targetDllPath;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds a DLL file to the list box when the button is clicked.
        /// </summary>
        private void addDllButton_Click(object sender, EventArgs e)
        {
            try
            {
                dllDialog = new OpenFileDialog
                {
                    Filter = "DLL Files (*.dll)|*.dll",
                    Title = "Select a DLL File"
                };

                if (dllDialog.ShowDialog() == DialogResult.OK)
                {
                    targetDllPath = dllDialog.FileName;
                }

                if (!string.IsNullOrEmpty(targetDllPath))
                {
                    listDllBox.Items.Add(targetDllPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Removes the selected DLL file from the list box when the button is clicked.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedListDll = listDllBox.SelectedItem;
                if (selectedListDll != null)
                {
                    listDllBox.Items.Remove(selectedListDll);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // On load, get process list and add to process listbox
        private void MainForm_Load(object sender, EventArgs e)
        {
            processes = Process.GetProcesses();

            foreach (var process in processes)
            {
                processList.Items.Add($"{process.ProcessName} | PID: {process.Id}");
            }
        }

        // Refresh process list
        private void refreshProcessButton_Click(object sender, EventArgs e)
        {
            processList.Items.Clear();
            processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                processList.Items.Add($"{process.ProcessName} | PID: {process.Id}");
            }
        }

        // Select target process
        private void selectProcessButton_Click(object sender, EventArgs e)
        {
            var selectedProccess = processList.SelectedItem;
            if (selectedProccess != null)
            {
                MessageBox.Show("Selected Process: " + selectedProccess.ToString(), "Process Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // inject dll into the process
        private void injectDllButton_Click(object sender, EventArgs e)
        {
            var selectedProcess = processList.SelectedItem?.ToString();
            var selectedDllFile = listDllBox.SelectedItem;
            if (!string.IsNullOrEmpty(selectedProcess) && selectedDllFile != null)
            {
                var selectedProcessPid = selectedProcess.Split(':')[1].Trim();
                var process = Process.GetProcessById(int.Parse(selectedProcessPid));
                IntPtr procHandle = OpenProcess(PROCESS_CREATE_THREAD | PROCESS_QUERY_INFORMATION | PROCESS_VM_OPERATION | PROCESS_VM_WRITE | PROCESS_VM_READ, false, process.Id);
                IntPtr loadLibraryAddr = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");

                var dllName = Path.GetFullPath(targetDllPath);
                IntPtr allocMemAddress = VirtualAllocEx(procHandle, IntPtr.Zero, (uint)((dllName.Length + 1) * Marshal.SizeOf(typeof(char))), MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);

                UIntPtr bytesWritten;
                WriteProcessMemory(procHandle, allocMemAddress, Encoding.Default.GetBytes(dllName), (uint)((dllName.Length + 1) * Marshal.SizeOf(typeof(char))), out bytesWritten);

                CreateRemoteThread(procHandle, IntPtr.Zero, 0, loadLibraryAddr, allocMemAddress, 0, IntPtr.Zero);

                MessageBox.Show("DLL injected successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No process selected for DLL injection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}