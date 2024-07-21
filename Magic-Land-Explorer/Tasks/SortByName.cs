using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer.Tasks
{
    public class SortByName
    {
        public static void DisplaySortedName(List<Category> categories )
        {
            var sortedDestinations = categories
                                    .SelectMany(c=>c.Destinations)
                                    .OrderBy(d => d.Name)
                                    .Select(d => d.Name);
            Console.WriteLine("\nDestionation names organized in alphabetical order:");
            int counter = 1;
            foreach (var name in sortedDestinations)
            {
                Console.WriteLine($"[{counter}]- {name}");
                counter++;
            }
            Console.WriteLine();
        }
    }
}
