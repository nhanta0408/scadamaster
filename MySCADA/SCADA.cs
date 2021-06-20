using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySCADA
{
    public class SCADA
    {
        public ArrayList Tasks = new ArrayList();
        public ArrayList Displays = new ArrayList();
        public ArrayList Motor_faceplates = new ArrayList();
        public ArrayList Graph = new ArrayList();
        public ArrayList Historians = new ArrayList();
        public ArrayList Alarms = new ArrayList();
        public ArrayList AlarmDisplays = new ArrayList();
        public ArrayList MotorsModbus = new ArrayList();


        public PLC S71500;
        public PLCModbus M340;
        public SCADA()
        {
            

        }
        public void AddTask(Task task)
        {
            task.Parent = this;
            Tasks.Add(task);
        }
        //Viết thêm 1 void cho SCADA Program.cs
        public void AddPLC(PLC plc)
        {
            plc.Parent = this;
            S71500 = plc;
        }

        public void AddPLCModbus(PLCModbus plc)
        {
            plc.Parent = this;
            M340 = plc;
        }

        public void AddFaceplate(MotorFaceplate faceplate)
        {
            faceplate.Parent = this;
            Motor_faceplates.Add(faceplate);
        }
        //public void AddFaceplate(Motor faceplate)
        //{
        //    faceplate.Parent = this;
        //    Motor_faceplates.Add(faceplate);
        //}
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
        public void AddHistorian(Historian historian)
        {
            historian.Parent = this;
            Historians.Add(historian);
        }
        public Historian FindHistorian(string name)
        {
            Historian result = null;
            foreach (var item in Historians)
            {
                var temp = (Historian)item;
                if(temp.Name == name)
                {
                    result = temp;
                }
            }
            return result;
        }
        public void AddGraph(LevelGraph levelGraph)
        {
            levelGraph.Parent = this;
            Graph.Add(levelGraph);
        }
        public void AddAlarm(Alarm alarm)
        {
            alarm.Parent = this;
            Alarms.Add(alarm);
        }
        public Alarm FindAlarm(string name)
        {
            Alarm result = null;
            foreach (var item in Alarms)
            {
                var temp = (Alarm)item;
                if (temp.Name == name)
                {
                    result = temp;
                }
            }
            return result;
        }
        public void AddAlarmDisplay(AlarmDisplay alarmDisplay)
        {
            alarmDisplay.Parent = this;
            AlarmDisplays.Add(alarmDisplay);
        }
        public void AddMotorModbus(MotorModbus motorModbus)
        {
            motorModbus.Parent = this;
            MotorsModbus.Add(motorModbus);
        }
    }
}
