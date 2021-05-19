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
    public partial class ImportFileAddOn : FileDialogControlBase
    {
        public bool YAxisUp = false;

        public ImportFileAddOn()
        {
            InitializeComponent();
        }

        private void yAxisUpCb_CheckedChanged(object sender, EventArgs e)
        {
            YAxisUp = yAxisUpCb.Checked;
        }
    }
}
