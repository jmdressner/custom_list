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
        // addmethod - check count
        // add method - make array bigger
        // check exceptions
        // remove, count, remove someting not there

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
            // add item passed in to the underlying structure (array)
        }

        public void Remove(T item)
        {

        }

        public override string ToString()
        {
            return "";
        }
    }
}
