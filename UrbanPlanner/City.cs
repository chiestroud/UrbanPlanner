using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    class City
    {
        public string Name { get; set; }
        public string Mayor { get; set; }
        public List<string> Buildings { get; set; } = new List<string>();
       
        public int YearEstablished { get; set; }
        

        public City(int year, string name, string mayor)
        {
            YearEstablished = year;
            Name = name;
            Mayor = mayor;
        }

        public void AddBuildings(string building)
        {
            Buildings.Add(building);
        }

        public void WriteCityInfo()
        {
            Console.WriteLine($"Here are the information about {Name}");
            Console.WriteLine($"{Name}'s current Mayor is {Mayor}");
            Console.WriteLine($"{Name} was build in {YearEstablished}");
            Console.WriteLine($"Famous buildings in {Name} is");
        }

  
    }
}
