using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceLibrary
{
    internal interface ICatalogItem : ISelectableItem
    {
        internal ILibraryItem ContainedItem { get; set; }
        internal void OnHover(object sender, EventArgs e);
        internal void OnLeave(object sender, EventArgs e);
    }
}
