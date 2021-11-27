using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TickItKiosk481
{
    /// <summary>
    /// Interaction logic for MemberSkip.xaml
    /// </summary>
    public partial class MemberSkip : Window
    {
        public static String showName = null;

        public MemberSkip()
        {
            InitializeComponent();
        }


        private void selectMovieVenomPoster(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.timeSelection.Show();
        }

        private void selectMovieVenomTitle(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.timeSelection.Show();
        }

        private void scanMembershipCard(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.memberScan.Show();
        }
    }
}
