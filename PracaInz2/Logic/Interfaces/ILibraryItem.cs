using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public interface ILibraryItem
    {
        public MongoDB.Bson.ObjectId Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
