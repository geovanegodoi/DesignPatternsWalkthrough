using System;
using Strategy.Strategy.Interface;

namespace Strategy.Strategy.Implementation
{
    public class PublicTransportStrategy : IRouteStrategy
    {
        public Route BuildRoute(int origin, int destination)
        {
            var distance = (destination - origin) + 100;
            var time = (destination - origin) + 50;
            var value = (destination - origin) + 50;

            return new Route(distance, time, value);
        }
    }
}
