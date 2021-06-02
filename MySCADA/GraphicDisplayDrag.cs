using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using static MySCADA.Program;

namespace MySCADA
{
    public partial class GraphicDisplayDrag : Form
    {
        public string Name;
        int Period;
        public ArrayList Tags = new ArrayList();
        public SCADA Parent;
        Image img;
        Image img_motor_on_1, img_motor_on_2, img_motor_on_3, img_motor_on_4, img_motor_on_5, img_motor_on_6, img_motor_on_7;
        Image img_motor_off_1, img_motor_off_2, img_motor_off_3, img_motor_off_4, img_motor_off_5, img_motor_off_6, img_motor_off_7;
        Image img_valve_on, img_valve_off;
        Image img_pipe_off, img_pipe_on;


        public GraphicDisplayDrag(string name, int period)
        {
            InitializeComponent();
            img_motor_on_1 = Image.FromFile("motor/Motor_on_1.png");
            img_motor_on_2 = Image.FromFile("motor/Motor_on_2.png");
            img_motor_on_3 = Image.FromFile("motor/Motor_on_3.png");
            img_motor_on_4 = Image.FromFile("motor/Motor_on_4.png");
            img_motor_on_5 = Image.FromFile("motor/Motor_on_5.png");
            img_motor_on_6 = Image.FromFile("motor/Motor_on_6.png");
            img_motor_on_7 = Image.FromFile("motor/Motor_on_7.png");

            img_motor_off_1 = Image.FromFile("motor/Motor_off_1.png");
            img_motor_off_2 = Image.FromFile("motor/Motor_off_2.png");
            img_motor_off_3 = Image.FromFile("motor/Motor_off_3.png");
            img_motor_off_4 = Image.FromFile("motor/Motor_off_4.png");
            img_motor_off_5 = Image.FromFile("motor/Motor_off_5.png");
            img_motor_off_6 = Image.FromFile("motor/Motor_off_6.png");
            img_motor_off_7 = Image.FromFile("motor/Motor_off_7.png");

            img_valve_on = Image.FromFile("valve/ValveSolinoid_on.png");
            img_valve_off = Image.FromFile("valve/ValveSolinoid_off.png");

            img_pipe_off =  Image.FromFile("Pipe_off.png");
            img_pipe_on = Image.FromFile("Pipe_on.png");

            Name = name;
            Period = period;
            updateTimer1.Interval = Period;
            updateTimer1.Start();



            pbMotor_1.Image = img_motor_off_1;
            pbMotor_2.Image = img_motor_off_1;
            pbValve.Image = img_valve_on;
            pbMotor_1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMotor_1.BackColor = Color.Transparent;
            pbMotor_2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMotor_2.BackColor = Color.Transparent;
            pbValve.SizeMode = PictureBoxSizeMode.StretchImage;
            pbValve.BackColor = Color.Transparent;
            pbValve.Size = new Size(110, 110);

        }

        private void GraphicDisplayDrag_Load(object sender, EventArgs e)
        {

        }



        private Image MotorSwCaImg(bool status, Int16 position)
        {
            Image img = img_motor_off_1;
            switch (position)
            {
                case (Int16)0:
                    img = status ? img_motor_on_1 : img_motor_off_1;
                    break;
                case (Int16)1:
                    img = status ? img_motor_on_1 : img_motor_off_1;
                    break;
                case (Int16)2:
                    img = status ? img_motor_on_2 : img_motor_off_2;
                    break;
                case (Int16)3:
                    img = status ? img_motor_on_3 : img_motor_off_3;
                    break;
                case (Int16)4:
                    img = status ? img_motor_on_4 : img_motor_off_4;
                    break;
                case (Int16)5:
                    img = status ? img_motor_on_5 : img_motor_off_5;
                    break;
                case (Int16)6:
                    img = status ? img_motor_on_6 : img_motor_off_6;
                    break;
                case (Int16)7:
                    img = status ? img_motor_on_7 : img_motor_off_7;
                    break;
                default:
                    img = img_motor_off_1;
                    break;

            }
            return img;
        }


        private void pbMotor_1_Click(object sender, EventArgs e)
        {
            //if(gbMotor_1.Visible == true)
            //{
            //    gbMotor_1.Visible = false;
            //}
            //else {
            //    gbMotor_1.Visible = true;
            //}
            MotorFaceplate fpl = (MotorFaceplate)Parent.Motor_faceplates[0];
            fpl.BringToFront();
            fpl.Show();
        }

        private void pbMotor_2_Click(object sender, EventArgs e)
        {
            //if (gbMotor_2.Visible == true)
            //{
            //    gbMotor_2.Visible = false;
            //}
            //else
            //{
            //    gbMotor_2.Visible = true;
            //}
            MotorFaceplate fpl = (MotorFaceplate)Parent.Motor_faceplates[1];
            fpl.BringToFront();
            fpl.Show();
        }

