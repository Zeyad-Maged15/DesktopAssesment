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
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Page
    {
        AssesmentEntities1 db = new AssesmentEntities1();
        public Search()
        {
            InitializeComponent();
        }

        private void navdelbutt_Click(object sender, RoutedEventArgs e)
        {
            Delete del = new Delete();
            this.NavigationService.Navigate(del);
        }

        private void searchbutt_Click(object sender, RoutedEventArgs e)
        {
            searchdg.ItemsSource = db.Userrs.Where(x => x.City == citytxt.Text).ToList();
        }
    }
}
