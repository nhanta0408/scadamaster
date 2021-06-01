
namespace MySCADA
{
    partial class AlarmDisplay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.updateTimer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewAlarm = new System.Windows.Forms.DataGridView();
            this.togEnabledUpdate = new MySCADA.RJToggleButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // updateTimer1
            // 
            this.updateTimer1.Interval = 500;
            this.updateTimer1.Tick += new System.EventHandler(this.updateTimer1_Tick);
            // 
            // dataGridViewAlarm
            // 
            this.dataGridViewAlarm.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAlarm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAlarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAlarm.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAlarm.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAlarm.Location = new System.Drawing.Point(39, 97);
            this.dataGridViewAlarm.Margin = new System.Windows.Forms.Padding(12);
            this.dataGridViewAlarm.Name = "dataGridViewAlarm";
            this.dataGridViewAlarm.ReadOnly = true;
            this.dataGridViewAlarm.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAlarm.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAlarm.RowHeadersVisible = false;
            this.dataGridViewAlarm.RowHeadersWidth = 55;
            this.dataGridViewAlarm.RowTemplate.Height = 50;
            this.dataGridViewAlarm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlarm.Size = new System.Drawing.Size(900, 800);
            this.dataGridViewAlarm.TabIndex = 131;
            this.dataGridViewAlarm.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridViewAlarm_Scroll);
            // 
            // togEnabledUpdate
            // 
            this.togEnabledUpdate.Location = new System.Drawing.Point(751, 34);
            this.togEnabledUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.togEnabledUpdate.MinimumSize = new System.Drawing.Size(45, 22);
            this.togEnabledUpdate.Name = "togEnabledUpdate";
            this.togEnabledUpdate.OffBackColor = System.Drawing.Color.Gray;
            this.togEnabledUpdate.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.togEnabledUpdate.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.togEnabledUpdate.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.togEnabledUpdate.Size = new System.Drawing.Size(79, 33);
            this.togEnabledUpdate.TabIndex = 132;
            this.togEnabledUpdate.UseVisualStyleBackColor = true;
            this.togEnabledUpdate.CheckedChanged += new System.EventHandler(this.togEnabledUpdate_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 133;
            this.label1.Text = "Enabled Update";
            // 
            // AlarmDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 1033);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.togEnabledUpdate);
            this.Controls.Add(this.dataGridViewAlarm);
            this.Name = "AlarmDisplay";
            this.Text = "AlarmDisplay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlarmDisplay_FormClosing);
            this.Load += new System.EventHandler(this.AlarmDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlarm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer updateTimer1;
        private System.Windows.Forms.DataGridView dataGridViewAlarm;
        private RJToggleButton togEnabledUpdate;
        private System.Windows.Forms.Label label1;
    }
}