
namespace pScript
{
    partial class EditCommands
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCommands));
            label1 = new System.Windows.Forms.Label();
            CommandList = new System.Windows.Forms.ListBox();
            label2 = new System.Windows.Forms.Label();
            CommandTextBox = new System.Windows.Forms.RichTextBox();
            DisplayTextBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            OKButton = new System.Windows.Forms.Button();
            SaveButton = new System.Windows.Forms.Button();
            ReorderDown = new System.Windows.Forms.Button();
            ReorderUp = new System.Windows.Forms.Button();
            AddButton = new System.Windows.Forms.Button();
            DeleteButton = new System.Windows.Forms.Button();
            SaveChanges = new System.Windows.Forms.Label();
            FlashTimer = new System.Windows.Forms.Timer(components);
            HelpButton = new System.Windows.Forms.Button();
            RunButton = new System.Windows.Forms.Button();
            CommandTree = new System.Windows.Forms.TreeView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(276, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Commands:";
            // 
            // CommandList
            // 
            CommandList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            CommandList.FormattingEnabled = true;
            CommandList.ItemHeight = 15;
            CommandList.Location = new System.Drawing.Point(276, 31);
            CommandList.Name = "CommandList";
            CommandList.Size = new System.Drawing.Size(191, 79);
            CommandList.TabIndex = 2;
            CommandList.Visible = false;
            CommandList.SelectedIndexChanged += CommandList_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 59);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 15);
            label2.TabIndex = 8;
            label2.Text = "Command Text:";
            // 
            // CommandTextBox
            // 
            CommandTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            CommandTextBox.Enabled = false;
            CommandTextBox.Location = new System.Drawing.Point(12, 77);
            CommandTextBox.Name = "CommandTextBox";
            CommandTextBox.Size = new System.Drawing.Size(258, 197);
            CommandTextBox.TabIndex = 7;
            CommandTextBox.Text = "";
            CommandTextBox.TextChanged += CommandTextBox_TextChanged;
            // 
            // DisplayTextBox
            // 
            DisplayTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            DisplayTextBox.Enabled = false;
            DisplayTextBox.Location = new System.Drawing.Point(12, 33);
            DisplayTextBox.Name = "DisplayTextBox";
            DisplayTextBox.Size = new System.Drawing.Size(258, 23);
            DisplayTextBox.TabIndex = 6;
            DisplayTextBox.TextChanged += DisplayTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 15);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 15);
            label3.TabIndex = 5;
            label3.Text = "Display Text:";
            // 
            // OKButton
            // 
            OKButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            OKButton.Location = new System.Drawing.Point(393, 281);
            OKButton.Name = "OKButton";
            OKButton.Size = new System.Drawing.Size(75, 23);
            OKButton.TabIndex = 11;
            OKButton.Text = "Close";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            SaveButton.Enabled = false;
            SaveButton.Location = new System.Drawing.Point(195, 280);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new System.Drawing.Size(75, 23);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ReorderDown
            // 
            ReorderDown.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ReorderDown.Location = new System.Drawing.Point(354, 7);
            ReorderDown.Name = "ReorderDown";
            ReorderDown.Size = new System.Drawing.Size(23, 23);
            ReorderDown.TabIndex = 12;
            ReorderDown.Text = "↓";
            ReorderDown.UseVisualStyleBackColor = true;
            ReorderDown.Click += ReorderDown_Click;
            // 
            // ReorderUp
            // 
            ReorderUp.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ReorderUp.Location = new System.Drawing.Point(379, 7);
            ReorderUp.Name = "ReorderUp";
            ReorderUp.Size = new System.Drawing.Size(23, 23);
            ReorderUp.TabIndex = 13;
            ReorderUp.Text = "↑";
            ReorderUp.UseVisualStyleBackColor = true;
            ReorderUp.Click += ReorderUp_Click;
            // 
            // AddButton
            // 
            AddButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            AddButton.Location = new System.Drawing.Point(445, 7);
            AddButton.Name = "AddButton";
            AddButton.Size = new System.Drawing.Size(23, 23);
            AddButton.TabIndex = 14;
            AddButton.Text = "+";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            DeleteButton.Location = new System.Drawing.Point(420, 7);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new System.Drawing.Size(23, 23);
            DeleteButton.TabIndex = 15;
            DeleteButton.Text = "-";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SaveChanges
            // 
            SaveChanges.AutoSize = true;
            SaveChanges.ForeColor = System.Drawing.Color.Red;
            SaveChanges.Location = new System.Drawing.Point(302, 284);
            SaveChanges.Name = "SaveChanges";
            SaveChanges.Size = new System.Drawing.Size(85, 15);
            SaveChanges.TabIndex = 16;
            SaveChanges.Text = "Save Changes?";
            SaveChanges.Visible = false;
            // 
            // FlashTimer
            // 
            FlashTimer.Interval = 10;
            // 
            // HelpButton
            // 
            HelpButton.Location = new System.Drawing.Point(195, 7);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new System.Drawing.Size(75, 23);
            HelpButton.TabIndex = 17;
            HelpButton.Text = "Help";
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Click += HelpButton_Click;
            // 
            // RunButton
            // 
            RunButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            RunButton.Enabled = false;
            RunButton.Location = new System.Drawing.Point(12, 280);
            RunButton.Name = "RunButton";
            RunButton.Size = new System.Drawing.Size(75, 23);
            RunButton.TabIndex = 18;
            RunButton.Text = "Run";
            RunButton.UseVisualStyleBackColor = true;
            RunButton.Click += RunButton_Click;
            // 
            // CommandTree
            // 
            CommandTree.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            CommandTree.FullRowSelect = true;
            CommandTree.HideSelection = false;
            CommandTree.Location = new System.Drawing.Point(276, 31);
            CommandTree.Name = "CommandTree";
            CommandTree.Size = new System.Drawing.Size(191, 243);
            CommandTree.TabIndex = 19;
            CommandTree.AfterSelect += CommandTree_AfterSelect;
            // 
            // EditCommands
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(479, 311);
            Controls.Add(CommandTree);
            Controls.Add(RunButton);
            Controls.Add(HelpButton);
            Controls.Add(SaveChanges);
            Controls.Add(DeleteButton);
            Controls.Add(AddButton);
            Controls.Add(ReorderUp);
            Controls.Add(ReorderDown);
            Controls.Add(OKButton);
            Controls.Add(SaveButton);
            Controls.Add(CommandTextBox);
            Controls.Add(DisplayTextBox);
            Controls.Add(label3);
            Controls.Add(CommandList);
            Controls.Add(label1);
            Controls.Add(label2);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "EditCommands";
            Text = "pScript v1.1 (edit commands)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CommandList;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RichTextBox CommandTextBox;
        public System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ReorderDown;
        private System.Windows.Forms.Button ReorderUp;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label SaveChanges;
        public System.Windows.Forms.Timer FlashTimer;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button RunButton;
        public System.Windows.Forms.TreeView CommandTree;
    }
}