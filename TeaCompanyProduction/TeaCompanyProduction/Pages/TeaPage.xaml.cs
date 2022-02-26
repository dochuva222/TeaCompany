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
using TeaCompanyProduction.Models;

namespace TeaCompanyProduction.Pages
{
    public partial class TeaPage : Page
    {
        Tea contextTea;
        public TeaPage(Tea tea)
        {
            InitializeComponent();
            CBGrades.ItemsSource = GlobalSettings.DB.Grade.ToList();
            CBTypes.ItemsSource = GlobalSettings.DB.Type.ToList();
            contextTea = tea;
            DataContext = contextTea;
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(contextTea.Name))
                errorMessage += "Введите название\n";
            if(contextTea.Type == null)
                errorMessage += "Выберите тип чая\n";
            if (contextTea.Grade == null)
                errorMessage += "Выберите сорт чая\n";
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (contextTea.Id == 0)
                GlobalSettings.DB.Tea.Add(contextTea);
            GlobalSettings.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BLoadPhoto_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() { Filter = ".jpg, .jpeg, .png|*.jpg; *.jpeg; *.png"};
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                contextTea.Image = File.ReadAllBytes(dialog.FileName);
                TeaImage.Source = Tools.BytesToImage(contextTea.Image);
            }

        }
    }
}
