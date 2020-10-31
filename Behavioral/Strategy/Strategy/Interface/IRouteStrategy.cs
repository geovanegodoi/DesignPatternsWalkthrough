using System;
namespace Strategy.Strategy.Interface
{
    public interface IRouteStrategy
    {
        Route BuildRoute(int origin, int destination);
    }
}
