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
                Console.WriteLine($"\nLogest Destinations: {longestDuration.Name}\tDuration:{longestDuration.Duration}\n");
            }
            else
            {
                Console.WriteLine("No Data");
            }
        }
    }
}
