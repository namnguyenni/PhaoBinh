using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
    /// Interaction logic for OpenFileDialog.xaml
    /// </summary>
    public partial class OpenFileAddOn : ControlAddOnBase
    {        
        public int ContentOption = 3;

        public void SetFileInfo(Bitmap thumbnail, string details)
        {
            thumbPicBox.Source = ConvertImage(thumbnail);
            txtFileInfo.Text = details;
        }

        public void ResetFileInfo()
        {            
            thumbPicBox.Source = null;
            txtFileInfo.Text = String.Empty;
        }

        public OpenFileAddOn()
        {
            InitializeComponent();            
        }     

        internal IntPtr _hFileDialogWrapperHandle = IntPtr.Zero;        

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

        #region ConvertImage
        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        public static extern IntPtr DeleteObject(IntPtr bmp);

        /// <summary>
        /// Method that converts a <see cref="System.Drawing.Bitmap"/> to a <see cref="System.Windows.Media.Imaging.BitmapSource"/>.
        /// </summary>
        /// <param name="bitmap">The image</param>
        /// <returns>The converted <see cref="System.Windows.Media.Imaging.BitmapSource"/>.</returns>
        public static BitmapSource ConvertImage(Bitmap bitmap)
        {
            if (bitmap == null)
                return null;

            IntPtr hBitmap = bitmap.GetHbitmap();
            BitmapSource bmpSource;
            try
            {
                bmpSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                    hBitmap,
                    IntPtr.Zero,
                    Int32Rect.Empty,
                    BitmapSizeOptions.FromEmptyOptions());

                bmpSource.Freeze(); // see http://stackoverflow.com/questions/21877221/memory-not-getting-released-in-wpf-image
            }
            finally
            {
                DeleteObject(hBitmap);
            }

            return bmpSource;
        }
        #endregion RenderContextUtility.ConvertImage
    }
}
