using Nemiro.OAuth.LoginForms;
using RegistrationApp.DataAccess;
using RegistrationApp.Services;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace RegistrationApp
{
    public partial class PageLogIn : Page
    {
        private MainWindow _mainWindow;

        public PageLogIn(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void RegistrationClick(object sender, RoutedEventArgs e)
        {
            _mainWindow.OpenPage(Pages.Registration);
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            var login = loginTextBox.Text;
            var password = passwordBox.Password;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            using (var context = new DataContext())
            {

                var user = context.Users.SingleOrDefault(searchingUser => searchingUser.Login == login);

                if (user == null || !SecurityHasher.VerifyPassword(password, SecurityHasher.HashPassword(user.Password)))
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
                else
                {
                    MessageBox.Show("Вход выполнен!");
                }
            }
        }

        private void MailRuLogInButton(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.SettingsKey))
            {
                var login = new MailRuLogin("765349", "ebe8fa0ee608795519181305f54a2e7e  ", true);

                login.ShowDialog();

                if (login.IsSuccessfully)
                {
                    Properties.Settings.Default.SettingsKey = login.AccessTokenValue;
                    MessageBox.Show("Вход выполнен успешно!");
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
        }

        private void VkontakteLogInButton(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.SettingsKey))
            {
                
                var login = new VkontakteLogin("6987858", "qKqLn4Nd4Jt5iJjU5v3f", true);
                login.ShowDialog();

                if (login.IsSuccessfully)
                {
                    Properties.Settings.Default.SettingsKey = login.AccessTokenValue;
                    MessageBox.Show("Вход выполнен успешно!");
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
        }

        private void LogInButton(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.SettingsKey))
            {
                var login = new YandexLogin("638293295dc6456fafa73726be67b68b", "8bc1b5dc48c34d97bc6d14de150113de", true);
                login.ShowDialog();

                if (login.IsSuccessfully)
                {
                    Properties.Settings.Default.SettingsKey = login.AccessTokenValue;
                    MessageBox.Show("Вход выполнен успешно!");
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
        }
    }
}
