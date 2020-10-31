using System;
using Strategy.Strategy.Interface;

namespace Strategy.Strategy.Implementation
{
    public class RoadStrategy : IRouteStrategy
    {
        public Route BuildRoute(int origin, int destination)
        {
            var distance = (destination - origin) + 50;
            var time = (destination - origin);
            var value = (destination - origin) + 100;

            return new Route(distance, time, value);
        }
    }
}
