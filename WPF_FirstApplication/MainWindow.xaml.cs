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

namespace WPF_FirstApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            lblMessage.Content = string.Empty;

            tbxFavoriteNumber.Clear();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("You clicked me!");

            MessageBox.Show("Thanks for clicking me!", "Clicked", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);

            lblMessage.Content = "Sanic";

            string answer = tbxFavoriteNumber.Text;
            double result = Convert.ToDouble(answer);

            lblOutput.Content = "Your Favorite number multiplied by 5 is " + (result * 5).ToString("N2") + "!";
        }

        private void btnDontClick_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Haha! Dummy.");
            Environment.Exit(0);
        }
    }
}
