using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySCADA
{

    public class DisplayTag
    {
        public string Name;
        public string Address;      //Quy ước nó sẽ trỏ vô ID của Tag nằm trong Task
        public int Value;           //Ví dụ "Task_1.Tag_1"
        public string Quality;
        public DateTime TimeStamp;
        public Display Parent;

        public DisplayTag(string name, string addrress)
        {
            Name = name;
            Address = addrress;
        }
    }
}
