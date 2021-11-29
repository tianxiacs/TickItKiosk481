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
        public static double subtotalTicket = 0.0;

        public Ticket()
        {
            InitializeComponent();
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

        private void UpdateSubtotal()
        {
            string ticketField = "";
            if (adultNum > 0)
            {
                if (TimeSelection.showType == "3D")
                {
                    ticketField = ticketField + "Adult Ticket x " + adultNum + "               $ " + App.prices["Adult Ticket 3D"] + "\n";
                }else if (TimeSelection.showType == "2D")
                {
                    ticketField = ticketField + "Adult Ticket x " + adultNum + "               $ " + App.prices["Adult Ticket 2D"] + "\n";
                }
                
            }
            if (childNum > 0)
            {
                if (TimeSelection.showType == "3D")
                {
                    ticketField = ticketField + "Child Ticket x " + childNum + "               $ " + App.prices["Child Ticket 3D"] + "\n";
                }
                else if (TimeSelection.showType == "2D")
                {
                    ticketField = ticketField + "Child Ticket x " + childNum + "               $ " + App.prices["Child Ticket 2D"] + "\n";
                }
            }
            if (seniorNum > 0)
            {
                if (TimeSelection.showType == "3D")
                {
                    ticketField = ticketField + "Senior Ticket x " + seniorNum + "              $ " + App.prices["Senior Ticket 3D"] + "\n";
                }
                else if (TimeSelection.showType == "2D")
                {
                    ticketField = ticketField + "Senior Ticket x " + seniorNum + "              $ " + App.prices["Senior Ticket 2D"] + "\n";
                }
            }
            if (redeemNum > 0)
            {
                ticketField = ticketField + "Redeemed Ticket x " + redeemNum + "            $0";
            }
            
            SubtotalFieldTicket.Content = ticketField;
            if (TimeSelection.showType == "3D")
            {
                SubtotalPriceTicket.Content = "$ " + String.Format("{0:0.##}", 1.05 * (adultNum * App.prices["Adult Ticket 3D"] + childNum * App.prices["Child Ticket 3D"] + seniorNum * App.prices["Senior Ticket 3D"]));
            }else if (TimeSelection.showType == "2D")
            {
                SubtotalPriceTicket.Content = "$ " + String.Format("{0:0.##}", 1.05 * (adultNum * App.prices["Adult Ticket 2D"] + childNum * App.prices["Child Ticket 2D"] + seniorNum * App.prices["Senior Ticket 2D"]));
            }
            
        }
        
        private void AddAdult(object sender, RoutedEventArgs e)
        {
            adultNum++;
            AdultLabel.Content = adultNum;
            UpdateSubtotal();
        }

        private void AddChild(object sender, RoutedEventArgs e)
        {
            childNum++;
            ChildLabel.Content = childNum;
            UpdateSubtotal();
        }

        private void AddSenior(object sender, RoutedEventArgs e)
        {
            seniorNum++;
            SeniorLabel.Content = seniorNum;
            UpdateSubtotal();
        }

        private void AddRedeem(object sender, RoutedEventArgs e)
        {
            redeemNum++;
            RedeemLabel.Content = redeemNum;
            UpdateSubtotal();
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
            this.Visibility = Visibility.Hidden;
            App.seat.Show();
        }

        private void BackToTimeSelection(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.timeSelection.Show();
        }
    }
}
