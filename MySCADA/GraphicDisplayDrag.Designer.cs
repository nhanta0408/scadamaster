
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
            this.buttonStart.Location = new System.Drawing.Point(62, 355);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(56, 19);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonStart_MouseDown);
            this.buttonStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonStart_MouseUp);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(62, 382);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(56, 19);
            this.buttonStop.TabIndex = 10;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonStop_MouseDown);
            this.buttonStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonStop_MouseUp);
            // 
            // zedGraphLevel
            // 
            this.zedGraphLevel.Location = new System.Drawing.Point(410, 11);
            this.zedGraphLevel.Name = "zedGraphLevel";
            this.zedGraphLevel.ScrollGrace = 0D;
            this.zedGraphLevel.ScrollMaxX = 0D;
            this.zedGraphLevel.ScrollMaxY = 0D;
            this.zedGraphLevel.ScrollMaxY2 = 0D;
            this.zedGraphLevel.ScrollMinX = 0D;
            this.zedGraphLevel.ScrollMinY = 0D;
            this.zedGraphLevel.ScrollMinY2 = 0D;
            this.zedGraphLevel.Size = new System.Drawing.Size(562, 336);
            this.zedGraphLevel.TabIndex = 11;
            // 
            // barLevel
            // 
            this.barLevel.BackColor = System.Drawing.Color.DarkGray;
            this.barLevel.Font = new System.Drawing.Font("Consolas", 10.25F);
            this.barLevel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.barLevel.Location = new System.Drawing.Point(217, 26);
            this.barLevel.Margin = new System.Windows.Forms.Padding(2);
            this.barLevel.Name = "barLevel";
            this.barLevel.Size = new System.Drawing.Size(37, 375);
            this.barLevel.TabIndex = 9;
            this.barLevel.Text = "basicProgressBar1";
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.AutoSize = true;
            this.rjToggleButton1.Location = new System.Drawing.Point(494, 382);
            this.rjToggleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(34, 18);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton1.Size = new System.Drawing.Size(34, 18);
            this.rjToggleButton1.TabIndex = 12;
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            this.rjToggleButton1.CheckedChanged += new System.EventHandler(this.rjToggleButton1_CheckedChanged);
            // 
            // pbValve
            // 
            this.pbValve.Image = global::MySCADA.Properties.Resources.Valve_off;
            this.pbValve.Location = new System.Drawing.Point(274, 279);
            this.pbValve.Margin = new System.Windows.Forms.Padding(2);
            this.pbValve.Name = "pbValve";
            this.pbValve.Size = new System.Drawing.Size(110, 110);
            this.pbValve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbValve.TabIndex = 8;
            this.pbValve.TabStop = false;
            this.pbValve.Click += new System.EventHandler(this.pbValve_Click);
            // 
            // pbMotor_2
            // 
            this.pbMotor_2.Image = global::MySCADA.Properties.Resources.Motor_off_1;
            this.pbMotor_2.Location = new System.Drawing.Point(62, 205);
            this.pbMotor_2.Margin = new System.Windows.Forms.Padding(2);
            this.pbMotor_2.Name = "pbMotor_2";
            this.pbMotor_2.Size = new System.Drawing.Size(110, 110);
            this.pbMotor_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMotor_2.TabIndex = 7;
            this.pbMotor_2.TabStop = false;
            this.pbMotor_2.Click += new System.EventHandler(this.pbMotor_2_Click);
            // 
            // pbMotor_1
            // 
            this.pbMotor_1.Image = global::MySCADA.Properties.Resources.Motor_off_1;
            this.pbMotor_1.Location = new System.Drawing.Point(62, 46);
            this.pbMotor_1.Margin = new System.Windows.Forms.Padding(2);
            this.pbMotor_1.Name = "pbMotor_1";
            this.pbMotor_1.Size = new System.Drawing.Size(110, 110);
            this.pbMotor_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMotor_1.TabIndex = 7;
            this.pbMotor_1.TabStop = false;
            this.pbMotor_1.Click += new System.EventHandler(this.pbMotor_1_Click);
            // 
            // GraphicDisplayDrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 500);
            this.Controls.Add(this.rjToggleButton1);
            this.Controls.Add(this.zedGraphLevel);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.barLevel);
            this.Controls.Add(this.pbValve);
            this.Controls.Add(this.pbMotor_2);
            this.Controls.Add(this.pbMotor_1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}