namespace DllProccessLoader
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            processList = new ListBox();
            selectProcessButton = new Button();
            injectDllButton = new Button();
            addDllButton = new Button();
            label1 = new Label();
            selectedDllFile = new OpenFileDialog();
            listDllBox = new ListBox();
            label2 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            refreshProcessButton = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // processList
            // 
            processList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            processList.BackColor = Color.FromArgb(30, 30, 30);
            processList.BorderStyle = BorderStyle.None;
            processList.ForeColor = Color.White;
            processList.FormattingEnabled = true;
            processList.Location = new Point(12, 56);
            processList.Name = "processList";
            processList.Size = new Size(428, 105);
            processList.TabIndex = 0;
            // 
            // selectProcessButton
            // 
            selectProcessButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            selectProcessButton.BackColor = Color.FromArgb(37, 37, 37);
            selectProcessButton.Cursor = Cursors.Hand;
            selectProcessButton.FlatAppearance.BorderSize = 0;
            selectProcessButton.FlatStyle = FlatStyle.Flat;
            selectProcessButton.Font = new Font("Liberation Mono", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectProcessButton.ForeColor = Color.Aqua;
            selectProcessButton.Location = new Point(446, 56);
            selectProcessButton.Name = "selectProcessButton";
            selectProcessButton.Size = new Size(125, 48);
            selectProcessButton.TabIndex = 1;
            selectProcessButton.Text = "Select Process";
            selectProcessButton.UseVisualStyleBackColor = false;
            selectProcessButton.Click += selectProcessButton_Click;
            // 
            // injectDllButton
            // 
            injectDllButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            injectDllButton.BackColor = Color.FromArgb(0, 255, 170);
            injectDllButton.Cursor = Cursors.Hand;
            injectDllButton.FlatAppearance.BorderSize = 0;
            injectDllButton.FlatStyle = FlatStyle.Flat;
            injectDllButton.Font = new Font("Liberation Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            injectDllButton.ForeColor = Color.Black;
            injectDllButton.Location = new Point(12, 400);
            injectDllButton.Name = "injectDllButton";
            injectDllButton.Size = new Size(559, 42);
            injectDllButton.TabIndex = 2;
            injectDllButton.Text = "INJECT";
            injectDllButton.UseVisualStyleBackColor = false;
            injectDllButton.Click += injectDllButton_Click;
            // 
            // addDllButton
            // 
            addDllButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addDllButton.BackColor = Color.FromArgb(37, 37, 37);
            addDllButton.Cursor = Cursors.Hand;
            addDllButton.FlatAppearance.BorderSize = 0;
            addDllButton.FlatStyle = FlatStyle.Flat;
            addDllButton.Font = new Font("Liberation Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addDllButton.ForeColor = Color.Aqua;
            addDllButton.Location = new Point(443, 184);
            addDllButton.Name = "addDllButton";
            addDllButton.Size = new Size(125, 48);
            addDllButton.TabIndex = 3;
            addDllButton.Text = "Add DLL";
            addDllButton.UseVisualStyleBackColor = false;
            addDllButton.Click += addDllButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Liberation Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(197, 17);
            label1.TabIndex = 4;
            label1.Text = "Select Target Process";
            // 
            // selectedDllFile
            // 
            selectedDllFile.FileName = "selectedDllFile";
            // 
            // listDllBox
            // 
            listDllBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listDllBox.BackColor = Color.FromArgb(30, 30, 30);
            listDllBox.BorderStyle = BorderStyle.None;
            listDllBox.ForeColor = Color.White;
            listDllBox.FormattingEnabled = true;
            listDllBox.Items.AddRange(new object[] { "..." });
            listDllBox.Location = new Point(12, 184);
            listDllBox.Name = "listDllBox";
            listDllBox.Size = new Size(425, 210);
            listDllBox.TabIndex = 5;
            listDllBox.Tag = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Liberation Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 164);
            label2.Name = "label2";
            label2.Size = new Size(98, 17);
            label2.TabIndex = 6;
            label2.Text = "Select DLL";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(37, 37, 37);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Liberation Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Aqua;
            button1.Location = new Point(443, 238);
            button1.Name = "button1";
            button1.Size = new Size(125, 48);
            button1.TabIndex = 7;
            button1.Text = "Remove DLL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Liberation Mono", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.FromArgb(0, 221, 255);
            linkLabel1.Location = new Point(220, 22);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(145, 12);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "github.com/joaostack";
            linkLabel1.VisitedLinkColor = Color.FromArgb(0, 160, 204);
            // 
            // refreshProcessButton
            // 
            refreshProcessButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            refreshProcessButton.BackColor = Color.FromArgb(37, 37, 37);
            refreshProcessButton.Cursor = Cursors.Hand;
            refreshProcessButton.FlatAppearance.BorderSize = 0;
            refreshProcessButton.FlatStyle = FlatStyle.Flat;
            refreshProcessButton.Font = new Font("Liberation Mono", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            refreshProcessButton.ForeColor = Color.Aqua;
            refreshProcessButton.Location = new Point(446, 113);
            refreshProcessButton.Name = "refreshProcessButton";
            refreshProcessButton.Size = new Size(125, 48);
            refreshProcessButton.TabIndex = 10;
            refreshProcessButton.Text = "Refresh";
            refreshProcessButton.UseVisualStyleBackColor = false;
            refreshProcessButton.Click += refreshProcessButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Liberation Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(206, 5);
            label3.Name = "label3";
            label3.Size = new Size(179, 17);
            label3.TabIndex = 11;
            label3.Text = "Dll Proccess Loader";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 12, 12);
            ClientSize = new Size(583, 454);
            Controls.Add(label3);
            Controls.Add(refreshProcessButton);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(listDllBox);
            Controls.Add(label1);
            Controls.Add(addDllButton);
            Controls.Add(injectDllButton);
            Controls.Add(selectProcessButton);
            Controls.Add(processList);
            Font = new Font("Liberation Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(224, 224, 224);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dll Proccess Loader";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox processList;
        private Button selectProcessButton;
        private Button injectDllButton;
        private Button addDllButton;
        private Label label1;
        private OpenFileDialog selectedDllFile;
        private ListBox listDllBox;
        private Label label2;
        private Button button1;
        private LinkLabel linkLabel1;
        private Button refreshProcessButton;
        private Label label3;
    }
}
