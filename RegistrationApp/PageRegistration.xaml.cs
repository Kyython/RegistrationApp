using RegistrationApp.DataAccess;
using System.Windows;
using System.Windows.Controls;

namespace RegistrationApp
{
    public partial class PageRegistration : Page
    {
        private MainWindow _mainWindow;

        public PageRegistration(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void RegistartionButtonClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(passwordBox.Password) || !string.IsNullOrEmpty(loginTextBox.Text))
            {
                if (passwordBox.Password != checkPassword.Password)
                {
                    MessageBox.Show("Пароли не совпадают");
                    return;
                }

                using (var context = new DataContext())
                {
                    context.Users.Add(new Models.User { Login = loginTextBox.Text, Password = passwordBox.Password });
                    context.SaveChanges();
                    MessageBox.Show("Регистрация завершена!");
                }
            }
            else
            {
                MessageBox.Show("Неккоректный ввод данных");
            }
        }

        private void ButtonBack(object sender, RoutedEventArgs e)
        {
            _mainWindow.OpenPage(Pages.LogIn);
        }

       
    }
}
