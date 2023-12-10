using Agenda_Iliana.agendailiana;
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
using System.Windows.Shapes;

namespace Agenda_Iliana
{
 
    public partial class Log : Window
    {
        public Log()
        {
            InitializeComponent();
        }

        private void BTN_Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        public IEnumerable<string> GetUsernameList()
        {
            using (var context = new AgendailianaContext())
            {
                var allUser = context.Users.Select(u => u.Username).ToList();
                return allUser;
            }
        }
        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Afficher la roue de chargement
            MySpinner.IsActive = true;
            var enteredUsername = TB_User.Text;
            var enteredPassword = new System.Net.NetworkCredential(string.Empty, TB_Password.Password).Password;

            using (var context = new AgendailianaContext())
            {
                var user = await Task.Run(() => context.Users.SingleOrDefault(u => u.Username == enteredUsername));

                if (user != null && user.Password == enteredPassword)
                {
                    // Stocker le nom d'utilisateur dans une variable accessible depuis une autre classe
                    App.Current.Properties["LoggedUsername"] = enteredUsername;

                    // Attendre 1 seconde pour simuler une connexion
                    await Task.Delay(1000);

                    // Rediriger vers la page principale
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Visibility = Visibility.Hidden;

                    // Cacher la roue de chargement
                    MySpinner.IsActive = false;
                }
                else
                {
                    // Afficher un message d'erreur
                    ErrorMessage.Text = "* Invalid username or password";

                    // Cacher la roue de chargement
                    MySpinner.IsActive = false;
                }
            }
        }


    }
}
    

