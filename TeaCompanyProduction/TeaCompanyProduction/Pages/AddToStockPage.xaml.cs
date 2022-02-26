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
using TeaCompanyProduction.Models;

namespace TeaCompanyProduction.Pages
{
    public partial class AddToStockPage : Page
    {
        public AddToStockPage()
        {
            InitializeComponent();
            CBTeas.ItemsSource = GlobalSettings.DB.Tea.ToList();
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

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            var selectedTea = CBTeas.SelectedItem as Tea;
            if (selectedTea == null)
            {
                MessageBox.Show("Выберите чай", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            GlobalSettings.DB.Tea.FirstOrDefault(t => t.Id == selectedTea.Id).InStock += int.Parse(TBQauntity.Text);
            GlobalSettings.DB.ProductionHistory.Add(new ProductionHistory() { DateTime = DateTime.Now, ProducedQuantity = int.Parse(TBQauntity.Text), TeaId = selectedTea.Id, UserId = GlobalSettings.LoggedUser.Id });
            GlobalSettings.DB.SaveChanges();
            Refresh();
        }
    }
}
