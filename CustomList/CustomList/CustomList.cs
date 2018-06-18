using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        T[] array;
        T item;
        private int capacity;
        private int count; 

        public CustomList()
        {
            capacity = 5;
            this.array = new T[capacity];
        }

        //member variable - array(5)
        // add method - check count
        // add method - make array bigger
        // check exceptions
        // remove - count, remove someting not there

        public int Capacity
        {
            get { return capacity; } 
            set { capacity = value; } 
        }

        public int Count { get; }

        public T this [int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

        public void Add(T item)
        {
            if (count < capacity)
            {
                for(int i = 0; i <= count; i++)
                {
                    if (count == i)
                    {
                        array[i] = item;
                    }
                }
                count++;
            }
            else
            {
                T[] array2 = new T[capacity += capacity];

                for(int i = 0; i <= count; i++)
                {
                    if (count == i)
                    {
                        array2[i] = item;
                    }
                    else
                    {
                        array2[i] = array[i];
                    }
                }
                array = array2;
                count++;
            }
        }

        public void Remove(T item)
        {
            for(int i = 0; i <= count; i++)
            {
                array[i] = default(T);
            }
            count++;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
