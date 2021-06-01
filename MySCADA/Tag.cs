using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySCADA
{
    public class Tag
    {
        public string Name;
        public string Address;
        public dynamic Value;
        public string Quality;
        public DateTime TimeStamp;
        public Task Parent;
        public Tag(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public Tag(string name, dynamic value, string quality, DateTime timestamp)
        {
            Name = name;
            Value = value;
            Quality = quality;
            TimeStamp = timestamp;
        }
    }
}
