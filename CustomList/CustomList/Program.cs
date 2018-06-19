using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomList<int> customList = new CustomList<int>();

            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Remove(5);
            customList.Remove(6);
            customList.Add(6);
            customList.Add(7);
            customList.Add(8);

            CustomList<int> customList2 = new CustomList<int>();

            customList2.Add(1);
            customList2.Add(2);
            customList2.Add(9);

            CustomList<int> resultList = customList + customList2;

            CustomList<int> subtractedList = customList - customList2;

            CustomList<int> zipList = customList.Zip(customList, customList2);

            customList.Remove(8);
            customList.Remove(7);
            customList.Remove(6);
            customList.Remove(4);
            customList2.Add(7);

            zipList = customList.Zip(customList, customList2);

            customList.ToString();

        }
    }
}
