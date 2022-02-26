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
    public partial class ListOfTeaPage : Page
    {
        public ListOfTeaPage()
        {
            InitializeComponent();
            var grades = GlobalSettings.DB.Grade.ToList();
            var types = GlobalSettings.DB.Type.ToList();
            grades.Insert(0, new Grade() { Name = "Все" });
            types.Insert(0, new Models.Type() { Name = "Все" });
            CBGrades.ItemsSource = grades;
            CBTypes.ItemsSource = types;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            var searchText = TBSearch.Text.ToLower();
            var selectedGrade = CBGrades.SelectedItem as Grade;
            var selectedType = CBTypes.SelectedItem as Models.Type;
            var filtred = GlobalSettings.DB.Tea.ToList();
            if (!string.IsNullOrWhiteSpace(searchText))
                filtred = filtred.Where(f => f.Name.ToLower().Contains(searchText) || f.Description.ToLower().Contains(searchText)).ToList();
            if (selectedType != null && selectedType.Id != 0)
                filtred = filtred.Where(f => f.TypeId == selectedType.Id).ToList();
            if (selectedGrade != null && selectedGrade.Id != 0)
                filtred = filtred.Where(f => f.GradeId == selectedGrade.Id).ToList();
            LVTea.ItemsSource = filtred;
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void CBGrades_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void CBTypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }
    }
}
