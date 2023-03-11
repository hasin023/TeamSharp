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
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }


        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Account successfully created!!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Hide();
            new Login().Show();
        }

        private void Exit_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Application.Current.Shutdown();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Minimize_Click(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.WindowState = WindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            txtEmail.Clear();
            txtName.Clear();
            txtUsername.Clear();
            txtDOB.Clear();
            passBox.Clear();
            conPassBox.Clear();

            if (dudeButton.IsChecked == true)
            {
                dudeButton.IsChecked = false;
            }
            else
            {
                girlButton.IsChecked = false;
            }

            genderImg.Source = new BitmapImage(new Uri("Images/background.png", UriKind.RelativeOrAbsolute));

            txtEmail.Focus();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dudeClick(object sender, RoutedEventArgs e)
        {
            if (dudeButton.IsChecked == true)
            {
                genderImg.Source = new BitmapImage(new Uri("Images/dudeIcon.png", UriKind.RelativeOrAbsolute));
            }
        }

        private void girlClick(object sender, RoutedEventArgs e)
        {
            if (girlButton.IsChecked == true)
            {
                genderImg.Source = new BitmapImage(new Uri("Images/girlIcon.png", UriKind.RelativeOrAbsolute));
            }

        }

        private void LoginLink_Click(object sender, RequestNavigateEventArgs e)
        {
            this.Hide();
            new Login().Show();
            e.Handled = true;
        }

        private void emailEnterKey(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtUsername.Focus();
            }
        }

        private void userEnterKey(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtName.Focus();
            }
        }

        private void nameEnterKey(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtDOB.Focus();
            }
        }

        private void dobEnterKey(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                passBox.Focus();
            }
        }

        private void passEnterKey(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                conPassBox.Focus();
            }
        }
    }
}
