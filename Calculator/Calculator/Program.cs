using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        static void Main()
        {
            // Create your expression here
            Expression expr = new PlusExpression(
                left: new ConstantExpression(4),
                right: new MinusExpression(
                    left: new ConstantExpression(1),
                    right: new ConstantExpression(2)));
            // Example:
            //Expression expr = new PlusExpression(
            //    new ConstantExpression(4),
            //    new PlusExpression(
            //        new ConstantExpression(1),
            //        new ConstantExpression(2)));

            // We print the textual representation
            Console.Write(expr.ToString());

            Console.Write(" = ");

            // ... and then the result of evaluating
            Console.WriteLine(expr.Evaluate());

            Console.ReadKey();
        }
    }
}