        private void pbValve_Click(object sender, EventArgs e)
        {
            //if (gbValve.Visible == true)
            //{
            //    gbValve.Visible = false;
            //}
            //else
            //{
            //    gbValve.Visible = true;
            //}
            MotorFaceplate fpl = (MotorFaceplate)Parent.Motor_faceplates[2];
            fpl.BringToFront();
            fpl.Show();
        }
        private void cbMotor_1_Mode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cbMotor_2_Mode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void enableCbTimer_Tick(object sender, EventArgs e)
        {

        }

        private void updateTimer1_Tick(object sender, EventArgs e)
        {

            Task task = Parent.FindTask("Task_1"); //VS bị confused giứa task của mình và task của system
            if (task != null)
            {
                Tag tagRunFB, tagPos;
                tagRunFB = task.FindTag("Motor_1_RunFB"); //Đọc RunFB Motor1
                tagPos = task.FindTag("Motor_1_Pos");
                if (tagRunFB != null && tagPos != null)
                {
                    pbMotor_1.Image = MotorSwCaImg(Convert.ToBoolean(tagRunFB.Value), Convert.ToInt16(tagPos.Value));
                    pbPipe1.Image = (Convert.ToBoolean(tagRunFB.Value)) ? img_pipe_on : img_pipe_off;

                }
                tagRunFB = task.FindTag("Motor_2_RunFB"); //Đọc RunFB Motor2
                tagPos = task.FindTag("Motor_2_Pos");
                if (tagRunFB != null && tagPos != null)
                {
                    pbMotor_2.Image = MotorSwCaImg(Convert.ToBoolean(tagRunFB.Value), Convert.ToInt16(tagPos.Value));
                    pbPipe2.Image = (Convert.ToBoolean(tagRunFB.Value)) ? img_pipe_on : img_pipe_off;

                }
                tagRunFB = task.FindTag("Valve_RunFB"); //Đọc RunFB Valve
                if (tagRunFB != null)
                {
                    pbValve.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbValve.Size = new Size(110, 110);
                    pbValve.Image = (Convert.ToBoolean(tagRunFB.Value)) ? img_valve_on : img_valve_off;
                    pbPipe3.Image = (Convert.ToBoolean(tagRunFB.Value)) ? img_pipe_on : img_pipe_off;
                }
                Tag tagLevel = task.FindTag("Level");
                if (tagLevel != null)
                {
                    barLevel.Value = tagLevel.Value;
                    if(tagLevel.Value< Alarm.lowlow || tagLevel.Value > Alarm.highhigh)
                    {
                        barLevel.TextColor = Color.FromArgb(0x990000);
                    }
                    else if (tagLevel.Value > Alarm.low && tagLevel.Value < Alarm.high)
                    {
                        barLevel.TextColor = Color.Black;
                    }
                    else
                    {
                        barLevel.TextColor = Color.Yellow;
                    }
                }
            }
        }

        private void buttonStart_MouseDown(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool("M0.0", true);
        }

        private void buttonStart_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool("M0.0", false);

        }

        private void buttonStop_MouseDown(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool("M0.1", true);
        }

        private void buttonStop_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool("M0.1", false);
        }

        private void buttonShowGraph_Click(object sender, EventArgs e)
        {
            LevelGraph lg = (LevelGraph)Parent.Graph[0];
            lg.BringToFront();
            lg.Show();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ovalRunning.BackColor = Color.Green;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            ovalRunning.BackColor = Color.Gray;
        }

        private void buttonShowAlarm_Click(object sender, EventArgs e)
        {
            AlarmDisplay ad = (AlarmDisplay)Parent.AlarmDisplays[0];
            ad.BringToFront();
            ad.Show();
        }

        private void cbValve_Mode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btMotor_1_Start_MouseDown(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool("DB1.DBX2.0", true);
        }
        private void btMotor_1_Start_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool("DB1.DBX2.0", false);
        }
        private void btMotor_1_Stop_MouseDown(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool("DB1.DBX2.1", true);
        }
        private void btMotor_1_Stop_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool("DB1.DBX2.1", false);
        }
        private void btMotor_2_Start_MouseDown(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool("DB2.DBX2.0", true);
        }
        private void btMotor_2_Start_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool("DB2.DBX2.0", false);
        }
        private void btMotor_2_Stop_MouseDown(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool("DB2.DBX2.1", true);
        }
        private void btMotor_2_Stop_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool("DB2.DBX2.1", false);
        }
        private void btValve_Start_MouseDown(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool("DB3.DBX2.0", true);

        }

        private void btValve_Start_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool("DB3.DBX2.0", false);
        }

        private void btValve_Stop_MouseDown(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool("DB3.DBX2.1", true);
        }

        private void btValve_Stop_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool("DB3.DBX2.1", false);
        }


    }
}
