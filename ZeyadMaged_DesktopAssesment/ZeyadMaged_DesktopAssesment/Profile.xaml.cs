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

namespace ZeyadMaged_DesktopAssesment
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        AssesmentEntities1 db = new AssesmentEntities1();
        public Profile()
        {
            InitializeComponent();
            Login log = new Login();
            Userr us = new Userr();
            datagrid1.ItemsSource = db.Userrs.Where(x => us.userid == 1 && x.usUsername.Contains(log.usernamelogtxt.Text) && x.usPassword.Contains(log.passlogtxt.Text)).ToList();
        }
            
        private void logoutbutt_Click(object sender, RoutedEventArgs e)
        {
            Login log = new Login();
            this.NavigationService.Navigate(log);
        }



        private void showbutt_Click(object sender, RoutedEventArgs e)
        {
            datagrid1.ItemsSource = db.Userrs.ToList();
        }


    }
}
