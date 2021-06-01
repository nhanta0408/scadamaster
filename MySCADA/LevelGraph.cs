﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace MySCADA
{
    public partial class LevelGraph : Form
    {
        private bool zedGraphIsPanning;
        public SCADA Parent; //Xíu cài sau trong Program.cs
        const double maxXSize = 100;
        private bool compactMode;
        private int _count;
        private int _preCount;
        public LevelGraph()
        {
            InitializeComponent();

            zedGraphIsPanning = false;
            zedGraphLevel.IsShowVScrollBar = false;
            GraphPane myPane = zedGraphLevel.GraphPane;
            myPane.Title.Text = "Đồ thị thể hiện mức nước trong bồn";
            myPane.XAxis.Title.Text = "Time (Seconds)";
            myPane.YAxis.Title.Text = "Chiều cao (mét)";
            
            RollingPointPairList list = new RollingPointPairList(10000);
            RollingPointPairList list1 = new RollingPointPairList(10000);

            LineItem curve = myPane.AddCurve("Level value", list, Color.Red, SymbolType.None);

            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = maxXSize;
            myPane.XAxis.Scale.MinorStep = maxXSize / 10;
            myPane.XAxis.Scale.MajorStep = maxXSize / 5;
            myPane.YAxis.Scale.Max = 110;
            myPane.YAxis.Scale.Min = 0;
            zedGraphLevel.AxisChange();
            updateTimer1.Enabled = true;

        }

        private void LevelGraph_Load(object sender, EventArgs e)
        {
            compactMode = false;
            _count = 0;
        }
        private void Draw(int x, int y, bool isPanning)
        {
            LineItem curve = zedGraphLevel.GraphPane.CurveList[0] as LineItem;
            IPointListEdit list = curve.Points as IPointListEdit;
            list.Add(x, y);

            Scale xScale = zedGraphLevel.GraphPane.XAxis.Scale;
            if (!isPanning)
            {
                if (x > xScale.Max - xScale.MajorStep)
                {
                    xScale.Max = x + xScale.MajorStep;
                    if (compactMode)
                    {
                        xScale.Min = 0;
                    }
                    else
                    {
                        xScale.Min = xScale.Max - maxXSize;
                    }
                }
            }
            zedGraphLevel.AxisChange();
            zedGraphLevel.Invalidate();
        }

        private void updateTimer1_Tick(object sender, EventArgs e)
        {
            Task task = Parent.FindTask("Task_1"); //VS bị confused giứa task của mình và task của system
            Tag tagLevel = task.FindTag("Level");
            if (tagLevel != null)
            {
                Historian levelHistorian = Parent.FindHistorian("Level");
             
                if (_preCount != levelHistorian.ringBuffer.count)
                {
                    Draw(_preCount, levelHistorian.ringBuffer.Peek(), zedGraphIsPanning);
                    _count ++;
                    _preCount = levelHistorian.ringBuffer.count;

                }
            }
        }



        private void LevelGraph_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void togCompactMode_CheckedChanged(object sender, EventArgs e)
        {
            compactMode = togCompactMode.Checked;
            if (togCompactMode.Checked)
            {
                togIsEnabledPan.Checked = false;
                togIsEnabledPan.Visible = false;
            }
            else
            {
                togIsEnabledPan.Checked = true;
                togIsEnabledPan.Visible = true;
            }
        }

        private void togIsEnabledPan_CheckedChanged(object sender, EventArgs e)
        {

            zedGraphIsPanning = togIsEnabledPan.Checked;

        }
    }
}
