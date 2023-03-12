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

namespace Language_Learning_App
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();

            if (Properties.Settings.Default.Username != string.Empty)
            {
                txtLUsername.Text = Properties.Settings.Default.Username;
            }
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
        private void loginClick(object sender, RoutedEventArgs e)
        {
            if (checkBox.IsChecked == true)
            {
                Language_Learning_App.Properties.Settings.Default.Username = txtLUsername.Text;
                Language_Learning_App.Properties.Settings.Default.Save();
            }
            if (txtLUsername.Text == "admin" && txtLPassword.Password == "admin")
            {
                this.Hide();
                new Menu().Show();
            }
            else
            {
                MessageBox.Show("Invalid log in Credentials", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void txtEnterKey(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtLPassword.Focus();
            }
        }
        private void passEnterKey(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                e.Handled = true;
                loginClick(sender, e);
            }
        }

        private void exitApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void RegisterLink_Click(object sender, RequestNavigateEventArgs e)
        {
            this.Hide();
            new Registration().Show();
            e.Handled = true;
        }
    }
}
