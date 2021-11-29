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
    /// Interaction logic for Window1.xaml
    /// </summary>
    /// 
    // App.timeSelection.showName
    public partial class TimeSelection : Window
    {
        /*
         * Yuan did the change
         * Using the "MembershipSkip" window to select the show Name
         */
        //public static String showName = null;
        public static String showTime = null;
        public static String showType = null;
        public static String showDate = null;
        public TimeSelection()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.showSelection.Show();
        }

        private void ChangeLanguage(object sender, RoutedEventArgs e)
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

        private void GoToTicket()
        {
            this.Visibility = Visibility.Hidden;
            App.ticket.Show();
            App.ticket.DateLabel.Content = showDate;
            App.ticket.TimeLabel.Content = showTime;
            App.ticket.FormatLabel.Content = showType;
            App.ticket.AdultLabel.Content = 0;
            App.ticket.ChildLabel.Content = 0;
            App.ticket.SeniorLabel.Content = 0;
            App.ticket.RedeemLabel.Content = 0;
            if (showType == "3D")
            {
                App.ticket.AdultPrice.Content = App.prices["Adult Ticket 3D"];
                App.ticket.ChildPrice.Content = App.prices["Child Ticket 3D"];
                App.ticket.SeniorPrice.Content = App.prices["Senior Ticket 3D"];
            }else if (showType == "2D")
            {
                App.ticket.AdultPrice.Content = App.prices["Adult Ticket 2D"];
                App.ticket.ChildPrice.Content = App.prices["Child Ticket 2D"];
                App.ticket.SeniorPrice.Content = App.prices["Senior Ticket 2D"];
            }
            
        }

        private void Show1(object sender, RoutedEventArgs e)
        {
            //showName = "Venom";
            showTime = "14:15 PM";
            showType = "3D";
            showDate = "2021-11-04";
            GoToTicket();
        }

        private void Show2(object sender, RoutedEventArgs e)
        {
            //showName = "Venom";
            showTime = "19:45 PM";
            showType = "3D";
            showDate = "2021-11-04";
            GoToTicket();
        }

        private void Show3(object sender, RoutedEventArgs e)
        {
            //showName = "Venom";
            showTime = "17:15 PM";
            showType = "2D";
            showDate = "2021-11-05";
            GoToTicket();
        }

        private void Show4(object sender, RoutedEventArgs e)
        {
            //showName = "Venom";
            showTime = "15:30 PM";
            showType = "2D";
            showDate = "2021-11-06";
            GoToTicket();
        }

        private void Show5(object sender, RoutedEventArgs e)
        {
            //showName = "Venom";
            showTime = "19:30 PM";
            showType = "3D";
            showDate = "2021-11-06";
            GoToTicket();
        }

        private void Show6(object sender, RoutedEventArgs e)
        {
            //showName = "Venom";
            showTime = "18:25 PM";
            showType = "2D";
            showDate = "2021-11-07";
            GoToTicket();
        }

        private void Show7(object sender, RoutedEventArgs e)
        {
            //showName = "Venom";
            showTime = "14:30 PM";
            showType = "3D";
            showDate = "2021-11-08";
            GoToTicket();
        }

        private void Show8(object sender, RoutedEventArgs e)
        {
            //showName = "Venom";
            showTime = "14:00 PM";
            showType = "3D";
            showDate = "2021-11-09";
            GoToTicket();
        }

        private void Show9(object sender, RoutedEventArgs e)
        {
            //showName = "Venom";
            showTime = "18:00 PM";
            showType = "2D";
            showDate = "2021-11-09";
            GoToTicket();
        }

        private void Show10(object sender, RoutedEventArgs e)
        {
            //showName = "Venom";
            showTime = "21:15 PM";
            showType = "3D";
            showDate = "2021-11-09";
            GoToTicket();
        }

        private void Show11(object sender, RoutedEventArgs e)
        {
            //showName = "Venom";
            showTime = "17:45 PM";
            showType = "3D";
            showDate = "2021-11-10";
            GoToTicket();
        }

        private void ScanMemberTime(object sender, RoutedEventArgs e)
        {
            MemberScan.skipNextPage = this;
            MemberWelcome.nextPage = this;
            this.Visibility = Visibility.Hidden;
            App.memberScan.Show();
        }
    }
    

}
