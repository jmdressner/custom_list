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
            //customList.Remove(5);
            customList.Add(6);
            customList.Add(7);
            customList.Add(8);
            //customList.Add(9);
            //customList.Add(10);
            //customList.Add(11);

        }
    }
}
