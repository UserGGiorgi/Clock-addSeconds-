using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Clock
    {
        int second;
        int minute;
        int hour;
        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                if (value < 24 && value >= 0)
                {
                    hour = value;
                }
                else
                {
                    Console.WriteLine("You Can't Declare Hours");
                }
            }
        }
        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value < 60 && value >= 0)
                {
                    minute = value;
                }
                else
                {
                    Console.WriteLine("You Can't Declare Minutes");
                }
            }
        }
        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                if (value < 60 && value >= 0)
                {
                    second = value;
                }
                else
                {
                    Console.WriteLine("You Can't Declare Seconds");
                }
            }
        }
        public void currentTime()
        {
            StringBuilder sb = new StringBuilder();

            if (hour < 10)
            {
                sb.Append("0");
                sb.Append(hour);
            }
            else
            {
                sb.Append(hour);
            }
            sb.Append(":");
            
            if (minute < 10)
            {
                sb.Append("0");
                sb.Append(minute);
            }
            else
            {
                sb.Append(minute);
            }
            sb.Append(":");
            if (second < 10)
            {
                sb.Append("0");
                sb.Append(second);
            }
            else
            {
                sb.Append(second);
            }
            Console.WriteLine(" Time:"+sb.ToString());
        }
        public void addSeconds(int sec)
        {
            for (int i = 0; i < sec; i++)
            {
                if (second == 59)
                {
                    second = 0;
                    addMinute();
                }
                else
                {
                    second++;
                }
            }
        }
        public void addMinute()
        {
            if (minute == 59)
            {
                minute = 0;
                addHour();
            }
            else
            {
                minute++;
            }

        }
        public void addHour()
        {
            if (hour==23)
            {
                hour = 0;
            }
            else
            {
                hour++;
            }
        }
    }
}
