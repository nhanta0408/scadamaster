
namespace MySCADA
{
    partial class MotorModbus
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
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.pbRunFB = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.progressBarLevel = new ProgressBars.Basic.BasicProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDisconnect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(46, 204);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 50);
            this.btnStop.TabIndex = 104;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseDown);
            this.btnStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseUp);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(46, 134);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 50);
            this.btnStart.TabIndex = 105;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStart_MouseDown);
            this.btnStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStart_MouseUp);
            // 
            // cbMode
            // 
            this.cbMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMode.FormattingEnabled = true;
            this.cbMode.ItemHeight = 25;
            this.cbMode.Items.AddRange(new object[] {
            "Manual",
            "Auto"});
            this.cbMode.Location = new System.Drawing.Point(46, 71);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(148, 33);
            this.cbMode.TabIndex = 106;
            this.cbMode.SelectedIndexChanged += new System.EventHandler(this.cbMode_SelectedIndexChanged);
            // 
            // pbRunFB
            // 
            this.pbRunFB.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.pbRunFB.Location = new System.Drawing.Point(163, 141);
            this.pbRunFB.Name = "pbRunFB";
            this.pbRunFB.Size = new System.Drawing.Size(55, 55);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.pbRunFB});
            this.shapeContainer1.Size = new System.Drawing.Size(482, 419);
            this.shapeContainer1.TabIndex = 107;
            this.shapeContainer1.TabStop = false;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // progressBarLevel
            // 
            this.progressBarLevel.BackColor = System.Drawing.Color.DarkGray;
            this.progressBarLevel.Font = new System.Drawing.Font("Consolas", 10.25F);
            this.progressBarLevel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.progressBarLevel.Location = new System.Drawing.Point(349, 92);
            this.progressBarLevel.Maximum = 1000;
            this.progressBarLevel.Name = "progressBarLevel";
            this.progressBarLevel.Size = new System.Drawing.Size(64, 162);
            this.progressBarLevel.TabIndex = 108;
            this.progressBarLevel.Text = "basicProgressBar1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 109;
            this.label1.Text = "ComboBox 40101";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 110;
            this.label2.Text = "Start 10102";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 110;
            this.label3.Text = "Stop 10103";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 109;
            this.label4.Text = "Light 10101";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 110;
            this.label5.Text = "ProgressBar 40100";
            // 
            // labelDisconnect
            // 
            this.labelDisconnect.AutoSize = true;
            this.labelDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisconnect.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDisconnect.Location = new System.Drawing.Point(88, 24);
            this.labelDisconnect.Name = "labelDisconnect";
            this.labelDisconnect.Size = new System.Drawing.Size(314, 32);
            this.labelDisconnect.TabIndex = 111;
            this.labelDisconnect.Text = "Chưa kết nối MODSIM";
            // 
            // MotorModbus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 419);
            this.Controls.Add(this.labelDisconnect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarLevel);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbMode);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "MotorModbus";
            this.Text = "MotorModbus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MotorModbus_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbMode;
        private Microsoft.VisualBasic.PowerPacks.OvalShape pbRunFB;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Timer timerUpdate;
        private ProgressBars.Basic.BasicProgressBar progressBarLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDisconnect;
    }
}