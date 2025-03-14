namespace TaskList
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            UpButton = new Button();
            DownButton = new Button();
            EditButton = new Button();
            RemoveButton = new Button();
            AddButton = new Button();
            DisplayTextBox = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newChecklistToolStripMenuItem = new ToolStripMenuItem();
            openChecklistToolStripMenuItem = new ToolStripMenuItem();
            saveChecklistToolStripMenuItem = new ToolStripMenuItem();
            saveChecklistAsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            checklistNameToolStripMenuItem = new ToolStripMenuItem();
            removeChecklistToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            alwaysOnTopToolStripMenuItem = new ToolStripMenuItem();
            transparencyToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBox1 = new ToolStripComboBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            NotesBox = new RichTextBox();
            ProgressTracker = new TrackBar();
            ProgressLabel = new Label();
            NotesLabel = new Label();
            FileBox = new ListBox();
            FilesLabel = new Label();
            AddFileButton = new Button();
            openFileDialog2 = new OpenFileDialog();
            TaskLabel = new Label();
            FolderButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SaveNotesButton = new Button();
            RemoveFileButton = new Button();
            BigSplit = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProgressTracker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BigSplit).BeginInit();
            BigSplit.Panel1.SuspendLayout();
            BigSplit.Panel2.SuspendLayout();
            BigSplit.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.Click += splitContainer1_Panel1_Click_1;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(UpButton);
            splitContainer1.Panel2.Controls.Add(DownButton);
            splitContainer1.Panel2.Controls.Add(EditButton);
            splitContainer1.Panel2.Controls.Add(RemoveButton);
            splitContainer1.Panel2.Controls.Add(AddButton);
            splitContainer1.Panel2.Controls.Add(DisplayTextBox);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Click += splitContainer1_Panel2_Click;
            splitContainer1.Size = new Size(286, 425);
            splitContainer1.SplitterDistance = 323;
            splitContainer1.TabIndex = 0;
            // 
            // UpButton
            // 
            UpButton.Location = new Point(191, 56);
            UpButton.Name = "UpButton";
            UpButton.Size = new Size(20, 23);
            UpButton.TabIndex = 6;
            UpButton.Text = "↑";
            UpButton.UseVisualStyleBackColor = true;
            UpButton.Visible = false;
            // 
            // DownButton
            // 
            DownButton.Location = new Point(165, 56);
            DownButton.Name = "DownButton";
            DownButton.Size = new Size(20, 23);
            DownButton.TabIndex = 5;
            DownButton.Text = "↓";
            DownButton.UseVisualStyleBackColor = true;
            DownButton.Visible = false;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(84, 56);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 23);
            EditButton.TabIndex = 4;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(3, 56);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(75, 23);
            RemoveButton.TabIndex = 3;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddButton.Location = new Point(228, 56);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(55, 23);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DisplayTextBox
            // 
            DisplayTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DisplayTextBox.Location = new Point(3, 27);
            DisplayTextBox.Name = "DisplayTextBox";
            DisplayTextBox.Size = new Size(280, 23);
            DisplayTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Item Text:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(582, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newChecklistToolStripMenuItem, openChecklistToolStripMenuItem, saveChecklistToolStripMenuItem, saveChecklistAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newChecklistToolStripMenuItem
            // 
            newChecklistToolStripMenuItem.Name = "newChecklistToolStripMenuItem";
            newChecklistToolStripMenuItem.Size = new Size(174, 22);
            newChecklistToolStripMenuItem.Text = "New Checklist...";
            newChecklistToolStripMenuItem.Click += newChecklistToolStripMenuItem_Click;
            // 
            // openChecklistToolStripMenuItem
            // 
            openChecklistToolStripMenuItem.Name = "openChecklistToolStripMenuItem";
            openChecklistToolStripMenuItem.Size = new Size(174, 22);
            openChecklistToolStripMenuItem.Text = "Open Checklist...";
            openChecklistToolStripMenuItem.Click += openChecklistToolStripMenuItem_Click;
            // 
            // saveChecklistToolStripMenuItem
            // 
            saveChecklistToolStripMenuItem.Name = "saveChecklistToolStripMenuItem";
            saveChecklistToolStripMenuItem.Size = new Size(174, 22);
            saveChecklistToolStripMenuItem.Text = "Save Checklist...";
            saveChecklistToolStripMenuItem.Click += saveChecklistToolStripMenuItem_Click;
            // 
            // saveChecklistAsToolStripMenuItem
            // 
            saveChecklistAsToolStripMenuItem.Name = "saveChecklistAsToolStripMenuItem";
            saveChecklistAsToolStripMenuItem.Size = new Size(174, 22);
            saveChecklistAsToolStripMenuItem.Text = "Save Checklist As...";
            saveChecklistAsToolStripMenuItem.Click += saveChecklistAsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checklistNameToolStripMenuItem, removeChecklistToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Visible = false;
            // 
            // checklistNameToolStripMenuItem
            // 
            checklistNameToolStripMenuItem.Name = "checklistNameToolStripMenuItem";
            checklistNameToolStripMenuItem.Size = new Size(177, 22);
            checklistNameToolStripMenuItem.Text = "Checklist Name...";
            checklistNameToolStripMenuItem.Visible = false;
            // 
            // removeChecklistToolStripMenuItem
            // 
            removeChecklistToolStripMenuItem.Name = "removeChecklistToolStripMenuItem";
            removeChecklistToolStripMenuItem.Size = new Size(177, 22);
            removeChecklistToolStripMenuItem.Text = "Remove Checklist...";
            removeChecklistToolStripMenuItem.Visible = false;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alwaysOnTopToolStripMenuItem, transparencyToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            alwaysOnTopToolStripMenuItem.Size = new Size(152, 22);
            alwaysOnTopToolStripMenuItem.Text = "Always On Top";
            alwaysOnTopToolStripMenuItem.Click += alwaysOnTopToolStripMenuItem_Click;
            // 
            // transparencyToolStripMenuItem
            // 
            transparencyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripComboBox1 });
            transparencyToolStripMenuItem.Name = "transparencyToolStripMenuItem";
            transparencyToolStripMenuItem.Size = new Size(152, 22);
            transparencyToolStripMenuItem.Text = "Transparency";
            transparencyToolStripMenuItem.Visible = false;
            transparencyToolStripMenuItem.Click += transparencyToolStripMenuItem_Click;
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Items.AddRange(new object[] { "100", "90", "80", "70", "60", "50", "40", "30", "20", "10", "0" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 23);
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "scl";
            openFileDialog1.FileName = "NewChecklist";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "scl";
            // 
            // NotesBox
            // 
            NotesBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NotesBox.Enabled = false;
            NotesBox.Location = new Point(4, 121);
            NotesBox.Name = "NotesBox";
            NotesBox.Size = new Size(276, 128);
            NotesBox.TabIndex = 4;
            NotesBox.Text = "";
            NotesBox.TextChanged += NotesBox_TextChanged;
            NotesBox.Leave += NotesBox_Leave;
            // 
            // ProgressTracker
            // 
            ProgressTracker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProgressTracker.Enabled = false;
            ProgressTracker.LargeChange = 1;
            ProgressTracker.Location = new Point(4, 55);
            ProgressTracker.Name = "ProgressTracker";
            ProgressTracker.Size = new Size(261, 45);
            ProgressTracker.TabIndex = 5;
            ProgressTracker.Scroll += ProgressTracker_Scroll;
            // 
            // ProgressLabel
            // 
            ProgressLabel.AutoSize = true;
            ProgressLabel.Enabled = false;
            ProgressLabel.Location = new Point(4, 37);
            ProgressLabel.Name = "ProgressLabel";
            ProgressLabel.Size = new Size(55, 15);
            ProgressLabel.TabIndex = 6;
            ProgressLabel.Text = "Progress:";
            // 
            // NotesLabel
            // 
            NotesLabel.AutoSize = true;
            NotesLabel.Enabled = false;
            NotesLabel.Location = new Point(4, 103);
            NotesLabel.Name = "NotesLabel";
            NotesLabel.Size = new Size(41, 15);
            NotesLabel.TabIndex = 7;
            NotesLabel.Text = "Notes:";
            // 
            // FileBox
            // 
            FileBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FileBox.Enabled = false;
            FileBox.FormattingEnabled = true;
            FileBox.ItemHeight = 15;
            FileBox.Location = new Point(4, 328);
            FileBox.Name = "FileBox";
            FileBox.RightToLeft = RightToLeft.Yes;
            FileBox.Size = new Size(276, 79);
            FileBox.TabIndex = 8;
            FileBox.SelectedIndexChanged += FileBox_SelectedIndexChanged;
            FileBox.DoubleClick += FileBox_DoubleClick;
            // 
            // FilesLabel
            // 
            FilesLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            FilesLabel.AutoSize = true;
            FilesLabel.Enabled = false;
            FilesLabel.Location = new Point(4, 310);
            FilesLabel.Name = "FilesLabel";
            FilesLabel.Size = new Size(33, 15);
            FilesLabel.TabIndex = 9;
            FilesLabel.Text = "Files:";
            // 
            // AddFileButton
            // 
            AddFileButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AddFileButton.Enabled = false;
            AddFileButton.Location = new Point(205, 299);
            AddFileButton.Name = "AddFileButton";
            AddFileButton.Size = new Size(75, 23);
            AddFileButton.TabIndex = 10;
            AddFileButton.Text = "Add File...";
            AddFileButton.UseVisualStyleBackColor = true;
            AddFileButton.Click += AddFileButton_Click;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // TaskLabel
            // 
            TaskLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TaskLabel.AutoSize = true;
            TaskLabel.Enabled = false;
            TaskLabel.Location = new Point(4, 9);
            TaskLabel.Name = "TaskLabel";
            TaskLabel.Size = new Size(284, 15);
            TaskLabel.TabIndex = 11;
            TaskLabel.Text = "______________________Task Name______________________";
            TaskLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FolderButton
            // 
            FolderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FolderButton.Enabled = false;
            FolderButton.Font = new Font("Segoe UI Symbol", 9F);
            FolderButton.Location = new Point(145, 299);
            FolderButton.Name = "FolderButton";
            FolderButton.Size = new Size(24, 23);
            FolderButton.TabIndex = 21;
            FolderButton.Text = "🗀";
            FolderButton.UseVisualStyleBackColor = true;
            FolderButton.Click += FolderButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // SaveNotesButton
            // 
            SaveNotesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveNotesButton.Enabled = false;
            SaveNotesButton.Location = new Point(205, 255);
            SaveNotesButton.Name = "SaveNotesButton";
            SaveNotesButton.Size = new Size(75, 23);
            SaveNotesButton.TabIndex = 22;
            SaveNotesButton.Text = "Save Notes";
            SaveNotesButton.UseVisualStyleBackColor = true;
            SaveNotesButton.Click += SaveNotesButton_Click;
            // 
            // RemoveFileButton
            // 
            RemoveFileButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveFileButton.Enabled = false;
            RemoveFileButton.Font = new Font("Segoe UI Symbol", 9F);
            RemoveFileButton.Location = new Point(175, 299);
            RemoveFileButton.Name = "RemoveFileButton";
            RemoveFileButton.Size = new Size(24, 23);
            RemoveFileButton.TabIndex = 23;
            RemoveFileButton.Text = "-";
            RemoveFileButton.UseVisualStyleBackColor = true;
            RemoveFileButton.Click += RemoveFileButton_Click;
            // 
            // BigSplit
            // 
            BigSplit.Dock = DockStyle.Fill;
            BigSplit.Location = new Point(0, 24);
            BigSplit.Name = "BigSplit";
            // 
            // BigSplit.Panel1
            // 
            BigSplit.Panel1.Controls.Add(splitContainer1);
            // 
            // BigSplit.Panel2
            // 
            BigSplit.Panel2.Controls.Add(TaskLabel);
            BigSplit.Panel2.Controls.Add(RemoveFileButton);
            BigSplit.Panel2.Controls.Add(ProgressLabel);
            BigSplit.Panel2.Controls.Add(FolderButton);
            BigSplit.Panel2.Controls.Add(SaveNotesButton);
            BigSplit.Panel2.Controls.Add(AddFileButton);
            BigSplit.Panel2.Controls.Add(ProgressTracker);
            BigSplit.Panel2.Controls.Add(FilesLabel);
            BigSplit.Panel2.Controls.Add(FileBox);
            BigSplit.Panel2.Controls.Add(NotesLabel);
            BigSplit.Panel2.Controls.Add(NotesBox);
            BigSplit.Size = new Size(582, 425);
            BigSplit.SplitterDistance = 286;
            BigSplit.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 449);
            Controls.Add(BigSplit);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "pChecklist (v0.91)";
            Click += Form1_Click;
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProgressTracker).EndInit();
            BigSplit.Panel1.ResumeLayout(false);
            BigSplit.Panel2.ResumeLayout(false);
            BigSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BigSplit).EndInit();
            BigSplit.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button AddButton;
        private TextBox DisplayTextBox;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newChecklistToolStripMenuItem;
        private ToolStripMenuItem openChecklistToolStripMenuItem;
        private ToolStripMenuItem saveChecklistAsToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem checklistNameToolStripMenuItem;
        private ToolStripMenuItem removeChecklistToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private ToolStripMenuItem transparencyToolStripMenuItem;
        private Button EditButton;
        private Button RemoveButton;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripComboBox toolStripComboBox1;
        private Button UpButton;
        private Button DownButton;
        private ToolStripMenuItem saveChecklistToolStripMenuItem;
        private RichTextBox NotesBox;
        private TrackBar ProgressTracker;
        private Label ProgressLabel;
        private Label NotesLabel;
        private ListBox FileBox;
        private Label FilesLabel;
        private Button AddFileButton;
        private OpenFileDialog openFileDialog2;
        private Label TaskLabel;
        private Button FolderButton;
        private System.Windows.Forms.Timer timer1;
        private Button SaveNotesButton;
        private Button RemoveFileButton;
        private SplitContainer BigSplit;
    }
}
