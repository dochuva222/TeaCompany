using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class SalePage : Page
    {
        public SalePage()
        {
            InitializeComponent();
            CBTeas.ItemsSource = GlobalSettings.DB.Tea.ToList();
            CBShops.ItemsSource = GlobalSettings.DB.Shop.ToList();
        }

        private void Refresh()
        {
            var selectedTea = CBTeas.SelectedItem as Tea;
            if (selectedTea == null)
                return;
            TBInStock.Text = $"На складе: {selectedTea.InStock}";
        }

        private void CBTeas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void TBQauntity_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"[0-9]"))
                e.Handled = true;
        }

        private void TBPrice_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, @"[0-9,]"))
                e.Handled = true;
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            var selectedTea = CBTeas.SelectedItem as Tea;
            var selectedShop = CBShops.SelectedItem as Shop;
            int quantity = 0;
            decimal price = 0;
            if (selectedTea == null)
            {
                MessageBox.Show("Выберите чай", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (selectedShop == null)
            {
                MessageBox.Show("Выберите магазин", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!int.TryParse(TBQauntity.Text, out quantity) || quantity > selectedTea.InStock || quantity <= 0)
            {
                MessageBox.Show("Введено неверное количество", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (!decimal.TryParse(TBPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Введено неверная стоимость", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            GlobalSettings.DB.Sale.Add(new Sale() { DateTime = DateTime.Now, UserId = GlobalSettings.LoggedUser.Id, Price = price, Quantity = quantity, ShopId = selectedShop.Id, TeaId = selectedTea.Id });
            GlobalSettings.DB.Tea.FirstOrDefault(t => t.Id == selectedTea.Id).InStock -= quantity;
            GlobalSettings.DB.SaveChanges();
            Refresh();
        }
    }
}
