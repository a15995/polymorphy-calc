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

        public new double Evaluate // b. Med implementation af Evaluate,
        {
            get { return value; } // der returnerer value.
        }

        public override string ToString // c. Med overstyring af ToString,
        {
            get { return value.ToString(); } //  der udskriver value.
        }   
    }

    public abstract class BinaryExpression : Expression // 3. Lav abstrakt Expression underklasse BinaryExpression:
    {
        protected Expression left; // a. Med to felter left
        protected Expression right; // og right af typen Expression, der kun er tilgængelige for underklasser og klassen selv.

        abstract readonly string OperatorSymbol { } // b. Med abstrakt read-only property OperatorSymbol af typen string.
        
        public sealed string ToString() // c. Med ToString,
        {
            return (left + " " + OperatorSymbol + " " + right); // der først udskriver left, så OperatorSymbol, så right (adskilt af mellemrum) og ikke kan overstyres
        }

    }

    public class PlusExpression : BinaryExpression // 4. Lav en BinaryExpression underklasse PlusExpression:
    {
        public new string OperatorSymbol // a. Med implementation af OperatorSymbol,
        {
            get { return "+"; } // der returnerer "+".
        }

        public new double Evaluate // b. med implementation af Evaluate,
        {
            get { return (left+right); } // der returnerer resultat af left + right.
        }
    }


    public class MinusExpression : BinaryExpression
    {

    }

    public class MultiplyExpression : BinaryExpression
    {

    }

    public class UnaryExpression : BinaryExpression
    {

    }
    
    public class NegateExpression : UnaryExpression
    {

    }


}
