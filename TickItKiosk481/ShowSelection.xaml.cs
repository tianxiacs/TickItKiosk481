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
    /// Interaction logic for Show_Selection.xaml
    /// </summary>
    public partial class ShowSelection : Window
    {
        public ShowSelection()
        {
            InitializeComponent();
        }

        private void SelectVenom(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.timeSelection.Show();
            TimeSelection.showName = "Venom";
            App.timeSelection.ShowSelectionTitle.Content = "Venom";
            App.ticket.TicketTitleLabel.Content = "Venom";

            App.ticket.DunkirkPoster.Visibility = Visibility.Hidden;
            App.ticket.VenomPoster.Visibility = Visibility.Visible;
            App.ticket.YourNamePoster.Visibility = Visibility.Hidden;

            App.timeSelection.PosterDunkirk.Visibility = Visibility.Hidden;
            App.timeSelection.PosterVenom.Visibility = Visibility.Visible;
            App.timeSelection.PosterYourName.Visibility = Visibility.Hidden;

            App.timeSelection.MovieIntro.Text = "While trying to take down Carlton, the CEO of Life Foundation, Eddie, a journalist, investigates experiments of human trials. Unwittingly, he gets merged with a symbiotic alien with lethal abilities.";
        }

        private void ScanMemberShow(object sender, RoutedEventArgs e)
        {
            MemberScan.skipNextPage = this;
            MemberWelcome.nextPage = this;
            this.Visibility = Visibility.Hidden;
            App.memberScan.Show();
        }

        private void SelectYourName(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.timeSelection.Show();
            TimeSelection.showName = "Your Name";
            App.timeSelection.ShowSelectionTitle.Content = "Your Name";
            App.ticket.TicketTitleLabel.Content = "Your Name";

            App.ticket.DunkirkPoster.Visibility = Visibility.Hidden;
            App.ticket.VenomPoster.Visibility = Visibility.Hidden;
            App.ticket.YourNamePoster.Visibility = Visibility.Visible;

            App.timeSelection.PosterDunkirk.Visibility = Visibility.Hidden;
            App.timeSelection.PosterVenom.Visibility = Visibility.Hidden;
            App.timeSelection.PosterYourName.Visibility = Visibility.Visible;

            App.timeSelection.MovieIntro.Text = "Two teenagers share a profound, magical connection upon discovering they are swapping bodies. Things manage to become even more complicated when the boy and girl decide to meet in person.";
        }

        private void SelectDunkirk(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            App.timeSelection.Show();
            TimeSelection.showName = "Dunkirk";
            App.timeSelection.ShowSelectionTitle.Content = "Dunkirk";
            App.ticket.TicketTitleLabel.Content = "Dunkirk";

            App.ticket.DunkirkPoster.Visibility = Visibility.Visible;
            App.ticket.VenomPoster.Visibility = Visibility.Hidden;
            App.ticket.YourNamePoster.Visibility = Visibility.Hidden;

            App.timeSelection.PosterDunkirk.Visibility = Visibility.Visible;
            App.timeSelection.PosterVenom.Visibility = Visibility.Hidden;
            App.timeSelection.PosterYourName.Visibility = Visibility.Hidden;

            App.timeSelection.MovieIntro.Text = "In May 1940, Germany advanced into France, trapping Allied troops on the beaches of Dunkirk. At the end of this heroic mission, 330,000 French, British, Belgian and Dutch soldiers were safely evacuated.";
        }

    }
}
