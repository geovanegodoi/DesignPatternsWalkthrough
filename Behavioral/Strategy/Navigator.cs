using System;
using Strategy.Strategy;
using Strategy.Strategy.Interface;

namespace Strategy
{
    public class Navigator
    {
        private IRouteStrategy _strategy = null;

        public Navigator()
        {
        }

        public void SetStrategy(IRouteStrategy strategy)
        {
            _strategy = strategy;
        }

        public Route BuildRoute(int origin, int destination)
        {
            return _strategy?.BuildRoute(origin, destination);
        }
    }
}
