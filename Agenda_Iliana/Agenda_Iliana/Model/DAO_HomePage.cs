using Agenda_Iliana.agendailiana;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Iliana.Model
{
    class DAO_HomePage
    {
        string loggedUsername = App.Current.Properties["LoggedUsername"] as string;


        public IEnumerable<Friend0> GetFriendData()
        {
            using (var context = new AgendailianaContext())
            {
                if (loggedUsername != null)
                {
                    var currentUser = context.Users.SingleOrDefault(u => u.Username == loggedUsername);

                    if (currentUser == null)
                    {
                        // Handle case when user is not found
                        return null;
                    }

                    // Check if the Friend table exists
                    var tableName = $"Friend_{currentUser.Id}";
                    var tableExists = context.Database.ExecuteSqlRaw($"SHOW TABLES LIKE '{tableName}'") > 0;

                    if (!tableExists)
                    {
                        // Handle case when the Friend table does not exist
                        return null;
                    }

                    var friends = context.Friend0s.Where(f => f.UserId == currentUser.Id).ToList();
                    return friends;
                }
                return null;
            }
        }


        public IEnumerable<Friend0> GetFriend()
        {
            using (var context = new AgendailianaContext())
            {
                var friends = context.Friend0s
                    .Join(context.Groupes, f => f.Id.ToString(), g => g.FriendId, (f, g) => new { Friend = f, Groupe = g })
                    .Where(x => x.Groupe.Friend == true && x.Groupe.FriendId == x.Friend.Id.ToString())
                    .Select(x => x.Friend)
                    .ToList();
                return friends;
            }
        }

        public IEnumerable<Friend0> GetOffice()
        {
            using (var context = new AgendailianaContext())
            {
                var offices = context.Friend0s
                    .Join(context.Groupes, f => f.Id.ToString(), g => g.FriendId, (f, g) => new { Friend = f, Groupe = g })
                    .Where(x => x.Groupe.Office == true && x.Groupe.FriendId == x.Friend.Id.ToString())
                    .Select(x => x.Friend)
                    .ToList();
                return offices;
            }
        }

        public IEnumerable<Friend0> GetFamily()
        {
            using (var context = new AgendailianaContext())
            {
                var family = context.Friend0s
                    .Join(context.Groupes, f => f.Id.ToString(), g => g.FriendId, (f, g) => new { Friend = f, Groupe = g })
                    .Where(x => x.Groupe.Family == true && x.Groupe.FriendId == x.Friend.Id.ToString())
                    .Select(x => x.Friend)
                    .ToList();
                return family;
            }
        }
    }
}
