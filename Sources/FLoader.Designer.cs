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
    partial class FLoader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLoader));
            this.mainProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainProgressBar.Location = new System.Drawing.Point(0, 0);
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(300, 40);
            this.mainProgressBar.TabIndex = 0;
            // 
            // FLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 40);
            this.Controls.Add(this.mainProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FLoader";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDImageResizer by Stephanus Bagus Saputra";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar mainProgressBar;
    }
}