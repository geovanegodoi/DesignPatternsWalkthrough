using System;
using Strategy.Strategy.Interface;

namespace Strategy.Strategy.Implementation
{
    public class WalkingStrategy : IRouteStrategy
    {
        public Route BuildRoute(int origin, int destination)
        {
            var distance = (destination - origin);
            var time = (destination - origin) + 200;
            var value = 0;

            return new Route(distance, time, value);
        }
    }
}
