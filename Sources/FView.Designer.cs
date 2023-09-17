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
    partial class FView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FView));
            this.bottomStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.copyrightToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.windowPanel = new System.Windows.Forms.Panel();
            this.pictureResultBox = new System.Windows.Forms.PictureBox();
            this.bottomStatusStrip.SuspendLayout();
            this.windowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureResultBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomStatusStrip
            // 
            this.bottomStatusStrip.BackColor = System.Drawing.Color.Brown;
            this.bottomStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStrip,
            this.copyrightToolStrip});
            this.bottomStatusStrip.Location = new System.Drawing.Point(0, 239);
            this.bottomStatusStrip.Name = "bottomStatusStrip";
            this.bottomStatusStrip.Size = new System.Drawing.Size(384, 22);
            this.bottomStatusStrip.TabIndex = 3;
            this.bottomStatusStrip.Text = "statusStrip1";
            // 
            // statusToolStrip
            // 
            this.statusToolStrip.ActiveLinkColor = System.Drawing.Color.White;
            this.statusToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.statusToolStrip.ForeColor = System.Drawing.Color.White;
            this.statusToolStrip.Name = "statusToolStrip";
            this.statusToolStrip.Size = new System.Drawing.Size(174, 17);
            this.statusToolStrip.Spring = true;
            this.statusToolStrip.Text = "SD Image Resizer v1.0";
            this.statusToolStrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // copyrightToolStrip
            // 
            this.copyrightToolStrip.ForeColor = System.Drawing.Color.White;
            this.copyrightToolStrip.Name = "copyrightToolStrip";
            this.copyrightToolStrip.Size = new System.Drawing.Size(195, 17);
            this.copyrightToolStrip.Text = "© ID 2022 Stephanus Bagus Saputra";
            // 
            // windowPanel
            // 
            this.windowPanel.Controls.Add(this.pictureResultBox);
            this.windowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowPanel.Location = new System.Drawing.Point(0, 0);
            this.windowPanel.Name = "windowPanel";
            this.windowPanel.Padding = new System.Windows.Forms.Padding(10);
            this.windowPanel.Size = new System.Drawing.Size(384, 239);
            this.windowPanel.TabIndex = 4;
            // 
            // pictureResultBox
            // 
            this.pictureResultBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureResultBox.Location = new System.Drawing.Point(10, 10);
            this.pictureResultBox.Name = "pictureResultBox";
            this.pictureResultBox.Size = new System.Drawing.Size(364, 219);
            this.pictureResultBox.TabIndex = 0;
            this.pictureResultBox.TabStop = false;
            // 
            // FView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.windowPanel);
            this.Controls.Add(this.bottomStatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDImageResizer by Stephanus Bagus Saputra";
            this.bottomStatusStrip.ResumeLayout(false);
            this.bottomStatusStrip.PerformLayout();
            this.windowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureResultBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip bottomStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusToolStrip;
        private System.Windows.Forms.ToolStripStatusLabel copyrightToolStrip;
        private System.Windows.Forms.Panel windowPanel;
        private System.Windows.Forms.PictureBox pictureResultBox;
    }
}