﻿using System;
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

namespace WPF_Web_Browser
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

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            //webGoogle.Navigate("https://www.google.com/search?q=" + query);


            string query = tbxQuery.Text;

            MyWebBrowserWindow myNewBrowser = new MyWebBrowserWindow();

            myNewBrowser.Query = query;
            myNewBrowser.Search(query);
            myNewBrowser.ShowDialog();

            


        }
    }
}
