using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySCADA
{
    public partial class MotorModbus : Form
    {
        public SCADA Parent;
        public MotorModbus()
        {
            InitializeComponent();
            timerUpdate.Interval = 100;
            timerUpdate.Enabled = true;
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            labelDisconnect.Visible = !Parent.M340.isConnected;
            if (Parent.M340.isConnected)
            {
                progressBarLevel.Value = Parent.M340.Level;
                pbRunFB.BackColor = Parent.M340.Status ? Color.Green : Color.Gray;
                if (!cbMode.Focused)
                {
                    cbMode.Text = Parent.M340.Mode.ToString() == "1" ? "Manual" : "Auto";
                }
            }
           
        }

        private void MotorModbus_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btnStart_MouseDown(object sender, MouseEventArgs e)
        {
            if (Parent.M340.isConnected)
            {
                Parent.M340.thePLC.WriteBoolean(255, 101, true);

            }
        }

        private void btnStart_MouseUp(object sender, MouseEventArgs e)
        {
            if (Parent.M340.isConnected)
            {
                Parent.M340.thePLC.WriteBoolean(255, 101, false);

            }
        }

        private void btnStop_MouseDown(object sender, MouseEventArgs e)
        {
            if (Parent.M340.isConnected)
            {
                Parent.M340.thePLC.WriteBoolean(255, 102, true);

            }
        }

        private void btnStop_MouseUp(object sender, MouseEventArgs e)
        {
            if (Parent.M340.isConnected)
            {
                Parent.M340.thePLC.WriteBoolean(255, 102, false);

            }
        }

        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Parent.M340.isConnected)
            {
                if (cbMode.SelectedIndex == 0)
                {
                    Parent.M340.thePLC.WriteWord(255, 100, (ushort)1);
                }
                else if (cbMode.SelectedIndex == 1)
                {
                    Parent.M340.thePLC.WriteWord(255, 100, (ushort)2);
                }
            }
            
        }
    }
}
