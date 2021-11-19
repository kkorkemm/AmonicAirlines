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

namespace AmonicSession1.Pages.AdminPages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для AdminMenuPage.xaml
    /// </summary>
    public partial class AdminMenuPage : Page
    {
        public AdminMenuPage()
        {
            InitializeComponent();

            List<Offices> offices = AppData.GetContext().Offices.ToList();
            offices.Insert(0, new Offices { Title = "All" });
            ComboOffice.ItemsSource = offices;

            GridUsers.ItemsSource = AppData.GetContext().Users.ToList();
        }

        private void MenuAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Выход из системы
        /// </summary>
        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите выйти из системы?", "Внимание!", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                Navigation.MainFrame.Navigate(new LoginPage());
            }
        }

        /// <summary>
        /// Закрашивание строк
        /// </summary>
        private void GridUsers_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            var user = e.Row.Item as Users;

            if (user.Active == false)
            {
                e.Row.Background = Brushes.Red;
            }
            else if (user.RoleID == 1)
            {
                e.Row.Background = Brushes.Green;
            }
        }

        private void BtnChange_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Фильтрация
        /// </summary>
        private void ComboOffice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var list = AppData.GetContext().Users.ToList();
            if (ComboOffice.SelectedIndex > 0)
            {
                var office = ComboOffice.SelectedItem as Offices;
                list = list.Where(p => p.OfficeID == office.ID).ToList();
            }
            GridUsers.ItemsSource = list;
        }
    }
}
