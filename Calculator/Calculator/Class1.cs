using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Expression
    {
        public abstract double Evaluate();
    }

    public class ConstantExpression : Expression
    {
        private readonly double value
        {
            get { return value; }
        }

        public override ToString()
        {
            return base.ToString();)
        }
        
    }

    sealed override Evaluate()
    {
        base.ToString();
    }
   

    public abstract class BinaryExpression : Expression
    {
        protected Expression left;
        protected Expression right;

        abstract readonly string OperatorSymbol;

    }

 }
