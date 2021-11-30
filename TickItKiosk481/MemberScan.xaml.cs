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
        public static Window skipNextPage;
        public MemberScan()
        {
            InitializeComponent();
        }

        private void SkipMember(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            skipNextPage.Show();
        }

        private void SignedIn(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.memberWelcome.Show();
        }

        private void SignInAsJohnny(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.memberWelcome.Show();
            App.memberWelcome.MemberNameLabel.Content = "Johnny!";
            App.memberWelcome.PointLabel.Content = 3500;
            App.memberWelcome.MovieNumberLabel.Content = "3 movies.";
            Ticket.redeemLimit = 3;

            App.showSelection.MemberInfoLabel.Content = "Welcome back, Jonny!\nMembership Points: 3500\nAvailable Redemption: 3";
            App.showSelection.ScanMemberButton.Visibility = Visibility.Hidden;
            App.timeSelection.MemberInfoLabel.Content = "Welcome back, Jonny!\nMembership Points: 3500\nAvailable Redemption: 3";
            App.timeSelection.ScanMemberButton.Visibility = Visibility.Hidden;
            App.ticket.MemberInfoLabel.Content = "Welcome back, Jonny!\nMembership Points: 3500\nAvailable Redemption: 3";
            App.ticket.ScanMemberButton.Visibility = Visibility.Hidden;

            App.ticket.PointBalanceTitleLabel.Visibility = Visibility.Visible;
            App.ticket.CurrentPointsLabel.Visibility = Visibility.Visible;
            App.ticket.CurrentPointsLabel.Content = "Current Points                    3500";
            App.ticket.TicketRedeemBalanceLabel.Visibility = Visibility.Visible;
            App.ticket.RemainingPointsLabel.Visibility = Visibility.Visible;
            App.ticket.RemainingPointsLabel.Content = "Remaining Points               3500";
            App.ticket.Divider1.Visibility = Visibility.Visible;
            App.ticket.Divider2.Visibility = Visibility.Visible;

            Ticket.pointBalance = 3500;
            App.ticket.RedeemLimitLabel.Content = "(You can redeem up to 3 movies)";
        }

        private void SignInAsLori(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.memberWelcome.Show();
            App.memberWelcome.MemberNameLabel.Content = "Lori!";
            App.memberWelcome.PointLabel.Content = 7400;
            App.memberWelcome.MovieNumberLabel.Content = "7 movies.";
            Ticket.redeemLimit = 7;

            App.showSelection.MemberInfoLabel.Content = "Welcome back, Lori!\nMembership Points: 7400\nAvailable Redemption: 7";
            App.showSelection.ScanMemberButton.Visibility = Visibility.Hidden;
            App.timeSelection.MemberInfoLabel.Content = "Welcome back, Lori!\nMembership Points: 7400\nAvailable Redemption: 7";
            App.timeSelection.ScanMemberButton.Visibility = Visibility.Hidden;
            App.ticket.MemberInfoLabel.Content = "Welcome back, Lori!\nMembership Points: 7400\nAvailable Redemption: 7";
            App.ticket.ScanMemberButton.Visibility = Visibility.Hidden;

            App.ticket.PointBalanceTitleLabel.Visibility = Visibility.Visible;
            App.ticket.CurrentPointsLabel.Visibility = Visibility.Visible;
            App.ticket.CurrentPointsLabel.Content = "Current Points                    7400";
            App.ticket.TicketRedeemBalanceLabel.Visibility = Visibility.Visible;
            App.ticket.RemainingPointsLabel.Visibility = Visibility.Visible;
            App.ticket.RemainingPointsLabel.Content = "Remaining Points               7400";
            App.ticket.Divider1.Visibility = Visibility.Visible;
            App.ticket.Divider2.Visibility = Visibility.Visible;

            Ticket.pointBalance = 7400;
            App.ticket.RedeemLimitLabel.Content = "(You can redeem up to 7 movies)";
        }
    }
}
