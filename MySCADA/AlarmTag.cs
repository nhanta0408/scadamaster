using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySCADA
{
    public class AlarmTag
    {
        public string Name { get; set; }
        public DateTime Timestamp { get; set; }
        public dynamic Value { get; set; }
        public string AlarmCode { get; set; }
        public string Detail { get; set; }
        public AlarmTag(string name, DateTime timestamp, dynamic value, string alarmCode)
        {
            Name = name;
            Timestamp = timestamp;
            Value = value;
            AlarmCode = alarmCode;
        }

    }
}
