using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Land_Explorer
{
    public class Destination
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Duration {  get; set; } 
        public int DurationInt { 
            get {
                if (string.IsNullOrEmpty(Duration))
                {
                return 0; 
                }
                // split Num 
                string durationStr = Duration.Split(' ')[0];
                if (int.TryParse(durationStr, out int duration))
                {
                    return duration;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}
