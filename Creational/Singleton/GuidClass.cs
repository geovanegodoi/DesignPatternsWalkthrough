using System;
namespace Singleton
{
    public abstract class BaseGuidClass
    {
        public Guid Uiid { get; protected set; } = Guid.NewGuid();
    }

    public class ClassA : BaseGuidClass { }

    public class ClassB : BaseGuidClass { }

    public class ClassC : BaseGuidClass { }

    public class ClassD : BaseGuidClass { }

    public class ClassE : BaseGuidClass { }
}
