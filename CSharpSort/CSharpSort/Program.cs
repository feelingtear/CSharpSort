using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //insert sort
            Console.WriteLine("---Insert sort---");

            int[] ay = new int[] {5,6,3,8,2,1,4,7 };

            Sort.InsertSort(ay);

            for (int i = 0; i < ay.Length; ++i)
            {
                Console.Write(ay[i]);
                Console.Write(",");
            }
            Console.WriteLine();
            Console.WriteLine("---Insert sort end---");
        }
    }
}
