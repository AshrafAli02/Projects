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
using System.Windows.Shapes;

namespace BMI_Calculator
{
    /// <summary>
    /// Interaction logic for SIUnit.xaml
    /// </summary>
    /// 
    public partial class SIUnit : Window
    {
        BMI bmical = new BMI();
        public SIUnit()
        {
            InitializeComponent();
        }

       public void setvalue()
        {
            bmical.Age= int.Parse(AgeBox.Text);
            bmical.Gender = "";
            if (Mradio.IsChecked == true)
            {
                bmical.Gender= "Male";
            }
            else
            {
                bmical.Gender= "Female";
            }
            bmical.Height= int.Parse(HeightBox.Text);
            bmical.Weight= int.Parse(WeightBox.Text);
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            setvalue();
            int cases = UnitSelection.SelectedIndex;
            int dummy=(int) bmical.casecheck(cases);
            double BmiValue = bmical._BMI;
            BMIt.Text = dummy.ToString();
        
            if ((int)dummy < 16)
            {
                //BackColor = "Red";
                DisplayPanel.Background =new LinearGradientBrush(Colors.Red,Colors.Pink,90);
            }
            else if ((int)dummy >= 16 && (int)dummy <= 17)
            {
                //BackColor = "Green";
                DisplayPanel.Background = new LinearGradientBrush(Colors.Green, Colors.Pink, 90);
            }
            else if ((int)dummy >= 18 && (int)dummy <= 25)
            {
                //BackColor = "Lightblue";
                DisplayPanel.Background = new LinearGradientBrush(Colors.LightBlue, Colors.Pink, 90);
            }
            else
            {
                //BackColor = "Orange";
                DisplayPanel.Background = new LinearGradientBrush(Colors.Orange, Colors.Pink, 90);
            }

        }
    }
}
