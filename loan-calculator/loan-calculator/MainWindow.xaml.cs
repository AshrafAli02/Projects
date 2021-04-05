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

namespace loan_calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Loan l = new Loan();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateEmi_Click(object sender, RoutedEventArgs e)
        {
            ValueSet();
            Emilable.Text = "EMI Per Months";
            var EmiAmount = string.Format("{0:0.00}", l.Emicalculate());
            Emi.Text = " Rs: " + EmiAmount.ToString() + "/-";
        }
        public void ValueSet()
        {
            l.LoanAmount = int.Parse(LoanAmount.Text);
            l.InterestPercentage = double.Parse(InterestPercentage.Text);
            l.NumberOfMonths = int.Parse(NoofMonths.Text);
        }
    }
}
