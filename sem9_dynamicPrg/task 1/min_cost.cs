using System;
using System.Reflection;

namespace sem9_dynamicPrg.task_1
{
    public class min_cost
    {
        public static void solve(int n, int M, int[] a, int[] b){
            int[] S = new int[n];
            char[] result = new char[n];
            int sum = 0;

            S[0] = Math.Min(a[0],b[0]);
            bool triger = (S[0] == a[0]) ? true:false;
            result[0] = (S[0] == a[0]) ? 'a':'b';
            sum += S[0];
            
            for(int i=1;i<n;i++){
                if(triger){
                    S[i] = Math.Min(a[i],b[i]+M);
                    triger = (S[i] == a[i]) ? true:false;
                    result[i] = (S[i] == a[i]) ? 'a':'b';
                }
                else{
                    S[i] = Math.Min(a[i]+M,b[i]);
                    triger = (S[i] == b[i]) ? false:true;
                    result[i] = (S[i] == b[i]) ? 'b':'a';
                }
                sum += S[i];
            }
            Console.WriteLine($"Summ = {sum}");
            for(int i=0;i<n;i++)
                Console.Write($"{result[i]} ");
        }
    }
}