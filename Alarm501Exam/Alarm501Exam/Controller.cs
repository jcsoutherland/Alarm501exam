using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm501Exam
{
    class Controller
    {

        int form_status;

        public string updateButtonStatus(int status)
        {
            if(status == 0)
            {
                return("Set");
            }
            else if(status == 1)
            {

                return("Start");
            }
            else
            {
                return ("Error");
            }
        }

        public string updateStatus(int status)
        {
            if(status == 0)
            {
                return ("Not Set");
            }
            else if(status == 1)
            {
                return("Alarm Set");
            }
            else if(status == 2)
            {
                return ("Running");
            }
            else if(status == 3) 
            {
                return ("Stopped");
            }
            else
            {
                return ("Error");
            }
        }

        public bool startButtonEnabled(int status)
        {
            if(status == 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool stopButtonEnabled(int status)
        {
            if (status == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getFormStatus()
        {
            return form_status;
        }

        public void setFormStatus(int x)
        {
            form_status = x;
        }


    }
}
