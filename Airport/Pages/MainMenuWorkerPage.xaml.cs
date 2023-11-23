using Airport.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Airport.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainMenuWorkerPage.xaml
    /// </summary>
    public partial class MainMenuWorkerPage : Page
    {
        public static List<Worker> workers { get; set; }
        public static Worker loggedUser;

        public MainMenuWorkerPage()
        {
            InitializeComponent();
            Worker w = DBConnection.loginedWorker;
            UserTB.Text = $"{w.Surname} {w.Name} {w.Patronymic}";
            workers = new List<Worker>(DBConnection.airportEntities.Worker.ToList());
            loggedUser = DBConnection.loginedWorker;
            this.DataContext = this;
        }

        private void WorkersBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllWorkersPage());
        }

        private void ClientsBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllClientPage());
        }

        private void FlightsBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlightsPage());
        }

        private void AirplaneBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllAirplanesPage());
        }

        private void AircompanyBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllAircompaniesPage());
        }

        private void CountryBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllCountriesPage());
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }
    }
}

