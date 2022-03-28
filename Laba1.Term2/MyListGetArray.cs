using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.Term2
{
    public static class MyListGetArray
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            var result = new T[list.Count()];

            for (int i = 0; i < list.Count(); i++)
                result[i] = list[i];

            return result;
        }
    }
}
