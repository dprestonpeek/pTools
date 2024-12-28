
namespace pScript
{
    partial class HelpWindow
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Child Node");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Child Node");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Child Node");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode(">>Parent Node", new System.Windows.Forms.TreeNode[] { treeNode3 });
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Child Node");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("><Aunt Node", new System.Windows.Forms.TreeNode[] { treeNode5 });
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode(">>Parent Node (Root)", new System.Windows.Forms.TreeNode[] { treeNode1, treeNode2, treeNode4, treeNode6 });
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("><< Grand Node (Root)");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpWindow));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            ExampleTree = new System.Windows.Forms.TreeView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(388, 30);
            label1.TabIndex = 0;
            label1.Text = "Preceed the name of your command with one of these options.\r\nWhen adding nodes, the relationship context reads from top to bottom. ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(46, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(341, 30);
            label2.TabIndex = 1;
            label2.Text = "Parent Node - All subsequent nodes will be Child Nodes unless \r\notherwise specified.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 64);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(23, 15);
            label4.TabIndex = 3;
            label4.Text = ">>";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(12, 133);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(23, 15);
            label8.TabIndex = 7;
            label8.Text = "><";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(46, 133);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(338, 45);
            label9.TabIndex = 8;
            label9.Text = "Aunt Node - The current submenu will be closed and this node\r\n will be up one layer from the previous. All subsequent nodes \r\nwill be Child Nodes unless otherwise specified.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(5, 215);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(40, 15);
            label10.TabIndex = 9;
            label10.Text = "><<...";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(46, 215);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(351, 45);
            label11.TabIndex = 10;
            label11.Text = "Grand Node - For each '<' symbol, one submenu will be closed\r\nand this node will be up that many layers from the previous. All \r\nsubsequent nodes will be Child Nodes unless otherwise specified.";
            // 
            // ExampleTree
            // 
            ExampleTree.ItemHeight = 30;
            ExampleTree.Location = new System.Drawing.Point(405, 12);
            ExampleTree.Name = "ExampleTree";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Child Node";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Child Node";
            treeNode3.Name = "Node5";
            treeNode3.Text = "Child Node";
            treeNode4.Name = "Node4";
            treeNode4.Text = ">>Parent Node";
            treeNode5.Name = "Node6";
            treeNode5.Text = "Child Node";
            treeNode6.Name = "Node3";
            treeNode6.Text = "><Aunt Node";
            treeNode7.Name = "Node0";
            treeNode7.Text = ">>Parent Node (Root)";
            treeNode8.Name = "Node7";
            treeNode8.Text = "><< Grand Node (Root)";
            ExampleTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode7, treeNode8 });
            ExampleTree.Size = new System.Drawing.Size(214, 258);
            ExampleTree.TabIndex = 11;
            // 
            // HelpWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(631, 282);
            Controls.Add(ExampleTree);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "HelpWindow";
            Text = "Help";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TreeView ExampleTree;
    }
}