using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm501Exam
{
    class Model
    {
        private DateTime alarmTime { get; set; }

        public void setAlarmTime(DateTime time)
        {
            alarmTime = time;
        }

        public DateTime getAlarmTime()
        {
            return alarmTime;
        }

    }
}
