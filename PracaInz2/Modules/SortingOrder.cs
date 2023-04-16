using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceLibrary
{
    public class SortingOrder
    {
        private string name;
        public string Name 
        {
            get
            {
                return IsAscending ? $"{name}(↑)" : $"{name}(↓)";
            }
            set
            {
                name = value;
            }
        }

        internal string SortingField { get; set; }
        internal bool IsAscending { get; set; }

        internal SortingOrder(string name, string sortingField, bool isAscending)
        {
            Name = name;
            SortingField = sortingField;
            IsAscending = isAscending;
        }
    }
}
