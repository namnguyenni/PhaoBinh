using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Cannon_Project.VideoView
{
    /// <summary>
    /// Interaction logic for VideoControl.xaml
    /// </summary>
    public partial class VideoControl : UserControl
    {
        bool isplaying;
        DispatcherTimer dispatcherTimer;

        public VideoControl()
        {
            InitializeComponent();
            isplaying = true;
            timebar.Visibility = Visibility.Visible;

        }

        void window_Closing(object sender, global::System.ComponentModel.CancelEventArgs e)
        {
            mediaElement.Close();

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        public void PauseVideo()
        {
            mediaElement.Pause();
            imgBtnPause.ImageSource = new BitmapImage(new Uri("../../Resources/play-arrow.png", UriKind.Relative));
            imgOpacityPause.ImageSource = new BitmapImage(new Uri("../../Resources/play-arrow.png", UriKind.Relative));
            isplaying = false;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (isplaying)
            {
                mediaElement.Pause();
                imgBtnPause.ImageSource = new BitmapImage(new Uri("../../Resources/play-arrow.png", UriKind.Relative));
                imgOpacityPause.ImageSource = new BitmapImage(new Uri("../../Resources/play-arrow.png", UriKind.Relative));
                isplaying = false;
            }
            else { 
                mediaElement.Play();
                imgBtnPause.ImageSource = new BitmapImage(new Uri("../../Resources/pause-button.png", UriKind.Relative));
                imgOpacityPause.ImageSource = new BitmapImage(new Uri("../../Resources/pause-button.png", UriKind.Relative));

                isplaying = true ;
            }
        }

        private void mediaElement_Loaded(object sender, RoutedEventArgs e)
        {
            mediaElement.LoadedBehavior = MediaState.Manual;

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Position += new TimeSpan(0, 0, 15);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (mediaElement.Position.TotalSeconds>16)
            {
                mediaElement.Position -= new TimeSpan(0, 0, 15);
            }
            else
            {
                mediaElement.Position = new TimeSpan(0, 0, 1);
            }

        }


        //hiển thị thời gian chỉ vào
        private void timebar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mediaElement.HasVideo)
            {
                double x = Mouse.GetPosition(timebar).X;
                double totalsecond = mediaElement.NaturalDuration.TimeSpan.TotalSeconds;
                int seconds = Convert.ToInt32(x * totalsecond / timebar.ActualWidth);
                TimeSpan time = TimeSpan.FromSeconds(seconds);
                string str = time.ToString(@"hh\:mm\:ss");
                timeMove.Visibility = Visibility.Visible;
                timeMove.Margin = new Thickness(0, 0, timebar.ActualWidth - x - 30, timeMove.Margin.Bottom);
                timeMove.Content = str;
            }
        }

        private void timebar_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (mediaElement.HasVideo)
            {
                double x = Mouse.GetPosition(timebar).X;
                double totalsecond = mediaElement.NaturalDuration.TimeSpan.TotalSeconds;
                int seconds = Convert.ToInt32(x * totalsecond / timebar.ActualWidth);
                TimeSpan time = TimeSpan.FromSeconds(seconds);
                string str = time.ToString(@"hh\:mm\:ss");
                mediaElement.Position = time;
                timebar.Value = 100 * x / timebar.ActualWidth;

            }
        }


        private void mediaElement_MouseEnter(object sender, MouseEventArgs e)
        {
            timebar.Visibility = Visibility.Visible;
        }

        private void mediaElement_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (isplaying)
            {
                mediaElement.Pause();
                imgBtnPause.ImageSource = new BitmapImage(new Uri("../../Resources/play-arrow.png", UriKind.Relative));
                imgOpacityPause.ImageSource = new BitmapImage(new Uri("../../Resources/play-arrow.png", UriKind.Relative));
                isplaying = false;
            }
            else
            {
                mediaElement.Play();
                imgBtnPause.ImageSource = new BitmapImage(new Uri("../../Resources/pause-button.png", UriKind.Relative));
                imgOpacityPause.ImageSource = new BitmapImage(new Uri("../../Resources/pause-button.png", UriKind.Relative));

                isplaying = true;
            }
        }

        private void mediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            timeEnd.Content = mediaElement.NaturalDuration.TimeSpan.ToString() ;

            //khởi tạo dispatcher time
            //cập nhật thời gian hiện tại
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();

        }

        public void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            // Updating the Label which displays the current second
            if (mediaElement.NaturalDuration.HasTimeSpan)
            {
                timecurrent.Content = FormatTime(Convert.ToInt32(mediaElement.Position.TotalSeconds));
                timebar.Value = mediaElement.Position.TotalSeconds * 100 / mediaElement.NaturalDuration.TimeSpan.TotalSeconds;
            }

            // Forcing the CommandManager to raise the RequerySuggested event
            CommandManager.InvalidateRequerySuggested();
        }

        public string FormatTime(int seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            string str = time.ToString(@"hh\:mm\:ss");
            return str;
        }

        private void mediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            imgBtnPause.ImageSource = new BitmapImage(new Uri("../../Resources/play-arrow.png", UriKind.Relative));
            imgOpacityPause.ImageSource = new BitmapImage(new Uri("../../Resources/play-arrow.png", UriKind.Relative));
            isplaying = false;
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFile();
        }

        public void OpenFile(string filepath="")
        {
            if (filepath != "")
            {
                mediaElement.Source = new Uri(filepath, UriKind.Relative);
                mediaElement.LoadedBehavior = MediaState.Manual;
                mediaElement.Play();
                filename.Content = System.IO.Path.GetFileName(filepath);
                isplaying = true;
                imgBtnPause.ImageSource = new BitmapImage(new Uri("../../Resources/pause-button.png", UriKind.Relative));
                imgOpacityPause.ImageSource = new BitmapImage(new Uri("../../Resources/pause-button.png", UriKind.Relative));

            }
            else
            {
                Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
                openFileDlg.DefaultExt = ".mp4";
                openFileDlg.Filter = "Video File (.mp4)|*.mp4";
                // Launch OpenFileDialog by calling ShowDialog method
                Nullable<bool> result = openFileDlg.ShowDialog();

                if (result == true)
                {
                    mediaElement.Source = new Uri(openFileDlg.FileName, UriKind.Relative);
                    mediaElement.LoadedBehavior = MediaState.Manual;
                    mediaElement.Play();
                    isplaying = true;
                    imgBtnPause.ImageSource = new BitmapImage(new Uri("../../Resources/pause-button.png", UriKind.Relative));
                    imgOpacityPause.ImageSource = new BitmapImage(new Uri("../../Resources/pause-button.png", UriKind.Relative));

                    filename.Content = System.IO.Path.GetFileName(openFileDlg.FileName);

                }
            }
        }

        private void timebar_MouseLeave(object sender, MouseEventArgs e)
        {
            timeMove.Visibility = Visibility.Hidden;
        }

        private void btn_Volumn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ChangeMediaVolume(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElement.Volume = slider.Value / 10;
        }

        private void btn_Volumn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            slider.Visibility = Visibility.Visible;
            slider.Focus();
        }

        private void slider_LostFocus(object sender, RoutedEventArgs e)
        {
            slider.Visibility = Visibility.Hidden;

        }
    }


}
