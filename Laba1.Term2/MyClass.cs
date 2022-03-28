using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.Term2
{
    public class MyClass
    {
        public static T FactoryMethod<T>() where T : new()
        {
            return new T();
        }
    }
}
