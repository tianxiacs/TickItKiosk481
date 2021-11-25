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
    /// Interaction logic for LanguageScreen.xaml
    /// </summary>
    public partial class LanguageScreen : Window
    {
        //public static string lastPage1 = "last";
        // public static Window lastSeat = new Seat();
        // lastPageSeat = MainWindow.getObject();
        public LanguageScreen()
        {
            InitializeComponent();
        }
        /*
        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            lastSeat.Show();
            
            // hide current window
            // show lastPageSeat Window
            if (lastPage == "Seat")
            {
                Seat objSeat = new Seat();
                this.Visibility = Visibility.Hidden;
                objSeat.Show();
            }
            else if (lastPage == "Ticket")
            {
                Ticket objTicket = new Ticket();
                this.Visibility = Visibility.Hidden;
                objTicket.Show();
            }
            */
        }
    }
}
