
using Agenda_Iliana.View;
using System.Windows;
using System.Windows.Input;


namespace Agenda_Iliana
{

    public partial class MainWindow : Window
    {
        string loggedUsername = App.Current.Properties["LoggedUsername"] as string;

        public MainWindow()
        {
            InitializeComponent();
            if (loggedUsername == null)
            {
                // Rediriger vers la page principale
                Log mainWindow = new Log();
                mainWindow.Show();
                this.Visibility = Visibility.Hidden;
            }
            else
            {
                TB_UserName.Text = loggedUsername.ToUpper();
                HomePage homePage = new HomePage();
                Conteneur.Children.Add(homePage);
            }
        }
        //Permet de bouger la fenetre
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void EventsButton_Click(object sender, RoutedEventArgs e)
        {
            Conteneur.Children.Clear();
            CalendarView calendarView = new CalendarView();
            Conteneur.Children.Add(calendarView);
        }
        private void ContactsButton_Click(object sender, RoutedEventArgs e)
        {
            Conteneur.Children.Clear();
            HomePage homePage = new HomePage();
            Conteneur.Children.Add(homePage);
        }
        

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }

    }
}