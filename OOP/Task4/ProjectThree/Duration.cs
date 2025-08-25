using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectThree
{
    public class Duration
    {
        private int hours;
        private int minutes;
        private int seconds;

        public Duration()
        {

        }
        public Duration(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public Duration(int seconds)
        {
            this.hours = seconds / 3600;
            this.minutes = (seconds % 3600) / 60;
            this.seconds = seconds % 60;
        }
        public override string ToString()
        {
            return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration
            {
                hours = d1.hours + d2.hours,
                minutes = d1.minutes + d2.minutes,
                seconds = d1.seconds + d2.seconds
            };
        }
        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration
            {
                hours = d1.hours - d2.hours,
                minutes = d1.minutes - d2.minutes,
                seconds = d1.seconds - d2.seconds
            };
        }
        public static bool operator >(Duration d1, Duration d2)
        {
            return ((d1.hours > d2.hours) && (d1.minutes > d2.minutes) && (d1.seconds > d2.seconds));
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return !(d1 > d2);
        }
        public static bool operator ==(Duration d1, Duration d2)
        {
            return ((d1.hours == d2.hours) && (d1.minutes == d2.minutes) && (d1.seconds == d2.seconds));
        }
        public static bool operator !=(Duration d1, Duration d2)
        {
            return !(d1 == d2);
        }
        public override bool Equals(object? obj)
        {
            if (obj is Duration)
            {
                return this == (Duration)obj;

            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(hours, minutes, seconds);
        }
    }
}
