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
    public partial class SaleHistoryPage : Page
    {
        public SaleHistoryPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGHistory.ItemsSource = GlobalSettings.DB.Sale.ToList();
        }
    }
}
