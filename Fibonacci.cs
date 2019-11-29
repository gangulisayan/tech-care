using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//few more number should be check
namespace PracticeProject.Coding
{
    class Fibonacci
    {
        
      public void FindSeries(int size)
        {
            int n1 = 0, n2 = 1, n3;
                        
      for (int i = 0; i < size; i++)
            {
                n3 = n1 + n2;
               // n3 = n2 + n3;
                n1 = n2;
                n2 = n3;
                Console.Write("  "+n3+"  ");
            }
        }

    }
}
