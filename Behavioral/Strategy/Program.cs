using System;
using Strategy.Strategy.Implementation;
using static System.Console;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var route = (origin: 10, destination: 50);
            var navigator = new Navigator();

            navigator.SetStrategy(strategy: new WalkingStrategy());
            var walkingRoute = navigator.BuildRoute(origin: route.origin, destination: route.destination);
            WriteLine("Walking Strategy");
            WriteLine(walkingRoute.ToString());

            navigator.SetStrategy(strategy: new PublicTransportStrategy());
            var publicTransportRoute = navigator.BuildRoute(origin: route.origin, destination: route.destination);
            WriteLine("Public Transport Strategy");
            WriteLine(publicTransportRoute.ToString());

            navigator.SetStrategy(strategy: new RoadStrategy());
            var roadRoute = navigator.BuildRoute(origin: route.origin, destination: route.destination);
            WriteLine("Road Strategy");
            WriteLine(roadRoute.ToString());

            ReadLine();
        }
    }
}
