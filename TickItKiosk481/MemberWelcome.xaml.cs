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
    /// Interaction logic for MemberWelcome.xaml
    /// </summary>
    public partial class MemberWelcome : Window
    {
        public Window nextPage;
        public MemberWelcome()
        {
            InitializeComponent();
        }

        private void MembershipContinue(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            nextPage.Show();
        }

    }
}
