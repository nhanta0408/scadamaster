
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
            this.pbMotor_1 = new System.Windows.Forms.PictureBox();
            this.pbMotor_2 = new System.Windows.Forms.PictureBox();
            this.enableCbTimer = new System.Windows.Forms.Timer(this.components);
            this.pbValve = new System.Windows.Forms.PictureBox();
            this.barLevel = new ProgressBars.Basic.BasicProgressBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValve)).BeginInit();
            this.SuspendLayout();
            // 
            // updateTimer1
            // 
            this.updateTimer1.Tick += new System.EventHandler(this.updateTimer1_Tick);
            // 
            // pbMotor_1
            // 
            this.pbMotor_1.Location = new System.Drawing.Point(83, 56);
            this.pbMotor_1.Name = "pbMotor_1";
            this.pbMotor_1.Size = new System.Drawing.Size(150, 150);
            this.pbMotor_1.TabIndex = 7;
            this.pbMotor_1.TabStop = false;
            this.pbMotor_1.Click += new System.EventHandler(this.pbMotor_1_Click);
            // 
            // pbMotor_2
            // 
            this.pbMotor_2.Location = new System.Drawing.Point(83, 252);
            this.pbMotor_2.Name = "pbMotor_2";
            this.pbMotor_2.Size = new System.Drawing.Size(150, 150);
            this.pbMotor_2.TabIndex = 7;
            this.pbMotor_2.TabStop = false;
            this.pbMotor_2.Click += new System.EventHandler(this.pbMotor_2_Click);
            // 
            // enableCbTimer
            // 
            this.enableCbTimer.Tick += new System.EventHandler(this.enableCbTimer_Tick);
            // 
            // pbValve
            // 
            this.pbValve.Location = new System.Drawing.Point(934, 369);
            this.pbValve.Name = "pbValve";
            this.pbValve.Size = new System.Drawing.Size(150, 150);
            this.pbValve.TabIndex = 8;
            this.pbValve.TabStop = false;
            this.pbValve.Click += new System.EventHandler(this.pbValve_Click);
            // 
            // barLevel
            // 
            this.barLevel.BackColor = System.Drawing.Color.DarkGray;
            this.barLevel.Font = new System.Drawing.Font("Consolas", 10.25F);
            this.barLevel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.barLevel.Location = new System.Drawing.Point(623, 26);
            this.barLevel.Name = "barLevel";
            this.barLevel.Size = new System.Drawing.Size(49, 461);
            this.barLevel.TabIndex = 9;
            this.barLevel.Text = "basicProgressBar1";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(1116, 56);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonStart_MouseDown);
            this.buttonStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonStart_MouseUp);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(1116, 89);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 10;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonStop_MouseDown);
            this.buttonStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonStop_MouseUp);
            // 
            // GraphicDisplayDrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 615);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.barLevel);
            this.Controls.Add(this.pbValve);
            this.Controls.Add(this.pbMotor_2);
            this.Controls.Add(this.pbMotor_1);
            this.Name = "GraphicDisplayDrag";
            this.Text = "GraphicDisplayDrag";
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValve)).EndInit();
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
    }
}