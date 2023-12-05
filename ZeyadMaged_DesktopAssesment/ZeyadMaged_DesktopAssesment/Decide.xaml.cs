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
    /// Interaction logic for Decide.xaml
    /// </summary>
    public partial class Decide : Page
    {
        public Decide()
        {
            InitializeComponent();
        }


        private void navtodel_Click(object sender, RoutedEventArgs e)
        {
            Search sea = new Search();
            this.NavigationService.Navigate(sea);
        }

        private void navtosear_Click(object sender, RoutedEventArgs e)
        {
            Delete del = new Delete();
            this.NavigationService.Navigate(del);
        }
    }
}
