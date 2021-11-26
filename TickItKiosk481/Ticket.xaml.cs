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
    /// Interaction logic for Ticket.xaml
    /// </summary>
    public partial class Ticket : Window
    {
        public static double subtotal = 0.0;
        public static int adultNum = 0;
        public static int childNum = 0;
        public static int seniorNum = 0;
        public static int redeemNum = 0;

        public Ticket()
        {
            InitializeComponent();
        }

        private void GetLanuage(object sender, RoutedEventArgs e)
        {
            LanguageScreen.lastPage = "Ticket";
            LanguageScreen objLanguageScreen = new LanguageScreen();
            this.Visibility = Visibility.Hidden;
            objLanguageScreen.Show();
        }

        private void GetHelp(object sender, RoutedEventArgs e)
        {
            Help.lastPage = "Ticket";
            Help objHelp = new Help();
            this.Visibility = Visibility.Hidden;
            objHelp.Show();
        }

        private void AddAdult(object sender, RoutedEventArgs e)
        {
            adultNum++;
            AdultLabel.Content = adultNum;
        }

        private void AddChild(object sender, RoutedEventArgs e)
        {
            childNum++;
            ChildLabel.Content = childNum;
        }

        private void AddSenior(object sender, RoutedEventArgs e)
        {
            seniorNum++;
            SeniorLabel.Content = seniorNum;
        }

        private void AddRedeem(object sender, RoutedEventArgs e)
        {
            redeemNum++;
            RedeemLabel.Content = redeemNum;
        }

        private void MinusAdult(object sender, RoutedEventArgs e)
        {
            adultNum--;
            AdultLabel.Content = adultNum;
        }

        private void MinusChild(object sender, RoutedEventArgs e)
        {
            childNum--;
            ChildLabel.Content = childNum;
        }

        private void MinusSenior(object sender, RoutedEventArgs e)
        {
            seniorNum--;
            SeniorLabel.Content = seniorNum;
        }

        private void MinusRedeem(object sender, RoutedEventArgs e)
        {
            redeemNum--;
            RedeemLabel.Content = redeemNum;
        }

        private void GoToSeats(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.seat.Show();
        }
    }
}
