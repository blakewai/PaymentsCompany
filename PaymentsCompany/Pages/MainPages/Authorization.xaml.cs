using PaymentsCompany.DataFolder;
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
        private DataFolder.KKkuzminaEntities context;
        public static User _user_Main_Info;
        private bool _Is_Click = true;
        public Authorization()
        {
            InitializeComponent();
        }

        private bool Check_input()
        {
            if(LoginTB.Text == null ||  LoginTB.Text == string.Empty)
            {
                MessageBox.Show("Укажите логин");
                return false;
            }
            if(PasswordPB.Password == null || PasswordPB.Password == string.Empty || PasswordTB.Text == string.Empty || PasswordTB.Text == null)
            {
                MessageBox.Show("Укажите пароль");
                return false;
            }
            return true;
        }

        private void PasswordVisibility_Click(object sender, RoutedEventArgs e)
        {
            if (_Is_Click)
            {
                PasswordTB.Text = PasswordPB.Password;
                PasswordPB.Password = PasswordTB.Text;
                PasswordPB.Visibility = Visibility.Collapsed;
                PasswordTB.Visibility = Visibility.Visible;
                _Is_Click = false;
            }
            else
            {
                PasswordPB.Password = PasswordTB.Text;
                PasswordTB.Text = PasswordPB.Password;
                PasswordTB.Visibility = Visibility.Collapsed;
                PasswordPB.Visibility = Visibility.Visible;
                _Is_Click = true;
            }
        }

        private void AuthorizationBT_Click(object sender, RoutedEventArgs e)
        {
            if (Check_input())
            {
                var UserAuth = context.User.Where(x => x.Login == LoginTB.Text && x.Password == PasswordPB.Password).FirstOrDefault();
                if (UserAuth != null)
                {
                    _user_Main_Info = UserAuth;
                    this.NavigationService.Navigate(new Uri("Pages/MainPages/PagesAllUser/Profile.xaml", UriKind.RelativeOrAbsolute));
                }
            }
            
        }

        private void ForgotPasswordBT_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Pages/MainPages/ForgotPassword.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
