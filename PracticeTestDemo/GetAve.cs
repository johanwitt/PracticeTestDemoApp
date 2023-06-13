using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTestDemo
{
    public static class GetAve
    {
        public static decimal getAve(decimal[] grades)
        {
            

            decimal average = grades.Average();
            return average;
        }
    }
}
