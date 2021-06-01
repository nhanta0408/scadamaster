using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySCADA
{
    public class Alarm
    {
        public SCADA Parent = null;
        public string Name;
        public List<AlarmTag> alarmTag = new List<AlarmTag>();
        const int lowlow = 10, low = 20, high = 80, highhigh = 90;
        public Alarm(string name)
        {
            Name = name;
        }
        public void CheckAlarmLevel(AlarmTag tag)
        {
            if (alarmTag == null || alarmTag.Count == 0)
            {
                if (tag.Value >= highhigh)
                {
                    tag.AlarmCode = "HH";
                    tag.Detail = "Mức nước đang là High High";
                    alarmTag.Add(tag);

                }
                else if (tag.Value >= high && tag.Value < highhigh)
                {

                    tag.AlarmCode = "H";
                    tag.Detail = "Mức nước đang là High";
                    alarmTag.Add(tag);

                }
                else if (tag.Value >= low && tag.Value < high)
                {

                    tag.AlarmCode = "N";
                    tag.Detail = "Mức nước đang là Normal";
                    alarmTag.Add(tag);

                }
                else if (tag.Value >= lowlow && tag.Value < low)
                {

                    tag.AlarmCode = "L";
                    tag.Detail = "Mức nước đang là Low";
                    alarmTag.Add(tag);

                }
                else if (tag.Value >= 0 && tag.Value < lowlow)
                {

                    tag.AlarmCode = "LL";
                    tag.Detail = "Mức nước đang là Low Low";
                    alarmTag.Add(tag);

                }
            }
            else
            {
                if (tag.Value >= highhigh)
                {
                    if (alarmTag.Last().AlarmCode != "HH")
                    {
                        tag.AlarmCode = "HH";
                        tag.Detail = "Mức nước đang là High High";
                        alarmTag.Add(tag);
                    }
                }
                else if (tag.Value >= high && tag.Value < highhigh)
                {
                    if (alarmTag.Last().AlarmCode != "H")
                    {
                        tag.AlarmCode = "H";
                        tag.Detail = "Mức nước đang là High";
                        alarmTag.Add(tag);
                    }
                }
                else if (tag.Value >= low && tag.Value < high)
                {
                    if (alarmTag.Last().AlarmCode != "N")
                    {
                        tag.AlarmCode = "N";
                        tag.Detail = "Mức nước đang là Normal";
                        alarmTag.Add(tag);
                    }
                }
                else if (tag.Value >= lowlow && tag.Value < low)
                {
                    if (alarmTag.Last().AlarmCode != "L")
                    {
                        tag.AlarmCode = "L";
                        tag.Detail = "Mức nước đang là Low";
                        alarmTag.Add(tag);
                    }
                }
                else if (tag.Value >= 0 && tag.Value < lowlow)
                {
                    if (alarmTag.Last().AlarmCode != "LL")
                    {
                        tag.AlarmCode = "LL";
                        tag.Detail = "Mức nước đang là Low Low";
                        alarmTag.Add(tag);
                    }
                }
            }

        }
    }
}
