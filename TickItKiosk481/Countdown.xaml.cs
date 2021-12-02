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
using System.Windows.Threading;

namespace TickItKiosk481
{
    /// <summary>
    /// Interaction logic for Countdown.xaml
    /// </summary>
    public partial class Countdown : Window
    {
        public Countdown()
        {
            InitializeComponent();
        }

        private void StartTimer(object sender, RoutedEventArgs e)
        {
            DispatcherTimer countdown = new DispatcherTimer();
            countdown.Interval = TimeSpan.FromSeconds(1);
            countdown.Tick += decreaseTime;
            countdown.Start();
        }

        int timer_count = 240;
        private void decreaseTime(object sender, EventArgs e)
        {
            TimerLabel.Content = timer_count;
            timer_count--;
        }
    }
}
