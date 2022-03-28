using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.Term2
{
    public class MyList<T>
    {
        T[] list;
        private int id = 0;

        public void Add(T element) //додавання елемета
        {
            list[id++] = element;
        }

        public T Get(int id)  //отримання значення за вказаним індексом
        {
            if ((id < this.id) && (id >= 0))
            {
                return list[id];
            }
            else { return default(T); }
        }

        public int Count() //для отримання загальної кількості елементів
        {
            return id;
        }

        public MyList(int length) //нужно задать размер массива
        {
            list = new T[length];
        }

        public T this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }
    }
}
