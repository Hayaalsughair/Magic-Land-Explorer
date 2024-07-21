using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public class Top3Duration
    {
        public static void DisplayTop3Duration(List<Category>categories) {
            var top3LogestDuration = categories
                                     .SelectMany(c=> c.Destinations)
                                     .OrderByDescending(d=> d.DurationInt)
                                     .Take(3)
                                     .Select(d => new { d.Name, d.Duration });
            Console.WriteLine("\nTop 3 Longest Duration:");

            int counter = 1;
            foreach (var destination in top3LogestDuration)
            {
                Console.WriteLine($"[{counter}]- {destination.Name} {destination.Duration}\n");
                counter++;
            }

        }
    }
}
