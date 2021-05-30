using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MySCADA.Program;

namespace MySCADA
{
    public class Task
    {
        public SCADA Parent = null;
        public string Name;
        int Period; //Private, gán 1 giá trị fixed luôn, không cho can thiệp từ bên ngoài
        System.Timers.Timer UpdateTimer = null;
        public ArrayList Tags = new ArrayList();

        public Task(string name, int period)
        {
            Name = name;
            Period = period;
        }

        public void AddTag(Tag tag)     //Hàm add phần tử, sẵn tiện trỏ luôn chính nó làm parent
        {
            tag.Parent = this;
            Tags.Add(tag);
        }
        public Tag FindTag(string name)
        {
            Tag tag = null;
            for (int i = 0; i < Tags.Count; i++)
            {
                tag = (Tag)Tags[i];     //ép kiểu
                if (tag.Name == name)    //Nếu tag có tên trùng với tên cần tìm
                    return tag;
            }
            return null;
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
            
            for (int i = 0; i < Tags.Count; i++)
            {
                Tag tag = (Tag)Tags[i];
                string[] temp_result_slit = tag.Address.Split('.');
                string obj = temp_result_slit[0];
                string signal = temp_result_slit[1];
                switch (obj)
                {
                    case "Motor_1":
                        switch (signal)
                        {
                            case "Mode":
                                tag.Value = Parent.S71500.Motor_1.Mode; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now; 
                                break;
                            case "Start":
                                tag.Value = Parent.S71500.Motor_1.Start; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Stop":
                                tag.Value = Parent.S71500.Motor_1.Stop; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "RunFB":
                                tag.Value = Parent.S71500.Motor_1.RunFB; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Reset":
                                tag.Value = Parent.S71500.Motor_1.Reset; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Fault":
                                tag.Value = Parent.S71500.Motor_1.Fault; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Pos":
                                tag.Value = Parent.S71500.Motor_1.Pos; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now;
                                break;

                        }
                        break;
                    case "Motor_2":
                        switch (signal)
                        {
                            case "Mode":
                                tag.Value = Parent.S71500.Motor_2.Mode; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Start":
                                tag.Value = Parent.S71500.Motor_2.Start; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Stop":
                                tag.Value = Parent.S71500.Motor_2.Stop; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "RunFB":
                                tag.Value = Parent.S71500.Motor_2.RunFB; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Reset":
                                tag.Value = Parent.S71500.Motor_2.Reset; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Fault":
                                tag.Value = Parent.S71500.Motor_2.Fault; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Pos":
                                tag.Value = Parent.S71500.Motor_2.Pos; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now;
                                break;
                        }
                        break;
                        case "Valve":
                        switch (signal)
                        {
                            case "Mode":
                                tag.Value = Parent.S71500.Valve.Mode; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Start":
                                tag.Value = Parent.S71500.Valve.Start; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Stop":
                                tag.Value = Parent.S71500.Valve.Stop; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "RunFB":
                                tag.Value = Parent.S71500.Valve.RunFB; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Reset":
                                tag.Value = Parent.S71500.Valve.Reset; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Fault":
                                tag.Value = Parent.S71500.Valve.Fault; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Pos":
                                tag.Value = Parent.S71500.Valve.Pos; //Parent là SCADA
                                tag.Quality = "Good";
                                tag.TimeStamp = DateTime.Now;
                                break;
                        }
                        break;
                    default:
                        break;
                }
                            }
        }

        public void Sleep()
        {
            if (UpdateTimer != null)
            {
                UpdateTimer.Stop();
            }
        }

        public void Resume()
        {
            if (UpdateTimer != null)
            {
                UpdateTimer.Start();
            }
        }
        public void Kill()
        {
            if (UpdateTimer != null)
            {
                UpdateTimer.Dispose();
                UpdateTimer = null;     //Nhớ dispose xong thì gán nó lại bằng null
            }
        }

    }
}
