using Magic_Land_Explorer.Tasks;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace Magic_Land_Explorer
{
    public class Program
    {
        //public delegate void MenuAction(List<Category> categories);

        static void Main(string[] args)
        {
            string json = File.ReadAllText("data.json");
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);

    
            bool startExplore = true;
            while (startExplore)
            {
                Console.WriteLine("Magic Land Explorer Menu:");
                Console.WriteLine("Press [1] Show destinations with duration less than 100 minutes");
                Console.WriteLine("Press [2] Show destination with the longest duration");
                Console.WriteLine("Press [3] Sort destinations by name");
                Console.WriteLine("Press [4] Show top 3 longest-duration destinations");
                Console.WriteLine("Press [0] To Quit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        FilterDestinations.DisplayDestination(categories);
                        break;
                    case "2":
                        LongestDuration.DisplayLongestDuration(categories);
                        break;
                    case "3":
                        SortByName.DisplaySortedName(categories);
                        break;
                    case "4":
                        Top3Duration.DisplayTop3Duration(categories);
                        break;
                    case "0":
                        startExplore = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
 }

