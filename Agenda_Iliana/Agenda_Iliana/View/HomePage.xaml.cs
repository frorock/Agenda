using Agenda_Iliana.agendailiana;
using Agenda_Iliana.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace Agenda_Iliana.View
{

    public partial class HomePage : UserControl
    {
        DAO_HomePage dataHandler = new DAO_HomePage();
        string loggedUsername = App.Current.Properties["LoggedUsername"] as string;


        public HomePage()
        {
            InitializeComponent();
            membersDataGrid.ItemsSource = dataHandler.GetFriendData();
            TB_Counter.Text = dataHandler.GetFriendData().Count().ToString() + " total contacts";
        }

        private void FriendButton_Click(object sender, RoutedEventArgs e)
        {
            membersDataGrid.ItemsSource = dataHandler.GetFriend();
            TB_Counter.Text = dataHandler.GetFriend().Count().ToString() + " total contacts";
        }

        private void FamilyButton_Click(object sender, RoutedEventArgs e)
        {
            membersDataGrid.ItemsSource = dataHandler.GetFamily();
            TB_Counter.Text = dataHandler.GetFamily().Count().ToString() + " total contacts";
        }

        private void OfficeButton_Click(object sender, RoutedEventArgs e)
        {
            membersDataGrid.ItemsSource = dataHandler.GetOffice();
            TB_Counter.Text = dataHandler.GetOffice().Count().ToString() + " total contacts";

        }
        private void AllButton_Click(object sender, RoutedEventArgs e)
        {
            membersDataGrid.ItemsSource = dataHandler.GetFriendData();
            TB_Counter.Text = dataHandler.GetFriendData().Count().ToString() + " total contacts";
        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text))
            {
                using (var context = new AgendailianaContext())
                {
                    var currentUser = context.Users.Single(u => u.Username == loggedUsername);
                    membersDataGrid.ItemsSource = context.Friend0s.Where(f => f.UserId == currentUser.Id).ToList();
                }
            }

            else
            {
                using (var context = new AgendailianaContext())
                {
                    var currentUser = context.Users.Single(u => u.Username == loggedUsername);
                    membersDataGrid.ItemsSource = context.Friend0s.Where(f => f.UserId == currentUser.Id && f.FirstName.ToUpper().StartsWith(textBoxSearch.Text.ToUpper())).ToList();
                }
            }
        }



        private void AddFriendButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            ClientPopup.IsOpen = true;
        }

        private void EditFriendButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            ClientPopup.IsOpen = true;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

            using (var context = new AgendailianaContext())
            {
                // Déclarer une variable pour stocker la liste active
                List<Friend0> activeList;

                // Récupérer l'ami à supprimer à partir du bouton cliqué 
                var button = sender as Button;
                var friend = membersDataGrid.SelectedItem as Friend0;
                var friendId = friend?.Id;

                if (friendId != null)
                {

                    if (Friend_Button.IsChecked == true || Family_Button.IsChecked == true || Office_Button.IsChecked == true)
                    {
                        var groupeToDelete = context.Groupes.SingleOrDefault(f => f.FriendId == friendId.ToString());
                        context.Groupes.Remove(groupeToDelete);
                    }

                    else
                    {
                        // Supprimer l'ami de la table 
                        var friendToDelete = context.Friend0s.SingleOrDefault(f => f.Id == friendId);
                        context.Friend0s.Remove(friendToDelete);
                    }
                    context.SaveChanges();

                    // Rafraîchir la liste 
                    switch (true)
                    {
                        case bool _ when Friend_Button.IsChecked == true:
                            membersDataGrid.ItemsSource = dataHandler.GetFriend();
                            break;
                        case bool _ when Family_Button.IsChecked == true:
                            membersDataGrid.ItemsSource = dataHandler.GetFamily();
                            break;
                        case bool _ when Office_Button.IsChecked == true:
                            membersDataGrid.ItemsSource = dataHandler.GetOffice();
                            break;
                        default:
                            membersDataGrid.ItemsSource = dataHandler.GetFriendData();
                            break;
                    }
                }
            }
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new AgendailianaContext())
            {
                if (loggedUsername != null)
                {
                    var button = sender as Button;
                    var friend = membersDataGrid.SelectedItem as Friend0;
                    var groupe = membersDataGrid.SelectedItem as Groupe;

                    var friendId = friend?.Id;
                    var groupeId = groupe?.FriendId;

                    // Récupérer l'utilisateur connecté 
                    var currentUser = context.Users.Single(u => u.Username == loggedUsername);
                    var friendToEdit = context.Friend0s.SingleOrDefault(f => f.Id == friendId);

                    if (friendId != null)
                    {
                        // Mettre à jour les propriétés de Friend0 en fonction des textboxes 
                        foreach (var property in typeof(Friend0).GetProperties())
                        {
                            var textbox = FindName("TB_" + property.Name) as TextBox;

                            if (!string.IsNullOrWhiteSpace(textbox?.Text) && friendToEdit != null)
                            {
                                property.SetValue(friendToEdit, textbox.Text);
                            }
                        }
                    }
                    else
                    {
                        // Créer un nouvel ami 
                        var newFriend = new Friend0
                        {
                            UserId = currentUser.Id,
                            LastName = TB_Name.Text,
                            FirstName = TB_Prenom.Text,
                            Address = TB_FriendAddress.Text,
                            Email = TB_FriendEmail.Text,
                            Phone = TB_FriendPhone.Text,
                        };

                        // Ajouter le nouvel ami à la table "Friend" appropriée pour l'utilisateur connecté 
                        context.Friend0s.Add(newFriend);

                        // Enregistrer les modifications dans la base de données 
                        context.SaveChanges();

                        // Mettre à jour l'ID de l'ami nouvellement créé
                        friendId = newFriend.Id;
                    }

                    if (groupeId != null)
                    {
                        // Mettre à jour les informations du groupe
                        var groupeToUpdate = context.Groupes.SingleOrDefault(g => g.FriendId == friendId.ToString());

                        if (groupeToUpdate != null)
                        {
                            groupeToUpdate.Family = FamilyCheckBox.IsChecked == true;
                            groupeToUpdate.Friend = FriendCheckBox.IsChecked == true;
                            groupeToUpdate.Office = OfficeCheckBox.IsChecked == true;
                        }
                    }
                    else
                    {
                        // Créer un nouveau groupe et l'ajouter à la table "Groupe"
                        var newGroup = new Groupe
                        {
                            FriendId = friendId.ToString(),
                            Family = FamilyCheckBox.IsChecked == true,
                            Friend = FriendCheckBox.IsChecked == true,
                            Office = OfficeCheckBox.IsChecked == true,
                        };

                        context.Groupes.Add(newGroup);
                    }

                    // Enregistrer les modifications dans la base de données 
                    context.SaveChanges();

                    // Recharger la liste des amis 
                    membersDataGrid.ItemsSource = dataHandler.GetFriendData();
                }

                FamilyCheckBox.IsChecked = false;
                FriendCheckBox.IsChecked = false;
                OfficeCheckBox.IsChecked = false;
            }

            ClientPopup.IsOpen = false;
        }


        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }

    }   
}

 