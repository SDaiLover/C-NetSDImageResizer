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
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.topPanel = new System.Windows.Forms.Panel();
            this.appLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.appTitleLabel = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.bottomStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBarToolStrip = new System.Windows.Forms.ToolStripProgressBar();
            this.copyrightToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.sidebarRightPanel = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.processButton = new System.Windows.Forms.Button();
            this.optionGroupBox = new System.Windows.Forms.GroupBox();
            this.backColorComboBox = new System.Windows.Forms.ComboBox();
            this.backColorLabel = new System.Windows.Forms.Label();
            this.stretchCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.layoutComboBox = new System.Windows.Forms.ComboBox();
            this.layoutLabel = new System.Windows.Forms.Label();
            this.viewSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.browseButton = new System.Windows.Forms.Button();
            this.windowLeftPanel = new System.Windows.Forms.Panel();
            this.imageExploreListView = new System.Windows.Forms.ListView();
            this.imageTempWorker = new System.ComponentModel.BackgroundWorker();
            this.pictureImageList = new System.Windows.Forms.ImageList(this.components);
            this.imageProcessWorker = new System.ComponentModel.BackgroundWorker();
            this.imageContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.modeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigLargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.removeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogoPictureBox)).BeginInit();
            this.bottomStatusStrip.SuspendLayout();
            this.sidebarRightPanel.SuspendLayout();
            this.optionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSizeTrackBar)).BeginInit();
            this.windowLeftPanel.SuspendLayout();
            this.imageContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.topPanel.TabIndex = 0;
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
            this.bottomStatusStrip.TabIndex = 1;
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
            // sidebarRightPanel
            // 
            this.sidebarRightPanel.Controls.Add(this.resetButton);
            this.sidebarRightPanel.Controls.Add(this.processButton);
            this.sidebarRightPanel.Controls.Add(this.optionGroupBox);
            this.sidebarRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidebarRightPanel.Location = new System.Drawing.Point(375, 48);
            this.sidebarRightPanel.Name = "sidebarRightPanel";
            this.sidebarRightPanel.Size = new System.Drawing.Size(209, 291);
            this.sidebarRightPanel.TabIndex = 2;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(6, 218);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(53, 30);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(65, 218);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(141, 30);
            this.processButton.TabIndex = 1;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            // 
            // optionGroupBox
            // 
            this.optionGroupBox.Controls.Add(this.backColorComboBox);
            this.optionGroupBox.Controls.Add(this.backColorLabel);
            this.optionGroupBox.Controls.Add(this.stretchCheckBox);
            this.optionGroupBox.Controls.Add(this.label1);
            this.optionGroupBox.Controls.Add(this.heightTextBox);
            this.optionGroupBox.Controls.Add(this.widthTextBox);
            this.optionGroupBox.Controls.Add(this.sizeComboBox);
            this.optionGroupBox.Controls.Add(this.sizeLabel);
            this.optionGroupBox.Controls.Add(this.layoutComboBox);
            this.optionGroupBox.Controls.Add(this.layoutLabel);
            this.optionGroupBox.Controls.Add(this.viewSizeTrackBar);
            this.optionGroupBox.Controls.Add(this.browseButton);
            this.optionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionGroupBox.Location = new System.Drawing.Point(6, 6);
            this.optionGroupBox.Name = "optionGroupBox";
            this.optionGroupBox.Size = new System.Drawing.Size(200, 206);
            this.optionGroupBox.TabIndex = 0;
            this.optionGroupBox.TabStop = false;
            this.optionGroupBox.Text = "Image Setting";
            // 
            // backColorComboBox
            // 
            this.backColorComboBox.FormattingEnabled = true;
            this.backColorComboBox.Location = new System.Drawing.Point(82, 171);
            this.backColorComboBox.Name = "backColorComboBox";
            this.backColorComboBox.Size = new System.Drawing.Size(112, 24);
            this.backColorComboBox.TabIndex = 11;
            // 
            // backColorLabel
            // 
            this.backColorLabel.AutoSize = true;
            this.backColorLabel.Location = new System.Drawing.Point(6, 174);
            this.backColorLabel.Name = "backColorLabel";
            this.backColorLabel.Size = new System.Drawing.Size(62, 16);
            this.backColorLabel.TabIndex = 10;
            this.backColorLabel.Text = "BG Color";
            // 
            // stretchCheckBox
            // 
            this.stretchCheckBox.AutoSize = true;
            this.stretchCheckBox.Location = new System.Drawing.Point(125, 145);
            this.stretchCheckBox.Name = "stretchCheckBox";
            this.stretchCheckBox.Size = new System.Drawing.Size(68, 20);
            this.stretchCheckBox.TabIndex = 9;
            this.stretchCheckBox.Text = "Stretch";
            this.stretchCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "x";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(114, 117);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(80, 22);
            this.heightTextBox.TabIndex = 7;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(6, 117);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(80, 22);
            this.widthTextBox.TabIndex = 6;
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Location = new System.Drawing.Point(82, 87);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(112, 24);
            this.sizeComboBox.TabIndex = 5;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(6, 90);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(34, 16);
            this.sizeLabel.TabIndex = 4;
            this.sizeLabel.Text = "Size";
            // 
            // layoutComboBox
            // 
            this.layoutComboBox.FormattingEnabled = true;
            this.layoutComboBox.Location = new System.Drawing.Point(82, 57);
            this.layoutComboBox.Name = "layoutComboBox";
            this.layoutComboBox.Size = new System.Drawing.Size(112, 24);
            this.layoutComboBox.TabIndex = 3;
            // 
            // layoutLabel
            // 
            this.layoutLabel.AutoSize = true;
            this.layoutLabel.Location = new System.Drawing.Point(6, 60);
            this.layoutLabel.Name = "layoutLabel";
            this.layoutLabel.Size = new System.Drawing.Size(48, 16);
            this.layoutLabel.TabIndex = 2;
            this.layoutLabel.Text = "Layout";
            // 
            // viewSizeTrackBar
            // 
            this.viewSizeTrackBar.Location = new System.Drawing.Point(92, 21);
            this.viewSizeTrackBar.Maximum = 7;
            this.viewSizeTrackBar.Name = "viewSizeTrackBar";
            this.viewSizeTrackBar.Size = new System.Drawing.Size(102, 45);
            this.viewSizeTrackBar.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(6, 21);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(80, 30);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // windowLeftPanel
            // 
            this.windowLeftPanel.Controls.Add(this.imageExploreListView);
            this.windowLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowLeftPanel.Location = new System.Drawing.Point(0, 48);
            this.windowLeftPanel.Name = "windowLeftPanel";
            this.windowLeftPanel.Size = new System.Drawing.Size(375, 291);
            this.windowLeftPanel.TabIndex = 3;
            // 
            // imageExploreListView
            // 
            this.imageExploreListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageExploreListView.Location = new System.Drawing.Point(0, 0);
            this.imageExploreListView.Name = "imageExploreListView";
            this.imageExploreListView.Size = new System.Drawing.Size(375, 291);
            this.imageExploreListView.TabIndex = 0;
            this.imageExploreListView.UseCompatibleStateImageBehavior = false;
            // 
            // pictureImageList
            // 
            this.pictureImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.pictureImageList.ImageSize = new System.Drawing.Size(98, 98);
            this.pictureImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageContextMenuStrip
            // 
            this.imageContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertImageToolStripMenuItem,
            this.previewImageToolStripMenuItem,
            this.toolStripMenuItem1,
            this.modeViewToolStripMenuItem,
            this.removeSelectedToolStripMenuItem,
            this.toolStripMenuItem2,
            this.removeAllToolStripMenuItem});
            this.imageContextMenuStrip.Name = "imageContextMenuStrip";
            this.imageContextMenuStrip.Size = new System.Drawing.Size(165, 126);
            // 
            // insertImageToolStripMenuItem
            // 
            this.insertImageToolStripMenuItem.Name = "insertImageToolStripMenuItem";
            this.insertImageToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.insertImageToolStripMenuItem.Text = "Insert Image";
            // 
            // previewImageToolStripMenuItem
            // 
            this.previewImageToolStripMenuItem.Name = "previewImageToolStripMenuItem";
            this.previewImageToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.previewImageToolStripMenuItem.Text = "Preview Image";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(161, 6);
            // 
            // modeViewToolStripMenuItem
            // 
            this.modeViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.largeToolStripMenuItem,
            this.bigLargeToolStripMenuItem});
            this.modeViewToolStripMenuItem.Name = "modeViewToolStripMenuItem";
            this.modeViewToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
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
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.removeSelectedToolStripMenuItem.Text = "Remove Selected";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(161, 6);
            // 
            // removeAllToolStripMenuItem
            // 
            this.removeAllToolStripMenuItem.Name = "removeAllToolStripMenuItem";
            this.removeAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.removeAllToolStripMenuItem.Text = "Remove All";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.windowLeftPanel);
            this.Controls.Add(this.sidebarRightPanel);
            this.Controls.Add(this.bottomStatusStrip);
            this.Controls.Add(this.topPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMain";
            this.Text = "SDImageResizer by Stephanus Bagus Saputra";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogoPictureBox)).EndInit();
            this.bottomStatusStrip.ResumeLayout(false);
            this.bottomStatusStrip.PerformLayout();
            this.sidebarRightPanel.ResumeLayout(false);
            this.optionGroupBox.ResumeLayout(false);
            this.optionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSizeTrackBar)).EndInit();
            this.windowLeftPanel.ResumeLayout(false);
            this.imageContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label appTitleLabel;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.StatusStrip bottomStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusToolStrip;
        private System.Windows.Forms.ToolStripProgressBar progressBarToolStrip;
        private System.Windows.Forms.ToolStripStatusLabel copyrightToolStrip;
        private System.Windows.Forms.Panel sidebarRightPanel;
        private System.Windows.Forms.Panel windowLeftPanel;
        private System.Windows.Forms.GroupBox optionGroupBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TrackBar viewSizeTrackBar;
        private System.ComponentModel.BackgroundWorker imageTempWorker;
        private System.Windows.Forms.ListView imageExploreListView;
        private System.Windows.Forms.ImageList pictureImageList;
        private System.Windows.Forms.Label layoutLabel;
        private System.Windows.Forms.ComboBox layoutComboBox;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.ComboBox backColorComboBox;
        private System.Windows.Forms.Label backColorLabel;
        private System.Windows.Forms.CheckBox stretchCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Button processButton;
        private System.ComponentModel.BackgroundWorker imageProcessWorker;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ContextMenuStrip imageContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem insertImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem removeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigLargeToolStripMenuItem;
        private System.Windows.Forms.PictureBox appLogoPictureBox;
    }
}