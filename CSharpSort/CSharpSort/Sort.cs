using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSort
{
    public class Sort
    {
        /// <summary>
        /// insert sort
        /// </summary>
        /// <param name="ay"></param>
        public static void InsertSort(int[] ay)
        {
            //get length of array
            int count = ay.Length;

            if(0==count|| 1==count)
            {
                return;
            }

            for (int i = 0; i < count; ++i)
            {
                for (int j = 0; j < count; ++j)
                {
                    if (ay[i] < ay[j])
                    {
                        //exchange 
                        int temp = ay[i];
                        ay[i] = ay[j];
                        ay[j] = temp;
                    }
                }
            }
        }
    }
}
