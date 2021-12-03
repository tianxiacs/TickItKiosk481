using System;
using System.Collections;
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
using System.Windows.Threading;

namespace TickItKiosk481
{
    /// <summary>
    /// Interaction logic for Seat.xaml
    /// </summary>
    public partial class Seat : Window
    {
        public int remainingSeatNum = 0;
        public ArrayList clickedButtons = new ArrayList();
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

        private void SeatClick(object sender, RoutedEventArgs e)
        {
            Button seatBoxButton = e.Source as Button;
            SeatContinueWarningLabel.Visibility = Visibility.Hidden;
            if (remainingSeatNum > 0 && Convert.ToString(seatBoxButton.Content) == "")
            {
                seatBoxButton.Content = "√";
                remainingSeatNum--;
                RemainingSeatLabel.Content = remainingSeatNum;
                clickedButtons.Add(seatBoxButton);
            }
            else if (Convert.ToString(seatBoxButton.Content) == "√")
            {
                seatBoxButton.Content = "";
                remainingSeatNum++;
                RemainingSeatLabel.Content = remainingSeatNum;
                clickedButtons.Remove(seatBoxButton);
            }

        }

        private void StartTimer()
        {
            DispatcherTimer countdown = new DispatcherTimer();
            countdown.Interval = TimeSpan.FromSeconds(1);
            countdown.Tick += decreaseTime;
            countdown.Start();
        }

        int timerCount = 240;
        private void decreaseTime(object sender, EventArgs e)
        {
            string timerStr = timerCount / 60 + " Minutes " + (timerCount % 60) + " Seconds";
            App.food.TimerLabel.Content = timerStr;
            App.payment.TimerLabel.Content = timerStr;
            App.cdp.TimerLabel.Content = timerStr;
            App.giftPayment.TimerLabel.Content = timerStr;
            timerCount--;
            if (timerCount == 0)
            {
                App.timeOut.Show();
            }
        }

        private void GoToFood(object sender, RoutedEventArgs e)
        {
            if (remainingSeatNum > 0)
            {
                SeatContinueWarningLabel.Visibility = Visibility.Visible;
            }
            else
            {
                App.food.TimerPopUpWindow.Visibility = Visibility.Visible;
                App.food.TimerPopUpContinueButton.Visibility = Visibility.Visible;
                timerCount = 240;
                StartTimer();
                this.Visibility = Visibility.Hidden;
                App.food.Show();
            }

        }

    }
}
