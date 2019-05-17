using System.Windows;

namespace RegistrationApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OpenPage(Pages.LogIn);
        }

        public void OpenPage(Pages page)
        {
            if (page == Pages.LogIn)
            {
                frame.Navigate(new PageLogIn(this));
            }
            else if (page == Pages.Registration)
            {
                frame.Navigate(new PageRegistration(this));
            }
        }

    }
}
