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

namespace AmonicSession1.Pages
{
    using Base;

    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(TextLogin.Text))
                errors.AppendLine("Введите логин");
            if (string.IsNullOrWhiteSpace(TextPass.Password))
                errors.AppendLine("Введите пароль");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            var user = AppData.GetContext().Users.Where(p => p.Email == TextLogin.Text && p.Password == TextPass.Password).FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show("Неверное соответствие логина и пароля");
                return;
            }

            if (user.Active == false)
            {
                MessageBox.Show("Пользователь заблокирован");
                return;
            }

            AppData.CurrentUser = user;

            if (user.RoleID == 1)
            {
                Navigation.MainFrame.Navigate(new AdminPages.AdminMenuPage());
            }
        }

        /// <summary>
        /// Выход
        /// </summary>
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
