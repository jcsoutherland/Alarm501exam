using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm501Exam
{
    class Model
    {
        private DateTime storedTime { get; set; }

        public void setStoredTime(DateTime time)
        {
            storedTime = time;
        }

        public DateTime getStoredTime()
        {
            return storedTime;
        }
    }
}
