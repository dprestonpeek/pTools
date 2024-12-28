﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pScript
{
    public partial class EditCommands : Form
    {
        bool aboutToAdd = false;
        bool adding = false;
        bool editing = false;

        string displayText = "";
        string commandText = "";
        bool togglable = false;
        int prevSelected = -1;
        int nodeRefreshLayers = 0;
        int nodeRefreshIndex = 0;
        TreeNode currentParent = null;
        Dictionary<string, TreeNode> AllNodes = new Dictionary<string, TreeNode>();

        public EditCommands()
        {
            InitializeComponent();
            RefreshList();
        }

        private void RefreshList()
        {
            List<TreeNode> parents = new List<TreeNode>();

            CommandTree.Nodes.Clear();
            AllNodes.Clear();
            foreach (Command cmd in Commands.commandList)
            {
                TreeNode newNode = null;
                bool newNodeIsNextParent = false;

                if (cmd.displayText != "" && cmd.displayText.Substring(0, 2).Equals("><"))
                {
                    newNodeIsNextParent = true;
                    int layers = 1;
                    int index = 2;
                    while (cmd.displayText[index].Equals('<'))
                    {
                        layers++;
                        index++;
                    }
                    currentParent = parents[parents.Count - 1 - layers];
                }

                if (currentParent == null)
                {
                    newNode = CommandTree.Nodes.Add(cmd.displayText);
                    AllNodes.Add(cmd.displayText, newNode);
                }
                else
                {
                    newNode = currentParent.Nodes.Add(cmd.displayText);
                    AllNodes.Add(cmd.displayText, newNode);
                }
                if (cmd.displayText != "" && cmd.displayText.Substring(0,2).Equals(">>"))
                {
                    currentParent = newNode;
                    parents.Add(newNode);
                }
                if (newNodeIsNextParent)
                {
                    currentParent = newNode;
                    parents.Add(newNode);
                }
            }
            currentParent = null;
            CommandTree.ExpandAll();
        }

        private void CommandList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void EnableDisableEditing()
        {
            if (CommandTree.SelectedNode == null)
            {
                DisableEditing();
            }
            else
            {
                EnableEditing();
            }
        }

        private void DisableEditing()
        {
            DisplayTextBox.Enabled = false;
            CommandTextBox.Enabled = false;
            SaveButton.Enabled = false;
            RunButton.Enabled = false;
            DisplayTextBox.Text = "";
            CommandTextBox.Text = "";
            ReorderUp.Enabled = false;
            ReorderDown.Enabled = false;
            editing = false;
        }

        private void EnableEditing()
        {
            DisplayTextBox.Enabled = true;
            CommandTextBox.Enabled = true;
            SaveButton.Enabled = true;
            RunButton.Enabled = true;
            DisplayTextBox.Text = "";
            CommandTextBox.Text = "";
            ReorderUp.Enabled = true;
            ReorderDown.Enabled = true;
        }

        private void UpdateUI()
        {
            if (CommandTree.SelectedNode != null)
            {
                Command selectedCommand = Commands.GetCommandByString(CommandTree.SelectedNode.Text);
                DisplayTextBox.Text = selectedCommand.displayText;
                CommandTextBox.Text = selectedCommand.commandText;
            }
            else
            {
                DisplayTextBox.Text = "";
                CommandTextBox.Text = "";
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            SaveChanges.Visible = false;
            editing = false;
            displayText = DisplayTextBox.Text;
            commandText = CommandTextBox.Text;
            if (adding)
            {
                adding = false;
                CommandTree.SelectedNode = GetNodeByString(displayText);
            }
            Command newCommand = new Command(displayText, commandText, togglable);
            Commands.SetCommandByString(displayText, newCommand);

            Program.SaveCommands();
            DisableEditing();
            //RefreshList();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (SaveChanges.Visible)
            {
                editing = false;
            }
            if (editing)
            {
                SaveChanges.Visible = true;
            }
            else
            {
                Close();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            TreeNode newNode = null;
            if (!aboutToAdd)
            {
                aboutToAdd = true;
                //int i = CommandList.Items.Add("New Command...");
                //CommandList.SelectedIndex = i;
                string newName = IncrementNameUntilUnique("NewCommand...");
                newNode = CommandTree.Nodes.Add(newName);
                Commands.commandList.Add(new Command(newName, "", false));
                EnableDisableEditing();
            }
            RefreshList();
            CommandTree.SelectedNode = GetNodeByString(newNode.Text);
            UpdateUI();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //int i = CommandList.SelectedIndex;
            //CommandList.Items.RemoveAt(i);
            string nodeText = CommandTree.SelectedNode.Text;
            Command cmdToRemove = Commands.GetCommandByString(nodeText);
            //CommandTree.Nodes.RemoveAt(i);
            int newIndex = Commands.commandList.IndexOf(cmdToRemove) - 1;
            if (newIndex < 0)
            {
                newIndex = 0;
            }
            Commands.commandList.Remove(Commands.GetCommandByString(nodeText));
            Program.SaveCommands();
            RefreshList();
            CommandTree.SelectedNode = GetNodeByString(Commands.commandList[newIndex].displayText);
        }

        private void ReorderUp_Click(object sender, EventArgs e)
        {
            //int index = CommandList.SelectedIndex;
            int index = Commands.commandList.IndexOf(Commands.GetCommandByString(CommandTree.SelectedNode.Text));
            prevSelected = index;
            if (index > 0)
            {
                Command cmdToMove = Commands.commandList[index];
                Command temp = Commands.commandList[index - 1];
                Commands.commandList[index - 1] = cmdToMove;
                Commands.commandList[index] = temp;
                RefreshList();
                DisableEditing();
                //CommandList.SelectedIndex = prevSelected - 1;
                
                CommandTree.SelectedNode = GetNodeByString(Commands.commandList[prevSelected - 1].displayText);
            }
        }

        private void ReorderDown_Click(object sender, EventArgs e)
        {
            //int index = CommandList.SelectedIndex;
            int index = Commands.commandList.IndexOf(Commands.GetCommandByString(CommandTree.SelectedNode.Text));
            prevSelected = index;
            //if (index != CommandList.Items.Count - 1)
            if (index != CommandTree.Nodes.Count - 1)
            {
                Command cmdToMove = Commands.commandList[index];
                Command temp = Commands.commandList[index + 1];
                Commands.commandList[index + 1] = cmdToMove;
                Commands.commandList[index] = temp;
                RefreshList();
                DisableEditing();
                CommandTree.SelectedNode = GetNodeByString(Commands.commandList[prevSelected + 1].displayText);
            }
        }

        private void DisplayTextBox_TextChanged(object sender, EventArgs e)
        {
            editing = true;
        }

        private void CommandTextBox_TextChanged(object sender, EventArgs e)
        {
            editing = true;
        }

        private void TogglableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            editing = true;
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            new HelpWindow().Show();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            Commands.FireCommandByString(DisplayTextBox.Text);
        }

        private string IncrementNameUntilUnique(string displayName)
        {
            string patternWparenths = "[ ][(]\\d+[)]";
            string patternIndex = "\\d+";
            Regex indexwParenths = new Regex(patternWparenths);
            Regex indexOnly = new Regex(patternIndex);
            string newDisplayName = displayName;

            //if command exists in list already
            while (Commands.GetCommandByString(newDisplayName) != null)
            {
                string endDisplayName = newDisplayName.Substring(newDisplayName.Length - 4, 4);
                string beginDisplayName = newDisplayName.Substring(0, newDisplayName.Length - 4);
                //if the command already has a " (##)" suffix
                MatchCollection matches = indexwParenths.Matches(endDisplayName);
                if (matches.Count > 0)
                {
                    //increment it
                    MatchCollection indexMatch = indexOnly.Matches(endDisplayName);
                    int index = int.Parse(indexMatch[0].Value);
                    index++;
                    newDisplayName = beginDisplayName + " (" + index + ")";
                }
                else
                {
                    //add one
                    newDisplayName = displayName + " (1)";
                }
            }
            return newDisplayName;
        }

        private TreeNode GetNodeByString(string displayText)
        {
            //return GetNodeByString(displayText, CommandTree.Nodes);
            foreach (KeyValuePair<string, TreeNode> kvp in AllNodes) 
            {
                if (kvp.Key.Equals(displayText))
                {
                    return kvp.Value;
                }
            }
            return null;
        }

        private TreeNode GetNodeByString(string displayText, TreeNodeCollection nodesToCheck)
        {
            
            foreach (TreeNode node in nodesToCheck)
            {
                if (node.Text == displayText)
                {
                    return node;
                }
                if (node.Nodes.Count > 0)
                {
                    return GetNodeByString(displayText, node.Nodes);
                }
            }
            return null;
        }

        private void CommandTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            EnableDisableEditing();
            if (adding)
            {
                adding = false;
                UpdateUI();
            }
            else if (aboutToAdd)
            {
                adding = true;
                aboutToAdd = false;
            }
            else
            {
                UpdateUI();
            }
        }
    }
}
