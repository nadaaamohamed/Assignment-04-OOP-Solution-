using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_OOP
{
    internal class Duration
    {
        #region Attributes 
        int hours;
        int minutes;
        int seconds;
        #endregion
        #region Constructors

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
            this.seconds = (seconds % 3600) % 60;
        }

        
        #endregion
        #region Method
        public override string ToString()
        {
            return $"Hours: {hours}, Minutes: {minutes}, Seconds: {seconds}";
        }

        public override int GetHashCode()
        {
              return HashCode.Combine(hours, minutes , seconds);

        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Duration duration = obj as Duration;    
            if (duration == null)
            {
                return false;
            }
            return hours == duration.hours && minutes == duration.minutes && seconds == duration.seconds;
        }

        #endregion
        #region Operators Overloading
        public static Duration operator +(Duration d1, Duration d2)
        {
            int hours = d1.hours + d2.hours;
            int minutes = d1.minutes + d2.minutes;
            int seconds = d1.seconds + d2.seconds;
            if (seconds >= 60)
            {
                minutes++;
                seconds -= 60;
            }
            if (minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }
            return new Duration(hours, minutes, seconds);
        }

        #endregion
    }
}
