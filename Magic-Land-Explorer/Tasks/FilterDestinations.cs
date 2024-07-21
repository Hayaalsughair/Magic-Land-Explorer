using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Magic_Land_Explorer.Tasks
{
    public static class FilterDestinations
    {
        public static void DisplayDestination(List<Category> categories)
        {
            var filteredDestionation = categories
                                       .SelectMany(c => c.Destinations)
                                       .Where(d => d.DurationInt < 100)
                                       .Select(d => new { d.Name, d.Duration });
            Console.WriteLine("Destinations that have duration less than 100 minutes:");
            int counter = 1;
            foreach (var destination in filteredDestionation)
            {
                if (filteredDestionation.Any())
                {
                    Console.WriteLine("Duration not available");
                }
                Console.WriteLine($"[{counter}]- {destination.Name} => Duration -{destination.Duration}\n");
                counter++;
            }

        }


    }
}
