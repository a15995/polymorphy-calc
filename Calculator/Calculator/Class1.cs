using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Expression // 1. Lav en abstrakt klasse Expression:
    {
        public abstract double Evaluate(); // a. med en abstrakt metode Evaluate uden parametre, der returnerer en double.
    }

    public sealed class ConstantExpression : Expression // 2. Lav Expression underklasse ConstantExpression: (d. Skal ikke kunne nedarves fra.)
    {
        private readonly double value; // a. Med privat readonly felt kaldet value af typen double.

        public ConstantExpression(double value) // Udenfor opgaven: Lav constructor der initierer value!
        {
            this.value = value;
        }

        public override double Evaluate() // b. Med implementation af Evaluate (metode),
        {
            return value; // der returnerer value.
        }

        public override string ToString() // c. Med overstyring af ToString (metode),
        {
            return this.value.ToString(); //  der udskriver value.
        }   
    }

    public abstract class BinaryExpression : Expression // 3. Lav abstrakt Expression underklasse BinaryExpression:
    {
        protected readonly Expression left; // a. Med to felter left
        protected readonly Expression right; // og right af typen Expression, der kun er tilgængelige for underklasser og klassen selv. Readonly er et valg.

        protected BinaryExpression(Expression left, Expression right) // Udenfor opgaven: Lav constructor der initierer left/right!
        {
            this.left = left;
            this.right = right;
        }

        public abstract string OperatorSymbol { get; } // b. Med abstrakt read-only property OperatorSymbol af typen string. (read-only: ingen property expressions)
        
        public sealed override string ToString() // c. Med ToString,
        {
            return left.ToString() + " " + OperatorSymbol + " " + right.ToString(); // der først udskriver left, så OperatorSymbol, så right (adskilt af mellemrum) og ikke kan overstyres
        }
    }

    public class PlusExpression : BinaryExpression // 4. Lav en BinaryExpression underklasse PlusExpression:
    {
        public PlusExpression(Expression left, Expression right) : base(left, right) { } // Udenfor opgaven: Lav constructor der initierer left/right!
        
        public override string OperatorSymbol // a. Med implementation af OperatorSymbol,
        {
            get { return "+"; } // der returnerer "+".
        }

        public override double Evaluate() // b. med implementation af Evaluate,
        {
            return left.Evaluate() + right.Evaluate(); // der returnerer resultat af left + right.
        }
    }


    public class MinusExpression : BinaryExpression // 5. Lav BinaryExpression underklasse MinusExpression:
    {
        public MinusExpression(Expression left, Expression right) : base(left, right) { } // Udenfor opgaven: Lav constructor der initierer left/right!

        public override string OperatorSymbol // a. Implementerer OperatorSymbol
        {
            get { return "-"; } // ved "-".
        }

        public override double Evaluate() // b. Implementerer Evaluate
        {
            return left.Evaluate() - right.Evaluate(); // ved left - right.
        }
    }

    public class MultiplyExpression : BinaryExpression // 6. Lav BinaryExpression underklasse MultiplyExpression:
    {
        public MultiplyExpression(Expression left, Expression right) : base(left, right) { } // Udenfor opgaven: Lav constructor der initierer left/right!

        public override string OperatorSymbol // a. Implementerer OperatorSymbol
        {
            get { return "*"; } // ved "*".
        }

        public override double Evaluate() // b. Implementerer Evaluate
        {
            return left.Evaluate() * right.Evaluate(); // ved left * right.
        }
    }

    public abstract class UnaryExpression : Expression // 7. Lav Expression underklasse UnaryExpression:
    {
        protected Expression expr; // a. Med protected felt expr af type Expression
    }
    
//    public class NegateExpression : UnaryExpression // 8. Lav UnaryExpression underklasse NegateExpression:
//    {
//        // a. Passende implementation af Evaluate og ToString
//    }
}
