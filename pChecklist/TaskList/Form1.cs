using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace TaskList
{
    public struct CheckItem
    {
        public CheckBox checkBox;
        public int id;
        public bool shouldBeChecked;
        public int progress;
        public List<string> notes;
        public List<string> files;

        public CheckItem(CheckBox checkBox, int id)
        {
            this.id = id;
            this.checkBox = checkBox;
            progress = 0;
            notes = new List<string>();
            files = new List<string>();
        }

        public void SetText(string newText)
        {
            if (checkBox != null)
            {
                checkBox.Text = newText;
            }
        }

        public void SetTicked(bool ticked)
        {
            if (checkBox != null)
            {
                checkBox.Checked = ticked;
            }
        }

        public void SetLocation(Point location)
        {
            if (checkBox != null)
            {
                checkBox.Location = location;
            }
        }

        public void SetNotes(string notes)
        {
            this.notes.Clear();
            this.notes.Add(notes);
        }

        public string GetNotes()
        {
            if (notes == null)
            {
                notes = new List<string>();
            }
            string notesStr = "";
            foreach (string note in notes)
            {
                notesStr += note;
            }
            return notesStr;
        }
    }

    public partial class Form1 : Form
    {
        List<CheckItem> items = new List<CheckItem>();
        int checkId = 0;
        bool editMode = false;
        CheckItem lastclicked;
        CheckItem none;
        SplitContainer template;
        string lastLoaded;
        string loadedFile;
        bool onTop;

        bool init = true;
        string dataFile = Path.Combine(Directory.GetCurrentDirectory(), "checklistData.txt");
        string currDir = Directory.GetCurrentDirectory();

        int spaceBetweenChecks = 25;

        public Form1()
        {
            InitializeComponent();
            template = splitContainer1;
            LoadSettings();
            init = false;
        }

        private void SetDetailsEnabled(bool enabled)
        {
            if (!enabled)
            {
                TaskLabel.Text = "______________________Task Name______________________";
                ProgressLabel.Text = "Progress: 0%";
            }
            TaskLabel.Enabled = enabled;
            ProgressLabel.Enabled = enabled;
            ProgressTracker.Enabled = enabled;
            NotesLabel.Enabled = enabled;
            NotesBox.Enabled = enabled;
            FilesLabel.Enabled = enabled;
            FileBox.Enabled = enabled;
            AddFileButton.Enabled = enabled;
            SaveNotesButton.Enabled = enabled;
            RemoveFileButton.Enabled = enabled;
        }

        private void SetDetails(CheckItem checkItem)
        {
            if (checkItem.Equals(none))
            {
                return;
            }
            TaskLabel.Text = checkItem.checkBox.Text;
            ProgressTracker.Value = checkItem.progress;
            ProgressLabel.Text = "Progress: " + checkItem.progress * 10 + "%";
            NotesBox.Text = checkItem.GetNotes();
            FileBox.Items.Clear();
            if (checkItem.files == null)
            {

            }
            foreach (string file in checkItem.files)
            {
                FileBox.Items.Add(file + "\n");
            }
            SaveFile(loadedFile);
        }

        private void LoadSettings()
        {
            if (File.Exists(dataFile))
            {
                string[] data = File.ReadAllLines(dataFile);
                lastLoaded = data[0];
                onTop = bool.Parse(data[1]);
                alwaysOnTopToolStripMenuItem.Checked = onTop;
                LoadFile(lastLoaded);
            }
            else
            {
                SaveSettings();
            }
        }

        private void AddChecklistItem(string displayText)
        {
            if (editMode)
            {
                lastclicked.SetText(displayText);
                DisableEditMode();
            }
            else
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = displayText;
                checkBox.Location = new Point(10, (items.Count * spaceBetweenChecks) + 10);
                //tabControl1.SelectedTab.Controls.Add(template);
                CheckItem newItem = new CheckItem(checkBox, checkId);
                newItem = StrikeoutIfShouldBeChecked(newItem);
                items.Add(newItem);
                checkBox.MouseClick += CheckBox_MouseClick;
                checkBox.AutoSize = true;
                splitContainer1.Panel1.Controls.Add(checkBox);

                DisplayTextBox.Text = "";
                checkId++;
            }
            SaveFile(lastLoaded);
        }

        private void AddChecklistItem(CheckItem checkItem)
        {
            if (editMode)
            {
                lastclicked.SetText(checkItem.checkBox.Text);
                DisableEditMode();
            }
            else
            {
                CheckBox checkBox = checkItem.checkBox;
                //CheckItem newItem = new CheckItem(checkBox, checkId);
                checkBox = StrikeoutIfChecked(checkBox);
                items.Add(checkItem);
                checkBox.MouseClick += CheckBox_MouseClick;
                checkBox.AutoSize = true;
                splitContainer1.Panel1.Controls.Add(checkBox);

                DisplayTextBox.Text = "";
                checkId++;
            }
            SaveFile(lastLoaded);
        }

        private CheckItem GetChecklistItem(Point location)
        {
            foreach (CheckItem item in items)
            {
                if (location == item.checkBox.Location)
                {
                    return item;
                }
            }
            return new CheckItem();
        }

        private CheckItem GetChecklistItem(string displayText)
        {
            foreach (CheckItem item in items)
            {
                if (displayText == item.checkBox.Text)
                {
                    return item;
                }
            }
            return new CheckItem();
        }

        //kind of a hacky fix to get notes saving properly
        private void SaveCheckItem(CheckItem ItemToSave)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].checkBox.Text.Equals(ItemToSave.checkBox.Text))
                {
                    items[i] = ItemToSave;
                }
            }
        }

        private void MoveChecklistItemUp(int deletedYPos)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].checkBox.Location.Y > deletedYPos)
                {
                    Point newPoint = new Point();
                    newPoint.X = items[i].checkBox.Location.X;
                    newPoint.Y = items[i].checkBox.Location.Y - spaceBetweenChecks;
                    items[i].SetLocation(newPoint);
                }
            }
        }

        private void CheckBox_MouseClick(object? sender, MouseEventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            CheckItem checkitem = GetChecklistItem(checkbox.Location);
            if (e.Button == MouseButtons.Left)
            {
                if (checkitem.Equals(lastclicked))
                {
                    StrikeoutIfChecked(checkbox);
                }
                else
                {
                    lastclicked = checkitem;
                    SetDetailsEnabled(true);
                    SetDetails(checkitem);
                    checkitem.checkBox.Checked = !checkitem.checkBox.Checked;
                }
            }
            SaveFile(lastLoaded);
        }

        private CheckBox StrikeoutIfChecked(CheckBox checkbox)
        {
            DisableEditMode();
            if (checkbox.Checked)
            {
                Font strikeFont = new Font(DisplayTextBox.Font, FontStyle.Strikeout);
                checkbox.Font = strikeFont;
            }
            else
            {
                Font regFont = new Font(DisplayTextBox.Font, FontStyle.Regular);
                checkbox.Font = regFont;
            }
            return checkbox;
        }

        private CheckItem StrikeoutIfShouldBeChecked(CheckItem checkitem)
        {
            if (checkitem.shouldBeChecked)
            {
                checkitem.checkBox.Checked = true;
                StrikeoutIfChecked(checkitem.checkBox);
            }
            return checkitem;
        }

        private void EnableEditMode()
        {
            editMode = true;
            AddButton.Text = "Save";
            DisplayTextBox.Text = lastclicked.checkBox.Text;
        }

        private void DisableEditMode()
        {
            editMode = false;
            AddButton.Text = "Add";
            DisplayTextBox.Text = "";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddChecklistItem(DisplayTextBox.Text);
        }

        private void splitContainer1_Panel1_Click(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EnableEditMode();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveItem(lastclicked);
        }

        private void RemoveItem(CheckItem itemToRemove)
        {
            Point location = new Point(itemToRemove.checkBox.Location.X, itemToRemove.checkBox.Location.Y);
            splitContainer1.Panel1.Controls.Remove(itemToRemove.checkBox);
            //itemToRemove.checkBox.Dispose();
            items.Remove(itemToRemove);
            MoveChecklistItemUp(location.Y);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tabControl1.SelectedTab.Text == "(+)")
            //{
            //    tabControl1.TabPages.Insert(tabControl1.TabPages.Count - 2, "New Checklist");
            //}
        }

        private void NewFile()
        {
            splitContainer1.Panel1.Controls.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                items.Remove(items[i]);
            }
        }

        private void SaveFile(string file)
        {
            if (init)
                return;
            List<string> data = new List<string>();
            foreach (CheckItem item in items)
            {
                data.Add("~~~");
                data.Add(item.id.ToString());
                data.Add(item.checkBox.Text);
                data.Add(item.checkBox.Checked.ToString());
                data.Add(item.checkBox.Location.X + "," + item.checkBox.Location.Y);
                data.Add(item.progress.ToString());
                //notes
                if (item.notes != null)
                {
                    foreach (string noteInList in item.notes)
                    {
                        data.Add(noteInList);
                    }
                }
                else
                {
                    data.Add("");
                }
                data.Add("~`endnotes`~");

                //files
                if (item.files != null)
                {
                    foreach (string fileInList in item.files)
                    {
                        data.Add(fileInList);
                    }
                }
                else
                {
                    data.Add("");
                }
                data.Add("~`endfiles`~");
            }
            File.WriteAllLines(file, data);
            lastLoaded = file;
            SaveSettings();
        }

        private void SaveSettings()
        {
            string[] settings = new string[2];
            settings[0] = lastLoaded;
            settings[1] = onTop.ToString();
            File.WriteAllLines(dataFile, settings);
        }

        private void LoadFile(string file)
        {
            string[] data = File.ReadAllLines(file);
            CheckItem newItem = new CheckItem();
            List<CheckItem> newItems = new List<CheckItem>();
            int line = 0;
            int index = 0;
            bool notes = true;

            foreach (string item in data)
            {
                if (item == "~~~")
                {
                    newItem.checkBox = new CheckBox();
                    index++;
                    line++;
                    continue;
                }
                if (line == 1)
                {
                    newItem.id = int.Parse(item);
                    line++;
                    continue;
                }
                if (line == 2)
                {
                    newItem.SetText(item);
                    line++;
                    continue;
                }
                if (line == 3)
                {
                    newItem.SetTicked(bool.Parse(item));
                    newItem.shouldBeChecked = bool.Parse(item);
                    line++;
                    continue;
                }
                if (line == 4)
                {
                    string[] split = item.Split(',');
                    newItem.SetLocation(new Point(int.Parse(split[0]), int.Parse(split[1])));
                    line++;
                    continue;
                }
                if (line == 5)
                {
                    if (item != "")
                    {
                        newItem.progress = int.Parse(item);
                    }
                    line++;
                    continue;
                }
                if (line >= 6)
                {
                    if (notes)
                    {
                        if (item == "~`endnotes`~")
                        {
                            notes = false;
                        } 
                        else
                        {
                            if (newItem.notes == null)
                            {
                                newItem.notes = new List<string>();
                            }
                            newItem.notes.Add(item);
                            line++;
                            continue;
                        }
                    }
                    else
                    {
                        if (item == "~`endfiles`~")
                        {
                            line = 0;
                            notes = true;
                            newItems.Add(newItem);
                            newItem = new CheckItem();
                        }
                        else
                        {
                            if (newItem.files == null)
                            {
                                newItem.files = new List<string>();
                            }
                            newItem.files.Add(item);
                            line++;
                            continue;
                        }
                    }
                }
            }

            lastclicked = none;

            for (int i = 0; i < newItems.Count; i++)
            {
                AddChecklistItem(newItems[i]);
            }
            loadedFile = file;
            lastLoaded = file;
            SaveSettings();
        }

        private void newChecklistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void openChecklistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadFile(openFileDialog1.FileName);
            }
        }

        private void saveChecklistAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                SaveFile(saveFileDialog1.FileName);
            }
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = alwaysOnTopToolStripMenuItem.Checked;
            onTop = TopMost;
            SaveSettings();
        }

        private void transparencyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveChecklistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile(lastLoaded);
        }

        private void FileBox_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", (string)FileBox.SelectedItem);
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog2 = new OpenFileDialog();
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                lastclicked.files.Add(openFileDialog2.FileName);
                SetDetails(lastclicked);
            }
        }

        private void FileBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FolderButton.Enabled = FileBox.SelectedItem != null;
        }

        private void FolderButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.GetDirectoryName((string)FileBox.SelectedItem));
        }

        private void ProgressTracker_Scroll(object sender, EventArgs e)
        {
            lastclicked.progress = ProgressTracker.Value;
            SaveCheckItem(lastclicked);
            SetDetails(lastclicked);
        }

        private void NotesBox_TextChanged(object sender, EventArgs e)
        {
            //doing this in SaveNotes() instead
            //SaveNotes();
            ////send cursor to the end of the text box. 
            ////This makes it difficult to go back and edit previous text.
            //if (NotesBox.Text.Length > 0)
            //{
            //    NotesBox.Select(NotesBox.Text.Length, 0);
            //}
        }

        private void SaveNotes()
        {
            if (lastclicked.notes != null)
            {
                lastclicked.SetNotes(NotesBox.Text);
                SaveCheckItem(lastclicked);
                SetDetails(lastclicked);
            }
        }

        private void NotesBox_Leave(object sender, EventArgs e)
        {
            SaveNotes();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            SaveNotes();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SaveNotes();
        }

        private void splitContainer1_Panel1_Click_1(object sender, EventArgs e)
        {
            SaveNotes();
        }

        private void splitContainer1_Panel2_Click(object sender, EventArgs e)
        {
            SaveNotes();
        }

        private void SaveNotesButton_Click(object sender, EventArgs e)
        {
            SaveNotes();
        }

        private void RemoveFileButton_Click(object sender, EventArgs e)
        {
            if (FileBox.SelectedItem != null)
            {
                lastclicked.files.RemoveAt(FileBox.SelectedIndex);
                SetDetails(lastclicked);
            }
        }
    }
}
