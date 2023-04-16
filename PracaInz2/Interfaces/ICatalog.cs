using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceLibrary
{
    internal interface ICatalog
    {
        internal List<KeyValuePair<string, KeyValuePair<string, string>>> SearchableFields { get; set; }
        internal ICatalogItem[] ItemControls { get; set; }
        internal void FindItems(string collection, string column, string value);
    }
}
