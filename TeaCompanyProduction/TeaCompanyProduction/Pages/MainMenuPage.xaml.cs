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

namespace TeaCompanyProduction.Pages
{
    public partial class MainMenuPage : Page
    {
        public MainMenuPage()
        {
            InitializeComponent();
            MainMenuFrame.Navigate(new ListOfTeaPage());
        }

        private void BListOfTea_Click(object sender, RoutedEventArgs e)
        {
            MainMenuFrame.Navigate(new ListOfTeaPage());
        }

        private void BAddInStock_Click(object sender, RoutedEventArgs e)
        {
            MainMenuFrame.Navigate(new AddToStockPage());
        }

        private void BProductionHistory_Click(object sender, RoutedEventArgs e)
        {
            MainMenuFrame.Navigate(new ProductionHistoryPage());
        }
    }
}
