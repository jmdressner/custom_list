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

        public int Capacity
        {
            get { return capacity; } 
            set { capacity = value; } 
        }

        public int Count { get { return count; } }

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

        public bool Remove(T item)
        {
            T[] array2 = new T[capacity];

            for (int i = 0; i <= count; i++)
            {
                if (array[i].Equals(item))
                {
                    count--;
                    continue;
                }
                array2[i] = array[i];
            }
            array = array2;
            return true;
        }

        public static CustomList<T> operator+ (CustomList<T> customList,  CustomList<T> customList2)
        {
            CustomList<T> resultList = new CustomList<T>();

            for (int i = 0; i < customList.count; i++)
            {
                resultList.Add(customList.array[i]);
            }
            for (int i = 0; i < customList2.count; i++)
            {
                resultList.Add(customList2.array[i]);
            }
            return resultList;
        }

        public static CustomList<T> operator- (CustomList<T> customList, CustomList<T> customList2)
        {
            CustomList<T> subtractedList = new CustomList<T>();

            for (int i = 0; i < customList.count; i++)
            {
                subtractedList.Add(customList.array[i]);
                
                for (int j = 0; j < customList2.count; j++)
                {
                    if (customList.array[i].Equals(customList2.array[j]))
                    {
                        subtractedList.Remove(customList.array[i]);
                    }
                }
            }

            return subtractedList;
        }

        public CustomList<T> Zip(CustomList<T> customList, CustomList<T> customList2)
        {
            CustomList<T> zipList = new CustomList<T>();

            for (int i = 0; i < customList.count; i++)
            {
                zipList.Add(customList.array[i]);

                if (i < customList2.count)
                {
                    zipList.Add(customList2.array[i]);
                }
            }
            return zipList;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
