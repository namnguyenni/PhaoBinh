using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace devDept.Controls.WinForms
{
    public partial class OpenFileAddOn : FileDialogControlBase
    {        
        public int ContentOption = 3;                

        public void SetFileInfo(Bitmap thumbnail, string details)
        {
            thumbPicBox.Image = thumbnail;
            txtFileInfo.Text = details;
        }

        public void ResetFileInfo()
        {
            if (thumbPicBox.Image != null)
            {
                thumbPicBox.Image.Dispose();
                thumbPicBox.Image = null;
            }

            txtFileInfo.Text = String.Empty;
        }

        public OpenFileAddOn()
        {
            InitializeComponent();
            geomAndTessRb.Select();            
        }

        private void geometryRb_CheckedChanged(object sender, EventArgs e)
        {
            ContentOption = 1;
        }

        private void tessellationRb_CheckedChanged(object sender, EventArgs e)
        {
            ContentOption = 2;
        }

        private void geomAndTessRb_CheckedChanged(object sender, EventArgs e)
        {
            ContentOption = 3;
        }        
    }
}
