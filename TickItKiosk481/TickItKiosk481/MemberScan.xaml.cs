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
    /// Interaction logic for MemberScan.xaml
    /// </summary>
    public partial class MemberScan : Window
    {
        public MemberScan()
        {
            InitializeComponent();
        }

        private void skipMembership(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.memberSkip.Show();
        }

        private void membershipSignedIn(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.memberWelcome.Show();
        }
    }
}
