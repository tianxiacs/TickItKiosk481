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
    /// Interaction logic for End_Window.xaml
    /// </summary>
    public partial class EndWindow : Window
    {
        public EndWindow()
        {
            InitializeComponent();
            ReceiptPrintedLabel.Visibility = Visibility.Hidden;
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

        private void RestartSession(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.mainWindow.Show();
        }

        private void PrintReceipt(object sender, RoutedEventArgs e)
        {
            ReceiptPrintedLabel.Visibility = Visibility.Visible;
        }
    }
}
