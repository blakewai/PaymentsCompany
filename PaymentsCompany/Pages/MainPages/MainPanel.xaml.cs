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
    /// Логика взаимодействия для MainPanel.xaml
    /// </summary>
    public partial class MainPanel : Page
    {
        private DataFolder.KKkuzminaEntities context;
        public static User UserMain = Authorization._user_Main_Info;
        public MainPanel()
        {
            InitializeComponent();
        }
        private void MainPageProfile()
        {

        }

        private void UsersBT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PaymentsBT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExiteBT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProfileBT_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
