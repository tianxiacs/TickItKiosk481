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

        private void GoToCreditDebitPayment(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.cdp.Show();
        }

        private void GoToGiftCardPayment(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.giftPayment.Show();
        }

        private void BackToFood(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.food.Show();
        }

        private void GetLanguage(object sender, RoutedEventArgs e)
        {
            App.languageScreen.lastPage = this;
            this.Visibility = Visibility.Hidden;
            App.languageScreen.Show();
        }

        private void GetHelp(object sender, RoutedEventArgs e)
        {
            App.help.lastPage = this;
            this.Visibility = Visibility.Hidden;
            App.help.Show();
        }

    }
}
