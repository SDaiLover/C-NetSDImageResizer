/***********************************************
 * SDIMAGERESIZER APPLICATION
 *                                               
 * @author : Stephanus Bagus Saputra 
 *          (Dai Wie Funk)             
 * @email  : stephanusdai@icloud.com             
 * @site   : https://www.stephanusdai.web.id
 *                                               
 * Copyright © ID 2021 Stephanus Bagus Saputra   
 ***********************************************
 * THE  SOFTWARE  IS PROVIDED  "AS IS", WITHOUT 
 * WARRANTY  OF ANY  KIND,  EXPRESS OR IMPLIED, 
 * INCLUDING  BUT NOT LIMITED TO THE WARRANTIES 
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR 
 * PURPOSE  AND  NONINFRINGEMENT.  IN  NO EVENT 
 * SHALL  THE AUTHORS  OR  COPYRIGHT HOLDERS BE 
 * LIABLE  FOR  ANY  CLAIM,  DAMAGES  OR  OTHER 
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, 
 * TORT OR OTHERWISE,  ARISING FROM,  OUT OF OR 
 * IN CONNECTION  WITH THE SOFTWARE  OR THE USE 
 * OR   OTHER   DEALINGS   IN   THE   SOFTWARE. 
 ***********************************************/
namespace StephanusDai.SDImageResizer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class FOuput : Form
    {
        private const string APP_TITLE = "SD Image Resizer";
        private CImageTempCollection imageTempResults;
        private FLoader loaderForm;
        private string pathSaveString;

        public FOuput(CImageTempCollection imageResult)
        {
            InitializeComponent();
            this.imageTempResults = new CImageTempCollection();
            this.loaderForm = new FLoader();
            this.imageTempResults = imageResult;
            this.imageExploreListView.View = View.LargeIcon;
            this.imageExploreListView.LargeImageList = pictureImageList;
            this.imageExploreListView.MultiSelect = true;
            this.imageExploreListView.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            this.appTitleLabel.Text = APP_TITLE;
            this.copyrightToolStrip.Text = "© ID 2022 Stephanus Bagus Saputra";
            this.statusToolStrip.Text = this.Text = APP_TITLE + " v" + Application.ProductVersion.ToString();
            this.viewSizeTrackBar.Maximum = 7;
            this.viewSizeTrackBar.Value = 2;
            this.progressBarToolStrip.Visible = false;
            this.pictureImageList.ColorDepth = ColorDepth.Depth32Bit;
            this.pictureImageList.ImageSize = new Size(84, 84);
            this.pathSaveTextBox.Enabled = false;
            this.imageExploreListView.ContextMenuStrip = this.imageContextMenuStrip;
            this.imageProcessWorker.WorkerReportsProgress = true;
            this.aboutButton.Click += new EventHandler(this.aboutButton_Click);
            this.pathBrowseButton.Click += new EventHandler(this.pathBrowseButton_Click);
            this.imageContextMenuStrip.Opened += new EventHandler(this.imageContextMenuStrip_Opened);
            this.viewSizeTrackBar.ValueChanged += new EventHandler(this.viewSizeTrackBar_ValueChanged);
            this.smallToolStripMenuItem.Click += new EventHandler(this.smallToolStripMenuItem_Click);
            this.mediumToolStripMenuItem.Click += new EventHandler(this.mediumToolStripMenuItem_Click);
            this.largeToolStripMenuItem.Click += new EventHandler(this.largeToolStripMenuItem_Click);
            this.bigLargeToolStripMenuItem.Click += new EventHandler(this.bigLargeToolStripMenuItem_Click);
            this.imageExploreListView.DoubleClick += new EventHandler(this.imageExploreListView_DoubleClick);
            this.previewImageToolStripMenuItem.Click += new EventHandler(this.previewImageToolStripMenuItem_Click);
            this.imageProcessWorker.DoWork += new DoWorkEventHandler(this.imageProcessWorker_DoWork);
            this.imageProcessWorker.ProgressChanged += new ProgressChangedEventHandler(this.imageProcessWorker_ProgressChanged);
            this.imageProcessWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.imageProcessWorker_RunWorkerCompleted);
            this.pathSaveTextBox.TextChanged += new EventHandler(this.pathSaveTextBox_TextChanged);
            this.processSaveButton.Click += new EventHandler(this.processSaveButton_Click);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            foreach (ImageTempBrowsed imageTemp in imageTempResults)
            {
                pictureImageList.Images.Add(imageTemp.Name, imageTemp.Image);
                imageExploreListView.Items.Add(imageTemp.Name, imageTemp.Name);
            }
        }

        private void pathSaveTextBox_TextChanged(object sender, EventArgs e)
        {
            pathSaveString = pathSaveTextBox.Text;
        }

        private void processSaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.pathSaveTextBox.Text))
            {
                MessageBox.Show("You have to choose a save location first!", APP_TITLE);
            }
            else
            {
                if (imageProcessWorker.IsBusy != true)
                {
                    loaderForm = new FLoader();
                    loaderForm.Show();
                    progressBarToolStrip.Visible = true;
                    this.Enabled = false;
                    imageProcessWorker.RunWorkerAsync(imageTempResults);
                }
            }
        }

        private void imageProcessWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            BackgroundWorker worker = sender as BackgroundWorker;
            CImageTempCollection imageFileResults = (CImageTempCollection)e.Argument;
            foreach (ImageTempBrowsed imageTemp in imageFileResults)
            {
                int index = i + 1;
                double bytesIn = double.Parse(index.ToString());
                double totalBytes = double.Parse(imageFileResults.Count.ToString());
                double percentage = bytesIn / totalBytes * 100;
                int currentIndex = int.Parse(Math.Truncate(percentage).ToString());
                string fileName = pathSaveString + System.IO.Path.DirectorySeparatorChar + imageTemp.Name + ".jpg";
                Image imageFile = imageTemp.Image;
                imageFile.Save(fileName, ImageFormat.Jpeg);
                worker.ReportProgress(currentIndex, imageTemp);
                i++;
            }
        }

        private void imageProcessWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ImageTempBrowsed imageTemp = (ImageTempBrowsed)e.UserState;
            progressBarToolStrip.Visible = true;
            progressBarToolStrip.Value = e.ProgressPercentage;
            loaderForm.ChangeProgress(e.ProgressPercentage);
        }

        private void imageProcessWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarToolStrip.Visible = false;
            loaderForm.Close();
            MessageBox.Show("Image has been converted successfully.", APP_TITLE);
            Process.Start("explorer.exe", pathSaveString);
            this.Enabled = true;
            this.Close();
        }

        private void imageContextMenuStrip_Opened(object sender, EventArgs e)
        {
            if (imageExploreListView.SelectedItems.Count == 1)
            {
                previewImageToolStripMenuItem.Enabled = true;
            }
            else
            {
                previewImageToolStripMenuItem.Enabled = false;
            }
        }

        private void previewImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageExploreListView.SelectedItems.Count == 1)
            {
                int index = imageExploreListView.SelectedItems[0].Index;
                string fileName = imageExploreListView.SelectedItems[0].Text;
                FView previewForm = new FView((ImageTempBrowsed)imageTempResults[index]);
                previewForm.ShowDialog(this);
            }
        }

        private void imageExploreListView_DoubleClick(object sender, EventArgs e)
        {
            previewImageToolStripMenuItem.PerformClick();
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewSizeTrackBar.Value = 0;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewSizeTrackBar.Value = 2;
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewSizeTrackBar.Value = 4;
        }

        private void bigLargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewSizeTrackBar.Value = 7;
        }

        private void pathBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowseDialog = new FolderBrowserDialog();
            if (folderBrowseDialog.ShowDialog() == DialogResult.OK)
            {
                pathSaveTextBox.Text = folderBrowseDialog.SelectedPath;
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            FAbout aboutForm = new FAbout();
            aboutForm.ShowDialog();
        }

        private void viewSizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            switch (viewSizeTrackBar.Value)
            {
                case 0:
                    pictureImageList.ImageSize = new Size(32, 32);
                    imageExploreListView.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                    smallToolStripMenuItem.Checked = true;
                    mediumToolStripMenuItem.Checked = false;
                    largeToolStripMenuItem.Checked = false;
                    bigLargeToolStripMenuItem.Checked = false;
                    break;
                case 1:
                    pictureImageList.ImageSize = new Size(56, 56);
                    imageExploreListView.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
                    smallToolStripMenuItem.Checked = true;
                    mediumToolStripMenuItem.Checked = false;
                    largeToolStripMenuItem.Checked = false;
                    bigLargeToolStripMenuItem.Checked = false;
                    break;
                case 2:
                    pictureImageList.ImageSize = new Size(84, 84);
                    imageExploreListView.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                    smallToolStripMenuItem.Checked = false;
                    mediumToolStripMenuItem.Checked = true;
                    largeToolStripMenuItem.Checked = false;
                    bigLargeToolStripMenuItem.Checked = false;
                    break;
                case 3:
                    pictureImageList.ImageSize = new Size(124, 124);
                    imageExploreListView.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular);
                    smallToolStripMenuItem.Checked = false;
                    mediumToolStripMenuItem.Checked = true;
                    largeToolStripMenuItem.Checked = false;
                    bigLargeToolStripMenuItem.Checked = false;
                    break;
                case 4:
                    pictureImageList.ImageSize = new Size(168, 168);
                    imageExploreListView.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
                    smallToolStripMenuItem.Checked = false;
                    mediumToolStripMenuItem.Checked = false;
                    largeToolStripMenuItem.Checked = true;
                    bigLargeToolStripMenuItem.Checked = false;
                    break;
                case 5:
                    pictureImageList.ImageSize = new Size(180, 180);
                    imageExploreListView.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Regular);
                    smallToolStripMenuItem.Checked = false;
                    mediumToolStripMenuItem.Checked = false;
                    largeToolStripMenuItem.Checked = true;
                    bigLargeToolStripMenuItem.Checked = false;
                    break;
                case 6:
                    pictureImageList.ImageSize = new Size(210, 210);
                    imageExploreListView.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                    smallToolStripMenuItem.Checked = false;
                    mediumToolStripMenuItem.Checked = false;
                    largeToolStripMenuItem.Checked = false;
                    bigLargeToolStripMenuItem.Checked = true;
                    break;
                default:
                    pictureImageList.ImageSize = new Size(256, 256);
                    imageExploreListView.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Regular);
                    smallToolStripMenuItem.Checked = false;
                    mediumToolStripMenuItem.Checked = false;
                    largeToolStripMenuItem.Checked = false;
                    bigLargeToolStripMenuItem.Checked = true;
                    break;
            }
            RefreshImageExploreListView();
        }

        private void RefreshImageExploreListView()
        {
            pictureImageList.Images.Clear();
            imageExploreListView.Items.Clear();
            foreach (ImageTempBrowsed imageFileTemp in imageTempResults)
            {
                pictureImageList.Images.Add(imageFileTemp.Name, imageFileTemp.Image);
                imageExploreListView.Items.Add(imageFileTemp.Name, imageFileTemp.Name);
            }
        }
    }
}
