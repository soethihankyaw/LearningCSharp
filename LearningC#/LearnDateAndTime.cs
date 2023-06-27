using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Date.And.Time
{
     class LearnDateAndTime
    {
        public DateTime dob = new DateTime(1993, 5, 4);
        public TimeSpan lunchTime = new TimeSpan(12, 30, 0);


        //For testing must be run on Program.Main
        //LearnDateAndTime learnDateAndTime = new LearnDateAndTime();

        //var dob = learnDateAndTime.dob;
        //Console.WriteLine("Day of the week {0}", dob.DayOfWeek);
        //dob = dob.AddDays(25);
        //dob = dob.AddMonths(7);
        //var dobgf = dob;
        //Console.WriteLine("Birthday of girlfriend : {0} and she is born on {1}", dobgf, dobgf.DayOfWeek);

        //var lunchTime = learnDateAndTime.lunchTime;
        //lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 00));
        //Console.WriteLine("New Time : {0}", lunchTime.ToString());

    }
}
