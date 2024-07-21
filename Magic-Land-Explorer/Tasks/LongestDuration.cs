using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public class LongestDuration
    {
        public static void  DisplayLongestDuration(List<Category> categories) {
            var longestDuration = categories
                                 .SelectMany(c => c.Destinations)
                                 .OrderByDescending(d => d.DurationInt)
                                 .FirstOrDefault();
            if (longestDuration != null)
            {
                Console.WriteLine($"Logest Destinations: {longestDuration.Name}\tDuration:{longestDuration.Duration}");
            }
            else
            {
                Console.WriteLine("No Data");
            }
        }
    }
}
