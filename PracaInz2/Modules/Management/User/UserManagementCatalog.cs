using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceLibrary
{
    internal class UserManagementCatalog : UserCatalog
    {
        protected override UserItem[] CreateUserItems(List<User> users)
        {
            UserItem[] items = new UserItem[users.Count];
            for (int i = 0; i < users.Count; i++)
            {
                items[i] = new UserItem(users.ElementAt(i), true);
            }
            return items;
        }

        internal void DeleteFromList(ICatalogItem item)
        {
            ItemControls = ItemControls.Where(x => !x.Equals(item)).ToArray();
        }
    }
}
