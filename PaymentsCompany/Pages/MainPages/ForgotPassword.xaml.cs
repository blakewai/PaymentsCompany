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
    /// Логика взаимодействия для ForgotPassword.xaml
    /// </summary>
    public partial class ForgotPassword : Page
    {
        private DataFolder.KKkuzminaEntities context;
        private Random random;
        private int randomcode;
        public ForgotPassword()
        {
            InitializeComponent();
            randomcode = random.Next(1000, 9999);
            MessageBox.Show($"Ваш код для входа в профиль: {randomcode}\nНе сообщайте код!", "Новое сообщение от: Почта", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private bool Check_input()
        {
            if (EmailTB.Text == null || EmailTB.Text == string.Empty)
            {
                MessageBox.Show("Укажите почту");
                return false;
            }
            if (CodeTB.Text == null || CodeTB.Text == string.Empty)
            {
                MessageBox.Show("Укажите код");
                return false;
            }
            if (CodeTB.Text != randomcode.ToString())
            {
                MessageBox.Show("Не правильный код!");
                return false;
            }
            return true;
        }

        private void AuthorizationBT_Click(object sender, RoutedEventArgs e)
        {
            if (Check_input())
            {
                var emailSearch = context.User.Where(x => x.Polzov.Email == EmailTB.Text).FirstOrDefault();
                if(emailSearch != null)
                {
                    MessageBox.Show($"Здравствуйте, мы приняли сообщение о том что вы забыли пароль или логин:\n" +
                                    $"Логин: {emailSearch.Login}\n" +
                                    $"Пароль: {emailSearch.Password}\n Больше не теряйте свои данные!", "Новое сообщение от: Почта", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.NavigationService.GoBack();
                }
                else
                {
                    MessageBox.Show("Такой почты не существует!");
                }
            }
        }

        private void ForgotPasswordBT_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
