﻿using System;
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
    /// Interaction logic for Help.xaml
    /// </summary>
    public partial class Help : Window
    {
        public static string lastPage = "last";
        public Help()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            if (lastPage == "Seat")
            {
                Seat objSeat = new Seat();
                this.Visibility = Visibility.Hidden;
                objSeat.Show();
            }else if (lastPage == "Ticket")
            {
                Ticket objTicket = new Ticket();
                this.Visibility = Visibility.Hidden;
                objTicket.Show();
            }
        }
    }
}