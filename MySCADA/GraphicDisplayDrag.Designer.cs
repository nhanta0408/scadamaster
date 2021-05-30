
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
            this.btMotor_1_Stop = new System.Windows.Forms.Button();
            this.btMotor_1_Start = new System.Windows.Forms.Button();
            this.cbMotor_1_Mode = new System.Windows.Forms.ComboBox();
            this.pbMotor_1_RunFB = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.updateTimer1 = new System.Windows.Forms.Timer(this.components);
            this.btMotor_2_Stop = new System.Windows.Forms.Button();
            this.btMotor_2_Start = new System.Windows.Forms.Button();
            this.cbMotor_2_Mode = new System.Windows.Forms.ComboBox();
            this.pbMotor_2_RunFB = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.btValve_Stop = new System.Windows.Forms.Button();
            this.btValve_Start = new System.Windows.Forms.Button();
            this.cbValve_Mode = new System.Windows.Forms.ComboBox();
            this.pbValve_RunFB = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.gbMotor_1 = new System.Windows.Forms.GroupBox();
            this.shapeContainer4 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.gbMotor_2 = new System.Windows.Forms.GroupBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.gbValve = new System.Windows.Forms.GroupBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.pbMotor_1 = new System.Windows.Forms.PictureBox();
            this.pbMotor_2 = new System.Windows.Forms.PictureBox();
            this.enableCbTimer = new System.Windows.Forms.Timer(this.components);
            this.pbValve = new System.Windows.Forms.PictureBox();
            this.gbMotor_1.SuspendLayout();
            this.gbMotor_2.SuspendLayout();
            this.gbValve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValve)).BeginInit();
            this.SuspendLayout();
            // 
            // btMotor_1_Stop
            // 
            this.btMotor_1_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMotor_1_Stop.Location = new System.Drawing.Point(26, 173);
            this.btMotor_1_Stop.Name = "btMotor_1_Stop";
            this.btMotor_1_Stop.Size = new System.Drawing.Size(90, 50);
            this.btMotor_1_Stop.TabIndex = 1;
            this.btMotor_1_Stop.Text = "Stop";
            this.btMotor_1_Stop.UseVisualStyleBackColor = true;
            this.btMotor_1_Stop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMotor_1_Stop_MouseDown);
            this.btMotor_1_Stop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMotor_1_Stop_MouseUp);
            // 
            // btMotor_1_Start
            // 
            this.btMotor_1_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMotor_1_Start.Location = new System.Drawing.Point(26, 103);
            this.btMotor_1_Start.Name = "btMotor_1_Start";
            this.btMotor_1_Start.Size = new System.Drawing.Size(90, 50);
            this.btMotor_1_Start.TabIndex = 1;
            this.btMotor_1_Start.Text = "Start";
            this.btMotor_1_Start.UseVisualStyleBackColor = true;
            this.btMotor_1_Start.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMotor_1_Start_MouseDown);
            this.btMotor_1_Start.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMotor_1_Start_MouseUp);
            // 
            // cbMotor_1_Mode
            // 
            this.cbMotor_1_Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMotor_1_Mode.FormattingEnabled = true;
            this.cbMotor_1_Mode.ItemHeight = 25;
            this.cbMotor_1_Mode.Items.AddRange(new object[] {
            "Manual",
            "Auto"});
            this.cbMotor_1_Mode.Location = new System.Drawing.Point(38, 40);
            this.cbMotor_1_Mode.Name = "cbMotor_1_Mode";
            this.cbMotor_1_Mode.Size = new System.Drawing.Size(148, 33);
            this.cbMotor_1_Mode.TabIndex = 100;
            this.cbMotor_1_Mode.SelectedIndexChanged += new System.EventHandler(this.cbMotor_1_Mode_SelectedIndexChanged);
            // 
            // pbMotor_1_RunFB
            // 
            this.pbMotor_1_RunFB.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.pbMotor_1_RunFB.Location = new System.Drawing.Point(150, 73);
            this.pbMotor_1_RunFB.Name = "pbMotor_1_RunFB";
            this.pbMotor_1_RunFB.Size = new System.Drawing.Size(55, 55);
            // 
            // updateTimer1
            // 
            this.updateTimer1.Tick += new System.EventHandler(this.updateTimer1_Tick);
            // 
            // btMotor_2_Stop
            // 
            this.btMotor_2_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMotor_2_Stop.Location = new System.Drawing.Point(42, 173);
            this.btMotor_2_Stop.Name = "btMotor_2_Stop";
            this.btMotor_2_Stop.Size = new System.Drawing.Size(90, 50);
            this.btMotor_2_Stop.TabIndex = 1;
            this.btMotor_2_Stop.Text = "Stop";
            this.btMotor_2_Stop.UseVisualStyleBackColor = true;
            this.btMotor_2_Stop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMotor_2_Stop_MouseDown);
            this.btMotor_2_Stop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMotor_2_Stop_MouseUp);
            // 
            // btMotor_2_Start
            // 
            this.btMotor_2_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMotor_2_Start.Location = new System.Drawing.Point(42, 103);
            this.btMotor_2_Start.Name = "btMotor_2_Start";
            this.btMotor_2_Start.Size = new System.Drawing.Size(90, 50);
            this.btMotor_2_Start.TabIndex = 1;
            this.btMotor_2_Start.Text = "Start";
            this.btMotor_2_Start.UseVisualStyleBackColor = true;
            this.btMotor_2_Start.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMotor_2_Start_MouseDown);
            this.btMotor_2_Start.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMotor_2_Start_MouseUp);
            // 
            // cbMotor_2_Mode
            // 
            this.cbMotor_2_Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMotor_2_Mode.FormattingEnabled = true;
            this.cbMotor_2_Mode.Items.AddRange(new object[] {
            "Manual",
            "Auto"});
            this.cbMotor_2_Mode.Location = new System.Drawing.Point(54, 40);
            this.cbMotor_2_Mode.Name = "cbMotor_2_Mode";
            this.cbMotor_2_Mode.Size = new System.Drawing.Size(148, 33);
            this.cbMotor_2_Mode.TabIndex = 0;
            this.cbMotor_2_Mode.SelectedIndexChanged += new System.EventHandler(this.cbMotor_2_Mode_SelectedIndexChanged);
            // 
            // pbMotor_2_RunFB
            // 
            this.pbMotor_2_RunFB.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.pbMotor_2_RunFB.Location = new System.Drawing.Point(161, 73);
            this.pbMotor_2_RunFB.Name = "pbMotor_2_RunFB";
            this.pbMotor_2_RunFB.Size = new System.Drawing.Size(55, 55);
            // 
            // btValve_Stop
            // 
            this.btValve_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValve_Stop.Location = new System.Drawing.Point(53, 173);
            this.btValve_Stop.Name = "btValve_Stop";
            this.btValve_Stop.Size = new System.Drawing.Size(90, 50);
            this.btValve_Stop.TabIndex = 1;
            this.btValve_Stop.Text = "Stop";
            this.btValve_Stop.UseVisualStyleBackColor = true;
            this.btValve_Stop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btValve_Stop_MouseDown);
            this.btValve_Stop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btValve_Stop_MouseUp);
            // 
            // btValve_Start
            // 
            this.btValve_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValve_Start.Location = new System.Drawing.Point(53, 103);
            this.btValve_Start.Name = "btValve_Start";
            this.btValve_Start.Size = new System.Drawing.Size(90, 50);
            this.btValve_Start.TabIndex = 1;
            this.btValve_Start.Text = "Start";
            this.btValve_Start.UseVisualStyleBackColor = true;
            this.btValve_Start.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btValve_Start_MouseDown);
            this.btValve_Start.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btValve_Start_MouseUp);
            // 
            // cbValve_Mode
            // 
            this.cbValve_Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbValve_Mode.FormattingEnabled = true;
            this.cbValve_Mode.Items.AddRange(new object[] {
            "Manual",
            "Auto"});
            this.cbValve_Mode.Location = new System.Drawing.Point(65, 40);
            this.cbValve_Mode.Name = "cbValve_Mode";
            this.cbValve_Mode.Size = new System.Drawing.Size(148, 33);
            this.cbValve_Mode.TabIndex = 0;
            this.cbValve_Mode.SelectedIndexChanged += new System.EventHandler(this.cbValve_Mode_SelectedIndexChanged);
            // 
            // pbValve_RunFB
            // 
            this.pbValve_RunFB.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.pbValve_RunFB.Location = new System.Drawing.Point(172, 72);
            this.pbValve_RunFB.Name = "pbValve_RunFB";
            this.pbValve_RunFB.Size = new System.Drawing.Size(55, 55);
            // 
            // gbMotor_1
            // 
            this.gbMotor_1.Controls.Add(this.btMotor_1_Stop);
            this.gbMotor_1.Controls.Add(this.btMotor_1_Start);
            this.gbMotor_1.Controls.Add(this.cbMotor_1_Mode);
            this.gbMotor_1.Controls.Add(this.shapeContainer4);
            this.gbMotor_1.Location = new System.Drawing.Point(60, 44);
            this.gbMotor_1.Name = "gbMotor_1";
            this.gbMotor_1.Size = new System.Drawing.Size(322, 245);
            this.gbMotor_1.TabIndex = 4;
            this.gbMotor_1.TabStop = false;
            this.gbMotor_1.Text = "groupBox1";
            this.gbMotor_1.Visible = false;
            // 
            // shapeContainer4
            // 
            this.shapeContainer4.Location = new System.Drawing.Point(3, 18);
            this.shapeContainer4.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer4.Name = "shapeContainer4";
            this.shapeContainer4.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.pbMotor_1_RunFB});
            this.shapeContainer4.Size = new System.Drawing.Size(316, 224);
            this.shapeContainer4.TabIndex = 2;
            this.shapeContainer4.TabStop = false;
            // 
            // gbMotor_2
            // 
            this.gbMotor_2.Controls.Add(this.btMotor_2_Stop);
            this.gbMotor_2.Controls.Add(this.cbMotor_2_Mode);
            this.gbMotor_2.Controls.Add(this.btMotor_2_Start);
            this.gbMotor_2.Controls.Add(this.shapeContainer1);
            this.gbMotor_2.Location = new System.Drawing.Point(387, 44);
            this.gbMotor_2.Name = "gbMotor_2";
            this.gbMotor_2.Size = new System.Drawing.Size(337, 245);
            this.gbMotor_2.TabIndex = 5;
            this.gbMotor_2.TabStop = false;
            this.gbMotor_2.Text = "groupBox2";
            this.gbMotor_2.Visible = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 18);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.pbMotor_2_RunFB});
            this.shapeContainer1.Size = new System.Drawing.Size(331, 224);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // gbValve
            // 
            this.gbValve.Controls.Add(this.btValve_Stop);
            this.gbValve.Controls.Add(this.cbValve_Mode);
            this.gbValve.Controls.Add(this.btValve_Start);
            this.gbValve.Controls.Add(this.shapeContainer2);
            this.gbValve.Location = new System.Drawing.Point(730, 44);
            this.gbValve.Name = "gbValve";
            this.gbValve.Size = new System.Drawing.Size(334, 245);
            this.gbValve.TabIndex = 6;
            this.gbValve.TabStop = false;
            this.gbValve.Text = "groupBox3";
            this.gbValve.Visible = false;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 18);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.pbValve_RunFB});
            this.shapeContainer2.Size = new System.Drawing.Size(328, 224);
            this.shapeContainer2.TabIndex = 2;
            this.shapeContainer2.TabStop = false;
            // 
            // pbMotor_1
            // 
            this.pbMotor_1.Location = new System.Drawing.Point(115, 315);
            this.pbMotor_1.Name = "pbMotor_1";
            this.pbMotor_1.Size = new System.Drawing.Size(200, 190);
            this.pbMotor_1.TabIndex = 7;
            this.pbMotor_1.TabStop = false;
            this.pbMotor_1.Click += new System.EventHandler(this.pbMotor_1_Click);
            // 
            // pbMotor_2
            // 
            this.pbMotor_2.Location = new System.Drawing.Point(462, 315);
            this.pbMotor_2.Name = "pbMotor_2";
            this.pbMotor_2.Size = new System.Drawing.Size(200, 190);
            this.pbMotor_2.TabIndex = 7;
            this.pbMotor_2.TabStop = false;
            this.pbMotor_2.Click += new System.EventHandler(this.pbMotor_2_Click);
            // 
            // pbValve
            // 
            this.pbValve.Location = new System.Drawing.Point(795, 315);
            this.pbValve.Name = "pbValve";
            this.pbValve.Size = new System.Drawing.Size(200, 190);
            this.pbValve.TabIndex = 8;
            this.pbValve.TabStop = false;
            this.pbValve.Click += new System.EventHandler(this.pbValve_Click);
            // 
            // GraphicDisplayDrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 615);
            this.Controls.Add(this.pbValve);
            this.Controls.Add(this.pbMotor_2);
            this.Controls.Add(this.pbMotor_1);
            this.Controls.Add(this.gbValve);
            this.Controls.Add(this.gbMotor_2);
            this.Controls.Add(this.gbMotor_1);
            this.Name = "GraphicDisplayDrag";
            this.Text = "GraphicDisplayDrag";
            this.gbMotor_1.ResumeLayout(false);
            this.gbMotor_2.ResumeLayout(false);
            this.gbValve.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotor_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbValve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btMotor_1_Stop;
        private System.Windows.Forms.Button btMotor_1_Start;
        private System.Windows.Forms.ComboBox cbMotor_1_Mode;
        private Microsoft.VisualBasic.PowerPacks.OvalShape pbMotor_1_RunFB;
        private System.Windows.Forms.Timer updateTimer1;
        private System.Windows.Forms.Button btMotor_2_Stop;
        private System.Windows.Forms.Button btMotor_2_Start;
        private System.Windows.Forms.ComboBox cbMotor_2_Mode;
        private Microsoft.VisualBasic.PowerPacks.OvalShape pbMotor_2_RunFB;
        private System.Windows.Forms.Button btValve_Stop;
        private System.Windows.Forms.Button btValve_Start;
        private System.Windows.Forms.ComboBox cbValve_Mode;
        private Microsoft.VisualBasic.PowerPacks.OvalShape pbValve_RunFB;
        private System.Windows.Forms.GroupBox gbMotor_1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer4;
        private System.Windows.Forms.GroupBox gbMotor_2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.GroupBox gbValve;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.PictureBox pbMotor_1;
        private System.Windows.Forms.PictureBox pbMotor_2;
        private System.Windows.Forms.Timer enableCbTimer;
        private System.Windows.Forms.PictureBox pbValve;
    }
}