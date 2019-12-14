using System;

namespace xFac
{
    public interface IContainer 
    {
        T Resolve<T>();
    }
}
