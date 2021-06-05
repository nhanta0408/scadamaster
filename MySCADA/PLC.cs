using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net; //Add thư viện, nhớ phải add luôn reference
using static MySCADA.Program;

namespace MySCADA
{
    // Đang copy file bên S7 Communication sang PLC của MySCADA.sln
    public class PLC
    {
        string IPAddress = "192.168.1.201";
        System.Timers.Timer  ReadPLCTimer = new System.Timers.Timer();
        Plc thePLC;
        public Device Motor_1 = new Device(); //Device = "Motor_1"(id á)
        public Device Motor_2 = new Device(); //Device = "Motor_2"
        public Device Valve = new Device(); //Device = "Valve"
        public short Level;
        public bool StartAuto;
        public bool StopAuto;
        public SCADA Parent;
        public PLC()
        {
            thePLC = new Plc(CpuType.S71500, IPAddress, 0, 1);
            try
            {
                thePLC.Open();
            }
            catch
            {
                ;
            }
            //Tick là Timer của Form not Console
            ReadPLCTimer.Interval = 1000;
            ReadPLCTimer.Enabled = true;
            ReadPLCTimer.Elapsed += new System.Timers.ElapsedEventHandler(ReadPLCTimer_Tick);
            ReadPLCTimer.Start();

        }

        private void ReadPLCTimer_Tick(object sender, EventArgs e)
        {
            if (thePLC.IsConnected)
            {
                thePLC.ReadClass(Motor_1, 1);
                thePLC.ReadClass(Motor_2, 2);
                thePLC.ReadClass(Valve, 3);

                object levelObj = thePLC.Read("MW20");
                Level = ((ushort)levelObj).ConvertToShort();
                Console.WriteLine("Level nè: " + Level.ToString());

                Historian levelHistorian = Parent.FindHistorian("Level");
                levelHistorian.ringBuffer.Enqueue(Level);
                Historian levelTimestampHistorian = Parent.FindHistorian("LevelTimestamp");
                levelTimestampHistorian.ringBuffer.Enqueue(DateTime.Now);
                
                Alarm levelAlarm = Parent.FindAlarm("Level");
                AlarmTag levelAlarmTag = new AlarmTag("Level", DateTime.Now, Level, " "); //Chưa so sánh nên chưa biết alarm code
                levelAlarm.CheckAlarmLevel(levelAlarmTag);
            }

        }
        public void WriteBool(string address, bool value)
        {
            thePLC.Write(address, value);

        }
        public void WriteInt(string address, short value)
        {
            thePLC.Write(address, value);

        }
        public void WriteIntAsync(string address, short value)
        {
            int startByteAdd = Convert.ToInt32(address[7]);
            thePLC.WriteAsync(DataType.DataBlock, startByteAdd, 0, value );
        }
    }
    
    public class Device 
    {
        public ushort Mode { get; set; } //"Mode"
        public bool Start { get; set; } //"Start"
        public bool Stop { get; set; } //"Stop" id á
        public bool RunCond { get; set; }
        public bool StopCond { get; set; }
        public bool RunFB { get; set; } //etc
        public bool Reset { get; set; }
        public byte aByte { get; set; }     //chèn vô 1 thằng do nó mất byte số 3, nhìn bên Offset của DB thấy 2.3 xong tới 4.0, mất byte 3
        public bool Cmd { get; set; }
        public bool Fault { get; set; }
        public Int16 Pos { get; set; }
    }
}
