using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bogoodski2020backend.Models
{
    public class NewRunlogRecord
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime SleepIn { get; set; }
        public DateTime SleepOut { get; set; }
        public  int SleepHours 
        { 
            get
            {
                var result = SleepOut.Subtract(SleepIn).Hours;
                return result;
            }
        }
        
        public string LiftRoutine { get; set; }

        public double Distance { get; set; }

        public DateTime DurationTotal { get; set; }

        public DateTime DurationMile1 { get; set; }
        public DateTime DurationMile2 { get; set; }
        public DateTime DurationMile3 { get; set; }
        public DateTime DurationMile4 { get; set; }
        public DateTime DurationMile5 { get; set; }
        public DateTime DurationMile6 { get; set; }
        public DateTime DurationMile7 { get; set; }
        public DateTime DurationMile8 { get; set; }
        public DateTime DurationMile9 { get; set; }
        public DateTime DurationMile10 { get; set; }
        public DateTime DurationMile11 { get; set; }
        public DateTime DurationMile12 { get; set; }
        public DateTime DurationMile13 { get; set; }
        public DateTime DurationMile14 { get; set; }
        public DateTime DurationMile15 { get; set; }
        public DateTime DurationMile16 { get; set; }
        public DateTime DurationMile17 { get; set; }
        public DateTime DurationMile18 { get; set; }
        public DateTime DurationMile19 { get; set; }
        public DateTime DurationMile20 { get; set; }
        public DateTime DurationMile21 { get; set; }
        public DateTime DurationMile22 { get; set; }
        public DateTime DurationMile23 { get; set; }
        public DateTime DurationMile24 { get; set; }
        public DateTime DurationMile25 { get; set; }
        public DateTime DurationMile26 { get; set; }
        public DateTime DurationMile27 { get; set; }
        public DateTime DurationMile28 { get; set; }
        public DateTime DurationMile29 { get; set; }
        public DateTime DurationMile30 { get; set; }

        public string RunType { get; set; }
        public string Comments { get; set; }

        public double PaceTotal 
        {
            get
            {
                return DurationTotal.Minute / Distance;
            }
        }
    }
}
