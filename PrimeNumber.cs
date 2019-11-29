using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Coding
{
    class PrimeNumber
    {
        int flag=0;
        public void Prime()
        {
            Console.WriteLine("Enter the Number:  ");
            string num= Console.ReadLine();
            int value = int.Parse(num);

            for (int i=2; i<=value/2;i++)
            {
                if (value % i == 0)
                {
                    Console.WriteLine("Number is not Prime");
                    flag = 1;
                    break;
                }

                
            }

            if(flag==0)
            Console.WriteLine("Number is prime");
        }
    }
}
