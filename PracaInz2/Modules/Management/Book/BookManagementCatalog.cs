using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceLibrary
{
    internal class BookManagementCatalog : BookCatalog
    {
        protected override BookItem[] CreateBookItems(List<Book> books)
        {
            BookItem[] items = new BookItem[books.Count];
            for (int i = 0; i < books.Count; i++)
            {
                items[i] = new BookItem(books.ElementAt(i), openCreator: true);

            }
            return items;
        }

        public void DeleteFromList(ICatalogItem item)
        {
            ItemControls = ItemControls.Where(x => !x.Equals(item)).ToArray();
        }
    }
}
