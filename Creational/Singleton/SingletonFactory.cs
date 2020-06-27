using System;
using System.Collections.Generic;

namespace Singleton
{
    public sealed class SingletonFactory<T>
        where T : class, new()
    {
        private static readonly T instance = new T();

        private SingletonFactory()
        {

        }

        public static T Instance()
        {
            return instance;
        }
    }
}
