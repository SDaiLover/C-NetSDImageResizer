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
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class FAbout : Form
    {
        public FAbout()
        {
            InitializeComponent();
            this.Text = "About Author";
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(300, 300);
            this.MaximumSize = new Size(300, 300);
            this.bottomStatusStrip.SizingGrip = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = SizeGripStyle.Hide;
        }
    }
}
