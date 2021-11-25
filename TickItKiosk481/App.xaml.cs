using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TickItKiosk481
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MainWindow mainWindow = new MainWindow();
        public static MemberSkip memberSkip = new MemberSkip();
        public static MemberScan memberScan = new MemberScan();
        public static MemberWelcome memberWelcome = new MemberWelcome();
        public static ShowSelection showSelection = new ShowSelection();
        public static TimeSelection timeSelection = new TimeSelection();
        public static Ticket ticket = new Ticket();
        public static Seat seat = new Seat();
        public static Countdown countDown = new Countdown();
        public static Food food = new Food();
        public static Payment payment = new Payment();
        public static CreditDebitPayment cdp = new CreditDebitPayment();
        public static GiftPayment giftPayment = new GiftPayment();
        public static LanguageScreen languageScreen = new LanguageScreen();
        public static Help help = new Help();
        public static Timeout timeOut = new Timeout();
        public static EndWindow endWindow = new EndWindow();

    }
}
