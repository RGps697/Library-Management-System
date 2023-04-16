using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceLibrary
{
    internal class UserCatalog : ICatalog
    {
        public List<KeyValuePair<string, KeyValuePair<string, string>>> SearchableFields { get; set; }
        public ICatalogItem[] ItemControls { get; set; }

        public UserCatalog()
        {
            SearchableFields = new List<KeyValuePair<string, KeyValuePair<string, string>>>{
                new KeyValuePair<string, KeyValuePair<string, string>>("Nazwisko", new KeyValuePair<string, string>(nameof(User.Surname), "users")),
                new KeyValuePair<string, KeyValuePair<string, string>>("Imię", new KeyValuePair<string, string>(nameof(User.FirstName), "users")),
                new KeyValuePair<string, KeyValuePair<string, string>>("E-mail", new KeyValuePair<string, string>(nameof(User.Email), "users")),
                new KeyValuePair<string, KeyValuePair<string, string>>("Numer telefonu", new KeyValuePair<string, string>(nameof(User.PhoneNumber), "users"))
            };
        }

        public void FindItems(string collection, string column, string value)
        {
            List<User> foundUsers = UserCRUD.FindUsers(collection, column, value);
            for(int i = 0; i < foundUsers.Count; i++)
            {
                if (foundUsers[i].Surname == "rootadmin")
                {
                    foundUsers.RemoveAt(i);
                }
            }
            ItemControls = CreateUserItems(foundUsers);
        }

        protected virtual UserItem[] CreateUserItems(List<User> users)
        {
            UserItem[] items = new UserItem[users.Count];
            for (int i = 0; i < users.Count; i++)
            {
                items[i] = new UserItem(users.ElementAt(i));
            }
            return items;
        }
    }
}
