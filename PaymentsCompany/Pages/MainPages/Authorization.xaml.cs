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

namespace PaymentsCompany.Pages.MainPages
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        private bool _Is_Click = true;
        public Authorization()
        {
            InitializeComponent();
        }

        private void PasswordVisibility_Click(object sender, RoutedEventArgs e)
        {
            if (_Is_Click)
            {
                PasswordTB.Text = PasswordPB.Password;
                PasswordPB.Visibility = Visibility.Collapsed;
                PasswordTB.Visibility = Visibility.Visible;
                _Is_Click = false;
            }
            else
            {
                PasswordPB.Password = PasswordTB.Text;
                PasswordTB.Visibility = Visibility.Collapsed;
                PasswordPB.Visibility = Visibility.Visible;
                _Is_Click = true;
            }
        }

        private void AuthorizationBT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ForgotPasswordBT_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
