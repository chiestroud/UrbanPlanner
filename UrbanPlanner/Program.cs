using Planner;
using System;
using System.Collections.Generic;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Building Info
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

            // City Info
            City nashville = new City(4000, "Nashville", "Nashville Person" );
            nashville.AddBuildings("Nashville Building");
            nashville.AddBuildings("Another Nashville Building");

            nashville.WriteCityInfo();
            foreach (string building in nashville.Buildings)
            {
                Console.WriteLine(building);
            }

            Console.WriteLine();

            City kyoto = new City(794, "Kyoto", "Kyoto Person");
            kyoto.AddBuildings("Kyoto Tower");
            kyoto.AddBuildings("Kyoto Second Tower");
            kyoto.WriteCityInfo();
            kyoto.AddBuilds(ChieEstate);
            foreach(string building in kyoto.Buildings)
            {
                Console.WriteLine(building);
            }
            
            foreach(Building building in kyoto.Builds)
            {
                building.Print();
            }
        }
    }
}
