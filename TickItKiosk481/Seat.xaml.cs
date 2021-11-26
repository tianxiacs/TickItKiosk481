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
        public Seat()
        {
            InitializeComponent();
        }

        private void BackToTicket(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.ticket.Show();
        }

        private void GetLanuage(object sender, RoutedEventArgs e)
        {
            LanguageScreen.lastPage = "Seat";
            LanguageScreen objLanguageScreen = new LanguageScreen();
            this.Visibility = Visibility.Hidden;
            objLanguageScreen.Show();
        }

        private void GetHelp(object sender, RoutedEventArgs e)
        {
            Help.lastPage = "Seat";
            Help objHelp = new Help();
            this.Visibility = Visibility.Hidden;
            objHelp.Show();
        }
    }
}
