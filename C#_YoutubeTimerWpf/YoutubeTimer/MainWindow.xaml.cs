using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Color = System.Drawing.Color;
using System.Windows.Threading;

namespace YoutubeTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static TimeSpan timeSpanNull;
        public static TimeSpan timeLimit;
        public static Stopwatch Stopwatch = new Stopwatch();
        DispatcherTimer dispatcherTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            
            if (Stopwatch.IsRunning)
            {
                string stopWatchStr = Stopwatch.Elapsed.ToString();
                string stopWatchStrOutPut = stopWatchStr.Substring(0, stopWatchStr.Length - 8);
                Label_time.Text = stopWatchStrOutPut;

                if(Stopwatch.Elapsed > timeLimit)
                {
                    Panel1.Background = Brushes.Red;
                }

                if(Stopwatch.Elapsed < timeLimit)
                {
                    Panel1.Background = Brushes.LightGreen;
                }

            }
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch.Start();
        }

        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch.Stop();
            Panel1.Background = Brushes.LightGray;
        }

        private void ButtonReset_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch = new Stopwatch();
            Label_time.Text = "00:00:00";
            Panel1.Background = Brushes.White;
        }

        private void RadioButton15_Checked(object sender, RoutedEventArgs e)
        {
            if (RadioButton15.IsChecked == true)
            {
                timeLimit = TimeSpan.Parse("00:15:00");
            }
        }

        private void RadioButton30_Checked(object sender, RoutedEventArgs e)
        {
            if (RadioButton30.IsChecked == true)
            {
                timeLimit = TimeSpan.Parse("00:30:00");
            }
        }

        private void RadioButton45_Checked(object sender, RoutedEventArgs e)
        {
            if (RadioButton45.IsChecked == true)
            {
                timeLimit = TimeSpan.Parse("00:45:00");
            }
        }
    }
}
