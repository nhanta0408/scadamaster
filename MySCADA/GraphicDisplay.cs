using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using static MySCADA.Program;
using System.Drawing;

namespace MySCADA
{
    class GraphicDisplay : Form
    {
        public string Name;
        int Period;
        Timer UpdateTimer = null;
        public ArrayList Tags = new ArrayList();
        public SCADA Parent;
        Button btMotor_1_Start, btMotor_1_Stop;
        Button btResume_Task_1;
        TextBox tbPump_2_Speed, tbPump_3_Speed, tbFlow_1_Speed, tbFlow_2_Speed, tbFlow_3_Speed;
        PictureBox pbMotor_1_RunFB;
        Image img;
        Label lbMotor_1_Mode;
        TextBox tbMotor_1_Mode; //sau này có thể đổi thành combo box

        Image imgOff = Image.FromFile("button_red_off.wmf");
        Image imgOn = Image.FromFile("button_red_on.wmf");

        Image img_agitator_1 = Image.FromFile("agitator_1.gif");
        Image img_agitator_2 = Image.FromFile("agitator_2.gif");
        Image img_agitator_3 = Image.FromFile("agitator_3.gif");
        private Button button1;
        private Button button2;
        private Button button3;
        Image img_agitator_4 = Image.FromFile("agitator_4.gif");
        public GraphicDisplay(string name, int period)
        {
            InitializeComponent();
            Name = name;
            Period = period;
            //base chính là thằng Form
            base.Name = name;
            base.WindowState = FormWindowState.Normal;
            base.Size = new System.Drawing.Size(500, 400); //Khúc này nhớ là (using + add reference) System.Drawing
            base.BackColor = Color.FromArgb(0, 95, 170);
            base.BackgroundImage = Image.FromFile("bg_1.jpg");
            base.Size = base.BackgroundImage.Size;

            btMotor_1_Start = new Button();
            btMotor_1_Start.Text = "Start Motor 1";
            btMotor_1_Start.Size = new Size(120, 50);
            btMotor_1_Start.Location = new Point(120, 5); //Location thì dùng class Point
            btMotor_1_Start.BackColor = Color.DarkGray;
            btMotor_1_Start.MouseDown += btMotor_1_Start_MouseDown;
            btMotor_1_Start.MouseUp += BtMotor_1_Start_MouseUp;

            btMotor_1_Stop = new Button();
            btMotor_1_Stop.Text = "Stop Motor 1";
            btMotor_1_Stop.Size = new Size(120, 50);
            btMotor_1_Stop.Location = new Point(120, 70); //Location thì dùng class Point
            btMotor_1_Stop.BackColor = Color.DarkGray;
            btMotor_1_Stop.Click += btMotor_1_Stop_Click;
            btMotor_1_Stop.MouseDown += btMotor_1_Stop_MouseDown;
            btMotor_1_Stop.MouseUp += BtMotor_1_Stop_MouseUp;

            lbMotor_1_Mode = new Label();
            lbMotor_1_Mode.BackColor = Color.Green;
            lbMotor_1_Mode.ForeColor = Color.Yellow;
            lbMotor_1_Mode.Font = new Font("Cambria", 16);
            lbMotor_1_Mode.Size = new Size(120, 50);
            lbMotor_1_Mode.Location = new Point(220, 120);

            tbMotor_1_Mode = new TextBox();
            tbMotor_1_Mode.BackColor = Color.Green;
            tbMotor_1_Mode.ForeColor = Color.Yellow;
            tbMotor_1_Mode.Font = new Font("Cambria", 16);
            tbMotor_1_Mode.Size = new Size(120, 50);
            tbMotor_1_Mode.Location = new Point(550, 350);
            tbMotor_1_Mode.KeyPress += TbMotor_1_Mode_KeyPress;

            pbMotor_1_RunFB = new PictureBox();
            pbMotor_1_RunFB.Location = new Point(350, 250);
            pbMotor_1_RunFB.BackColor = Color.Transparent;     //Do ảnh mình là transparent rồi -> cho back là transparent luôn mới đúng
            pbMotor_1_RunFB.BackgroundImage = img_agitator_3;
            pbMotor_1_RunFB.Size = img_agitator_1.Size;
            pbMotor_1_RunFB.BackgroundImageLayout = ImageLayout.Stretch;
            pbMotor_1_RunFB.Click += pbMotor_1_RunFB_Click;


            UpdateTimer = new Timer();
            UpdateTimer.Interval = Period;
            UpdateTimer.Tick += UpdateTimer_Tick;

            base.Controls.Add(btMotor_1_Start);
            base.Controls.Add(btMotor_1_Stop);
            base.Controls.Add(lbMotor_1_Mode);
            base.Controls.Add(pbMotor_1_RunFB);
            base.Controls.Add(tbMotor_1_Mode);
            UpdateTimer.Start();
        }

        

