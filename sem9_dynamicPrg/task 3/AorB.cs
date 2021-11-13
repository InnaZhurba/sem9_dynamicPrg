using System;

namespace sem9_dynamicPrg.task_3
{
    public class AorB
    {
        public static void solve(int r, int c, int[] S)
        {
            int[] opt = new int[S.Length+1];
            
            opt[0] = 0;
            //j
            for (int i = 1, j=0; j < S.Length; i++,j++)
            {
                if (i >= 4)
                {
                    opt[i] = Math.Min(opt[i - 1] + S[j] * r, opt[i - 4] + 4 * c);
                }
                else
                {
                    opt[i] = opt[i - 1] + S[j] * r;
                }
                Console.Write($"{opt[i]} ");
            }
        }
    }
}