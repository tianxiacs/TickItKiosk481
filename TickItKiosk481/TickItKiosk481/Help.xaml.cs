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
    /// Interaction logic for Help.xaml
    /// </summary>
    public partial class Help : Window
    {
        public static Window lastPage;
        public Help()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            lastPage.Show();
        }
    }
}
