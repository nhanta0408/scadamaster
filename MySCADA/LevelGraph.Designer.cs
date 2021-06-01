
namespace MySCADA
{
    partial class LevelGraph
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
            this.zedGraphLevel = new ZedGraph.ZedGraphControl();
            this.updateTimer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.togCompactMode = new MySCADA.RJToggleButton();
            this.togIsEnabledPan = new MySCADA.RJToggleButton();
            this.SuspendLayout();
            // 
            // zedGraphLevel
            // 
            this.zedGraphLevel.Location = new System.Drawing.Point(34, 33);
            this.zedGraphLevel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.zedGraphLevel.Name = "zedGraphLevel";
            this.zedGraphLevel.ScrollGrace = 0D;
            this.zedGraphLevel.ScrollMaxX = 0D;
            this.zedGraphLevel.ScrollMaxY = 0D;
            this.zedGraphLevel.ScrollMaxY2 = 0D;
            this.zedGraphLevel.ScrollMinX = 0D;
            this.zedGraphLevel.ScrollMinY = 0D;
            this.zedGraphLevel.ScrollMinY2 = 0D;
            this.zedGraphLevel.Size = new System.Drawing.Size(917, 508);
            this.zedGraphLevel.TabIndex = 12;
            // 
            // updateTimer1
            // 
            this.updateTimer1.Interval = 500;
            this.updateTimer1.Tick += new System.EventHandler(this.updateTimer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 574);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enabled Pan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 633);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Compact Mode";
            // 
            // togCompactMode
            // 
            this.togCompactMode.Location = new System.Drawing.Point(202, 630);
            this.togCompactMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.togCompactMode.MinimumSize = new System.Drawing.Size(45, 22);
            this.togCompactMode.Name = "togCompactMode";
            this.togCompactMode.OffBackColor = System.Drawing.Color.Gray;
            this.togCompactMode.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.togCompactMode.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.togCompactMode.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.togCompactMode.Size = new System.Drawing.Size(76, 33);
            this.togCompactMode.TabIndex = 13;
            this.togCompactMode.UseVisualStyleBackColor = true;
            this.togCompactMode.CheckedChanged += new System.EventHandler(this.togCompactMode_CheckedChanged);
            // 
            // togIsEnabledPan
            // 
            this.togIsEnabledPan.Location = new System.Drawing.Point(202, 566);
            this.togIsEnabledPan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.togIsEnabledPan.MinimumSize = new System.Drawing.Size(45, 22);
            this.togIsEnabledPan.Name = "togIsEnabledPan";
            this.togIsEnabledPan.OffBackColor = System.Drawing.Color.Gray;
            this.togIsEnabledPan.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.togIsEnabledPan.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.togIsEnabledPan.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.togIsEnabledPan.Size = new System.Drawing.Size(76, 33);
            this.togIsEnabledPan.TabIndex = 13;
            this.togIsEnabledPan.UseVisualStyleBackColor = true;
            this.togIsEnabledPan.CheckedChanged += new System.EventHandler(this.togIsEnabledPan_CheckedChanged);
            // 
            // LevelGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.togCompactMode);
            this.Controls.Add(this.togIsEnabledPan);
            this.Controls.Add(this.zedGraphLevel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LevelGraph";
            this.Text = "LevelGraph";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LevelGraph_FormClosing);
            this.Load += new System.EventHandler(this.LevelGraph_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphLevel;
        private RJToggleButton togIsEnabledPan;
        private System.Windows.Forms.Timer updateTimer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private RJToggleButton togCompactMode;
    }
}