using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using TimeZoneConverter;

namespace DigitalClock
{
    class TimeZone
    {

       private DateTime _date;
        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date=value;
            }
        }
       private TimeZoneInfo timeinfo;
        private int _hour;
        public int Hour
        {
            get
            {
                return _hour=_date.Hour;
            }
        }
        private int _minute;
        public int Minute
        {
            get
            {
                return _minute=_date.Minute;
            }
        }
        private int _second;
        public int Second
        {
            get
            {
                return _second=_date.Second;
            }
        }

        private string _zone;
        public string Zone
        {
            get
            {
                return _zone;
            }
            set
            {
                value = _zone;
            }
        }
        private string _day;
        public string Day
        {
            get
            {
                return _day = _date.Day.ToString();
            }
        }
        public void TimeConverter(string region)
        {
            timeinfo = TZConvert.GetTimeZoneInfo(region);
            Date = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeinfo);
        }

        public string Hourconvert(int h)
        {
            StringBuilder sb = new StringBuilder();
            if (h > 12)
            {
                h -= 12;
                sb.Append(h);
            }
            else if (h < 10)
            {
                sb.Append("0" + h);
            }
            else
            {
                sb.Append(h);
            }
            return sb.ToString();
        }

        public string Minutesconvert(int M)
        {
            StringBuilder sb = new StringBuilder();
            if (M < 10)
            {
                sb.Append("0" + M);
            }
            else
            {
                sb.Append(M);
            }
            return sb.ToString();
        }
        public string Secondconvert(int s)
        {
            StringBuilder sb = new StringBuilder();
            if (s < 10)
            {
                sb.Append("0" + s);
            }
            else
            {
                sb.Append(s);
            }
            return sb.ToString();
        }

        public void Convtertime(string s)
        {
           
        }
    }
}
