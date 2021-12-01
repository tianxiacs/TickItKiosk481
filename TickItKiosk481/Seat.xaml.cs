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
    /// Interaction logic for Seat.xaml
    /// </summary>
    public partial class Seat : Window
    {
        public static int remainingSeatNum = 0;
        public Seat()
        {
            InitializeComponent();
            SeatContinueWarningLabel.Visibility = Visibility.Hidden;
        }

        private void BackToTicket(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.ticket.Show();
        }

        private void GetLanguage(object sender, RoutedEventArgs e)
        {
            LanguageScreen.lastPage = this;
            this.Visibility = Visibility.Hidden;
            App.languageScreen.Show();
        }

        private void GetHelp(object sender, RoutedEventArgs e)
        {
            Help.lastPage = this;
            this.Visibility = Visibility.Hidden;
            App.help.Show();
        }

        private void SeatClick(object sender, RoutedEventArgs e)
        {
            Button seatBoxButton = e.Source as Button;
            SeatContinueWarningLabel.Visibility = Visibility.Hidden;
            if (remainingSeatNum > 0 && Convert.ToString(seatBoxButton.Content) == "")
            {
                seatBoxButton.Content = "√";
                remainingSeatNum--;
                RemainingSeatLabel.Content = remainingSeatNum;
            }
            else if (Convert.ToString(seatBoxButton.Content) == "√")
            {
                seatBoxButton.Content = "";
                remainingSeatNum++;
                RemainingSeatLabel.Content = remainingSeatNum;
            }

        }

        private void GoToFood(object sender, RoutedEventArgs e)
        {
            if (remainingSeatNum > 0)
            {
                SeatContinueWarningLabel.Visibility = Visibility.Visible;
            }else
            {
                this.Visibility = Visibility.Hidden;
                App.food.Show();
            }
            
        }
    }
}
