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
    public partial class SaveFileAddOn : FileDialogControlBase
    {
        public int ContentOption = 3;
        public int SerialOption = 0;
        public bool SelectedOnly = false;
        public bool Purge = false;

        public SaveFileAddOn()
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

        private void compressCb_CheckedChanged(object sender, EventArgs e)
        {
            SerialOption = compressCb.Checked ? 1 : 0;
        }

        private void selectedOnlyCb_CheckedChanged(object sender, EventArgs e)
        {
            SelectedOnly = selectedOnlyCb.Checked ? true : false;
        }

        private void purgeCb_CheckedChanged(object sender, EventArgs e)
        {
            Purge = purgeCb.Checked ? true : false;
        }
    }
}
