using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for ForgetPassword.xaml
    /// </summary>
    public partial class ForgetPassword : Page
    {
        AssesmentEntities1 db = new AssesmentEntities1();
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void updatepassword_Click(object sender, RoutedEventArgs e)
        {
            Userr us = db.Userrs.FirstOrDefault(x => x.Phonenumber == phonenumforgtxt.Text || x.Phonenumber != phonenumforgtxt.Text);
            if(us.Phonenumber == phonenumforgtxt.Text)
            {
                if(newpassforgtxt.Text == confpassforgtxt.Text)
                {
                    us.usPassword = newpassforgtxt.Text;
                }
                else
                {
                    MessageBox.Show("New Password is Not Identity With Confirm Password");
                }
            }
            else
            {
                MessageBox.Show("Phone Number is Not Saved Before");
            }
            db.Userrs.AddOrUpdate(us);
        }
    }
}
