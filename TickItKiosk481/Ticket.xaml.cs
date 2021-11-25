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
    }
}
