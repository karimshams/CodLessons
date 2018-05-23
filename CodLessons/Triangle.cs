using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodLessons
{
    public static class Triangle
    {

        // 93 % I suffered a lot I thought he wanted to count the number of triangles
        // https://app.codility.com/demo/results/training6RUM6Y-VV5/

        public static int solution(int[] A)
        {
            Array.Sort(A);
           
            for (int i = 2; i < A.Length;i++)
            {
                                
                 if (A[i-2] + A[i-1] > A[i]  && A[i] > 0)
                 {
                    return 1;
                    
                 }
            }
            return 0;
        }


        }
}
//HashSet<int> count = new HashSet<int>();
//bool cond1 = false;
//bool cond2 = false;
//bool cond3 = false;
//int num = 1;

//for (int i = 1; i < A.Length; i++)
//{
//    if (A[i] == A[i-1])
//    {
//        num++;
//    }
//    else
//    {
//        count.Add(num);
//        num = 1;
//    }
//}