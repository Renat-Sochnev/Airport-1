using Airport.DB;
using Airport.Pages;
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
    /// Логика взаимодействия для AllTeamsPage.xaml
    /// </summary>
    public partial class AllTeamsPage : Page
    {
        public static List<Team> teams { get; set; }
        public static List<Worker> workers { get; set; }
        public static Worker loggedUser;

        public AllTeamsPage()
        {
            InitializeComponent();
            workers = DBConnection.airportEntities.Worker.ToList();
            loggedUser = DBConnection.loginedWorker;
            this.DataContext = this;
            Refresh();
        }

        private void Refresh()
        {
            TeamLV.ItemsSource = DBConnection.airportEntities.Team.ToList();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }
        private void AddWorkerBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddTeamPage());
        }

        private void DeleteWorkerBTN_Click(object sender, RoutedEventArgs e)
        {
            if (TeamLV.SelectedItem is Worker work)
            {
                DBConnection.airportEntities.Worker.Remove(work);
                DBConnection.airportEntities.SaveChanges();
                Refresh();
            }
        }
        private void EditWorkerBTN_Click(object sender, RoutedEventArgs e)
        {
            if (TeamLV.SelectedItem is Team team)
            {
                TeamLV.SelectedItem = null;
                NavigationService.Navigate(new EditTeamPage(team));
            }
        }
    }
}

