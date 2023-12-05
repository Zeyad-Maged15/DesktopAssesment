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
    /// Interaction logic for Signup.xaml
    /// </summary>
    public partial class Signup : Page
    {
        bool IsValid(string zeyad)
        {
            bool cha, num, spcha;
            cha = num = spcha = false;
            string sp = "!@#$%^&*()-_=+";
            foreach (char c in zeyad)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    return cha = true;
                }
                else if (c >= 'a' && c <= 'z')
                {
                    return cha = true;
                }
                else if (c >= 0 && c <= 1000)
                {
                    return num = true;
                }
                else if (c >= 0 && c <= 1000)
                {
                    return num = true;
                }
                else if(c.Equals (sp))
                {
                    return spcha = true;
                }
            }
            return cha && num && spcha;
        }

        AssesmentEntities1 db = new AssesmentEntities1();
        public Signup()
        {
            InitializeComponent();
        }

        private void loginsignbutt_Click(object sender, RoutedEventArgs e)
        {
            Login log = new Login();
            this.NavigationService.Navigate(log);
        }

        private void signupbutt_Click(object sender, RoutedEventArgs e)
        {
            string malesigncheckk = "Male";
            string femalesigncheckk = "Female";
            int a = 18;
            int b = 60;
            Userr us = new Userr();
            us.usUsername = usernamesigntxt.Text;

            if(IsValid(passsigntxt.Password))
            {
                us.usPassword = passsigntxt.Password;
            }
            else
            {
                MessageBox.Show("Password Must Contains Characters,Numbers,Special Characters");
            }

            if (malesigncheck.IsPressed || femalesigncheck.IsPressed)
            {
                if (malesigncheck.IsPressed)
                {
                    us.Gender = malesigncheckk;
                }
                else if (femalesigncheck.IsPressed)
                {
                    us.Gender = femalesigncheckk;
                }
                
            }
            else
            {
                MessageBox.Show("Please Choose Gender");
            }

            us.City = citysigncombo.Text;
            if ((int.Parse(agesigntxt.Text) >= a && int.Parse(agesigntxt.Text) <= b))
            {
                us.Age = agesigntxt.Text;
            }
            else
            {
                MessageBox.Show("Age Must be Between 18 and 60 Years Old");
            }
            
            db.Userrs.Add(us);
            MessageBox.Show("Data Saved Successfully");
        }

        private void passsignbutt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
