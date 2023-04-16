using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceLibrary
{
    public interface ISelectableItem
    {
        Action<ISelectableItem> OnItemClick { get; set; }
        bool IsSelected { get; internal set; }
        internal void ItemClicked(object sender, EventArgs e);
        internal void Selected();
        internal void Deselected();
    }
}
