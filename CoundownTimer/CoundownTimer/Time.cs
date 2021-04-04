using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoundownTimer
{
    class Time
    {
        public int timesecond=60;
        public int minute;
        public int Millisecond=100;
        public int Interval;
        public TimeSpan starttime;
        public int RemaningInterval;
        public TimeSpan totaltimeremanining;
        public int Hour;
        public int Intervaltime;

        //public Time()
        //{
        //    this.timesecond = 60;
        //    this.minute 
        //    this.Hour = 0;
        //    this.Interval = 0;
        //    this.Intervaltime = 0;
        //}
        public void check()
        {
           
            if(timesecond!=0&&minute!=0&&Millisecond==0)
            {
                timesecond -= 1;
               //minute -= 1;
                Millisecond = 100;
            }
            else if(timesecond==0&&Millisecond==0&&minute!=0)
            {
                minute -= 1;
                timesecond = 60;
                Millisecond = 100;
            }
            else
            {
                Millisecond -= 1;
            }
        }

        public string Conveter(int value)
        {
            StringBuilder sb = new StringBuilder();
            if(value<10)
            {
                sb.Append("0" + value);
            }
            else
            {
                sb.Append(value);
            }
            return sb.ToString();
        }
    }
}
