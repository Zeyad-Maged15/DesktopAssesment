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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        AssesmentEntities1 db = new AssesmentEntities1();
        public Login()
        {
            InitializeComponent();
        }

        private void forgetpassbutt_Click(object sender, RoutedEventArgs e)
        {
            ForgetPassword fg = new ForgetPassword();
            this.NavigationService.Navigate(fg);
        }

        private void loginbutt_Click(object sender, RoutedEventArgs e)
        {
            if(logcombo.Text == "Admin")
            {
                Adminn ad = db.Adminns.First(x => x.admin_username == usernamelogtxt.Text && x.admin_pass == passlogtxt.Text || x.admin_username != usernamelogtxt.Text && x.admin_pass != passlogtxt.Text || x.admin_username == usernamelogtxt.Text && x.admin_pass != passlogtxt.Text || x.admin_username != usernamelogtxt.Text && x.admin_pass == passlogtxt.Text);
                if (ad.admin_username == usernamelogtxt.Text && ad.admin_pass == passlogtxt.Text)
                {
                    MessageBox.Show("Login successfully");
                    Profile pro = new Profile();
                    this.NavigationService.Navigate(pro);
                }
            }

            else if (logcombo.Text == "User")            {
                Userr us = db.Userrs.First(x => x.usUsername == usernamelogtxt.Text && x.usPassword == passlogtxt.Text);
                if (us.usUsername == usernamelogtxt.Text && us.usPassword == passlogtxt.Text)
                {
                    MessageBox.Show("Login successfully");
                    Decide dec = new Decide();
                    this.NavigationService.Navigate(dec);
                }
            }
            else if (usernamelogtxt.Text == null && passlogtxt.Text == null)
            {
                MessageBox.Show("Enter your username and password");
            }

            else
            {
                MessageBox.Show("Login Failed");
            }

        }

        private void signuplogbutt_Click(object sender, RoutedEventArgs e)
        {
            Signup su = new Signup();
            this.NavigationService.Navigate(su);
        }
    }
}