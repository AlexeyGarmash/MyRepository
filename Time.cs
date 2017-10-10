using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metropolitan
{
    class Time
    {
        private int hour;
        private int minute;
        private int second;
        public Time()
        {
            this.minute = 0;
            this.second = 0;
            this.hour = 0;
        }
        public Time(int h, int m, int s)
        {
            this.hour = h;
            this.minute = m;
            this.second = s;
        }
        public int MIN
        {
            get { return minute; }
            set { minute = value; }
        }
        public int SEC
        {
            get { return second; }
            set { second = value; }
        }
        public int HOUR
        {
            get { return hour; }
            set { hour = value; }
        }
    }
}
