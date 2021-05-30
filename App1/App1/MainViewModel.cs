using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using static MySCADA.Program;
using Task = MySCADA.Program.Task;

namespace App1
{
    class MainViewModel: BindableBase
    {
        System.Timers.Timer UpdateTimer = null;
        private int tag11Val;
        public int Tag11Val { get => tag11Val; set => tag11Val = value; }
        SCADA Root = new SCADA();
        //Tạo Task
        Task Task1 = new Task("Task_1", 100);
        //Tạo các Tag
        Tag Tag11 = new Tag("Pump_1_Speed", 1000);
        public MainViewModel()
        {
            Root.AddTask(Task1);
            Root.RunTask("Task_1");
            Task1.AddTag(Tag11);

            UpdateTimer = new System.Timers.Timer(1000);
            UpdateTimer.AutoReset = true;
            UpdateTimer.Elapsed += UpdateTimer_Elapsed;
            UpdateTimer.Start();
        }

        private void UpdateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Tag11Val = Tag11.Value;
        }
    }
}
