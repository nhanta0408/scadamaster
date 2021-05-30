using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySCADA
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Welcome to Very Simple SCADA Kernel");
        //    Console.WriteLine("The program helps to learn");
        //    Console.WriteLine("SCADA Design and Programming");
        //    Console.WriteLine("Press any key to continue");
        //    Console.ReadKey();

        //    //Trước hết tạo phần cao nhất là SCADA
        //    SCADA Root = new SCADA();
        //    //Tạo Task
        //    Task Task1 = new Task("Task_1", 100);
        //    //Tạo các Tag
        //    Tag Tag11 = new Tag("Pump_1_Speed", 1000);
        //    Tag Tag12 = new Tag("Pump_2_Speed", 2000);
        //    Tag Tag13 = new Tag("Pump_3_Speed", 3000);
        //    Tag Tag14 = new Tag("Pump_1_CMD", 1000000);
        //    //Add các con vào Parent
        //    Root.AddTask(Task1);
        //    Task Task2 = new Task("Task_2", 1000);
        //    Tag Tag21 = new Tag("Flow_1_Speed", 40000);
        //    Tag Tag22 = new Tag("Flow_2_Speed", 50000);
        //    Tag Tag23 = new Tag("Flow_3_Speed", 60000);
        //    Task2.AddTag(Tag21);
        //    Task2.AddTag(Tag22);
        //    Task2.AddTag(Tag23);
        //    Root.AddTask(Task2);

        //    Task1.AddTag(Tag11);
        //    Task1.AddTag(Tag12);
        //    Task1.AddTag(Tag13);
        //    Task1.AddTag(Tag14);
        //    Root.RunTask("Task_1");
        //    Root.RunTask("Task_2");



        //    Display Display1 = new Display("Display_1", 100); //100ms cập nhật 1 lần
        //    DisplayTag dTag11 = new DisplayTag("Pump_1_Speed", "Task_1.Pump_1_Speed"); //Địa chỉ phải gõ cả name Task và name Tag
        //    DisplayTag dTag12 = new DisplayTag("Pump_2_Speed", "Task_1.Pump_2_Speed");
        //    DisplayTag dTag13 = new DisplayTag("Pump_3_Speed", "Task_1.Pump_3_Speed");
        //    DisplayTag dTag17 = new DisplayTag("Pump_1_CMD", "Task_1.Pump_1_CMD");

        //    Display1.AddTag(dTag11);
        //    Display1.AddTag(dTag12);
        //    Display1.AddTag(dTag13);

        //    DisplayTag dTag14 = new DisplayTag("Flow_1_Speed", "Task_2.Flow_1_Speed"); //Địa chỉ phải gõ cả name Task và name Tag
        //    DisplayTag dTag15 = new DisplayTag("Flow_2_Speed", "Task_2.Flow_2_Speed");
        //    DisplayTag dTag16 = new DisplayTag("Flow_3_Speed", "Task_2.Flow_3_Speed");

        //    Display1.AddTag(dTag14);
        //    Display1.AddTag(dTag15);
        //    Display1.AddTag(dTag16);
        //    Display1.AddTag(dTag17);

        //    Root.AddDisplay(Display1);
        //    Root.RunDisplay("Display_1");
        //    Console.ReadKey();

        //    //Root.SleepTask("Task_1");
        //    //Console.ReadKey();
        //    //Root.SleepTask("Task_2");
        //    //Console.ReadKey();
        //    //Root.ResumeTask("Task_1");
        //    //Console.ReadKey();
        //    //Root.ResumeTask("Task_2");
        //    //Console.ReadKey();
        //    //Root.KillTask("Task_1");
        //    //Console.ReadKey();
        //    //Root.ResumeTask("Task_1");
        //    //Console.ReadKey();



        //    Console.ReadKey();
        //}

        public class Tag
        {
            public string Name;
            public int Address;
            public int Value;
            public string Quality;
            public DateTime TimeStamp;
            public Task Parent;
            public Tag(string name, int address)
            {
                Name = name;
                Address = address;
            }

        }
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
                // Simulation
                Random r = new Random();
                for (int i = 0; i < Tags.Count; i++)
                {
                    Tag tag = (Tag)Tags[i];
                    if (tag.Address < 100000)
                    {
                        int temp = r.Next(0, 1000);
                        tag.Value = temp + tag.Address;
                        tag.Quality = "GOOD";
                        tag.TimeStamp = DateTime.Now;
                    }
                    //else
                    //{
                    //    int temp = r.Next(0, 1000);
                    //    if (temp > 500)
                    //        tag.Value = 1;
                    //    else
                    //        tag.Value = 0;
                    //    //tag.Value = temp + tag.Address;
                    //    tag.Quality = "GOOD";
                    //    tag.TimeStamp = DateTime.Now;
                    //}
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

        public class SCADA
        {
            ArrayList Tasks = new ArrayList();
            ArrayList Displays = new ArrayList();

            public void AddTask(Task task)
            {
                task.Parent = this;
                Tasks.Add(task);
            }

            public void AddDisplay(Display display)
            {
                display.Parent = this;
                Displays.Add(display);
            }

            public Task FindTask(string name)
            {
                Task task = null;
                for (int i = 0; i < Tasks.Count; i++)
                {
                    task = (Task)Tasks[i];
                    if (task.Name == name)
                        return task;
                }

                return null;
            }

            public void RunTask(string name)
            {
                Task task = null;
                for (int i = 0; i < Tasks.Count; i++)
                {
                    task = (Task)Tasks[i];
                    if (task.Name == name)
                        task.Engine();
                }
            }

            public void SleepTask(string name)
            {
                Task task = null;
                for (int i = 0; i < Tasks.Count; i++)
                {
                    task = (Task)Tasks[i];
                    if (task.Name == name)
                        task.Sleep();
                }
            }

            public void ResumeTask(string name)
            {
                Task task = null;
                for (int i = 0; i < Tasks.Count; i++)
                {
                    task = (Task)Tasks[i];
                    if (task.Name == name)
                        task.Resume();
                }
            }
            public void KillTask(string name)
            {
                Task task = null;
                for (int i = 0; i < Tasks.Count; i++)
                {
                    task = (Task)Tasks[i];
                    if (task.Name == name)
                        task.Kill();
                }
            }

            public void RunDisplay(string name)
            {
                Display display = null;
                for (int i = 0; i < Displays.Count; i++)
                {
                    display = (Display)Displays[i];
                    if (display.Name == name)
                        display.Engine();
                }
            }

        }
    }
}
