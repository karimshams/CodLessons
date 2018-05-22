using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodLessons
{
     public static class Distinct
    {

        // solution one
        // third trial 
        // https://app.codility.com/demo/results/training94RNRV-H66/
        public static int solution(int[] A)
        {
           
            Array.Sort(A);
            if (A.Length == 0)
            {
                return 0;
            }
            else
            {

                int distinct = 1;
                for (int i = 1; i < A.Length; i++)
            {
                if (A[i] != A[i-1])
                {
                    distinct++;
                }
            }
                return distinct;
            }
            
        }

        //solution two
        //  first trial
        // https://app.codility.com/demo/results/trainingJW248D-R6P/
        public static int solution2(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            HashSet<int> seen = new HashSet<int>();
            int distinct = 0;

            for (int i = 0; i < A.Length; i++)
            {
                seen.Add(A[i]);
            }

            distinct = seen.Count;

            return distinct;
        }

    }
}
