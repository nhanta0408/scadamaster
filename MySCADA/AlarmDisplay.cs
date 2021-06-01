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
    public partial class AlarmDisplay : Form
    {
        public SCADA Parent;
        public List<AlarmTag> messageAlarm = new List<AlarmTag>();
        public List<AlarmTag> alarms;
        private bool enabledUpdate;
        public AlarmDisplay()
        {
            InitializeComponent();
            enabledUpdate = true;
            togEnabledUpdate.Checked = true;
        }

        private void AlarmDisplay_Load(object sender, EventArgs e)
        {
            updateTimer1.Enabled = true;
            UpdateAlarmTag();
        }

        private void AlarmDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        private void UpdateAlarmTag()
        {
            alarms = Parent.FindAlarm("Level").alarmTag;
            //richTextBox1.Text = "";
            //foreach (var alarm in alarms)
            //{
            //    richTextBox1.Text += "\n " + alarm.Detail;
            //}
            dataGridViewAlarm.DataSource = null;
            var alarm_temp = alarms.OrderByDescending(p => p.Timestamp).ToList();
            dataGridViewAlarm.DataSource = alarm_temp;
            dataGridViewAlarm.Columns[0].Visible = false;
            dataGridViewAlarm.Columns[1].Visible = true;
            dataGridViewAlarm.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            dataGridViewAlarm.Columns[2].Visible = false;
            dataGridViewAlarm.Columns[3].Visible = false;
            dataGridViewAlarm.Columns[4].Visible = true;
            dataGridViewAlarm.Columns[1].Width = 200;
            dataGridViewAlarm.Columns[4].Width = 600;

        }

        private void updateTimer1_Tick(object sender, EventArgs e)
        {
            if (enabledUpdate)
            {
                UpdateAlarmTag();
            }
        }

        private void dataGridViewAlarm_Scroll(object sender, ScrollEventArgs e)
        {
           
        }

        private void togEnabledUpdate_CheckedChanged(object sender, EventArgs e)
        {
            enabledUpdate = togEnabledUpdate.Checked;
        }
    }
}
