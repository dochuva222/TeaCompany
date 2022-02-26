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
using TeaCompanySales.Models;

namespace TeaCompanySales.Pages
{
    public partial class ShopListPage : Page
    {
        public ShopListPage()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            var searchText = TBSearch.Text.ToLower();
            var filtred = GlobalSettings.DB.Shop.ToList();
            if (!string.IsNullOrWhiteSpace(searchText))
                filtred = filtred.Where(f => f.Name.ToLower().Contains(searchText) || f.Address.ToLower().Contains(searchText)).ToList();
            LVShops.ItemsSource = filtred;
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ShopPage(new Shop()));
        }

        private void BDelete_Click(object sender, RoutedEventArgs e)
        {
            var selectedShop = LVShops.SelectedItem as Shop;
            if (selectedShop == null)
            {
                MessageBox.Show("Выберите магазин, который хотите удалить.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (MessageBox.Show($"Вы уверены что хотите удалить {selectedShop.Name}", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                GlobalSettings.DB.Shop.Remove(selectedShop);
                GlobalSettings.DB.SaveChanges();
                Refresh();
            }
        }

        private void LVShops_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedShop = LVShops.SelectedItem as Shop;
            if (selectedShop == null)
                return;
            NavigationService.Navigate(new ShopPage(selectedShop));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
    }
}
