using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3LAbTask
{
    class Program
    {
        static void Main(string[] args)
        {

            QuerySyntax(); 



        }
        static void QuerySyntax()
        {
            int[] numbers =
                {1,5,3,6,11,2,15,21,13,12,0};

            var outputNumbers =
                from number in numbers
                where number > 5
                orderby number descending
                select number;

            foreach (int i in outputNumbers)   // for every int in output numbers display it
            {
                Console.WriteLine(i); 

            }
        }

        static void LambdaSyntax()
        {



        }
    }
}
