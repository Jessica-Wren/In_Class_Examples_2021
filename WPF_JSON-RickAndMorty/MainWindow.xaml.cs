using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace WPF_JSON_RickAndMorty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //https://rickandmortyapi.com/api/character

            using (var client = new HttpClient()) // need a while loop   while the string i set for my url (for null values)
            {
                string url = "https://rickandmortyapi.com/api/character";
                

                while (string.IsNullOrEmpty(url) == false) // check to see if the string is null or empty
                {
                    var jsonData = client.GetStringAsync(url).Result;  //Json Data   // sometimes there is an exception here. Sometimes there is not. Please try to test the application again

                    RickAndMortyAPI api = JsonConvert.DeserializeObject<RickAndMortyAPI>(jsonData); // newtonsoft

                    foreach (var character in api.results)
                    {
                        lbxCharacters.Items.Add(character);

                    }

                    url = api.info.next; // calling the properties in the rickand morty class and setting the url = to the next string. When string are done, its done 
                }

                
            }

        }

        private void lbxCharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // how to get the image on the same window

            //var selectedCharacter = (Character)lbxCharacters.SelectedItem;
            //imgCharacter.Source = new BitmapImage(new Uri(selectedCharacter.image));


            //  // how to get the image on a different window

            Character selectedCharacter = (Character)lbxCharacters.SelectedItem;
            MyWindow myNewWindow = new MyWindow();
            myNewWindow.SetupWindow(selectedCharacter);
            myNewWindow.ShowDialog();
        }
    }
}
