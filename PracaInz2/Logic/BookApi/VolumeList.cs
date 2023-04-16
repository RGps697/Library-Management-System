using System.Collections.Generic;

namespace LogicLibrary
{
    public class VolumeList
    {
        public string kind { get; set; }
        public List<Volume> items { get; set; }
        public int totalItems { get; set; }
    }
}
