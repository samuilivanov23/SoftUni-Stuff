using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IBox<T>
    {
        void Add(T item);

        int Count { get ; }

        List<T> Data { get; }
    }
}
