using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501Exam
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            time_picker.Value = DateTime.Now;
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        delegate void UpdateLabel(Label lbl, string value);
        void UpdateDataLabel(Label lbl, string value)
        {
            lbl.Text = value;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = time_picker.Value;
            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                timer.Stop();
                try
                {
                    UpdateLabel upd = UpdateDataLabel;
                    if (lbl_status.InvokeRequired)
                    {
                        Invoke(upd, lbl_status, "Stop");
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_set_start_Click(object sender, EventArgs e)
        {
            timer.Start();
            lbl_status.Text = "Running";
        }

        private void Btn_stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lbl_status.Text = "Stop";
        }
    }
}
