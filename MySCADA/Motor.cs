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
    public partial class Motor : Form
    {
        Image img_motor_on_1, img_motor_off_1;
        
        int ID;
        public SCADA Parent;
        public Motor(int id)
        {
            img_motor_on_1 = Image.FromFile("motor/Motor_on_1.png");
            img_motor_off_1 = Image.FromFile("motor/Motor_off_1.png");
            InitializeComponent();
            ID = id;
          
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

        private void tbMode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                short temp;
                bool retcode = Int16.TryParse(tbMode.Text, out temp);
                //short value = Convert.ToInt16(tbMotor_1_Mode.Text);
                if (retcode)
                {
                    Parent.S71500.WriteInt("DB1.DBW0", temp);
                }
            }
        }

        private void Motor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            Task task = Parent.FindTask("Task_1");
            Tag tag;
            string Prefix = $"Motor_{ID}";  //cách dùng prefix
            if (task != null)
            {
                tag = task.FindTag($"{Prefix}_Mode"); //Đọc mode Motor1

                if (tag != null)
                {
                   tbMode.Text = tag.Value.ToString() ;
                        //== "1" ? "Manual" : "Auto";
                }
                tag = task.FindTag($"{Prefix}_RunFB"); //Đọc mode Motor1

                if (tag != null)
                {
                    pictureBox1.Image = tag.Value ? img_motor_on_1 : img_motor_off_1;

                }

            }
        }
    }
}
