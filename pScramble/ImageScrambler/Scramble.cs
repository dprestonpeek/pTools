using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageScrambler
{
    public partial class Scramble : Form
    {
        string file;
        string lastAddedFile;
        string scrambledFile;
        List<string> files = new List<string>();
        List<string> gallery = new List<string>();
        bool scrambling = false;
        bool batchScrambling = false;
        bool navigating = false;
        bool navToUrl = false;
        bool fromUrl = false;
        int zoom = 100;

        int index = 0;

        public Scramble()
        {
            InitializeComponent();
            InitializeCanvas();
        }

        private void InitializeCanvas()
        {
            ImagePanel.AllowDrop = true;
        }

        public struct Coord
        {
            public int x, y;
        }

        private bool Work(Bitmap srcb, Bitmap outb)
        {
            int w = srcb.Width, h = srcb.Height;
            Coord[] coord = new Coord[w * h];

            FastBitmap fsb = new FastBitmap(srcb);
            FastBitmap fob = new FastBitmap(outb);
            fsb.LockImage();
            fob.LockImage();
            ulong seed;
            if (passwordField.Text == "")
            {
                seed = 0;
            }
            else
            {
                seed = Convert.ToUInt64(passwordField.Text);
            }

            int numpix = 0;
            for (int y = 0; y < h; y++)
                for (int x = 0; x < w; numpix++, x++)
                {
                    coord[numpix].x = x;
                    coord[numpix].y = y;
                    uint color = fsb.GetPixel(x, y);
                    seed += color;
                    fob.SetPixel(x, y, color);
                }
            fsb.UnlockImage();
            fob.UnlockImage();
            pbOutput.Refresh();
            Application.DoEvents();

            int half = numpix / 2;
            int limit = half;
            XorShift rng = new XorShift(seed);
            fileProgressBar.Visible = true;
            fileProgressBar.Maximum = limit;

            fob.LockImage();
            while (limit > 0)
            {
                int p = (int)(rng.next() % (uint)limit);
                int q = (int)(rng.next() % (uint)limit);
                uint color = fob.GetPixel(coord[p].x, coord[p].y);
                fob.SetPixel(coord[p].x, coord[p].y, fob.GetPixel(coord[half + q].x, coord[half + q].y));
                fob.SetPixel(coord[half + q].x, coord[half + q].y, color);
                limit--;
                if (p < limit)
                {
                    coord[p] = coord[limit];
                }
                if (q < limit)
                {
                    coord[half + q] = coord[half + limit];
                }
                if ((limit & 0xfff) == 0)
                {
                    fileProgressBar.Value = limit;
                    fob.UnlockImage();
                    pbOutput.Refresh();
                    fob.LockImage();
                }
            }
            fob.UnlockImage();
            pbOutput.Refresh();
            //if (fileProgressBar.Value == fileProgressBar.Maximum)
            //fileProgressBar.Visible = false;
            return true;
        }

        void DupImage(PictureBox s, PictureBox d)
        {
            if (d.Image != null)
                d.Image.Dispose();
            d.Image = new Bitmap(s.Image.Width, s.Image.Height);
        }

        void GetImagePB(PictureBox pb, string file)
        {
            Bitmap bms = new Bitmap(file, false);
            Bitmap bmp = bms.Clone(new Rectangle(0, 0, bms.Width, bms.Height), PixelFormat.Format32bppArgb);
            bms.Dispose();
            if (pb.Image != null)
                pb.Image.Dispose();
            pb.Image = bmp;
        }

        private void ScrambleButton_Click(object sender, EventArgs e)
        {
            try
            {
                file = ImageCanvas.Url.AbsolutePath;
                //SaveFileTemp(Path.GetDirectoryName(file) + Path.DirectorySeparatorChar + Path.GetFileName(file) + ".scr");
                ScrambleImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not scramble Image: " + file + "\n Original error: " + ex.Message);
            }
        }

        private void ScrambleImage()
        {
            ScrambleImage("");
        }

        private void ScrambleImage(string saveTo)
        {
            scrambling = true;
            try
            {
                while (file.Contains(".scr"))
                {
                    file = file.Replace(".scr", "");
                }
                GetImagePB(pbInput, file);
                pbInput.Tag = file;
                DupImage(pbInput, pbOutput);
                if (Work(pbInput.Image as Bitmap, pbOutput.Image as Bitmap))
                {
                    scrambledFile = file + ".scr";

                    while (scrambledFile.Contains(".scr.scr"))
                    {
                        scrambledFile = scrambledFile.Replace(".scr.scr", ".scr");
                    }
                    files.Add(scrambledFile);
                    pbOutput.Image.Save(scrambledFile);
                    if (saveTo != "")
                    {
                        pbOutput.Image.Save(saveTo);
                        gallery.Add(saveTo);
                        GalleryList.Items.Add(saveTo);
                    }
                    else
                    {
                        ImageCanvas.Navigate(scrambledFile);
                        //ImageCanvas.AllowNavigation = false;
                        //Task.Run(new Action(WaitAndReAllowNav), CancellationToken.None);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not scramble Image: " + file + "\n Original error: " + ex.Message);
            }
            scrambling = false;
        }

        private void BatchScramble(List<string> imagesToScramble)
        {
            batchScrambling = true;
            string oldPath = "";
            List<string> imageNames = new List<string>();
            imageNames.AddRange(imagesToScramble);
            try
            {
                for (int i = 0; i < imageNames.Count; i++)
                {
                    imageNames[i] = Path.GetFileName(imagesToScramble[i]);
                }

                oldPath = Path.GetDirectoryName(imagesToScramble[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                return;
            }

            string newPath = oldPath + "\\scrambled";
            Directory.CreateDirectory(newPath);

            processProgressBar.Visible = true;
            processProgressBar.Maximum = imageNames.Count;
            for (int i = 0; i < imageNames.Count; processProgressBar.Value++, i++)
            {
                file = Path.Combine(oldPath, imageNames[i]);
                ScrambleImage(newPath + Path.DirectorySeparatorChar + imageNames[i]);
            }
            processProgressBar.Visible = false;
            processProgressBar.Value = 0;
            ImageCanvas.Navigate(gallery[index]);
            GalleryList.SelectedIndex = index;
            batchScrambling = false;
        }

        private void UnscrambleImage(string saveTo)
        {
            scrambling = true;
            try
            {
                GetImagePB(pbInput, file);
                pbInput.Tag = file;
                DupImage(pbInput, pbOutput);
                ImageCanvas.Navigate(file);
                //ImageCanvas.AllowNavigation = false;
                //Task.Run(new Action(WaitAndReAllowNav), CancellationToken.None);
                //if (Work(pbInput.Image as Bitmap, pbOutput.Image as Bitmap))
                //{
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not scramble Image: " + file + "\n Original error: " + ex.Message);
            }
            scrambling = false;
        }

        private void InstantUnscramble(string file)
        {
            //if (file.Substring(file.Length - 4) != ".scr")
            //    return;
            InstantScramble(file);
        }

        private void InstantScramble(string file)
        {
            scrambling = true;
            try
            {
                GetImagePB(pbInput, file);
                pbInput.Tag = file;
                DupImage(pbInput, pbOutput);
                if (Work(pbInput.Image as Bitmap, pbOutput.Image as Bitmap))
                {
                    scrambledFile = Path.GetDirectoryName(file) + Path.DirectorySeparatorChar + Path.GetFileName(file) + ".scr";
                    files.Add(scrambledFile);
                    pbOutput.Image.Save(scrambledFile);
                    ImageCanvas.Navigate(scrambledFile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not scramble Image: " + file + "\n Original error: " + ex.Message);
            }
            scrambling = false;
        }

        private void LoadImage(string saveTo)
        {
            scrambling = true;
            try
            {
                GetImagePB(pbInput, file);
                pbInput.Tag = file;
                DupImage(pbInput, pbOutput);
                Path.GetFileName(file);
                string fileToRemove = GetFileNameInGallery(saveTo);

                if (fileToRemove != "")
                {
                    gallery.Remove(fileToRemove);
                    GalleryList.Items.Remove(fileToRemove);
                }
                if (saveTo.Substring(saveTo.Length - 4) != ".scr")
                {
                    gallery.Add(saveTo);
                    GalleryList.Items.Add(saveTo);
                    lastAddedFile = saveTo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not scramble Image: " + file + "\n Original error: " + ex.Message);
            }
            scrambling = false;
        }

        private string GetFileNameInGallery(string thisImage)
        {
            string forwardSlashes;
            string backSlashes;

            if (thisImage.Contains('\\'))
            {
                forwardSlashes = thisImage.Replace('\\', '/');
            }
            else
            {
                forwardSlashes = thisImage;
            }
            if (thisImage.Contains('/'))
            {
                backSlashes = thisImage.Replace('/', '\\');
            }
            else
            {
                backSlashes = thisImage;
            }
            if (forwardSlashes == thisImage && thisImage == backSlashes) //there are no slashes in the filename
            {
                return "";
            }

            foreach (string line in gallery)
            {
                if (line == forwardSlashes)
                    return forwardSlashes;
                if (line == backSlashes)
                    return backSlashes;
            }
            return "";
        }

        private void Scramble_FormClosed(object sender, FormClosedEventArgs e)
        {
            DeleteFiles(false);
        }

        private void DeleteFiles(bool safely)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            try
            {
                if (pbInput.Image != null)
                {
                    pbInput.Image.Dispose();
                }
                pbInput.Dispose();
                if (pbOutput.Image != null)
                {
                    pbOutput.Image.Dispose();
                }
                pbOutput.Dispose();
            }
            catch(Exception e)
            {

            }

            for (int i = 0; i < files.Count; i++)
            {
                if (safely)
                {
                    if (files[i] != ImageCanvas.Url.LocalPath)
                    {
                        if (File.Exists(files[i]))
                        {
                            File.Delete(files[i]);
                        }
                        files.Remove(files[i]);
                    }
                }
                else
                {
                    if (File.Exists(files[i]))
                    {
                        File.Delete(files[i]);
                    }
                    files.Remove(files[i]);
                }
            }
        }

        private void ImageCanvas_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (!scrambling && !navToUrl)
            {
                if (ImageCanvas.Url.AbsolutePath.Substring(ImageCanvas.Url.AbsolutePath.Length - 4) != ".scr")
                {
                    file = ImageCanvas.Url.AbsolutePath;
                    if (ImageCanvas.Url.AbsoluteUri.Contains("AppData/Local/Temp")) //if this file is at a web address, download it to resources
                    {
                        navToUrl = true;
                        string newfilepath = Path.Combine(@"../../Resources/", Path.GetFileName(file));

                        File.Copy(ImageCanvas.Url.AbsolutePath, newfilepath);
                        //FileDownload.DownloadImageToFile(ImageCanvas.Url.AbsoluteUri, newfilepath);
                        //while (!FileDownload.DownloadComplete)
                        //{
                        //    Thread.Sleep(50);
                        //}
                        file = newfilepath;
                        LoadImage(file);
                        ImageCanvas.Navigate(file);
                        //GetImagePB(pbInput, file);
                        //DupImage(pbInput, pbOutput);
                        navToUrl = false;
                    }
                    else
                    {
                        if (!navigating)
                        {
                            LoadImage(file);
                            GalleryList.SelectedIndex = GalleryList.FindString(lastAddedFile);
                        }
                        else
                        {
                            navigating = false;
                            navToUrl = false;
                        }
                    }
                }
                else
                {
                }

                DeleteFiles(true);
            }
            else
            {
                navToUrl = false;
            }
        }

        private void ImageCanvas_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (ImageCanvas.Url.AbsolutePath.Contains("http") || ImageCanvas.Url.AbsolutePath.Equals("blank"))
            {
                navToUrl = true;
            }
        }

        private void SaveFile()
        {
            GetImagePB(pbInput, ImageCanvas.Url.LocalPath);
            try
            {
                string[] split = ImageCanvas.Url.LocalPath.Split('.');
                string ext = split[split.Length - 1];
                string filenameWoExt = split[0];
                string newFilename = filenameWoExt + "." + ext;
                int i = 0;
                while (File.Exists(newFilename))
                {
                    newFilename = filenameWoExt + "_" + i + "." + ext;
                    i++;
                }
                pbInput.Image.Save(newFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not save file to disk. Original error: " + ex.Message);
            }
        }

        private void SaveFileAs()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = "c:\\temp\\";
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (fromUrl)
            {
                ScrambleImage(file);
                pbInput.Image.Save(file);
            }
            else
            {
                GetImagePB(pbInput, ImageCanvas.Url.LocalPath);
            }

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbInput.Image.Save(dialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not save file to disk. Original error: " + ex.Message);
                }
            }
        }

        private void SaveFile(string oldPath, string newPath)
        {
            GetImagePB(pbOutput, oldPath);
            try
            {
                string sub = newPath.Substring(newPath.Length - 4);
                while (sub == ".scr")
                {
                    newPath = newPath.Substring(0, newPath.Length - 4);
                    sub = newPath.Substring(newPath.Length - 4);
                }
                pbOutput.Image.Save(newPath + ".scr");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not save file to disk. Original error: " + ex.Message);
            }
        }

        private void SaveFileTemp(string newPath)
        {
            try
            {
                string sub = newPath.Substring(newPath.Length - 4);
                while (sub == ".scr")
                {
                    newPath = newPath.Substring(0, newPath.Length - 4);
                    sub = newPath.Substring(newPath.Length - 4);
                }
                pbOutput.Image.Save(newPath + ".scr");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not save file to disk. Original error: " + ex.Message);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFilesAndData();
        }

        private void ClearFilesAndData()
        {
            ImageCanvas.Navigate("");
            scrambling = false;
            fromUrl = false;
            DeleteFiles(false);
            GalleryList.Items.Clear();
            gallery.Clear();
            index = 0;
        }

        private void NavigateLeft()
        {
            if (index > 0)
            {
                index--;
                GalleryList.SelectedIndex = index;
                ImageCanvas.Navigate(GalleryList.SelectedItem.ToString());
                if (stayUnscCheck.Checked)
                {
                    InstantScramble(GalleryList.SelectedItem.ToString());
                }
            }
        }

        private void NavigateRight()
        {
            if (index < gallery.Count - 1)
            {
                index++;
                GalleryList.SelectedIndex = index;
                ImageCanvas.Navigate(GalleryList.SelectedItem.ToString());
                if (stayUnscCheck.Checked)
                {
                    InstantScramble(GalleryList.SelectedItem.ToString());
                }
            }
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            NavigateLeft();
        }

        private void RightArrow_Click(object sender, EventArgs e)
        {
            NavigateRight();
        }

        private void stayUnscCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (stayUnscCheck.Checked)
            {
                ImageCanvas.Refresh();
            }
        }

        private void GalleryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GalleryList.SelectedIndex == -1)
                return;
            navigating = true;
            index = GalleryList.SelectedIndex;
            ImageCanvas.Navigate(GalleryList.SelectedItem.ToString());
            if (stayUnscCheck.Checked)
            {
                InstantUnscramble(GalleryList.SelectedItem.ToString());
            }
        }

        private void submitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fromUrl = true;
        }

        private void fromUrlCheck_CheckedChanged(object sender, EventArgs e)
        {
            fromUrl = true;
        }

        private void openASingleFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\temp\\";
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            string oldPath = "";
            string imageName = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageName = openFileDialog.FileName;
                    for (int i = 0; i < imageName.Length; i++)
                    {
                        string[] split = imageName.Split('\\');
                        imageName = split[split.Length - 1];
                    }

                    oldPath = openFileDialog.FileName.Replace("\\" + imageName, "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    return;
                }
                file = oldPath + "\\" + imageName;
                LoadImage(oldPath + "\\" + imageName);
                ImageCanvas.Navigate(gallery[index]);
                GalleryList.SelectedIndex = index;
            }
        }

        private void openMultipleFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string oldPath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\temp\\";
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] imageNames;
                try
                {
                    imageNames = openFileDialog.FileNames;
                    for (int i = 0; i < imageNames.Length; i++)
                    {
                        string[] split = imageNames[i].Split('\\');
                        imageNames[i] = split[split.Length - 1];
                    }

                    oldPath = openFileDialog.FileNames[0].Replace("\\" + imageNames[0], "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    return;
                }
                for (int i = 0; i < imageNames.Length; i++)
                {
                    file = oldPath + "\\" + imageNames[i];
                    LoadImage(oldPath + "\\" + imageNames[i]);
                }
                ImageCanvas.Navigate(gallery[index]);
                GalleryList.SelectedIndex = index;
            }
        }

        private void saveSelectedFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveSelectedFileAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }

        private void scrambleMultipleFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string oldPath = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\temp\\";
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                BatchScramble(openFileDialog.FileNames.ToList());
            }
        }

        private void scrambleSelectedFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScrambleImage(GalleryList.SelectedItem.ToString());
        }

        private void UnscrambleButton_Click(object sender, EventArgs e)
        {
            UnscrambleImage("");
        }

        private void scrambleAllFilesInGalleryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> filesToRemoveFromGallery = new List<string>();
            filesToRemoveFromGallery.AddRange(gallery);
            GalleryList.Items.Clear();
            gallery.Clear();
            BatchScramble(filesToRemoveFromGallery);
            while (batchScrambling) { }
            //GalleryList.SelectedIndex = 0;
            foreach (string line in filesToRemoveFromGallery)
            {
                if (gallery.Contains(line))
                {
                    gallery.Remove(line);
                }
                if (GalleryList.Items.Contains(line))
                {
                    GalleryList.Items.Remove(line);
                }
            }
        }

        private void RemoveFileButton_Click(object sender, EventArgs e)
        {
            if (GalleryList.Items.Count > 0)
            {
                int index = GalleryList.SelectedIndex;
                gallery.Remove(GalleryList.SelectedItem.ToString());
                GalleryList.Items.Remove(GalleryList.SelectedItem);
                GalleryList.SelectedIndex = -1;
            }
        }
    }

    //Adapted from Visual C# Kicks - http://www.vcskicks.com/
    public unsafe class FastBitmap
    {
        private Bitmap workingBitmap = null;
        private int width = 0;
        private BitmapData bitmapData = null;
        private Byte* pBase = null;

        public FastBitmap(Bitmap inputBitmap)
        {
            workingBitmap = inputBitmap;
        }

        public BitmapData LockImage()
        {
            Rectangle bounds = new Rectangle(Point.Empty, workingBitmap.Size);

            width = (int)(bounds.Width * 4 + 3) & ~3;

            //Lock Image
            bitmapData = workingBitmap.LockBits(bounds, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            pBase = (Byte*)bitmapData.Scan0.ToPointer();
            return bitmapData;
        }

        private uint* pixelData = null;

        public uint GetPixel(int x, int y)
        {
            pixelData = (uint*)(pBase + y * width + x * 4);
            return *pixelData;
        }

        public uint GetNextPixel()
        {
            return *++pixelData;
        }

        public void GetPixelArray(int x, int y, uint[] Values, int offset, int count)
        {
            pixelData = (uint*)(pBase + y * width + x * 4);
            while (count-- > 0)
            {
                Values[offset++] = *pixelData++;
            }
        }

        public void SetPixel(int x, int y, uint color)
        {
            pixelData = (uint*)(pBase + y * width + x * 4);
            *pixelData = color;
        }

        public void SetNextPixel(uint color)
        {
            *++pixelData = color;
        }

        public void UnlockImage()
        {
            workingBitmap.UnlockBits(bitmapData);
            bitmapData = null;
            pBase = null;
        }
    }

    public class XorShift
    {
        private ulong x; /* The state must be seeded with a nonzero value. */

        public XorShift(ulong seed)
        {
            x = seed;
        }

        public ulong next()
        {
            x ^= x >> 12; // a
            x ^= x << 25; // b
            x ^= x >> 27; // c
            return x * 2685821657736338717L;
        }
    }
}
