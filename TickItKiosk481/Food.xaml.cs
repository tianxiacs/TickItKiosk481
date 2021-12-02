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
    /// Interaction logic for Food.xaml
    /// </summary>
    public partial class Food : Window
    {
        public string allFieldText = "";
        public string foodField = "";
        public double subtotalAll = 0.0;
        public double subtotalFood = 0.0;

        public int popcornLargeNum = 0;
        public int popcornSmallNum = 0;
        public int friesLargeNum = 0;
        public int friesSmallNum = 0;
        public int popLargeNum = 0;
        public int popSmallNum = 0;
        public Food()
        {
            InitializeComponent();
        }

        private void ChangeLanguage(object sender, RoutedEventArgs e)
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

        private void UpdateSubtotal()
        {
            foodField = "";
            if (popcornLargeNum > 0)
            {
                foodField = foodField + "Popcorn (Large) x " + popcornLargeNum + "        $ " + 10.99 + "\n";
            }
            if (popcornSmallNum > 0)
            {
                foodField = foodField + "Popcorn (Small) x " + popcornSmallNum + "        $ " + 8.99 + "\n";
            }
            if (friesLargeNum > 0)
            {
                foodField = foodField + "Fries (Large) x " + friesLargeNum + "              $ " + 7.99 + "\n";
            }
            if (friesSmallNum > 0)
            {
                foodField = foodField + "Fries (Small) x " + friesSmallNum + "              $ " + 5.99 + "\n";
            }
            if (popLargeNum > 0)
            {
                foodField = foodField + "Pop (Large) x " + popLargeNum + "               $ " + 2.99 + "\n";
            }
            if (popSmallNum > 0)
            {
                foodField = foodField + "Pop (Small) x " + popSmallNum + "               $ " + 1.99 + "\n";
            }

            FoodSubtotalLabel.Content = allFieldText + foodField;
            subtotalFood = 1.05 * (popcornLargeNum * 10.99 + popcornSmallNum * 8.99 + friesLargeNum * 7.99 + friesSmallNum * 5.99 + popLargeNum * 2.99 + popSmallNum * 1.99);
            FoodPriceLabel.Content = "$ " + String.Format("{0:0.##}", subtotalAll + subtotalFood);
        }

        private void AddPopcornLarge(object sender, RoutedEventArgs e)
        {
            popcornLargeNum++;
            PopcornLargeLabel.Content = popcornLargeNum;
            UpdateSubtotal();
        }

        private void AddPopcornSmall(object sender, RoutedEventArgs e)
        {
            popcornSmallNum++;
            PopcornSmallLabel.Content = popcornSmallNum;
            UpdateSubtotal();
        }

        private void AddFriesLarge(object sender, RoutedEventArgs e)
        {
            friesLargeNum++;
            FriesLargeLabel.Content = friesLargeNum;
            UpdateSubtotal();
        }

        private void AddFriesSmall(object sender, RoutedEventArgs e)
        {
            friesSmallNum++;
            FriesSmallLabel.Content = friesSmallNum;
            UpdateSubtotal();
        }

        private void AddPopLarge(object sender, RoutedEventArgs e)
        {
            popLargeNum++;
            PopLargeLabel.Content = popLargeNum;
            UpdateSubtotal();
        }

        private void AddPopSmall(object sender, RoutedEventArgs e)
        {
            popSmallNum++;
            PopSmallLabel.Content = popSmallNum;
            UpdateSubtotal();
        }

        private void MinusPopcornLarge(object sender, RoutedEventArgs e)
        {
            if (popcornLargeNum > 0)
            {
                popcornLargeNum--;
            }
            PopcornLargeLabel.Content = popcornLargeNum;
            UpdateSubtotal();
        }

        private void MinusPopcornSmall(object sender, RoutedEventArgs e)
        {
            if (popcornSmallNum > 0)
            {
                popcornSmallNum--;
            }
            PopcornSmallLabel.Content = popcornSmallNum;
            UpdateSubtotal();
        }

        private void MinusFriesLarge(object sender, RoutedEventArgs e)
        {
            if (friesLargeNum > 0)
            {
                friesLargeNum--;
            }
            FriesLargeLabel.Content = friesLargeNum;
            UpdateSubtotal();
        }

        private void MinusFriesSmall(object sender, RoutedEventArgs e)
        {
            if (friesSmallNum > 0)
            {
                friesSmallNum--;
            }
            FriesSmallLabel.Content = friesSmallNum;
            UpdateSubtotal();
        }

        private void MinusPopLarge(object sender, RoutedEventArgs e)
        {
            if (popLargeNum > 0)
            {
                popLargeNum--;
            }
            PopLargeLabel.Content = popLargeNum;
            UpdateSubtotal();
        }

        private void MinusPopSmall(object sender, RoutedEventArgs e)
        {
            if (popSmallNum > 0)
            {
                popSmallNum--;
            }
            PopSmallLabel.Content = popSmallNum;
            UpdateSubtotal();
        }

        private void GoToPayment(object sender, RoutedEventArgs e)
        {
            App.payment.MoneyFieldFinalLabel.Content = allFieldText + foodField;
            App.payment.MoneyPriceFinalLabel.Content = "$ " + String.Format("{0:0.##}", subtotalAll + subtotalFood);

            this.Visibility = Visibility.Hidden;
            App.payment.Show();
        }

        private void BackToSeat(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.seat.Show();
        }
    }
}
