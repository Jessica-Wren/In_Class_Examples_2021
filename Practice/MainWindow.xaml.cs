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

namespace Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            bool checkForBlank = true; 
            if (string.IsNullOrWhiteSpace(tbxFirstName.Text) == true)
            {
                checkForBlank = false;
                MessageBox.Show("You must enter a vaild field (letters) for the First Name box.", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            if (string.IsNullOrWhiteSpace(tbxStreetName.Text) == true)
            {
                checkForBlank = false;
                MessageBox.Show("Please dont leave streetname blank", "Heyy!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            int zip;
            if (int.TryParse(tbxStreetNumber.Text, out zip) == false)
            {
                checkForBlank = false;
                MessageBox.Show("Put a number for street address", "Hey!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            double gpa;
            if (double.TryParse(tbxGPA.Text, out gpa) == false)
            {
                checkForBlank = false;
                MessageBox.Show("Put a number for GPA", "Hey!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }


            if (checkForBlank == false)
            {
                return;
            }

           
            tbxStreetName.Clear();
            tbxStreetNumber.Clear();
            tbxGPA.Clear();
            tbxFirstName.Clear();
        }

        
    }
}
