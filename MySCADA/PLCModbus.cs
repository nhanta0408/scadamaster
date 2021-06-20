using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modbus.Device;
using static MySCADA.Program;

namespace MySCADA
{
    // Đang copy file bên S7 Communication sang PLC của MySCADA.sln
    public class PLCModbus
    {
        string IPAddress = "192.168.1.200";
        System.Timers.Timer  ReadPLCTimer = new System.Timers.Timer();
        public ModbusTcpDevice thePLC;
        //public Device Motor_1 = new Device(); //Device = "Motor_1"(id á)
        //public Device Motor_2 = new Device(); //Device = "Motor_2"
        //public Device Valve = new Device(); //Device = "Valve"

        public int Level;
        public bool Status;
        public int Mode;
        public bool isConnected = false;  
        //public short Level;
        //public bool StartAuto;
        //public bool StopAuto;
        public SCADA Parent;
        public PLCModbus()
        {
            //Tick là Timer của Form not Console
            ReadPLCTimer.Interval = 1000;

            ReadPLCTimer.Elapsed += new System.Timers.ElapsedEventHandler(ReadPLCTimer_Tick);

            thePLC = new ModbusTcpDevice(IPAddress);
            
            isConnected = thePLC.Connect();
            if(isConnected)
            {
                ReadPLCTimer.Start();
                ReadPLCTimer.Enabled = true;
            }
            else
            {
                ReadPLCTimer.Enabled = false;
            }
        }

        private void ReadPLCTimer_Tick(object sender, EventArgs e)
        {
            if (isConnected)
            {

                Level = thePLC.ReadWord(255,99);
                Mode = thePLC.ReadWord(255, 100);

                Status = thePLC.ReadBoolean(255, 100);

                Console.WriteLine("Level bên Modbus: " + Level.ToString());

                //Historian levelHistorian = Parent.FindHistorian("Level");
                //levelHistorian.ringBuffer.Enqueue(Level);
                //Historian levelTimestampHistorian = Parent.FindHistorian("LevelTimestamp");
                //levelTimestampHistorian.ringBuffer.Enqueue(DateTime.Now);
                
                //Alarm levelAlarm = Parent.FindAlarm("Level");
                //AlarmTag levelAlarmTag = new AlarmTag("Level", DateTime.Now, Level, " "); //Chưa so sánh nên chưa biết alarm code
                //levelAlarm.CheckAlarmLevel(levelAlarmTag);
            }

        }
      
    }
    
    public class Actuator 
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
    public class ModbusTcpDevice
    {
        ModbusIpMaster master = null;
        System.Net.Sockets.TcpClient client = null;
        string Address = "127.0.0.1";

        public ModbusTcpDevice(string address)
        {
            Address = address;
        }

        public bool Connect()
        {
            try
            {
                client = new System.Net.Sockets.TcpClient(this.Address, 1000);
                master = ModbusIpMaster.CreateIp(client);

                return true;
            }

            catch (Exception ex)
            {
                //this.errorCode = ex.Message;
                return false;
            }
        }

        public void DisConnect()
        {
            if (client != null)
            {
                client.Close();
                client = null;
            }
            if (master != null)
            {
                master.Dispose();
                master = null;
            }
        }

        public bool ReadBoolean(byte slaveID, ushort address)
        {
            bool[] result = master.ReadCoils(slaveID, address, 1);
            return result[0];
        }

        public void WriteBoolean(byte slaveID, ushort address, bool value)
        {
            master.WriteSingleCoil(slaveID, address, value);
        }

        public ushort ReadWord(byte slaveID, ushort address)
        {
            ushort[] result = master.ReadHoldingRegisters(slaveID, address, 1);
            return result[0];
        }

        public void WriteWord(byte slaveID, ushort address, ushort value)
        {
            master.WriteSingleRegister(slaveID, address, value);
        }

        public UInt32 ReadDoubleWord(byte slaveID, ushort address)
        {
            ushort[] result = master.ReadHoldingRegisters(slaveID, address, 2);
            byte[] data0 = BitConverter.GetBytes(result[0]);  // MW100
            byte[] data1 = BitConverter.GetBytes(result[1]);  // MW101
            byte[] data = new byte[] { data0[0], data0[1], data1[0], data1[1] };
            return BitConverter.ToUInt32(data, 0);
        }

        public void WriteDoubleWord(byte slaveID, ushort address, uint value)
        {
            byte[] valueConvert = BitConverter.GetBytes(value);
            ushort[] data = new ushort[2];
            data[0] = BitConverter.ToUInt16(valueConvert, 0);
            data[1] = BitConverter.ToUInt16(valueConvert, 2);
            master.WriteMultipleRegisters(slaveID, address, data);
        }
    }
}
