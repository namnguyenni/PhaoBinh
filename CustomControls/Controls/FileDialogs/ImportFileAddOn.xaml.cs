using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using devDept.Controls.Wpf;

namespace devDept.Controls.Wpf
{
    /// <summary>
    /// Interaction logic for ImportFileAddOn.xaml
    /// </summary>
    public partial class ImportFileAddOn : ControlAddOnBase
    {
        public bool YAxisUp = false;
        public ImportFileAddOn()
        {
            InitializeComponent();
        }

        private void Control_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void yAxisUpCb_Checked(object sender, RoutedEventArgs e)
        {
            YAxisUp = (bool)yAxisUpCb.IsChecked.Value;
        }
    }
}
