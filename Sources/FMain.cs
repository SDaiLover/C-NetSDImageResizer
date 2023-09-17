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
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class FMain : Form
    {
        private const string APP_TITLE = "SD Image Resizer";
        private Dictionary<string, ImageTempBrowsed> imageTempBrowsed;
        private List<ImageTempBrowsed> imageTempResult;
        private FLoader loaderForm;
        private Size imageRenderSize;
        private bool imageStretch;
 
        public FMain()
        {
            InitializeComponent();
            this.imageTempBrowsed = new Dictionary<string, ImageTempBrowsed>();
            this.imageTempResult = new List<ImageTempBrowsed>();
            this.loaderForm = new FLoader();
            this.imageRenderSize = new Size(400, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.copyrightToolStrip.Text = "© ID 2022 Stephanus Bagus Saputra";
            this.optionGroupBox.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            this.layoutComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.backColorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.backColorComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            this.layoutComboBox.Items.AddRange(new object[] {"Square", "Portrait", "Landscape"});
            this.sizeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.appTitleLabel.Text = APP_TITLE;
            this.statusToolStrip.Text = this.Text = APP_TITLE + " v" + Application.ProductVersion.ToString();
            this.progressBarToolStrip.Visible = false;
            this.imageTempWorker.WorkerReportsProgress = true;
            this.imageProcessWorker.WorkerReportsProgress = true;
            this.mediumToolStripMenuItem.Checked = true;
            this.MinimumSize = new Size(600, 400);
            this.imageExploreListView.View = View.LargeIcon;
            this.imageExploreListView.LargeImageList = pictureImageList;
            this.imageExploreListView.MultiSelect = true;
            this.imageExploreListView.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            this.viewSizeTrackBar.Maximum = 7;
            this.viewSizeTrackBar.Value = 2;
            this.widthTextBox.Text = this.heightTextBox.Text = "0";
            this.pictureImageList.ColorDepth = ColorDepth.Depth32Bit;
            this.pictureImageList.ImageSize = new Size(84, 84);
            this.imageExploreListView.ContextMenuStrip = this.imageContextMenuStrip;
            this.resetButton.Click += new EventHandler(this.resetButton_Click);
            this.removeAllToolStripMenuItem.Click += new EventHandler(this.resetButton_Click);
            this.aboutButton.Click += new EventHandler(this.aboutButton_Click);
            this.browseButton.Click += new EventHandler(this.browseButton_Click);
            this.insertImageToolStripMenuItem.Click += new EventHandler(this.browseButton_Click);
            this.processButton.Click += new EventHandler(this.processButton_Click);
            this.viewSizeTrackBar.ValueChanged += new EventHandler(this.viewSizeTrackBar_ValueChanged);
            this.imageTempWorker.DoWork += new DoWorkEventHandler(this.imageTempWorker_DoWork);
            this.imageTempWorker.ProgressChanged += new ProgressChangedEventHandler(this.imageTempWorker_ProgressChanged);
            this.imageTempWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.imageTempWorker_RunWorkerCompleted);
            this.widthTextBox.TextChanged += new EventHandler(this.sizeTextBox_TextChanged);
            this.heightTextBox.TextChanged += new EventHandler(this.sizeTextBox_TextChanged);
            this.layoutComboBox.SelectedIndexChanged += new EventHandler(this.layoutComboBox_SelectedIndexChanged);
            this.sizeComboBox.SelectedIndexChanged += new EventHandler(this.sizeComboBox_SelectedIndexChanged);
            this.backColorComboBox.DrawItem += new DrawItemEventHandler(this.backColorComboBox_DrawItem);
            this.imageProcessWorker.DoWork += new DoWorkEventHandler(this.imageProcessWorker_DoWork);
            this.imageProcessWorker.ProgressChanged += new ProgressChangedEventHandler(this.imageProcessWorker_ProgressChanged);
            this.imageProcessWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.imageProcessWorker_RunWorkerCompleted);
            this.imageContextMenuStrip.Opened += new EventHandler(this.imageContextMenuStrip_Opened);
            this.smallToolStripMenuItem.Click += new EventHandler(this.smallToolStripMenuItem_Click);
            this.mediumToolStripMenuItem.Click += new EventHandler(this.mediumToolStripMenuItem_Click);
            this.largeToolStripMenuItem.Click += new EventHandler(this.largeToolStripMenuItem_Click);
            this.bigLargeToolStripMenuItem.Click += new EventHandler(this.bigLargeToolStripMenuItem_Click);
            this.widthTextBox.TextChanged += new EventHandler(this.sizeImageTextBox_TextChanged);
            this.heightTextBox.TextChanged += new EventHandler(this.sizeImageTextBox_TextChanged);
            this.stretchCheckBox.CheckedChanged += new EventHandler(this.stretchCheckBox_CheckedChanged);
            this.imageExploreListView.DoubleClick += new EventHandler(this.imageExploreListView_DoubleClick);
            this.previewImageToolStripMenuItem.Click += new EventHandler(this.previewImageToolStripMenuItem_Click);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.layoutComboBox.SelectedIndex = 0;
            PrepairBackColorComboBox();
        }

        private void PrepairBackColorComboBox()
        {
            backColorComboBox.Items.Clear();
            Type colorType = typeof(Color);
            PropertyInfo[] propInfos = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo propInfo in propInfos)
            {
                if (propInfo.Name != "Transparent")
                {
                    backColorComboBox.Items.Add(propInfo.Name);
                }
            }
            backColorComboBox.SelectedIndex = backColorComboBox.Items.IndexOf("Black");
        }

        private void previewImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageExploreListView.SelectedItems.Count == 1)
            {
                int index = imageExploreListView.SelectedItems[0].Index;
                string fileName = imageExploreListView.SelectedItems[0].Text;
                FView previewForm = new FView(imageTempBrowsed[fileName]);
                previewForm.ShowDialog(this);
            }
        }

        private void imageExploreListView_DoubleClick(object sender, EventArgs e)
        {
            previewImageToolStripMenuItem.PerformClick();
        }

        private void stretchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            imageStretch = stretchCheckBox.Checked;
        }

        private void sizeImageTextBox_TextChanged(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(widthTextBox.Text);
            int height = Convert.ToInt32(heightTextBox.Text);
            imageRenderSize = new Size(width, height);
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

        private void imageContextMenuStrip_Opened(object sender, EventArgs e)
        {
            if (imageExploreListView.SelectedItems.Count > 0)
            {
                insertImageToolStripMenuItem.Visible = false;
                previewImageToolStripMenuItem.Visible = true;
                removeAllToolStripMenuItem.Enabled = true;
                previewImageToolStripMenuItem.Enabled = true;
                removeSelectedToolStripMenuItem.Visible = false;
                if (imageExploreListView.SelectedItems.Count > 1)
                {
                    previewImageToolStripMenuItem.Enabled = false;
                    removeSelectedToolStripMenuItem.Visible = true;
                }
            }
            else
            {
                insertImageToolStripMenuItem.Visible = true;
                previewImageToolStripMenuItem.Visible = false;
                removeSelectedToolStripMenuItem.Visible = false;
                if (imageExploreListView.Items.Count > 0)
                {
                    removeAllToolStripMenuItem.Enabled = true;
                }
                else
                {
                    removeAllToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void backColorComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics graph = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string name = ((ComboBox)sender).Items[e.Index].ToString();
                Font font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
                Color color = Color.FromName(name);
                Brush brush = new SolidBrush(color);
                graph.DrawString(name, font, Brushes.Black, rect.X + 28, rect.Top);
                graph.FillRectangle(brush, rect.X + 3, rect.Y + 2, 20, rect.Height - 5);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            pictureImageList.Images.Clear();
            imageExploreListView.Items.Clear();
            imageTempBrowsed.Clear();
            imageTempResult.Clear();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            if (imageTempBrowsed.Count <= 0)
            {
                MessageBox.Show("You have to one Image for Processing!", APP_TITLE);
            }
            else
            {
                if (imageProcessWorker.IsBusy != true)
                {
                    loaderForm = new FLoader();
                    loaderForm.Show();
                    progressBarToolStrip.Visible = true;
                    imageTempResult.Clear();
                    this.Enabled = false;
                    imageProcessWorker.RunWorkerAsync(imageTempBrowsed);
                }
            }
        }

        private void layoutComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (layoutComboBox.SelectedIndex)
            {
                case 2:
                    sizeComboBox.Items.Clear();
                    sizeComboBox.Items.AddRange(new object[] { "480x320", "720x480", "800x480", "960x640", "1024x768" });
                    sizeComboBox.SelectedIndex = 0;
                    break;
                case 1:
                    sizeComboBox.Items.Clear();
                    sizeComboBox.Items.AddRange(new object[] { "320x480", "480x720", "480x800", "640x960", "768x1024" });
                    sizeComboBox.SelectedIndex = 0;
                    break;
                default:
                    sizeComboBox.Items.Clear();
                    sizeComboBox.Items.AddRange(new object[] { "320x320", "480x480", "800x800", "960x960", "1024x1024" });
                    sizeComboBox.SelectedIndex = 0;
                    break;
            }
        }

        private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sizeComboBox.SelectedIndex)
            {
                case 4:
                    if (layoutComboBox.SelectedIndex == 0)
                    {
                        widthTextBox.Text = "1024";
                        heightTextBox.Text = "1024";
                    }
                    else if (layoutComboBox.SelectedIndex == 1)
                    {
                        widthTextBox.Text = "768";
                        heightTextBox.Text = "1024";
                    }
                    else if (layoutComboBox.SelectedIndex == 2)
                    {
                        widthTextBox.Text = "1024";
                        heightTextBox.Text = "768";
                    }
                    break;
                case 3:
                    if (layoutComboBox.SelectedIndex == 0)
                    {
                        widthTextBox.Text = "960";
                        heightTextBox.Text = "960";
                    }
                    else if (layoutComboBox.SelectedIndex == 1)
                    {
                        widthTextBox.Text = "640";
                        heightTextBox.Text = "960";
                    }
                    else if (layoutComboBox.SelectedIndex == 2)
                    {
                        widthTextBox.Text = "960";
                        heightTextBox.Text = "640";
                    }
                    break;
                case 2:
                    if (layoutComboBox.SelectedIndex == 0)
                    {
                        widthTextBox.Text = "800";
                        heightTextBox.Text = "800";
                    }
                    else if (layoutComboBox.SelectedIndex == 1)
                    {
                        widthTextBox.Text = "480";
                        heightTextBox.Text = "800";
                    }
                    else if (layoutComboBox.SelectedIndex == 2)
                    {
                        widthTextBox.Text = "800";
                        heightTextBox.Text = "480";
                    }
                    break;
                case 1:
                    if (layoutComboBox.SelectedIndex == 0)
                    {
                        widthTextBox.Text = "480";
                        heightTextBox.Text = "480";
                    }
                    else if (layoutComboBox.SelectedIndex == 1)
                    {
                        widthTextBox.Text = "480";
                        heightTextBox.Text = "720";
                    }
                    else if (layoutComboBox.SelectedIndex == 2)
                    {
                        widthTextBox.Text = "720";
                        heightTextBox.Text = "480";
                    }
                    break;
                default:
                    if (layoutComboBox.SelectedIndex == 0)
                    {
                        widthTextBox.Text = "320";
                        heightTextBox.Text = "320";
                    }
                    else if (layoutComboBox.SelectedIndex == 1)
                    {
                        widthTextBox.Text = "320";
                        heightTextBox.Text = "480";
                    }
                    else if (layoutComboBox.SelectedIndex == 2)
                    {
                        widthTextBox.Text = "480";
                        heightTextBox.Text = "320";
                    }
                    break;
            }
        }

        private void sizeTextBox_TextChanged(object sender, EventArgs e)
        {
            int distance;
            TextBox sizeText = (TextBox)sender;
            if (int.TryParse(sizeText.Text, out distance))
            {
                if (sizeText.Text.Length > 1)
                {
                    if (sizeText.Text.IndexOf("0") == 0)
                    {
                        MessageBox.Show("Wrong format! Zero cannot be in front.", APP_TITLE);
                    }
                }
            }
            else
            {
                MessageBox.Show("Only numbers are allowed!", APP_TITLE);
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            FAbout aboutForm = new FAbout();
            aboutForm.ShowDialog();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageBrowseDialog = new OpenFileDialog();
            imageBrowseDialog.Title = "Please select the desired image";
            imageBrowseDialog.Filter = "JPG Images(*.jpg; *.jpeg)|*.jpg; *.jpeg";
            imageBrowseDialog.Multiselect = true;

            if (imageBrowseDialog.ShowDialog() == DialogResult.OK)
            {
                if (imageTempWorker.IsBusy != true)
                {
                    progressBarToolStrip.Visible = true;
                    imageTempWorker.RunWorkerAsync(imageBrowseDialog);
                }
            }
        }

        private void imageTempWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            BackgroundWorker worker = sender as BackgroundWorker;
            OpenFileDialog imageBrowseDialog = e.Argument as OpenFileDialog;
            int totalFileBrowsed = imageBrowseDialog.FileNames.Count();
            foreach (string imageFile in imageBrowseDialog.FileNames)
            {
                int index = i + 1;
                double bytesIn = double.Parse(index.ToString());
                double totalBytes = double.Parse(totalFileBrowsed.ToString());
                double percentage = bytesIn / totalBytes * 100;
                int currentIndex = int.Parse(Math.Truncate(percentage).ToString());
                worker.ReportProgress(currentIndex, imageFile);
                i++;
            }
        }

        private void imageTempWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string imageFile = (string)e.UserState;
            string fileName = Path.GetFileNameWithoutExtension(imageFile);
            progressBarToolStrip.Visible = true;
            progressBarToolStrip.Value = e.ProgressPercentage;
            if (imageTempBrowsed.ContainsKey(fileName) == false)
            {
                Bitmap imageFileBrowsed = new Bitmap(imageFile);
                ImageTempBrowsed newImageTemp = new ImageTempBrowsed();
                newImageTemp.Name = fileName;
                newImageTemp.Path = imageFile;
                newImageTemp.Image = imageFileBrowsed;
                newImageTemp.Size = new Size(imageFileBrowsed.Width, imageFileBrowsed.Height);
                imageTempBrowsed.Add(fileName, newImageTemp);

                pictureImageList.Images.Add(fileName, imageFileBrowsed);
                imageExploreListView.Items.Add(fileName, fileName);
            }
        }

        private void imageTempWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarToolStrip.Visible = false;
        }

        private void imageProcessWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            BackgroundWorker worker = sender as BackgroundWorker;
            Dictionary<string, ImageTempBrowsed> imageFileCache = (Dictionary<string, ImageTempBrowsed>)e.Argument;
            foreach (KeyValuePair<string, ImageTempBrowsed> imageTemp in imageFileCache)
            {
                ImageTempBrowsed imageFileTemp = (ImageTempBrowsed)imageTemp.Value;

                Bitmap imageFileResult = ResizeImage(imageFileTemp.Image, imageRenderSize.Width, imageRenderSize.Height, imageStretch);
                ImageTempBrowsed newImageTemp = new ImageTempBrowsed();
                newImageTemp.Name = imageFileTemp.Name;
                newImageTemp.Path = imageFileTemp.Path;
                newImageTemp.Image = imageFileResult;
                newImageTemp.Size = new Size(imageFileResult.Width, imageFileResult.Height);
                imageTempResult.Add(newImageTemp);

                int index = i + 1;
                double bytesIn = double.Parse(index.ToString());
                double totalBytes = double.Parse(imageTempBrowsed.Count.ToString());
                double percentage = bytesIn / totalBytes * 100;
                int currentIndex = int.Parse(Math.Truncate(percentage).ToString());
                worker.ReportProgress(currentIndex, imageFileCache);
                i++;
            }
        }

        private void imageProcessWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarToolStrip.Visible = true;
            progressBarToolStrip.Value = e.ProgressPercentage;
            loaderForm.ChangeProgress(e.ProgressPercentage);
        }

        private void imageProcessWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarToolStrip.Visible = false;
            loaderForm.Close();
            this.Enabled = true;
            this.Focus();
            CImageTempCollection imageResult = new CImageTempCollection();
            foreach (ImageTempBrowsed imageTemp in imageTempResult)
            {
                imageResult.Add(imageTemp);
            }
            FOuput outForm = new FOuput(imageResult);
            outForm.ShowDialog();
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
            foreach (KeyValuePair<string, ImageTempBrowsed> imageTemp in imageTempBrowsed)
            {
                ImageTempBrowsed imageFileTemp = (ImageTempBrowsed)imageTemp.Value;
                pictureImageList.Images.Add(imageFileTemp.Name, imageFileTemp.Image);
                imageExploreListView.Items.Add(imageFileTemp.Name, imageFileTemp.Name);
            }
        }

        protected Bitmap ResizeImage(Image image, int width, int height, bool stretch)
        {
            var destImage = new Bitmap(width, height);
            if (stretch == true)
            {
                var destRect = new Rectangle(0, 0, width, height);

                destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                using (var graphics = Graphics.FromImage(destImage))
                {
                    graphics.CompositingMode = CompositingMode.SourceCopy;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    using (var wrapMode = new ImageAttributes())
                    {
                        wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                        graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                    }
                }
            }
            else
            {
                destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                float scale = Math.Min(width / image.Width, height / image.Height);
                var brush = new SolidBrush(Color.Black);

                double ratioX = (double)width / (double)image.Width;
                double ratioY = (double)height / (double)image.Height;
                double ratio = ratioX < ratioY ? ratioX : ratioY;
                int scaleHeight = Convert.ToInt32(image.Height * ratio);
                int scaleWidth = Convert.ToInt32(image.Width * ratio);
                int posX = Convert.ToInt32((width - (image.Width * ratio)) / 2);
                int posY = Convert.ToInt32((height - (image.Height * ratio)) / 2);

                var destRect = new Rectangle(posX, posY, scaleWidth, scaleHeight);

                using (var graphics = Graphics.FromImage(destImage))
                {
                    graphics.CompositingMode = CompositingMode.SourceCopy;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    using (var wrapMode = new ImageAttributes())
                    {
                        wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                        graphics.FillRectangle(brush, new RectangleF(0, 0, width, height));
                        graphics.DrawImage(image, posX, posY, scaleWidth, scaleHeight);
                    }
                }
            }

            return destImage;
        }
    }
}
