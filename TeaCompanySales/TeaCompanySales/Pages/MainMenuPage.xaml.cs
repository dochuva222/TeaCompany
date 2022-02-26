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

namespace TeaCompanySales.Pages
{
    public partial class MainMenuPage : Page
    {
        public MainMenuPage()
        {
            InitializeComponent();
            MainMenuFrame.Navigate(new ShopListPage());
        }

        private void BShopList_Click(object sender, RoutedEventArgs e)
        {
            MainMenuFrame.Navigate(new ShopListPage());
        }

        private void BListOfTea_Click(object sender, RoutedEventArgs e)
        {
            MainMenuFrame.Navigate(new ListOfTeaPage());
        }

        private void BSale_Click(object sender, RoutedEventArgs e)
        {
            MainMenuFrame.Navigate(new SalePage());
        }

        private void BSaleHistory_Click(object sender, RoutedEventArgs e)
        {
            MainMenuFrame.Navigate(new SaleHistoryPage());
        }
    }
}
