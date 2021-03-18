using System;
using System.Collections.Generic;
using System.IO;
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

namespace PracticeGrady
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<CoolData> Peeps = new List<CoolData>();
        
        public MainWindow()
        {
            InitializeComponent();

            var lines = File.ReadAllLines("Sample1.csv").Skip(1);

            foreach (var line in lines)  
            {
                Peeps.Add(new CoolData(line));  // "line" is a parameter we made up here. By doing this we made the second constructor in the TVShow class
            }

            


            PopulateListbox(Peeps);
        }

        private void PopulateListbox(List<CoolData> peeps)
        {
            foreach (var peep in Peeps)
            {
                lbxListCoolGuys.Items.Add(peep);
            }
        }

        private void btnUgliness_Click(object sender, RoutedEventArgs e)
        {
            

            



            string status = btnUgliness.Content.ToString();

            switch (status)
            {
                case "Go To Max":                                                   // When we click the button (Which says GoToMax) It will calculate max (BC currently the label is showing average)

                    int maxUgly = 0;
                    foreach (var ugly in Peeps)
                    {
                        var values = ugly.Ugliness;
                        

                        if (Convert.ToInt32(values) > maxUgly)
                        {
                            maxUgly = Convert.ToInt32(values);


                        }
                        lblUglinessNumber.Content = maxUgly;
                    }

                                                                                 
                    btnUgliness.Content = "Go To Average";                         
                    break;

                case "Go To Average":                                              // When we click the button (Which says GoToAverage) It will calculate Average (BC currently the label is showing Max)

                    int i = 0;
                    int totalUgly = 0;
                    foreach (var ugly in Peeps)
                    {
                        var values = ugly.Ugliness;

                        totalUgly += Convert.ToInt32(values);                    //(totalugly = totalugly + values) this adds all the numbers for ugliness
                        i++;                                                     // counting the amount of times weve been through
                    }

                    int avUgly = totalUgly / i;   // finding the average
                    lblUglinessNumber.Content = avUgly;

                    lblUglinessNumber.Content = avUgly;                          //When the label says Average
                    lblUglinessPerson.Content = "";
                    btnUgliness.Content = "Go To Max";                             // The button will say "GoToMax"
                    break;



                default:
                    break;
            }

        }
    }
}
