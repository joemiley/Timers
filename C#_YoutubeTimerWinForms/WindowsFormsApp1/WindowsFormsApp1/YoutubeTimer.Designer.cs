namespace WindowsFormsApp1
{
    partial class YoutubeTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoutubeTimer));
            this.Panel1ButtonStart = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel1LabelTimer = new System.Windows.Forms.Label();
            this.Panel1Radio45 = new System.Windows.Forms.RadioButton();
            this.Panel1Radio30 = new System.Windows.Forms.RadioButton();
            this.Panel1Radio15 = new System.Windows.Forms.RadioButton();
            this.Panel1ButtonReset = new System.Windows.Forms.Button();
            this.Panel1ButtonStop = new System.Windows.Forms.Button();
            this.Panel1DisplayTimer = new System.Windows.Forms.Timer(this.components);
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1ButtonStart
            // 
            this.Panel1ButtonStart.AutoSize = true;
            this.Panel1ButtonStart.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel1ButtonStart.Location = new System.Drawing.Point(3, 162);
            this.Panel1ButtonStart.Name = "Panel1ButtonStart";
            this.Panel1ButtonStart.Size = new System.Drawing.Size(160, 50);
            this.Panel1ButtonStart.TabIndex = 1;
            this.Panel1ButtonStart.Text = "Start";
            this.Panel1ButtonStart.UseVisualStyleBackColor = true;
            this.Panel1ButtonStart.Click += new System.EventHandler(this.Panel1ButtonStart_Click);
            // 
            // Panel1
            // 
            this.Panel1.AutoSize = true;
            this.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.Panel1.Controls.Add(this.Panel1Radio45);
            this.Panel1.Controls.Add(this.Panel1Radio30);
            this.Panel1.Controls.Add(this.Panel1Radio15);
            this.Panel1.Controls.Add(this.Panel1ButtonReset);
            this.Panel1.Controls.Add(this.Panel1ButtonStop);
            this.Panel1.Controls.Add(this.Panel1ButtonStart);
            this.Panel1.Controls.Add(this.Panel1LabelTimer);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(486, 215);
            this.Panel1.TabIndex = 3;
            // 
            // Panel1LabelTimer
            // 
            this.Panel1LabelTimer.AutoSize = true;
            this.Panel1LabelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold);
            this.Panel1LabelTimer.Location = new System.Drawing.Point(8, 9);
            this.Panel1LabelTimer.Name = "Panel1LabelTimer";
            this.Panel1LabelTimer.Size = new System.Drawing.Size(300, 76);
            this.Panel1LabelTimer.TabIndex = 7;
            this.Panel1LabelTimer.Text = "00:00:00";
            // 
            // Panel1Radio45
            // 
            this.Panel1Radio45.AutoSize = true;
            this.Panel1Radio45.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.Panel1Radio45.Location = new System.Drawing.Point(353, 113);
            this.Panel1Radio45.Name = "Panel1Radio45";
            this.Panel1Radio45.Size = new System.Drawing.Size(130, 43);
            this.Panel1Radio45.TabIndex = 6;
            this.Panel1Radio45.TabStop = true;
            this.Panel1Radio45.Text = "45min";
            this.Panel1Radio45.UseVisualStyleBackColor = true;
            this.Panel1Radio45.CheckedChanged += new System.EventHandler(this.Panel1Radio45_CheckedChanged);
            // 
            // Panel1Radio30
            // 
            this.Panel1Radio30.AutoSize = true;
            this.Panel1Radio30.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.Panel1Radio30.Location = new System.Drawing.Point(182, 113);
            this.Panel1Radio30.Name = "Panel1Radio30";
            this.Panel1Radio30.Size = new System.Drawing.Size(130, 43);
            this.Panel1Radio30.TabIndex = 5;
            this.Panel1Radio30.TabStop = true;
            this.Panel1Radio30.Text = "30min";
            this.Panel1Radio30.UseVisualStyleBackColor = true;
            this.Panel1Radio30.CheckedChanged += new System.EventHandler(this.Panel1Radio30_CheckedChanged);
            // 
            // Panel1Radio15
            // 
            this.Panel1Radio15.AutoSize = true;
            this.Panel1Radio15.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel1Radio15.Location = new System.Drawing.Point(21, 113);
            this.Panel1Radio15.Name = "Panel1Radio15";
            this.Panel1Radio15.Size = new System.Drawing.Size(130, 43);
            this.Panel1Radio15.TabIndex = 4;
            this.Panel1Radio15.TabStop = true;
            this.Panel1Radio15.Text = "15min";
            this.Panel1Radio15.UseVisualStyleBackColor = true;
            this.Panel1Radio15.CheckedChanged += new System.EventHandler(this.Panel1Radio15_CheckedChanged);
            // 
            // Panel1ButtonReset
            // 
            this.Panel1ButtonReset.AutoSize = true;
            this.Panel1ButtonReset.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.Panel1ButtonReset.Location = new System.Drawing.Point(323, 162);
            this.Panel1ButtonReset.Name = "Panel1ButtonReset";
            this.Panel1ButtonReset.Size = new System.Drawing.Size(160, 50);
            this.Panel1ButtonReset.TabIndex = 3;
            this.Panel1ButtonReset.Text = "Reset";
            this.Panel1ButtonReset.UseVisualStyleBackColor = true;
            this.Panel1ButtonReset.Click += new System.EventHandler(this.Panel1ButtonReset_Click);
            // 
            // Panel1ButtonStop
            // 
            this.Panel1ButtonStop.AutoSize = true;
            this.Panel1ButtonStop.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold);
            this.Panel1ButtonStop.Location = new System.Drawing.Point(163, 162);
            this.Panel1ButtonStop.Name = "Panel1ButtonStop";
            this.Panel1ButtonStop.Size = new System.Drawing.Size(160, 50);
            this.Panel1ButtonStop.TabIndex = 2;
            this.Panel1ButtonStop.Text = "Stop";
            this.Panel1ButtonStop.UseVisualStyleBackColor = true;
            this.Panel1ButtonStop.Click += new System.EventHandler(this.Panel1ButtonStop_Click);
            // 
            // Panel1DisplayTimer
            // 
            this.Panel1DisplayTimer.Enabled = true;
            this.Panel1DisplayTimer.Interval = 10;
            this.Panel1DisplayTimer.Tick += new System.EventHandler(this.Panel1DisplayTimer_Tick);
            // 
            // YoutubeTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(480, 211);
            this.Controls.Add(this.Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YoutubeTimer";
            this.Text = "YoutubeTimer";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Panel1ButtonStart;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label Panel1LabelTimer;
        private System.Windows.Forms.RadioButton Panel1Radio45;
        private System.Windows.Forms.RadioButton Panel1Radio30;
        private System.Windows.Forms.RadioButton Panel1Radio15;
        private System.Windows.Forms.Button Panel1ButtonReset;
        private System.Windows.Forms.Button Panel1ButtonStop;
        private System.Windows.Forms.Timer Panel1DisplayTimer;
    }
}

