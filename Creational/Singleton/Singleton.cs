using System;
namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instance = new Singleton();

        private Singleton()
        {

        }

        public Guid Uiid { get; private set; } = Guid.NewGuid();

        public static Singleton Instance()
        {
            return _instance;
        }
    }
}
