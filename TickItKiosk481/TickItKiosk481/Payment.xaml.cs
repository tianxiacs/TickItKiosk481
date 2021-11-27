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
    /// Interaction logic for Payment_Window.xaml
    /// </summary>
    public partial class Payment : Window
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void CreditDebitPayment(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.cdp.Show();
        }

        private void GiftCardPayment(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.giftPayment.Show();
        }
    }
}
