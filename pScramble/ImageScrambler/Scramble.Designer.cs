namespace ImageScrambler
{
    partial class Scramble
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
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ImageCanvas = new System.Windows.Forms.WebBrowser();
            this.RemoveFileButton = new System.Windows.Forms.Button();
            this.GalleryList = new System.Windows.Forms.ListBox();
            this.pbInput = new System.Windows.Forms.PictureBox();
            this.pbOutput = new System.Windows.Forms.PictureBox();
            this.ScrambleButton = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.fileProgressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileMenuStripBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.openASingleFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMultipleFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedFileAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrambleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.multipleFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrambleAllFilesInGalleryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigateLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigateRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LeftArrow = new System.Windows.Forms.Button();
            this.RightArrow = new System.Windows.Forms.Button();
            this.stayUnscCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.processProgressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.fromUrlCheck = new System.Windows.Forms.CheckBox();
            this.UnscrambleButton = new System.Windows.Forms.Button();
            this.ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImagePanel
            // 
            this.ImagePanel.AllowDrop = true;
            this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePanel.Controls.Add(this.splitContainer1);
            this.ImagePanel.Controls.Add(this.pbInput);
            this.ImagePanel.Controls.Add(this.pbOutput);
            this.ImagePanel.Location = new System.Drawing.Point(16, 28);
            this.ImagePanel.Margin = new System.Windows.Forms.Padding(4);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(855, 552);
            this.ImagePanel.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ImageCanvas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RemoveFileButton);
            this.splitContainer1.Panel2.Controls.Add(this.GalleryList);
            this.splitContainer1.Size = new System.Drawing.Size(855, 552);
            this.splitContainer1.SplitterDistance = 639;
            this.splitContainer1.TabIndex = 3;
            // 
            // ImageCanvas
            // 
            this.ImageCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageCanvas.Location = new System.Drawing.Point(0, 0);
            this.ImageCanvas.MinimumSize = new System.Drawing.Size(20, 20);
            this.ImageCanvas.Name = "ImageCanvas";
            this.ImageCanvas.Size = new System.Drawing.Size(639, 552);
            this.ImageCanvas.TabIndex = 0;
            this.ImageCanvas.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.ImageCanvas_DocumentCompleted);
            this.ImageCanvas.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.ImageCanvas_Navigated);
            // 
            // RemoveFileButton
            // 
            this.RemoveFileButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RemoveFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveFileButton.Location = new System.Drawing.Point(0, 526);
            this.RemoveFileButton.Name = "RemoveFileButton";
            this.RemoveFileButton.Size = new System.Drawing.Size(212, 26);
            this.RemoveFileButton.TabIndex = 15;
            this.RemoveFileButton.Text = "Remove File";
            this.RemoveFileButton.UseVisualStyleBackColor = true;
            this.RemoveFileButton.Click += new System.EventHandler(this.RemoveFileButton_Click);
            // 
            // GalleryList
            // 
            this.GalleryList.AllowDrop = true;
            this.GalleryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GalleryList.FormattingEnabled = true;
            this.GalleryList.ItemHeight = 16;
            this.GalleryList.Location = new System.Drawing.Point(0, 0);
            this.GalleryList.Name = "GalleryList";
            this.GalleryList.Size = new System.Drawing.Size(212, 516);
            this.GalleryList.TabIndex = 10;
            this.GalleryList.SelectedIndexChanged += new System.EventHandler(this.GalleryList_SelectedIndexChanged);
            // 
            // pbInput
            // 
            this.pbInput.Location = new System.Drawing.Point(3, 3);
            this.pbInput.Name = "pbInput";
            this.pbInput.Size = new System.Drawing.Size(25, 25);
            this.pbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbInput.TabIndex = 1;
            this.pbInput.TabStop = false;
            this.pbInput.Visible = false;
            // 
            // pbOutput
            // 
            this.pbOutput.Location = new System.Drawing.Point(427, 6);
            this.pbOutput.Name = "pbOutput";
            this.pbOutput.Size = new System.Drawing.Size(25, 25);
            this.pbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOutput.TabIndex = 2;
            this.pbOutput.TabStop = false;
            this.pbOutput.Visible = false;
            // 
            // ScrambleButton
            // 
            this.ScrambleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ScrambleButton.Location = new System.Drawing.Point(19, 588);
            this.ScrambleButton.Margin = new System.Windows.Forms.Padding(4);
            this.ScrambleButton.Name = "ScrambleButton";
            this.ScrambleButton.Size = new System.Drawing.Size(205, 28);
            this.ScrambleButton.TabIndex = 2;
            this.ScrambleButton.Text = "Scramble";
            this.ScrambleButton.UseVisualStyleBackColor = true;
            this.ScrambleButton.Click += new System.EventHandler(this.ScrambleButton_Click);
            // 
            // passwordField
            // 
            this.passwordField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.passwordField.Location = new System.Drawing.Point(19, 623);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '○';
            this.passwordField.Size = new System.Drawing.Size(205, 22);
            this.passwordField.TabIndex = 4;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // fileProgressBar
            // 
            this.fileProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fileProgressBar.Location = new System.Drawing.Point(772, 588);
            this.fileProgressBar.Name = "fileProgressBar";
            this.fileProgressBar.Size = new System.Drawing.Size(100, 23);
            this.fileProgressBar.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.OpenFileMenuStripBtn,
            this.saveAsToolStripMenuItem,
            this.scrambleToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.newToolStripMenuItem.Text = "New Session";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // OpenFileMenuStripBtn
            // 
            this.OpenFileMenuStripBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openASingleFileToolStripMenuItem,
            this.openMultipleFilesToolStripMenuItem});
            this.OpenFileMenuStripBtn.Name = "OpenFileMenuStripBtn";
            this.OpenFileMenuStripBtn.Size = new System.Drawing.Size(140, 22);
            this.OpenFileMenuStripBtn.Text = "Open...";
            // 
            // openASingleFileToolStripMenuItem
            // 
            this.openASingleFileToolStripMenuItem.Name = "openASingleFileToolStripMenuItem";
            this.openASingleFileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openASingleFileToolStripMenuItem.Text = "A Single File...";
            this.openASingleFileToolStripMenuItem.Click += new System.EventHandler(this.openASingleFileToolStripMenuItem_Click);
            // 
            // openMultipleFilesToolStripMenuItem
            // 
            this.openMultipleFilesToolStripMenuItem.Name = "openMultipleFilesToolStripMenuItem";
            this.openMultipleFilesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openMultipleFilesToolStripMenuItem.Text = "Multiple Files...";
            this.openMultipleFilesToolStripMenuItem.Click += new System.EventHandler(this.openMultipleFilesToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedFileToolStripMenuItem,
            this.selectedFileAsToolStripMenuItem});
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveAsToolStripMenuItem.Text = "Save...";
            this.saveAsToolStripMenuItem.Visible = false;
            // 
            // selectedFileToolStripMenuItem
            // 
            this.selectedFileToolStripMenuItem.Name = "selectedFileToolStripMenuItem";
            this.selectedFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectedFileToolStripMenuItem.Text = "Selected File";
            this.selectedFileToolStripMenuItem.Click += new System.EventHandler(this.saveSelectedFileToolStripMenuItem_Click);
            // 
            // selectedFileAsToolStripMenuItem
            // 
            this.selectedFileAsToolStripMenuItem.Name = "selectedFileAsToolStripMenuItem";
            this.selectedFileAsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectedFileAsToolStripMenuItem.Text = "Selected File As...";
            this.selectedFileAsToolStripMenuItem.Click += new System.EventHandler(this.saveSelectedFileAsToolStripMenuItem_Click);
            // 
            // scrambleToolStripMenuItem
            // 
            this.scrambleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedFileToolStripMenuItem1,
            this.multipleFilesToolStripMenuItem,
            this.scrambleAllFilesInGalleryToolStripMenuItem});
            this.scrambleToolStripMenuItem.Name = "scrambleToolStripMenuItem";
            this.scrambleToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.scrambleToolStripMenuItem.Text = "Scramble...";
            // 
            // selectedFileToolStripMenuItem1
            // 
            this.selectedFileToolStripMenuItem1.Name = "selectedFileToolStripMenuItem1";
            this.selectedFileToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.selectedFileToolStripMenuItem1.Text = "Selected File";
            this.selectedFileToolStripMenuItem1.Click += new System.EventHandler(this.scrambleSelectedFileToolStripMenuItem_Click);
            // 
            // multipleFilesToolStripMenuItem
            // 
            this.multipleFilesToolStripMenuItem.Name = "multipleFilesToolStripMenuItem";
            this.multipleFilesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.multipleFilesToolStripMenuItem.Text = "Multiple Files...";
            this.multipleFilesToolStripMenuItem.Click += new System.EventHandler(this.scrambleMultipleFilesToolStripMenuItem_Click);
            // 
            // scrambleAllFilesInGalleryToolStripMenuItem
            // 
            this.scrambleAllFilesInGalleryToolStripMenuItem.Name = "scrambleAllFilesInGalleryToolStripMenuItem";
            this.scrambleAllFilesInGalleryToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.scrambleAllFilesInGalleryToolStripMenuItem.Text = "All Files in Gallery";
            this.scrambleAllFilesInGalleryToolStripMenuItem.Click += new System.EventHandler(this.scrambleAllFilesInGalleryToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigateLeftToolStripMenuItem,
            this.navigateRightToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // navigateLeftToolStripMenuItem
            // 
            this.navigateLeftToolStripMenuItem.Name = "navigateLeftToolStripMenuItem";
            this.navigateLeftToolStripMenuItem.ShortcutKeyDisplayString = "⫷";
            this.navigateLeftToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.navigateLeftToolStripMenuItem.Text = "Navigate Left";
            // 
            // navigateRightToolStripMenuItem
            // 
            this.navigateRightToolStripMenuItem.Name = "navigateRightToolStripMenuItem";
            this.navigateRightToolStripMenuItem.ShortcutKeyDisplayString = "⫸";
            this.navigateRightToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.navigateRightToolStripMenuItem.Text = "Navigate Right";
            // 
            // LeftArrow
            // 
            this.LeftArrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftArrow.Location = new System.Drawing.Point(418, 588);
            this.LeftArrow.Name = "LeftArrow";
            this.LeftArrow.Size = new System.Drawing.Size(75, 58);
            this.LeftArrow.TabIndex = 7;
            this.LeftArrow.Text = "⫷";
            this.LeftArrow.UseVisualStyleBackColor = true;
            this.LeftArrow.Click += new System.EventHandler(this.LeftArrow_Click);
            // 
            // RightArrow
            // 
            this.RightArrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RightArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightArrow.Location = new System.Drawing.Point(499, 588);
            this.RightArrow.Name = "RightArrow";
            this.RightArrow.Size = new System.Drawing.Size(75, 58);
            this.RightArrow.TabIndex = 8;
            this.RightArrow.Text = "⫸";
            this.RightArrow.UseVisualStyleBackColor = true;
            this.RightArrow.Click += new System.EventHandler(this.RightArrow_Click);
            // 
            // stayUnscCheck
            // 
            this.stayUnscCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stayUnscCheck.AutoSize = true;
            this.stayUnscCheck.Location = new System.Drawing.Point(252, 596);
            this.stayUnscCheck.Name = "stayUnscCheck";
            this.stayUnscCheck.Size = new System.Drawing.Size(116, 20);
            this.stayUnscCheck.TabIndex = 9;
            this.stayUnscCheck.Text = "Auto-Scramble";
            this.stayUnscCheck.UseVisualStyleBackColor = true;
            this.stayUnscCheck.CheckedChanged += new System.EventHandler(this.stayUnscCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(733, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "File:";
            // 
            // processProgressBar
            // 
            this.processProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.processProgressBar.Location = new System.Drawing.Point(772, 625);
            this.processProgressBar.Name = "processProgressBar";
            this.processProgressBar.Size = new System.Drawing.Size(100, 23);
            this.processProgressBar.TabIndex = 11;
            this.processProgressBar.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(705, 630);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Process:";
            this.label2.Visible = false;
            // 
            // fromUrlCheck
            // 
            this.fromUrlCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fromUrlCheck.AutoSize = true;
            this.fromUrlCheck.Enabled = false;
            this.fromUrlCheck.Location = new System.Drawing.Point(252, 622);
            this.fromUrlCheck.Name = "fromUrlCheck";
            this.fromUrlCheck.Size = new System.Drawing.Size(78, 20);
            this.fromUrlCheck.TabIndex = 13;
            this.fromUrlCheck.Text = "From Url";
            this.fromUrlCheck.UseVisualStyleBackColor = true;
            this.fromUrlCheck.Visible = false;
            this.fromUrlCheck.CheckedChanged += new System.EventHandler(this.fromUrlCheck_CheckedChanged);
            // 
            // UnscrambleButton
            // 
            this.UnscrambleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UnscrambleButton.Location = new System.Drawing.Point(357, 630);
            this.UnscrambleButton.Margin = new System.Windows.Forms.Padding(4);
            this.UnscrambleButton.Name = "UnscrambleButton";
            this.UnscrambleButton.Size = new System.Drawing.Size(26, 22);
            this.UnscrambleButton.TabIndex = 14;
            this.UnscrambleButton.Text = "Unscramble";
            this.UnscrambleButton.UseVisualStyleBackColor = true;
            this.UnscrambleButton.Visible = false;
            this.UnscrambleButton.Click += new System.EventHandler(this.UnscrambleButton_Click);
            // 
            // Scramble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 660);
            this.Controls.Add(this.UnscrambleButton);
            this.Controls.Add(this.fromUrlCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.processProgressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stayUnscCheck);
            this.Controls.Add(this.RightArrow);
            this.Controls.Add(this.LeftArrow);
            this.Controls.Add(this.fileProgressBar);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.ScrambleButton);
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Scramble";
            this.Text = "pScramble - (v1.1)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Scramble_FormClosed);
            this.ImagePanel.ResumeLayout(false);
            this.ImagePanel.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.Button ScrambleButton;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.WebBrowser ImageCanvas;
        private System.Windows.Forms.ProgressBar fileProgressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileMenuStripBtn;
        private System.Windows.Forms.PictureBox pbOutput;
        private System.Windows.Forms.PictureBox pbInput;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Button LeftArrow;
        private System.Windows.Forms.Button RightArrow;
        private System.Windows.Forms.CheckBox stayUnscCheck;
        private System.Windows.Forms.ListBox GalleryList;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigateLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigateRightToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar processProgressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox fromUrlCheck;
        private System.Windows.Forms.ToolStripMenuItem openASingleFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMultipleFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedFileAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scrambleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem multipleFilesToolStripMenuItem;
        private System.Windows.Forms.Button UnscrambleButton;
        private System.Windows.Forms.ToolStripMenuItem scrambleAllFilesInGalleryToolStripMenuItem;
        private System.Windows.Forms.Button RemoveFileButton;
    }
}

