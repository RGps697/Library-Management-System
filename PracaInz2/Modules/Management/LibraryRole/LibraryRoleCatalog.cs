using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceLibrary
{
    internal class LibraryRoleCatalog : ICatalog
    {
        public List<KeyValuePair<string, KeyValuePair<string, string>>> SearchableFields { get; set; }
        public ICatalogItem[] ItemControls { get; set; }
                
        public LibraryRoleCatalog()
        {
            SearchableFields = new List<KeyValuePair<string, KeyValuePair<string, string>>>{
                new KeyValuePair<string, KeyValuePair<string, string>>("Nazwa", new KeyValuePair<string, string>(nameof(LibraryRole.Name), "roles"))
            };
        }

        public void FindItems(string collection, string column, string value)
        {
            List<LibraryRole> receivedLibraryRoles = LibraryRoleCRUD.FindRoles(collection, column, value);
            for (int i = 0; i < receivedLibraryRoles.Count; i++)
            {
                if (receivedLibraryRoles[i].Name == "Root Administrator")
                {
                    receivedLibraryRoles.RemoveAt(i);
                }
            }
            ItemControls = CreateLibraryRoleItems(receivedLibraryRoles);
        }

        private ICatalogItem[] CreateLibraryRoleItems(List<LibraryRole> libraryRoles)
        {
            LibraryRoleItem[] items = new LibraryRoleItem[libraryRoles.Count];
            for (int i = 0; i < libraryRoles.Count; i++)
            {
                items[i] = new LibraryRoleItem(libraryRoles.ElementAt(i));
            }
            return items;
        }

        internal void DeleteFromList(ICatalogItem item)
        {
            ItemControls = ItemControls.Where(x => !x.Equals(item)).ToArray();
        }
    }
}
