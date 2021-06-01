using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MySCADA.PLC;
namespace MySCADA
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Very Simple SCADA Kernel");
            //Console.WriteLine("The program helps to learn");
            //Console.WriteLine("SCADA Design and Programming");
            //Console.WriteLine("Press any key to continue");
            //Console.ReadKey();




            //Trước hết tạo phần cao nhất là SCADA
            SCADA Root = new SCADA();
            PLC plc = new PLC();
            Root.AddPLC(plc); //ko có đối số

            //Tạo Task
            Task Task1 = new Task("Task_1", 100);
            //Tạo các Tag
            Tag Motor_1_Mode = new Tag("Motor_1_Mode", "Motor_1.Mode");
            Tag Motor_2_Mode = new Tag("Motor_2_Mode", "Motor_2.Mode");
            Tag Valve_Mode = new Tag("Valve_Mode", "Valve.Mode");

            Tag Motor_1_Start = new Tag("Motor_1_Start", "Motor_1.Start");
            Tag Motor_2_Start = new Tag("Motor_2_Start", "Motor_2.Start");
            Tag Valve_Start = new Tag("Valve_Start", "Valve.Start");

            Tag Motor_1_Stop = new Tag("Motor_1_Stop", "Motor_1.Stop");
            Tag Motor_2_Stop = new Tag("Motor_2_Stop", "Motor_2.Stop");
            Tag Valve_Stop = new Tag("Valve_Stop", "Valve.Stop");

            Tag Motor_1_RunFB = new Tag("Motor_1_RunFB", "Motor_1.RunFB");
            Tag Motor_2_RunFB = new Tag("Motor_2_RunFB", "Motor_2.RunFB");
            Tag Valve_RunFB = new Tag("Valve_RunFB", "Valve.RunFB");

            Tag Motor_1_Reset = new Tag("Motor_1_Reset", "Motor_1.Reset");
            Tag Motor_2_Reset = new Tag("Motor_2_Reset", "Motor_2.Reset");
            Tag Valve_Reset = new Tag("Valve_Reset", "Valve.Reset");

            Tag Motor_1_Fault = new Tag("Motor_1_Fault", "Motor_1.Fault");
            Tag Motor_2_Fault = new Tag("Motor_2_Fault", "Motor_2.Fault");
            Tag Valve_Fault = new Tag("Valve_Fault", "Valve.Fault");

            Tag Motor_1_Pos = new Tag("Motor_1_Pos", "Motor_1.Pos");
            Tag Motor_2_Pos = new Tag("Motor_2_Pos", "Motor_2.Pos");
            Tag Valve_Pos = new Tag("Valve_Pos", "Valve.Pos");

            Tag Level = new Tag("Level", "MW20");

            //Add các con vào Parent
            Root.AddTask(Task1);

            Task1.AddTag(Motor_1_Mode);
            Task1.AddTag(Motor_2_Mode);
            Task1.AddTag(Valve_Mode);

            Task1.AddTag(Motor_1_Start);
            Task1.AddTag(Motor_2_Start);
            Task1.AddTag(Valve_Start);

            Task1.AddTag(Motor_1_Stop);
            Task1.AddTag(Motor_2_Stop);
            Task1.AddTag(Valve_Stop);

            Task1.AddTag(Motor_1_RunFB);
            Task1.AddTag(Motor_2_RunFB);
            Task1.AddTag(Valve_RunFB);

            Task1.AddTag(Motor_1_Reset);
            Task1.AddTag(Motor_2_Reset);
            Task1.AddTag(Valve_Reset);

            Task1.AddTag(Motor_1_Fault);
            Task1.AddTag(Motor_2_Fault);
            Task1.AddTag(Valve_Fault);

            Task1.AddTag(Motor_1_Pos);
            Task1.AddTag(Motor_2_Pos);
            Task1.AddTag(Valve_Pos);

            Task1.AddTag(Level);

            Root.RunTask("Task_1");



            MotorFaceplate Motor_1_Faceplate = new MotorFaceplate(1);
            MotorFaceplate Motor_2_Faceplate = new MotorFaceplate(2);
            MotorFaceplate Motor_3_Faceplate = new MotorFaceplate(3);

            Root.AddFaceplate(Motor_1_Faceplate);
            Root.AddFaceplate(Motor_2_Faceplate);
            Root.AddFaceplate(Motor_3_Faceplate);


            Historian levelHistorian = new Historian("Level",8000);
            Root.AddHistorian(levelHistorian);

            Alarm levelAlarm = new Alarm("Level");
            Root.AddAlarm(levelAlarm);
            //GraphicDisplay Main_Page = new GraphicDisplay("Main_Page", 100);
            //Main_Page.Parent = Root;
            //Main_Page.ShowDialog();

            LevelGraph LevelGraph = new LevelGraph();
            LevelGraph.Parent = Root;
            Root.AddGraph(LevelGraph);

            AlarmDisplay LevelAlarmDisplay = new AlarmDisplay();
            LevelAlarmDisplay.Parent = Root;
            Root.AddAlarmDisplay(LevelAlarmDisplay);

            GraphicDisplayDrag Main_Page_Drag = new GraphicDisplayDrag("Main_Page_Drag", 100);
            Main_Page_Drag.Parent = Root;
            Main_Page_Drag.ShowDialog();

            
            
            Console.ReadKey();


            ////Test queue
            //RingBuffer queue = new RingBuffer(10);

            //for (int i = 0; i < 100; i++)
            //{
            //    queue.Enqueue(i);
            //    foreach (var item in queue.nums)
            //    {
            //        Console.Write("  " + item);
            //    }
            //    System.Threading.Thread.Sleep(200);
            //    Console.Clear();
            //}
            //Console.ReadKey();
        }


    }
}
