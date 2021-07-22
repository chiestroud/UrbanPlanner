using Planner;
using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Width = 150.5;
            FiveOneTwoEigth.Stories = 5;
            FiveOneTwoEigth.Depth = 300;

            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Chie Stroud");
            Console.WriteLine();

            Building NashvilleOne = new Building("1 Nashville Avenue");
            NashvilleOne.Width = 111.1;
            NashvilleOne.Stories = 10;
            NashvilleOne.Depth = 130;

            NashvilleOne.Construct();
            NashvilleOne.Purchase("Nashville One");
            Console.WriteLine();

            Building ChieEstate = new Building("156 Chie Street");
            ChieEstate.Width = 635.26;
            ChieEstate.Stories = 1;
            ChieEstate.Depth = 500.15;

            ChieEstate.Construct();
            ChieEstate.Purchase("Chie's Favorite Person");
            Console.WriteLine();
        }
    }
}
