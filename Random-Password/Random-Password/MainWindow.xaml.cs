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

namespace Random_Password
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NumberCheckBox.IsChecked = true;
            LowercaseCheckBox.IsChecked = true;
            UpperCaseCheckBox.IsChecked = true;
            SymbolCheckBox.IsChecked = true;
            PasswordBox.Text = "Your Password";
        }

        public void Hello()
        {
            MessageBox.Show("Hello");
        }

        private void Clipboardbtn_Click(object sender, RoutedEventArgs e)
        {
           
            PasswordBox.Focusable = true;
            if (PasswordBox.Text == "Your Password")
            {
               MessageBox.Show("Generate Your Password!...","Warning",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            else
            {
                Clipboard.SetText(PasswordBox.Text);
                MessageBox.Show("Text Copied to Clipboard ...","Success",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            
        }
        Password pass = new Password();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pass.Count = 0;
            pass.Length = int.Parse(Lengthbox.Text);
            var v2 = UpperCaseCheckBox.IsChecked;
            var v1 = NumberCheckBox.IsChecked;
            var v3 = LowercaseCheckBox.IsChecked;
            var v4 = SymbolCheckBox.IsChecked;
            if (v1 == false && v2 == false && v3 == false && v4 == false||(v1 == false && v2 == false && v3 == false && v4 == false))
            {
                MessageBox.Show("Select Atleast One Pattern", "Warning", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                pass.GenaratePassword = new char[int.Parse(Lengthbox.Text)];
                pass.passGenerate(v1, v2, v3, v4);
                PasswordBox.Text = pass.getPassword();
            }
            
        }

        private void Lengthbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(int.Parse(Lengthbox.Text)<=8)
            {
                Passwordstrength.Background = new SolidColorBrush(Colors.Red);
            }
            if (int.Parse(Lengthbox.Text) >= 12)
            {
                Passwordstrength.Background = new SolidColorBrush(Colors.Green);
            }
            else if(Lengthbox.Text=="")
            {
                
            }
        }
    }
}
