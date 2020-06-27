using System;
namespace Singleton
{
    public class NonSingleton
    {
        public NonSingleton()
        {
        }

        public Guid Uiid { get; private set; } = Guid.NewGuid();

        public static NonSingleton Instance()
        {
            return new NonSingleton();
        }
    }
}
