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
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            var loggedUser = GlobalSettings.DB.User.FirstOrDefault(u => u.Login == TBLogin.Text && u.Password == PBPassword.Password);
            if (loggedUser == null || loggedUser.RoleId != 2)
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            GlobalSettings.LoggedUser = loggedUser;
            NavigationService.Navigate(new MainMenuPage());
        }

        private void BClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
