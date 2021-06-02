
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicDisplayDrag));
            this.updateTimer1 = new System.Windows.Forms.Timer(this.components);
            this.enableCbTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.pbValve = new System.Windows.Forms.PictureBox();
            this.pbMotor_2 = new System.Windows.Forms.PictureBox();
            this.pbMotor_1 = new System.Windows.Forms.PictureBox();
            this.buttonShowGraph = new System.Windows.Forms.Button();
            this.buttonShowAlarm = new System.Windows.Forms.Button();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pbPipe1 = new System.Windows.Forms.PictureBox();
            this.pbPipe2 = new System.Windows.Forms.PictureBox();
            this.pbPipe3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.barLevel = new ProgressBars.Basic.BasicProgressBar();
            this.ovalRunning = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pbValve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(55)))));
            this.buttonStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(31, 41);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(149, 73);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            this.buttonStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonStart_MouseDown);
            this.buttonStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonStart_MouseUp);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(55)))));
            this.buttonStop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonStop.ForeColor = System.Drawing.Color.White;
            this.buttonStop.Location = new System.Drawing.Point(31, 128);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(149, 73);
            this.buttonStop.TabIndex = 10;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            this.buttonStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonStop_MouseDown);
            this.buttonStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonStop_MouseUp);
            // 
            // pbValve
            // 
            this.pbValve.Image = global::MySCADA.Properties.Resources.Valve_off;
            this.pbValve.Location = new System.Drawing.Point(1037, 495);
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
            this.pbMotor_2.Location = new System.Drawing.Point(91, 335);
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
            this.pbMotor_1.BackColor = System.Drawing.Color.Transparent;
            this.pbMotor_1.Image = global::MySCADA.Properties.Resources.Motor_off_1;
            this.pbMotor_1.Location = new System.Drawing.Point(88, 111);
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
            this.buttonShowGraph.BackColor = System.Drawing.Color.White;
            this.buttonShowGraph.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonShowGraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(77)))));
            this.buttonShowGraph.Location = new System.Drawing.Point(1310, 283);
            this.buttonShowGraph.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShowGraph.Name = "buttonShowGraph";
            this.buttonShowGraph.Size = new System.Drawing.Size(223, 74);
            this.buttonShowGraph.TabIndex = 13;
            this.buttonShowGraph.Text = "SHOW GRAPH";
            this.buttonShowGraph.UseVisualStyleBackColor = false;
            this.buttonShowGraph.Click += new System.EventHandler(this.buttonShowGraph_Click);
            // 
            // buttonShowAlarm
            // 
            this.buttonShowAlarm.BackColor = System.Drawing.Color.White;
            this.buttonShowAlarm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonShowAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(77)))));
            this.buttonShowAlarm.Location = new System.Drawing.Point(1310, 383);
            this.buttonShowAlarm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShowAlarm.Name = "buttonShowAlarm";
            this.buttonShowAlarm.Size = new System.Drawing.Size(223, 74);
            this.buttonShowAlarm.TabIndex = 13;
            this.buttonShowAlarm.Text = "SHOW ALARM";
            this.buttonShowAlarm.UseVisualStyleBackColor = false;
            this.buttonShowAlarm.Click += new System.EventHandler(this.buttonShowAlarm_Click);
            // 
            // pbBackground
            // 
            this.pbBackground.Image = ((System.Drawing.Image)(resources.GetObject("pbBackground.Image")));
            this.pbBackground.Location = new System.Drawing.Point(48, 27);
            this.pbBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(864, 660);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 14;
            this.pbBackground.TabStop = false;
            // 
            // pbPipe1
            // 
            this.pbPipe1.Image = ((System.Drawing.Image)(resources.GetObject("pbPipe1.Image")));
            this.pbPipe1.InitialImage = null;
            this.pbPipe1.Location = new System.Drawing.Point(277, 153);
            this.pbPipe1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPipe1.Name = "pbPipe1";
            this.pbPipe1.Size = new System.Drawing.Size(140, 49);
            this.pbPipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe1.TabIndex = 15;
            this.pbPipe1.TabStop = false;
            // 
            // pbPipe2
            // 
            this.pbPipe2.Image = ((System.Drawing.Image)(resources.GetObject("pbPipe2.Image")));
            this.pbPipe2.InitialImage = null;
            this.pbPipe2.Location = new System.Drawing.Point(277, 379);
            this.pbPipe2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPipe2.Name = "pbPipe2";
            this.pbPipe2.Size = new System.Drawing.Size(140, 49);
            this.pbPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe2.TabIndex = 16;
            this.pbPipe2.TabStop = false;
            // 
            // pbPipe3
            // 
            this.pbPipe3.Image = ((System.Drawing.Image)(resources.GetObject("pbPipe3.Image")));
            this.pbPipe3.InitialImage = null;
            this.pbPipe3.Location = new System.Drawing.Point(905, 574);
            this.pbPipe3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPipe3.Name = "pbPipe3";
            this.pbPipe3.Size = new System.Drawing.Size(140, 49);
            this.pbPipe3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe3.TabIndex = 17;
            this.pbPipe3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pbPipe3);
            this.groupBox1.Controls.Add(this.pbPipe2);
            this.groupBox1.Controls.Add(this.pbMotor_1);
            this.groupBox1.Controls.Add(this.pbPipe1);
            this.groupBox1.Controls.Add(this.pbMotor_2);
            this.groupBox1.Controls.Add(this.pbValve);
            this.groupBox1.Controls.Add(this.barLevel);
            this.groupBox1.Controls.Add(this.pbBackground);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1213, 758);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // barLevel
            // 
            this.barLevel.BackColor = System.Drawing.Color.DarkGray;
            this.barLevel.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barLevel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.barLevel.Location = new System.Drawing.Point(529, 140);
            this.barLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barLevel.Name = "barLevel";
            this.barLevel.Size = new System.Drawing.Size(64, 480);
            this.barLevel.TabIndex = 9;
            this.barLevel.Text = "basicProgressBar1";
            // 
            // ovalRunning
            // 
            this.ovalRunning.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalRunning.Location = new System.Drawing.Point(187, 64);
            this.ovalRunning.Name = "ovalRunning";
            this.ovalRunning.Size = new System.Drawing.Size(78, 79);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonStart);
            this.groupBox2.Controls.Add(this.buttonStop);
            this.groupBox2.Controls.Add(this.shapeContainer2);
            this.groupBox2.Location = new System.Drawing.Point(1294, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 225);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 18);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalRunning});
            this.shapeContainer2.Size = new System.Drawing.Size(401, 204);
            this.shapeContainer2.TabIndex = 11;
            this.shapeContainer2.TabStop = false;
            // 
            // GraphicDisplayDrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 743);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonShowGraph);
            this.Controls.Add(this.buttonShowAlarm);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GraphicDisplayDrag";
            this.Text = "GraphicDisplayDrag";
            this.Load += new System.EventHandler(this.GraphicDisplayDrag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbValve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button buttonShowGraph;
        private System.Windows.Forms.Button buttonShowAlarm;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.PictureBox pbPipe1;
        private System.Windows.Forms.PictureBox pbPipe2;
        private System.Windows.Forms.PictureBox pbPipe3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalRunning;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
    }
}