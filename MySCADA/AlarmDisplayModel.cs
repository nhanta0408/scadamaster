using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySCADA
{
    public class AlarmDisplayModel
    {
        public string AlarmCode;
        public string AlarmDetail;

        public AlarmDisplayModel(string alarmCode, string alarmDetail)
        {
            AlarmCode = alarmCode;
            AlarmDetail = alarmDetail;

        }
        public AlarmDisplayModel()
        {

        }
    }
}
