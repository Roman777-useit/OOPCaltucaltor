using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Rational
    {
        int num, den;
        public Rational(int num, int den)
        {
            this.num = num;
            this.den = den;
        }
        public static Rational operator +(Rational rational1, Rational rational2)
        {
            if (rational1.den == 0 || rational2.den == 0)
            {
                throw new DivideByZeroException();
            }
            int numResult;
            int denResult;
            Rational rational;
            numResult = rational1.num * rational2.den + rational2.num * rational1.den;
            denResult = rational1.den * rational2.den;
            rational = new Rational(numResult, denResult);
            return rational;
        }
        public static Rational operator -(Rational rational1, Rational rational2)
        {
            if (rational1.den == 0 || rational2.den == 0)
            {
                throw new DivideByZeroException();
            }
            int numResult;
            int denResult;
            Rational rational;
            numResult = rational1.num * rational2.den - rational2.num * rational1.den;
            denResult = rational1.den * rational2.den;
            rational = new Rational(numResult, denResult);
            return rational;
        }
        public static Rational operator *(Rational rational1, Rational rational2)
        {
            if (rational1.den == 0 || rational2.den == 0)
            {
                throw new DivideByZeroException();
            }
            int numResult;
            int denResult;
            Rational rational;
            numResult = rational1.num * rational2.num;
            denResult = rational1.den * rational2.den;
            rational = new Rational(numResult, denResult);
            return rational;
        }
        public static Rational operator /(Rational rational1, Rational rational2)
        {
            if (rational1.den == 0 || rational2.den == 0)
            {
                throw new DivideByZeroException();
            }
            int numResult = rational1.num * rational2.den;
            int denResult = rational1.den * rational2.num;
            if (numResult == Math.Abs(0) || denResult == Math.Abs(0))
            {
                throw new DivideByZeroException();
            }
            Rational rational = new Rational(numResult, denResult);
            return rational;
        }
        public override string ToString()
        {
            string result = "";
            if (this.num != this.den)
            {
                result = $"{this.num} / {this.den}";
            }
            if (this.num == Math.Abs(0))
            {
                result = $"{0}";
            }
            if (this.den == 1)
            {
                result = $"{this.num}";
            }
            return result;
        }
        public Rational Reduction()
        {
            int numResult = Math.Abs(this.num);
            int denResult = Math.Abs(this.den);
            if (numResult != denResult && numResult != 0)
            {
                while (numResult != denResult)
                {
                    if (numResult > denResult)
                    {
                        numResult = numResult - denResult;
                    }
                    else
                    {
                        denResult = denResult - numResult;
                    }
                }
                int nod = numResult;
                numResult = this.num / nod;
                denResult = this.den / nod;
            }
            else if (numResult == denResult)
            {
                numResult = numResult / numResult;
                denResult = denResult / denResult;
            }
            Rational result = new Rational(numResult, denResult);
            return result;
        }
    }
}
