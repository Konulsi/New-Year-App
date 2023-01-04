using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class FibonacciService : IFibonacciService
    {
        public int[] GetNumFibonacci(int length)
        {
            int a = 0;  
            int b = 1; 
            int[] fibNums= new int[length];
            fibNums[0] = a;
            fibNums[1] = b;
            for (int i = 2; i < length; i++)
            {
                int c = a + b;
                a = b; 
                b = c;
                fibNums[i] = c; 
            }
            return fibNums; 
        }
    }
}
