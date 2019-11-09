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
        //Making the controller, model, and status to send to the controller to update the view
        Controller controller = new Controller();
        Model model = new Model();

        //Creates timer object to keep track of how much time has passed
        System.Timers.Timer timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Sets the DateTimePicker object to the time of the machine
            time_picker.Value = DateTime.Now;
            //Starts the new timer with default settings
            timer = new System.Timers.Timer();
            //Sets the time interval
            timer.Interval = 1000;
            //Sets the elapsed time which we use with the compareCurrentTime method
            timer.Elapsed += compareCurrentTime;
            //Sets the beginning status to 0, so the controller knows how to set the view
            controller.setFormStatus(0);
            //The view getting updated from the controller
            lbl_status.Text = controller.updateStatus(controller.getFormStatus());
            btn_set_start.Text = controller.updateButtonStatus(controller.getFormStatus());
            
        }

        //Our delegate to update the labels
        delegate void UpdateLabel(Label lbl, string value);
        void updateDataLabel(Label lbl, string value)
        {
            lbl.Text = value;
        }

        //Compares current time with saved time so we know when the alarm goes off
        private void compareCurrentTime(object sender, System.Timers.ElapsedEventArgs e)
        {
            //Gets the current time
            DateTime currentTime = DateTime.Now;

            //Gets the saved time from the model
            DateTime userTime = model.getAlarmTime();
            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                timer.Stop();
                try
                {
                    UpdateLabel update = updateDataLabel;
                    controller.setFormStatus(3);
                    if (lbl_status.InvokeRequired)
                    {
                        Invoke(update, lbl_status, "Alarm Went Off");
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //When the Set/Start button is clicked it contacts the view to update the button/labels
        private void Btn_set_start_Click(object sender, EventArgs e)
        {
           if(controller.getFormStatus() == 0)
           {
                //SETS THE MODEL WHEN THE USER CLICKS SET
                model.setAlarmTime(time_picker.Value);
                controller.setFormStatus(1);
                btn_set_start.Text = controller.updateButtonStatus(controller.getFormStatus());
                lbl_status.Text = controller.updateStatus(controller.getFormStatus());
           }
           else if(controller.getFormStatus() == 1)
            {
                controller.setFormStatus(2);
                lbl_status.Text = controller.updateStatus(controller.getFormStatus());
                btn_stop.Enabled = controller.stopButtonEnabled(controller.getFormStatus());
                timer.Start();
                btn_set_start.Enabled = controller.startButtonEnabled(controller.getFormStatus());
            }
            
            
        }

        private void Btn_stop_Click(object sender, EventArgs e)
        {
            if(controller.getFormStatus() == 2)
            {
                controller.setFormStatus(0);
                timer.Stop();
                btn_set_start.Enabled = controller.startButtonEnabled(controller.getFormStatus());
                btn_stop.Enabled = controller.stopButtonEnabled(controller.getFormStatus());
                btn_set_start.Text = controller.updateButtonStatus(controller.getFormStatus());
                lbl_status.Text = controller.updateStatus(controller.getFormStatus());
            }

            else if(controller.getFormStatus() == 3)
            {
                lbl_status.Text = controller.updateStatus(controller.getFormStatus());
                controller.setFormStatus(0);
                btn_set_start.Text = controller.updateButtonStatus(controller.getFormStatus());
                btn_stop.Enabled = controller.stopButtonEnabled(controller.getFormStatus());
                btn_set_start.Enabled = controller.startButtonEnabled(controller.getFormStatus());
            }
        }
    }
}
