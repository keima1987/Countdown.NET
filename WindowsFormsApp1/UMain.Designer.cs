namespace WindowsFormsApp1
{
    partial class frmCountdown
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCountdown));
            this.bdDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.tmCountdown = new System.Windows.Forms.Timer(this.components);
            this.speHours = new System.Windows.Forms.NumericUpDown();
            this.speMin = new System.Windows.Forms.NumericUpDown();
            this.speSec = new System.Windows.Forms.NumericUpDown();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.rbCounter = new System.Windows.Forms.RadioButton();
            this.rbCountdownT = new System.Windows.Forms.RadioButton();
            this.rbCountdownD = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.speHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speSec)).BeginInit();
            this.gbMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdDateTime
            // 
            this.bdDateTime.CustomFormat = "dd/MM/yyyy - HH:mm:ss";
            this.bdDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bdDateTime.Location = new System.Drawing.Point(12, 26);
            this.bdDateTime.Name = "bdDateTime";
            this.bdDateTime.ShowUpDown = true;
            this.bdDateTime.Size = new System.Drawing.Size(148, 22);
            this.bdDateTime.TabIndex = 0;
            this.bdDateTime.Value = new System.DateTime(2017, 10, 7, 0, 0, 0, 0);
            // 
            // lblCountdown
            // 
            this.lblCountdown.Font = new System.Drawing.Font("Digital-7 Mono", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.Location = new System.Drawing.Point(5, 56);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCountdown.Size = new System.Drawing.Size(320, 44);
            this.lblCountdown.TabIndex = 1;
            this.lblCountdown.Text = "--.--:--:--.---";
            this.lblCountdown.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 108);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(309, 25);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 139);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(309, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(12, 9);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(58, 13);
            this.lblDateTime.TabIndex = 4;
            this.lblDateTime.Text = "&Date/Time";
            // 
            // tmCountdown
            // 
            this.tmCountdown.Interval = 10;
            this.tmCountdown.Tick += new System.EventHandler(this.tmCountdown_Tick);
            // 
            // speHours
            // 
            this.speHours.Enabled = false;
            this.speHours.Location = new System.Drawing.Point(171, 26);
            this.speHours.Name = "speHours";
            this.speHours.ReadOnly = true;
            this.speHours.Size = new System.Drawing.Size(46, 22);
            this.speHours.TabIndex = 5;
            // 
            // speMin
            // 
            this.speMin.Enabled = false;
            this.speMin.Location = new System.Drawing.Point(223, 26);
            this.speMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.speMin.Name = "speMin";
            this.speMin.ReadOnly = true;
            this.speMin.Size = new System.Drawing.Size(46, 22);
            this.speMin.TabIndex = 6;
            this.speMin.ValueChanged += new System.EventHandler(this.speMin_ValueChanged);
            // 
            // speSec
            // 
            this.speSec.Enabled = false;
            this.speSec.Location = new System.Drawing.Point(275, 26);
            this.speSec.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.speSec.Name = "speSec";
            this.speSec.ReadOnly = true;
            this.speSec.Size = new System.Drawing.Size(46, 22);
            this.speSec.TabIndex = 7;
            this.speSec.ValueChanged += new System.EventHandler(this.speSec_ValueChanged);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(168, 9);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(38, 13);
            this.lblHours.TabIndex = 8;
            this.lblHours.Text = "&Hours";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(220, 9);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(30, 13);
            this.lblMin.TabIndex = 9;
            this.lblMin.Text = "&Min:";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(272, 9);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(27, 13);
            this.lblSec.TabIndex = 10;
            this.lblSec.Text = "S&ec:";
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.rbCounter);
            this.gbMode.Controls.Add(this.rbCountdownT);
            this.gbMode.Controls.Add(this.rbCountdownD);
            this.gbMode.Location = new System.Drawing.Point(331, 8);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(151, 154);
            this.gbMode.TabIndex = 11;
            this.gbMode.TabStop = false;
            this.gbMode.Tag = "0";
            this.gbMode.Text = "M&ode";
            // 
            // rbCounter
            // 
            this.rbCounter.AutoSize = true;
            this.rbCounter.Location = new System.Drawing.Point(16, 116);
            this.rbCounter.Name = "rbCounter";
            this.rbCounter.Size = new System.Drawing.Size(67, 17);
            this.rbCounter.TabIndex = 2;
            this.rbCounter.Text = "Counter";
            this.rbCounter.UseVisualStyleBackColor = true;
            this.rbCounter.CheckedChanged += new System.EventHandler(this.rbCounter_CheckedChanged);
            // 
            // rbCountdownT
            // 
            this.rbCountdownT.AutoSize = true;
            this.rbCountdownT.Location = new System.Drawing.Point(16, 69);
            this.rbCountdownT.Name = "rbCountdownT";
            this.rbCountdownT.Size = new System.Drawing.Size(123, 17);
            this.rbCountdownT.TabIndex = 1;
            this.rbCountdownT.Text = "Countdown (Timer)";
            this.rbCountdownT.UseVisualStyleBackColor = true;
            this.rbCountdownT.CheckedChanged += new System.EventHandler(this.rbCountdownT_CheckedChanged);
            // 
            // rbCountdownD
            // 
            this.rbCountdownD.AutoSize = true;
            this.rbCountdownD.Checked = true;
            this.rbCountdownD.Location = new System.Drawing.Point(16, 22);
            this.rbCountdownD.Name = "rbCountdownD";
            this.rbCountdownD.Size = new System.Drawing.Size(120, 17);
            this.rbCountdownD.TabIndex = 0;
            this.rbCountdownD.TabStop = true;
            this.rbCountdownD.Text = "Countdown (Date)";
            this.rbCountdownD.UseVisualStyleBackColor = true;
            this.rbCountdownD.CheckedChanged += new System.EventHandler(this.rbCountdownD_CheckedChanged);
            // 
            // frmCountdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 169);
            this.Controls.Add(this.gbMode);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.speSec);
            this.Controls.Add(this.speMin);
            this.Controls.Add(this.speHours);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.bdDateTime);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCountdown";
            this.Text = "Countdown/Counter";
            this.Load += new System.EventHandler(this.frmCountdown_Load);
            ((System.ComponentModel.ISupportInitialize)(this.speHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speSec)).EndInit();
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker bdDateTime;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer tmCountdown;
        private System.Windows.Forms.NumericUpDown speHours;
        private System.Windows.Forms.NumericUpDown speMin;
        private System.Windows.Forms.NumericUpDown speSec;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.RadioButton rbCounter;
        private System.Windows.Forms.RadioButton rbCountdownT;
        private System.Windows.Forms.RadioButton rbCountdownD;
    }
}

