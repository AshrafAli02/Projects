using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace CoundownTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Time t = new Time();
        public MainWindow()
        {
            InitializeComponent();
           
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            intervalBox.Text = "";
            Hourbox.Text = "";
            Minutebox.Text = "";
            Intervaltimebox.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        { 
            SetValue();
            watch wt = new watch();
            wt.ShowDialog();
        }
        public void SetValue()
        {
            t.Interval = int.Parse(intervalBox.Text);
            t.Hour = int.Parse(Hourbox.Text);
            t.minute = int.Parse(Minutebox.Text);
            t.Intervaltime = int.Parse(Intervaltimebox.Text);
        }
    }
}
