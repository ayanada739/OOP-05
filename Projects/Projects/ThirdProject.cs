using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Projects
{
    public class ThirdProject
    {

        public class Duration
        {
            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int Seconds { get; set; }

            public Duration(int hours, int minutes, int seconds)
            {
                Hours = hours;
                Minutes = minutes;
                Seconds = seconds;
                Normalize();
            }

            public Duration(int totalSeconds)
            {
                Hours = totalSeconds / 3600;
                totalSeconds %= 3600;
                Minutes = totalSeconds / 60;
                Seconds = totalSeconds % 60;
                Normalize();
            }

            private void Normalize()
            {
                if (Seconds >= 60)
                {
                    Minutes += Seconds / 60;
                    Seconds %= 60;
                }
                if (Minutes >= 60)
                {
                    Hours += Minutes / 60;
                    Minutes %= 60;
                }
            }

            public override string ToString()
            {
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            }

            public override bool Equals(object obj)
            {
                if (obj is Duration other)
                {
                    return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Hours, Minutes, Seconds);
            }

            public static Duration operator +(Duration d1, Duration d2)
            {
                return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
            }

            public static Duration operator +(Duration d, int seconds)
            {
                return new Duration(d.ToTotalSeconds() + seconds);
            }

            public static Duration operator +(int seconds, Duration d)
            {
                return d + seconds;
            }

            public static Duration operator ++(Duration d)
            {
                return new Duration(d.ToTotalSeconds() + 60);
            }

            public static Duration operator --(Duration d)
            {
                return new Duration(d.ToTotalSeconds() - 60);
            }

            public static Duration operator -(Duration d1, Duration d2)
            {
                return new Duration(d1.ToTotalSeconds() - d2.ToTotalSeconds());
            }

            public static bool operator >(Duration d1, Duration d2)
            {
                return d1.ToTotalSeconds() > d2.ToTotalSeconds();
            }

            public static bool operator <(Duration d1, Duration d2)
            {
                return d1.ToTotalSeconds() < d2.ToTotalSeconds();
            }

            public static bool operator >=(Duration d1, Duration d2)
            {
                return d1.ToTotalSeconds() >= d2.ToTotalSeconds();
            }

            public static bool operator <=(Duration d1, Duration d2)
            {
                return d1.ToTotalSeconds() <= d2.ToTotalSeconds();
            }

            public static explicit operator DateTime(Duration d)
            {
                return new DateTime().AddSeconds(d.ToTotalSeconds());
            }

            private int ToTotalSeconds()
            {
                return Hours * 3600 + Minutes * 60 + Seconds;
            }
        }

    }
}
