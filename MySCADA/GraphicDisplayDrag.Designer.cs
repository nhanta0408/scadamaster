
namespace MySCADA
{
    partial class GraphicDisplayDrag
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.updateTimer1 = new System.Windows.Forms.Timer(this.components);
            this.enableCbTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.zedGraphLevel = new ZedGraph.ZedGraphControl();
            this.barLevel = new ProgressBars.Basic.BasicProgressBar();
            this.rjToggleButton1 = new MySCADA.RJToggleButton();
            this.pbValve = new System.Windows.Forms.PictureBox();
            this.pbMotor_2 = new System.Windows.Forms.PictureBox();
            this.pbMotor_1 = new System.Windows.Forms.PictureBox();
            this.buttonShowGraph = new System.Windows.Forms.Button();
            this.buttonShowAlarm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbValve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor_1)).BeginInit();
            this.SuspendLayout();
            // 
            // updateTimer1
            // 
            this.updateTimer1.Tick += new System.EventHandler(this.updateTimer1_Tick);
            // 
            // enableCbTimer
            // 
            this.enableCbTimer.Tick += new System.EventHandler(this.enableCbTimer_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(83, 438);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(120, 62);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonStart_MouseDown);
            this.buttonStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonStart_MouseUp);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(83, 510);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(120, 62);
            this.buttonStop.TabIndex = 10;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonStop_MouseDown);
            this.buttonStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonStop_MouseUp);
            // 
            // zedGraphLevel
            // 
            this.zedGraphLevel.Location = new System.Drawing.Point(547, 14);
            this.zedGraphLevel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.zedGraphLevel.Name = "zedGraphLevel";
            this.zedGraphLevel.ScrollGrace = 0D;
            this.zedGraphLevel.ScrollMaxX = 0D;
            this.zedGraphLevel.ScrollMaxY = 0D;
            this.zedGraphLevel.ScrollMaxY2 = 0D;
            this.zedGraphLevel.ScrollMinX = 0D;
            this.zedGraphLevel.ScrollMinY = 0D;
            this.zedGraphLevel.ScrollMinY2 = 0D;
            this.zedGraphLevel.Size = new System.Drawing.Size(749, 414);
            this.zedGraphLevel.TabIndex = 11;
            // 
            // barLevel
            // 
            this.barLevel.BackColor = System.Drawing.Color.DarkGray;
            this.barLevel.Font = new System.Drawing.Font("Consolas", 10.25F);
            this.barLevel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.barLevel.Location = new System.Drawing.Point(289, 32);
            this.barLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barLevel.Name = "barLevel";
            this.barLevel.Size = new System.Drawing.Size(49, 462);
            this.barLevel.TabIndex = 9;
            this.barLevel.Text = "basicProgressBar1";
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.AutoSize = true;
            this.rjToggleButton1.Location = new System.Drawing.Point(659, 470);
            this.rjToggleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton1.Size = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.TabIndex = 12;
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            // 
            // pbValve
            // 
            this.pbValve.Image = global::MySCADA.Properties.Resources.Valve_off;
            this.pbValve.Location = new System.Drawing.Point(365, 343);
            this.pbValve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbValve.Name = "pbValve";
            this.pbValve.Size = new System.Drawing.Size(147, 135);
            this.pbValve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbValve.TabIndex = 8;
            this.pbValve.TabStop = false;
            this.pbValve.Click += new System.EventHandler(this.pbValve_Click);
            // 
            // pbMotor_2
            // 
            this.pbMotor_2.Image = global::MySCADA.Properties.Resources.Motor_off_1;
            this.pbMotor_2.Location = new System.Drawing.Point(83, 252);
            this.pbMotor_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMotor_2.Name = "pbMotor_2";
            this.pbMotor_2.Size = new System.Drawing.Size(147, 135);
            this.pbMotor_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMotor_2.TabIndex = 7;
            this.pbMotor_2.TabStop = false;
            this.pbMotor_2.Click += new System.EventHandler(this.pbMotor_2_Click);
            // 
            // pbMotor_1
            // 
            this.pbMotor_1.Image = global::MySCADA.Properties.Resources.Motor_off_1;
            this.pbMotor_1.Location = new System.Drawing.Point(83, 57);
            this.pbMotor_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMotor_1.Name = "pbMotor_1";
            this.pbMotor_1.Size = new System.Drawing.Size(147, 135);
            this.pbMotor_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMotor_1.TabIndex = 7;
            this.pbMotor_1.TabStop = false;
            this.pbMotor_1.Click += new System.EventHandler(this.pbMotor_1_Click);
            // 
            // buttonShowGraph
            // 
            this.buttonShowGraph.Location = new System.Drawing.Point(867, 498);
            this.buttonShowGraph.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShowGraph.Name = "buttonShowGraph";
            this.buttonShowGraph.Size = new System.Drawing.Size(175, 62);
            this.buttonShowGraph.TabIndex = 13;
            this.buttonShowGraph.Text = "SHOW GRAPH";
            this.buttonShowGraph.UseVisualStyleBackColor = true;
            this.buttonShowGraph.Click += new System.EventHandler(this.buttonShowGraph_Click);
            // 
            // buttonShowAlarm
            // 
            this.buttonShowAlarm.Location = new System.Drawing.Point(1121, 498);
            this.buttonShowAlarm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowAlarm.Name = "buttonShowAlarm";
            this.buttonShowAlarm.Size = new System.Drawing.Size(175, 62);
            this.buttonShowAlarm.TabIndex = 13;
            this.buttonShowAlarm.Text = "SHOW ALARM";
            this.buttonShowAlarm.UseVisualStyleBackColor = true;
            this.buttonShowAlarm.Click += new System.EventHandler(this.buttonShowAlarm_Click);
            // 
            // GraphicDisplayDrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 615);
            this.Controls.Add(this.buttonShowAlarm);
            this.Controls.Add(this.buttonShowGraph);
            this.Controls.Add(this.rjToggleButton1);
            this.Controls.Add(this.zedGraphLevel);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.barLevel);
            this.Controls.Add(this.pbValve);
            this.Controls.Add(this.pbMotor_2);
            this.Controls.Add(this.pbMotor_1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GraphicDisplayDrag";
            this.Text = "GraphicDisplayDrag";
            this.Load += new System.EventHandler(this.GraphicDisplayDrag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbValve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer updateTimer1;
        private System.Windows.Forms.PictureBox pbMotor_1;
        private System.Windows.Forms.PictureBox pbMotor_2;
        private System.Windows.Forms.Timer enableCbTimer;
        private System.Windows.Forms.PictureBox pbValve;
        private ProgressBars.Basic.BasicProgressBar barLevel;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private ZedGraph.ZedGraphControl zedGraphLevel;
        private RJToggleButton rjToggleButton1;
        private System.Windows.Forms.Button buttonShowGraph;
        private System.Windows.Forms.Button buttonShowAlarm;
    }
}