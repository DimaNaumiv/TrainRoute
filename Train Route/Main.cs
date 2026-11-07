using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Train_Route.DAL.Repository;

namespace Train_Route
{
    public class Program
    {
        public static void Main(string[] args) { 
            Servise ser = new Servise();
            //var routes = ser.GetFromTo(2200001, 2218000);
            //ShowSimRoutes(routes);
            var routes = ser.GetFromToOneStep(2200001, 2200250);
            PrintRouteResults(routes);

            //var routes = ser.GetRotesByCode(2200001);
            //ShowSimRoutes(routes);
        }
        public static void ShowSimRoutes(List<Routes> routes)
        {
            int index = 0;
            foreach (var route in routes)
            {
                Console.WriteLine($"Route {index}:");
                var stations = route.Sations.OrderBy(s => s.StationOrder).ToList();
                foreach (var station in stations)
                {
                    Console.WriteLine($"order: {station.StationOrder} name: {station.Station.Name}");
                }
                index++;
            }
        }
        public static void PrintRouteResults(List<Routes[]> routesList)
        {
            if (routesList == null || routesList.Count == 0)
            {
                Console.WriteLine("========================================");
                Console.WriteLine(" Маршрутів з однією пересадкою не знайдено ");
                Console.WriteLine("========================================");
                return;
            }

            Console.WriteLine("========================================");
            Console.WriteLine($" ЗНАЙДЕНО ПЕРЕСАДОЧНИХ МАРШРУТІВ: {routesList.Count}");
            Console.WriteLine("========================================");

            int variantNum = 1;
            foreach (var pair in routesList)
            {
                Console.WriteLine($"Варіант пересадки #{variantNum}:");

                // Виводимо інформацію про перший маршрут 
                // (замініть .Id або інші властивості на реальні поля вашого класу Routes)
                Console.WriteLine($"  ├─ Маршрут №1 (ID: {pair[0].Id})");
                var fromStations = pair[0].Sations.OrderBy(s=>s.StationOrder);
                foreach (var station in fromStations)
                {
                    Console.WriteLine($"order: {station.StationOrder} name: {station.Station.Name}");
                }

                // Виводимо інформацію про другий маршрут
                Console.WriteLine($"  └─ Маршрут №2 (ID: {pair[1].Id})");
                var toStations = pair[1].Sations.OrderBy(s => s.StationOrder);
                foreach (var station in toStations)
                {
                    Console.WriteLine($"order: {station.StationOrder} name: {station.Station.Name}");
                }

                Console.WriteLine("----------------------------------------");
                variantNum++;
            }
        }
    }
}
