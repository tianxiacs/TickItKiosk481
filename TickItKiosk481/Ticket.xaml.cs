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
        public int adultNum = 0;
        public int childNum = 0;
        public int seniorNum = 0;
        public int redeemNum = 0;
        public double subtotalTicket = 0.0;

        public int redeemLimit = 0;
        public int ticketLimit = 0;
        public int pointBalance = 0;

        public string subtotalFieldText = "";
        public string pointsFieldText = "";

        public Ticket()
        {
            InitializeComponent();

            // Set Points Balance Module to hidden
            PointBalanceTitleLabel.Visibility = Visibility.Hidden;
            CurrentPointsLabel.Visibility = Visibility.Hidden;
            TicketRedeemBalanceLabel.Visibility = Visibility.Hidden;
            RemainingPointsLabel.Visibility = Visibility.Hidden;
            Divider1.Visibility = Visibility.Hidden;
            Divider2.Visibility = Visibility.Hidden;

            TicketContinueWarningLabel.Visibility = Visibility.Hidden;
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

        private void CheckLimit()
        {

        }

        private void UpdateSubtotal()
        {
            string ticketField = "";
            string pointField = "";
            if (adultNum > 0)
            {
                if (App.timeSelection.showType == "3D")
                {
                    ticketField = ticketField + "Adult Ticket x " + adultNum + "               $ " + App.prices["Adult Ticket 3D"] + "\n";
                }else if (App.timeSelection.showType == "2D")
                {
                    ticketField = ticketField + "Adult Ticket x " + adultNum + "               $ " + App.prices["Adult Ticket 2D"] + "\n";
                }
                
            }
            if (childNum > 0)
            {
                if (App.timeSelection.showType == "3D")
                {
                    ticketField = ticketField + "Child Ticket x " + childNum + "               $ " + App.prices["Child Ticket 3D"] + "\n";
                }
                else if (App.timeSelection.showType == "2D")
                {
                    ticketField = ticketField + "Child Ticket x " + childNum + "               $ " + App.prices["Child Ticket 2D"] + "\n";
                }
            }
            if (seniorNum > 0)
            {
                if (App.timeSelection.showType == "3D")
                {
                    ticketField = ticketField + "Senior Ticket x " + seniorNum + "              $ " + App.prices["Senior Ticket 3D"] + "\n";
                }
                else if (App.timeSelection.showType == "2D")
                {
                    ticketField = ticketField + "Senior Ticket x " + seniorNum + "              $ " + App.prices["Senior Ticket 2D"] + "\n";
                }
            }
            if (redeemNum > 0)
            {
                ticketField = ticketField + "Redeemed Ticket x " + redeemNum + "            $0";
                pointField = "Ticket Redemption x " + redeemNum + "       1000";
            }
            
            SubtotalFieldTicket.Content = ticketField;
            TicketRedeemBalanceLabel.Content = pointField;
            RemainingPointsLabel.Content = "Remaining Points               " + (pointBalance - 1000 * redeemNum);
            if (App.timeSelection.showType == "3D")
            {
                subtotalTicket = 1.05 * (adultNum * App.prices["Adult Ticket 3D"] + childNum * App.prices["Child Ticket 3D"] + seniorNum * App.prices["Senior Ticket 3D"]);
                SubtotalPriceTicket.Content = "$ " + String.Format("{0:0.##}", subtotalTicket);
            }else if (App.timeSelection.showType == "2D")
            {
                subtotalTicket = 1.05 * (adultNum * App.prices["Adult Ticket 2D"] + childNum * App.prices["Child Ticket 2D"] + seniorNum * App.prices["Senior Ticket 2D"]);
                SubtotalPriceTicket.Content = "$ " + String.Format("{0:0.##}", subtotalTicket);
            }

            subtotalFieldText = ticketField;
            pointsFieldText = pointField;
        }
        
        private void AddAdult(object sender, RoutedEventArgs e)
        {
            adultNum++;
            AdultLabel.Content = adultNum;
            UpdateSubtotal();
            TicketContinueWarningLabel.Visibility = Visibility.Hidden;
        }

        private void AddChild(object sender, RoutedEventArgs e)
        {
            childNum++;
            ChildLabel.Content = childNum;
            UpdateSubtotal();
            TicketContinueWarningLabel.Visibility = Visibility.Hidden;
        }

        private void AddSenior(object sender, RoutedEventArgs e)
        {
            seniorNum++;
            SeniorLabel.Content = seniorNum;
            UpdateSubtotal();
            TicketContinueWarningLabel.Visibility = Visibility.Hidden;
        }

        private void AddRedeem(object sender, RoutedEventArgs e)
        {
            if (redeemNum < redeemLimit)
            {
                redeemNum++;
                RedeemLabel.Content = redeemNum;
                UpdateSubtotal();
                TicketContinueWarningLabel.Visibility = Visibility.Hidden;
            }
            
        }

        private void MinusAdult(object sender, RoutedEventArgs e)
        {
            if (adultNum > 0)
            {
                adultNum--;
            }
            AdultLabel.Content = adultNum;
            UpdateSubtotal();
        }

        private void MinusChild(object sender, RoutedEventArgs e)
        {
            if (childNum > 0)
            {
                childNum--;
            }
            ChildLabel.Content = childNum;
            UpdateSubtotal();
        }

        private void MinusSenior(object sender, RoutedEventArgs e)
        {
            if (seniorNum > 0)
            {
                seniorNum--;
            }
            SeniorLabel.Content = seniorNum;
            UpdateSubtotal();
        }

        private void MinusRedeem(object sender, RoutedEventArgs e)
        {
            if (redeemNum > 0)
            {
                redeemNum--;
            }
            RedeemLabel.Content = redeemNum;
            UpdateSubtotal();
        }

        private void GoToSeats(object sender, RoutedEventArgs e)
        {
            if (adultNum + childNum + seniorNum + redeemNum > 0)
            {
                this.Visibility = Visibility.Hidden;
                App.seat.Show();
                App.seat.remainingSeatNum = adultNum + childNum + seniorNum + redeemNum;
                App.seat.RemainingSeatLabel.Content = adultNum + childNum + seniorNum + redeemNum;

                App.food.allFieldText = subtotalFieldText;
                App.food.subtotalAll = subtotalTicket;
                App.payment.pointTotalText = pointsFieldText;

                App.food.FoodSubtotalLabel.Content = App.food.allFieldText;
                App.food.FoodPriceLabel.Content = "$ " + String.Format("{0:0.##}", subtotalTicket);
            }
            else
            {
                TicketContinueWarningLabel.Visibility = Visibility.Visible;
            }
            
        }

        private void BackToTimeSelection(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.timeSelection.Show();
        }

        private void ScanMemberTicket(object sender, RoutedEventArgs e)
        {
            App.memberScan.skipNextPage = this;
            App.memberWelcome.nextPage = this;
            this.Visibility = Visibility.Hidden;
            App.memberScan.Show();
        }
    }
}
