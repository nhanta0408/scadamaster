using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySCADA
{
    public class Display
    {
        public string Name;
        int Period;
        System.Timers.Timer UpdateTimer = null;
        public ArrayList Tags = new ArrayList();    //Tags đồ họa
        public SCADA Parent;

        public Display(string name, int period)
        {
            Name = name;
            Period = period;
        }
        public void AddTag(DisplayTag tag)
        {
            tag.Parent = this;
            Tags.Add(tag);
        }
        public void Engine()        //Tạo Timer và update cho cái Timer đó
        {
            UpdateTimer = new System.Timers.Timer(Period);
            UpdateTimer.AutoReset = true;
            UpdateTimer.Elapsed += new System.Timers.ElapsedEventHandler(UpdateTags);
            UpdateTimer.Start();
        }
        void UpdateTags(object sender, System.Timers.ElapsedEventArgs e)
        {
            for (int i = 0; i < Tags.Count; i++)    //Dùng for để tìm kiến
            {
                DisplayTag dtag = (DisplayTag)Tags[i];
                string[] temp = dtag.Address.Split('.');    //Cắt address thành TaskName và TagName
                Task task = Parent.FindTask(temp[0]);       //Parent là SCADA
                if (task != null)
                {
                    Tag tag = task.FindTag(temp[1]);        //Nhờ task find Tag
                    if (tag != null)
                    {
                        dtag.Value = tag.Value;
                        dtag.Quality = tag.Quality;
                        dtag.TimeStamp = tag.TimeStamp;

                    }
                }
            }

            //// Monitoring
            Console.Clear();
            Console.WriteLine("SCADA Monitoring at Pump and Flow areas:");
            Console.WriteLine("==========================================");
            for (int i = 0; i < Tags.Count; i++)
            {
                DisplayTag dtag = (DisplayTag)Tags[i];
                Console.WriteLine(dtag.Name + ":\t" + dtag.Value.ToString() +
                    "\t" + dtag.Quality + "\t" + dtag.TimeStamp.ToLongTimeString());
            }
        }
    }
}
