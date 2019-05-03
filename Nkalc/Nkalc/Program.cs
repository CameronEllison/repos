
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkalc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            while (playAgain)
            {

            
            string mathProblem;
            mathProblem = Console.ReadLine();


            NCalc.Expression expression = new NCalc.Expression(mathProblem);
            string answer = expression.Evaluate().ToString();
            Console.WriteLine(answer);
            //Console.ReadLine();


        }
        }
    }
}
