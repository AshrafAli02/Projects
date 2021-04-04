using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CoundownTimer
{
    /// <summary>
    /// Interaction logic for watch.xaml
    /// </summary>
    /// 
   
    public partial class watch : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        Stopwatch sw = new Stopwatch();
        Time timec = new Time();
        public watch()
        {
            InitializeComponent();
            MainGrid.Background = new LinearGradientBrush(Colors.Blue, Colors.Violet, 50);

            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Intervalminute.Text = timec.Conveter(timec.timesecond);
            IntervalSecond.Text = timec.Conveter(timec.Millisecond);
            timec.check();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string type = btnstart.Content.ToString();
            if (type == "stop")
            {
                timer.Stop();
                btnstart.Content = "Start";
            }
            else
            {
                timer.Start();
                btnstart.Content = "stop";
            }
        }
    }
}
