using System;

namespace xFac
{
    public interface IContainer 
    {
        T Get<T>();
    }
}