        private void UpdateTimer_Tick(object sender, EventArgs e) //Vòng lặp cập nhật giá trị Speed
        {
            Task task = Parent.FindTask("Task_1"); //VS bị confused giứa task của mình và task của system
            Tag tag;
            if (task != null)
            {
                tag = task.FindTag("Motor_1_Mode");
                if (tag != null)
                {
                }
                tag = task.FindTag("Motor_1_RunFB");
                if (Convert.ToBoolean(tag.Value) == true)
                {
                    
                    
                    //Image img;
                    //img = tag.Value == true ? imgOn : imgOff;
                    //pbMotor_1_RunFB.Image = img;
                }
                tag = task.FindTag("Motor_1_Pos");
                if (tag != null)
                {
                    lbMotor_1_Mode.Text = tag.Value.ToString();
                    //if(tag.Value == 0)
                    //{
                    //    pbMotor_1_RunFB.BackgroundImage = img_agitator_1;
                    //}
                    //else if (tag.Value == 1)
                    //{
                    //    pbMotor_1_RunFB.BackgroundImage = img_agitator_1;
                    //}
                    //else if (tag.Value == 2)
                    //{
                    //    pbMotor_1_RunFB.BackgroundImage = img_agitator_2;
                    //}
                    //else if (tag.Value == 3)
                    //{
                    //    pbMotor_1_RunFB.BackgroundImage = img_agitator_3;
                    //}
                    //else if (tag.Value == 4)
                    //{
                    //    pbMotor_1_RunFB.BackgroundImage = img_agitator_4;
                    //}
                    switch (tag.Value)
                    {
                        case (Int16)0:
                            pbMotor_1_RunFB.BackgroundImage = img_agitator_1;
                            break;
                        case (Int16)1:
                            pbMotor_1_RunFB.BackgroundImage = img_agitator_1;
                            break;
                        case (Int16)2:
                            pbMotor_1_RunFB.BackgroundImage = img_agitator_2;
                            break;
                        case (Int16)3:
                            pbMotor_1_RunFB.BackgroundImage = img_agitator_3;
                            break;
                        case (Int16)4:
                            pbMotor_1_RunFB.BackgroundImage = img_agitator_4;
                            break;
                        default:
                           
                            break;
                    }
                }

            }
        }



        

        //Xuất hiện khi resize cái desginer
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GraphicDisplay
            // 
            this.ClientSize = new System.Drawing.Size(451, 388);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "GraphicDisplay";
            this.ResumeLayout(false);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Motor fpl = (Motor)Parent.Motor_faceplates[2];
            fpl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Motor fpl = (Motor)Parent.Motor_faceplates[1];
            fpl.Show();
        }

        private void btMotor_1_Start_MouseDown(object sender, EventArgs e)
        {
            Parent.S71500.WriteBool("DB1.DBX2.0", true);

        }
        private void BtMotor_1_Start_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool("DB1.DBX2.0", false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Motor fpl = (Motor)Parent.Motor_faceplates[0];
            fpl.Show();
        }

        private void btMotor_1_Stop_Click(object sender, EventArgs e)
        {
        }

        private void pbMotor_1_RunFB_Click(object sender, EventArgs e)
        {

        }
        private void BtMotor_1_Stop_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool("DB1.DBX2.1", false);
        }

        private void btMotor_1_Stop_MouseDown(object sender, MouseEventArgs e)
        {
            Parent.S71500.WriteBool("DB1.DBX2.1", true);
        }
        private void TbMotor_1_Mode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
            {
                short temp;
                bool retcode = Int16.TryParse(tbMotor_1_Mode.Text, out temp);
                //short value = Convert.ToInt16(tbMotor_1_Mode.Text);
                if(retcode)
                {
                    Parent.S71500.WriteInt("DB1.DBW0", temp);
                }
            }
        }
    }


}
