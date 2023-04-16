using System;
using System.Windows.Forms;

namespace UserInterfaceLibrary
{
    public partial class SelectableItemPanel : UserControl
    {
        public ISelectableItem SelectedItem { get; set; }

        public SelectableItemPanel()
        {
            InitializeComponent();
            BackColor = UIColors.SelectableItemPanelListColor;
        }

        public void SelectItem(ISelectableItem item)
        {
            if(SelectedItem != null)
            {
                SelectedItem.Deselected();
                SelectedItem.IsSelected = false;
            }
            SelectedItem = item;
            item.Selected();
            item.IsSelected = true;
            Console.WriteLine($"Selected: {SelectedItem}");
        }

        public void DeselectItem()
        {
            if (SelectedItem != null)
            {
                SelectedItem.Deselected();
                SelectedItem.IsSelected = false;
            }
        }

        public T GetSelectedItem<T>()
        {
            return (T)SelectedItem;
        }

        public void AddItem(ISelectableItem item, bool reload = false)
        {
            item.OnItemClick = SelectItem;
            if (reload) itemList.Controls.Clear();
            itemList.Controls.Add((Control)item);
        }

        public void AddItems(ISelectableItem[] items, bool reload = false)
        {
            if (reload) itemList.Controls.Clear();

            for (int i = 0; i < items.Length; i++)
            {
                items[i].OnItemClick = SelectItem;
            }
            itemList.Controls.Clear();
            itemList.Controls.AddRange((Control[])items);
        }

        public void DeleteSelectedItem()
        {
            if (SelectedItem != null)
            {
                itemList.Controls.Remove((Control)SelectedItem);
            }
        }

        public void ClearList()
        {
            itemList.Controls.Clear();
        }

    }
}
