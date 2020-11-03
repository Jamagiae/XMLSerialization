using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLSerialization
{
    [Serializable]
     public class Employee // NOTE YOU CANNOT SERIALIZE PRIVATE FIELDS
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double SSNumber { get; set; }
        public DateTime EntryDate { get; set; } // using DateTime method. Predefined method method in .NET Framework
    }
}
