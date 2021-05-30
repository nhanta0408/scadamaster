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
    public partial class MotorFaceplate : Form
    {
      
        Image img_motor_on_1, img_motor_off_1;

        int ID;
        public SCADA Parent;
        public MotorFaceplate(int id)
        {
            img_motor_on_1 = Image.FromFile("motor/Motor_on_1.png");
            img_motor_off_1 = Image.FromFile("motor/Motor_off_1.png");
            InitializeComponent();
            ID = id;
        }

        
        
        private string FromIdToVariableNameString(int id)
        {
            string variableNameString = "";
            switch (id)
            {
                case 1:
                    variableNameString = "Motor_1";

                    break;
                case 2:
                    variableNameString = "Motor_2";
                    break;
                case 3:
                    variableNameString = "Valve";
                    break;
                default:
                    break;                   
            }
            return variableNameString;
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            Task task = Parent.FindTask("Task_1");
            Tag tag;
            string Prefix = FromIdToVariableNameString(ID);  //cách dùng prefix
            if (task != null)
            {       
                tag = task.FindTag($"{Prefix}_Mode"); //Đọc mode Motor1

                if (tag != null && !cbMode.Focused)
                {
                    cbMode.Text = tag.Value.ToString() == "1" ? "Manual" : "Auto";
                }
                tag = task.FindTag($"{Prefix}_RunFB"); //Đọc mode Motor1

                if (tag != null)
                {
                    pbRunFB.BackColor = tag.Value == true ? Color.Green : Color.Gray;

                }

            }
        }
        private void btnStart_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool($"DB{ID}.DBX2.0", false);
        }

        private void btnStart_MouseDown(object sender, MouseEventArgs e)
        {

            Parent.S71500.WriteBool($"DB{ID}.DBX2.0", true);
        }

        private void btnStop_MouseDown(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool($"DB{ID}.DBX2.1", true);
        }

        

        private void btnStop_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool($"DB{ID}.DBX2.1", false);
        }

        private void MotorFaceplate_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void MotorFaceplate_Load(object sender, EventArgs e)
        {
            this.Text = FromIdToVariableNameString(ID) + " faceplate";
        }

        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMode.SelectedIndex == 0)
            {
                Parent.S71500.WriteInt($"DB{ID}.DBW0", (Int16)1);
            }
            else if (cbMode.SelectedIndex == 1)
            {
                Parent.S71500.WriteInt($"DB{ID}.DBW0", (Int16)2);
            }
        }
    }
}
