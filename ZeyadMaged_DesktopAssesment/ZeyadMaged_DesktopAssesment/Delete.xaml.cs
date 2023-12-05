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
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Page
    {
        AssesmentEntities1 db = new AssesmentEntities1();
        public Delete()
        {
            InitializeComponent();
        }

        private void navsearbutt_Click(object sender, RoutedEventArgs e)
        {
            Search se = new Search();
            this.NavigationService.Navigate(se);
        }

        private void searchbutt_Click(object sender, RoutedEventArgs e)
        {
            Userr us = db.Userrs.Remove(db.Userrs.FirstOrDefault(x => x.Phonenumber == pntxt.Text));
            db.SaveChanges();
            deletedg.ItemsSource = db.Userrs.ToList();
        }
    }
}
