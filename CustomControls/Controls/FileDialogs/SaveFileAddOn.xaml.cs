using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.VisualStyles;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using devDept.Controls.Wpf;

namespace devDept.Controls.Wpf
{
    /// <summary>
    /// Interaction logic for SaveFileDialog.xaml
    /// </summary>
    public partial class SaveFileAddOn : ControlAddOnBase
    {
        public int ContentOption = 3;
        public int SerialOption = 0;
        public bool SelectedOnly = false;
        public bool Purge = false;
        public SaveFileAddOn()
        {
            InitializeComponent();
        }

        internal IntPtr _hFileDialogWrapperHandle = IntPtr.Zero;

        private void Control_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void GeometryRb_OnChecked(object sender, RoutedEventArgs e)
        {
            ContentOption = 1;
        }

        private void TessellationRb_OnChecked(object sender, RoutedEventArgs e)
        {
            ContentOption = 2;
        }

        private void GeomAndTessRb_OnChecked(object sender, RoutedEventArgs e)
        {
            ContentOption = 3;
        }

        private void CompressCb_OnClick(object sender, RoutedEventArgs e)
        {
            SerialOption = (CompressCb.IsChecked == true) ? 1 : 0;
        }

        private void SelectedOnlyCb_OnClick(object sender, RoutedEventArgs e)
        {
            SelectedOnly = (SelectedOnlyCb.IsChecked == true) ? true : false;
        }

        private void PurgeCb_OnClick(object sender, RoutedEventArgs e)
        {
            Purge = (PurgeCb.IsChecked == true) ? true : false;
        }
    }
}
