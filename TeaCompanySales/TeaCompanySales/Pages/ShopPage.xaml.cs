using Microsoft.Win32;
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
using TeaCompanySales.Models;

namespace TeaCompanySales.Pages
{
    public partial class ShopPage : Page
    {
        Shop contextShop;
        public ShopPage(Shop shop)
        {
            InitializeComponent();
            contextShop = shop;
            DataContext = contextShop;
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(contextShop.Name))
                errorMessage += "Введите название\n";
            if (string.IsNullOrWhiteSpace(contextShop.Address))
                errorMessage += "Введите адрес\n";
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (contextShop.Id == 0)
                GlobalSettings.DB.Shop.Add(contextShop);
            GlobalSettings.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BLoadPhoto_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() { Filter = ".jpg, .jpeg, .png|*.jpg; *.jpeg; *.png" };
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                contextShop.Image = File.ReadAllBytes(dialog.FileName);
                TeaImage.Source = Tools.BytesToImage(contextShop.Image);
            }
        }
    }
}
