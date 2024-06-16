using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace WindowsFormsApp1
{
    public partial class YoutubeTimer : Form
    {
        public static TimeSpan timeLimit;
        public static Stopwatch Stopwatch = new Stopwatch();
        public YoutubeTimer()
        {
            InitializeComponent();
            
        }

        private void Panel1ButtonStart_Click(object sender, EventArgs e)
        {
            Stopwatch.Start();
        }

        private void Panel1DisplayTimer_Tick(object sender, EventArgs e)
        {
            Panel1LabelTimer.Font = new Font("Microsoft Sans Serif", (float)Math.Round(Width*0.1,2)+ (float)Math.Round(Height * 0.1, 2)-18);

            Panel1ButtonStart.Width = (Width / 3)-30;
            Panel1ButtonStop .Width = (Width / 3)-30;
            Panel1ButtonReset.Width = (Width / 3)-30;

            Panel1LabelTimer.Location = new Point(Width / 10, 5);

            Panel1ButtonStart.Location = new Point(10,Height-120);
            Panel1ButtonStop.Location = new Point(10 + Panel1ButtonStart.Width, Height-120);
            Panel1ButtonReset.Location = new Point(10 + Panel1ButtonStart.Width + Panel1ButtonStop.Width, Height-120);

            Panel1Radio15.Location = new Point(10 + ((int)Math.Round(Panel1ButtonStart.Width * 0.2, 0)), Height - 175);
            Panel1Radio30.Location = new Point(10 + Panel1ButtonStart.Width +((int)Math.Round(Panel1ButtonStop.Width * 0.2, 0)), Height - 175);
            Panel1Radio45.Location = new Point(10 + Panel1ButtonStart.Width + Panel1ButtonStop.Width + ((int)Math.Round(Panel1ButtonReset.Width * 0.2, 0)), Height - 175);

            if (Stopwatch.IsRunning)
            {
                string stopWatchStr = Stopwatch.Elapsed.ToString();
                string stopWatchStrOutPut = stopWatchStr.Substring(0, stopWatchStr.Length - 8);
                Panel1LabelTimer.Text = stopWatchStrOutPut;

                if(Panel1Radio15.Checked == false && Panel1Radio30.Checked == false && Panel1Radio45.Checked == false)
                {
                    Panel1.BackColor = Color.FromArgb(240, 240, 240);
                }

                if (Stopwatch.Elapsed <= timeLimit && Panel1Radio15.Checked == true || Panel1Radio30.Checked == true || Panel1Radio45.Checked == true)
                {
                    Panel1.BackColor = Color.LightGreen;
                }
                else if (Stopwatch.Elapsed > timeLimit && Panel1Radio15.Checked == true || Panel1Radio30.Checked == true || Panel1Radio45.Checked == true)
                {
                    Panel1.BackColor = Color.Red;
                }
                else
                {
                    Panel1.BackColor = Color.FromArgb(240, 240, 240);
                }
            }
            

        }

        private void Panel1Radio15_CheckedChanged(object sender, EventArgs e)
        {
            if (Panel1Radio15.Checked) 
            { 
                timeLimit = TimeSpan.Parse("00:15:00");

            }        
        }

        private void Panel1Radio30_CheckedChanged(object sender, EventArgs e)
        {
            if (Panel1Radio30.Checked)
            {
                timeLimit = TimeSpan.Parse("00:30:00");

            }
        }

        private void Panel1Radio45_CheckedChanged(object sender, EventArgs e)
        {
            if (Panel1Radio45.Checked)
            {
                timeLimit = TimeSpan.Parse("00:45:00");

            }
        }

        private void Panel1ButtonStop_Click(object sender, EventArgs e)
        {
            Stopwatch.Stop();
            Panel1.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void Panel1ButtonReset_Click(object sender, EventArgs e)
        {
            Stopwatch = new Stopwatch();
            Panel1LabelTimer.Text = "00:00:00";
            Panel1.BackColor = Color.FromArgb(240, 240, 240);
        }
    }
}
