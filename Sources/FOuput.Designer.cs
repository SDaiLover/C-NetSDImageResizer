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
    partial class FOuput
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOuput));
            this.bottomStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBarToolStrip = new System.Windows.Forms.ToolStripProgressBar();
            this.copyrightToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureImageList = new System.Windows.Forms.ImageList(this.components);
            this.toolboxPanel = new System.Windows.Forms.Panel();
            this.pathBrowseButton = new System.Windows.Forms.Button();
            this.pathSaveTextBox = new System.Windows.Forms.TextBox();
            this.pathSaveLabel = new System.Windows.Forms.Label();
            this.processSaveButton = new System.Windows.Forms.Button();
            this.viewSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.windowPanel = new System.Windows.Forms.Panel();
            this.imageExploreListView = new System.Windows.Forms.ListView();
            this.imageContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.previewImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.modeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigLargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageProcessWorker = new System.ComponentModel.BackgroundWorker();
            this.topPanel = new System.Windows.Forms.Panel();
            this.appLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.appTitleLabel = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.bottomStatusStrip.SuspendLayout();
            this.toolboxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSizeTrackBar)).BeginInit();
            this.windowPanel.SuspendLayout();
            this.imageContextMenuStrip.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomStatusStrip
            // 
            this.bottomStatusStrip.BackColor = System.Drawing.Color.Brown;
            this.bottomStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStrip,
            this.progressBarToolStrip,
            this.copyrightToolStrip});
            this.bottomStatusStrip.Location = new System.Drawing.Point(0, 339);
            this.bottomStatusStrip.Name = "bottomStatusStrip";
            this.bottomStatusStrip.Size = new System.Drawing.Size(584, 22);
            this.bottomStatusStrip.TabIndex = 2;
            this.bottomStatusStrip.Text = "statusStrip1";
            // 
            // statusToolStrip
            // 
            this.statusToolStrip.ActiveLinkColor = System.Drawing.Color.White;
            this.statusToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.statusToolStrip.ForeColor = System.Drawing.Color.White;
            this.statusToolStrip.Name = "statusToolStrip";
            this.statusToolStrip.Size = new System.Drawing.Size(272, 17);
            this.statusToolStrip.Spring = true;
            this.statusToolStrip.Text = "SD Image Resizer v1.0";
            this.statusToolStrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBarToolStrip
            // 
            this.progressBarToolStrip.Name = "progressBarToolStrip";
            this.progressBarToolStrip.Size = new System.Drawing.Size(100, 16);
            // 
            // copyrightToolStrip
            // 
            this.copyrightToolStrip.ForeColor = System.Drawing.Color.White;
            this.copyrightToolStrip.Name = "copyrightToolStrip";
            this.copyrightToolStrip.Size = new System.Drawing.Size(195, 17);
            this.copyrightToolStrip.Text = "© ID 2022 Stephanus Bagus Saputra";
            // 
            // pictureImageList
            // 
            this.pictureImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.pictureImageList.ImageSize = new System.Drawing.Size(98, 98);
            this.pictureImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolboxPanel
            // 
            this.toolboxPanel.Controls.Add(this.pathBrowseButton);
            this.toolboxPanel.Controls.Add(this.pathSaveTextBox);
            this.toolboxPanel.Controls.Add(this.pathSaveLabel);
            this.toolboxPanel.Controls.Add(this.processSaveButton);
            this.toolboxPanel.Controls.Add(this.viewSizeTrackBar);
            this.toolboxPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolboxPanel.Location = new System.Drawing.Point(0, 302);
            this.toolboxPanel.Name = "toolboxPanel";
            this.toolboxPanel.Size = new System.Drawing.Size(584, 37);
            this.toolboxPanel.TabIndex = 3;
            // 
            // pathBrowseButton
            // 
            this.pathBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pathBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pathBrowseButton.Location = new System.Drawing.Point(352, 8);
            this.pathBrowseButton.Name = "pathBrowseButton";
            this.pathBrowseButton.Size = new System.Drawing.Size(35, 20);
            this.pathBrowseButton.TabIndex = 4;
            this.pathBrowseButton.Text = "[..]";
            this.pathBrowseButton.UseVisualStyleBackColor = true;
            // 
            // pathSaveTextBox
            // 
            this.pathSaveTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathSaveTextBox.Location = new System.Drawing.Point(67, 8);
            this.pathSaveTextBox.Name = "pathSaveTextBox";
            this.pathSaveTextBox.Size = new System.Drawing.Size(286, 20);
            this.pathSaveTextBox.TabIndex = 6;
            // 
            // pathSaveLabel
            // 
            this.pathSaveLabel.AutoSize = true;
            this.pathSaveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathSaveLabel.Location = new System.Drawing.Point(7, 9);
            this.pathSaveLabel.Name = "pathSaveLabel";
            this.pathSaveLabel.Size = new System.Drawing.Size(54, 15);
            this.pathSaveLabel.TabIndex = 5;
            this.pathSaveLabel.Text = "Location";
            // 
            // processSaveButton
            // 
            this.processSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.processSaveButton.Location = new System.Drawing.Point(497, 4);
            this.processSaveButton.Name = "processSaveButton";
            this.processSaveButton.Size = new System.Drawing.Size(77, 30);
            this.processSaveButton.TabIndex = 3;
            this.processSaveButton.Text = "Save";
            this.processSaveButton.UseVisualStyleBackColor = true;
            // 
            // viewSizeTrackBar
            // 
            this.viewSizeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewSizeTrackBar.Location = new System.Drawing.Point(393, 4);
            this.viewSizeTrackBar.Maximum = 7;
            this.viewSizeTrackBar.Name = "viewSizeTrackBar";
            this.viewSizeTrackBar.Size = new System.Drawing.Size(98, 45);
            this.viewSizeTrackBar.TabIndex = 2;
            this.viewSizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // windowPanel
            // 
            this.windowPanel.Controls.Add(this.imageExploreListView);
            this.windowPanel.Controls.Add(this.topPanel);
            this.windowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowPanel.Location = new System.Drawing.Point(0, 0);
            this.windowPanel.Name = "windowPanel";
            this.windowPanel.Size = new System.Drawing.Size(584, 302);
            this.windowPanel.TabIndex = 4;
            // 
            // imageExploreListView
            // 
            this.imageExploreListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageExploreListView.Location = new System.Drawing.Point(0, 48);
            this.imageExploreListView.Name = "imageExploreListView";
            this.imageExploreListView.Size = new System.Drawing.Size(584, 254);
            this.imageExploreListView.TabIndex = 1;
            this.imageExploreListView.UseCompatibleStateImageBehavior = false;
            // 
            // imageContextMenuStrip
            // 
            this.imageContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previewImageToolStripMenuItem,
            this.toolStripMenuItem1,
            this.modeViewToolStripMenuItem});
            this.imageContextMenuStrip.Name = "imageContextMenuStrip";
            this.imageContextMenuStrip.Size = new System.Drawing.Size(152, 54);
            // 
            // previewImageToolStripMenuItem
            // 
            this.previewImageToolStripMenuItem.Name = "previewImageToolStripMenuItem";
            this.previewImageToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.previewImageToolStripMenuItem.Text = "Preview Image";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 6);
            // 
            // modeViewToolStripMenuItem
            // 
            this.modeViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.largeToolStripMenuItem,
            this.bigLargeToolStripMenuItem});
            this.modeViewToolStripMenuItem.Name = "modeViewToolStripMenuItem";
            this.modeViewToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.modeViewToolStripMenuItem.Text = "Display View";
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.smallToolStripMenuItem.Text = "Small";
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Checked = true;
            this.mediumToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.largeToolStripMenuItem.Text = "Large";
            // 
            // bigLargeToolStripMenuItem
            // 
            this.bigLargeToolStripMenuItem.Name = "bigLargeToolStripMenuItem";
            this.bigLargeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.bigLargeToolStripMenuItem.Text = "Big Large";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Brown;
            this.topPanel.Controls.Add(this.appLogoPictureBox);
            this.topPanel.Controls.Add(this.authorLabel);
            this.topPanel.Controls.Add(this.appTitleLabel);
            this.topPanel.Controls.Add(this.aboutButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(584, 48);
            this.topPanel.TabIndex = 2;
            // 
            // appLogoPictureBox
            // 
            this.appLogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.appLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("appLogoPictureBox.Image")));
            this.appLogoPictureBox.Location = new System.Drawing.Point(12, 6);
            this.appLogoPictureBox.Name = "appLogoPictureBox";
            this.appLogoPictureBox.Size = new System.Drawing.Size(36, 36);
            this.appLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appLogoPictureBox.TabIndex = 3;
            this.appLogoPictureBox.TabStop = false;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.BackColor = System.Drawing.Color.Transparent;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.ForeColor = System.Drawing.Color.White;
            this.authorLabel.Location = new System.Drawing.Point(54, 25);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(182, 16);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "by Stephanus Bagus Saputra";
            // 
            // appTitleLabel
            // 
            this.appTitleLabel.AutoSize = true;
            this.appTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.appTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitleLabel.ForeColor = System.Drawing.Color.White;
            this.appTitleLabel.Location = new System.Drawing.Point(54, 9);
            this.appTitleLabel.Name = "appTitleLabel";
            this.appTitleLabel.Size = new System.Drawing.Size(108, 16);
            this.appTitleLabel.TabIndex = 1;
            this.appTitleLabel.Text = "Image Resizer";
            // 
            // aboutButton
            // 
            this.aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutButton.AutoSize = true;
            this.aboutButton.Location = new System.Drawing.Point(497, 6);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(77, 35);
            this.aboutButton.TabIndex = 0;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // FOuput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.windowPanel);
            this.Controls.Add(this.toolboxPanel);
            this.Controls.Add(this.bottomStatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FOuput";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDImageResizer by Stephanus Bagus Saputra";
            this.bottomStatusStrip.ResumeLayout(false);
            this.bottomStatusStrip.PerformLayout();
            this.toolboxPanel.ResumeLayout(false);
            this.toolboxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSizeTrackBar)).EndInit();
            this.windowPanel.ResumeLayout(false);
            this.imageContextMenuStrip.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip bottomStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusToolStrip;
        private System.Windows.Forms.ToolStripProgressBar progressBarToolStrip;
        private System.Windows.Forms.ToolStripStatusLabel copyrightToolStrip;
        private System.Windows.Forms.ImageList pictureImageList;
        private System.Windows.Forms.Panel toolboxPanel;
        private System.Windows.Forms.Panel windowPanel;
        private System.Windows.Forms.ListView imageExploreListView;
        private System.Windows.Forms.TrackBar viewSizeTrackBar;
        private System.Windows.Forms.Button processSaveButton;
        private System.Windows.Forms.TextBox pathSaveTextBox;
        private System.Windows.Forms.Label pathSaveLabel;
        private System.Windows.Forms.Button pathBrowseButton;
        private System.Windows.Forms.ContextMenuStrip imageContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem previewImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigLargeToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker imageProcessWorker;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox appLogoPictureBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label appTitleLabel;
        private System.Windows.Forms.Button aboutButton;
    }
}