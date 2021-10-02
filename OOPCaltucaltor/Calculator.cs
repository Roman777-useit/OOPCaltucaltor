using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Calculator
    {
       
        int num, den;

        public Calculator(int num, int den)
        {

            this.num=num;
            this.den=den;
        }

        public static Calculator operator+(Calculator rational1, Calculator rational2) {
            if (rational1.den == 0 || rational2.den == 0)
            {
                throw new Exception(nameof(rational1));
            }
            int numResult;
            int denResult;
            Calculator rational;
            if (rational1.den == rational2.den)
            {
                 numResult= rational1.num + rational2.num;
                 denResult = rational1.den;
            }
            else {
                numResult = rational1.num * rational2.den + rational2.num * rational1.den;
                denResult = rational1.den * rational2.den;

            }
            rational=new Calculator(numResult,denResult);
            return rational;
        }
        public static Calculator operator -(Calculator rational1, Calculator rational2)
        {
            if (rational1.den == 0 || rational2.den == 0) {
               throw new Exception(nameof(rational1)) ;
            }
           int numResult;
            int denResult;
            Calculator rational;
            if (rational1.den == rational2.den)
            {
                numResult = rational1.num - rational2.num;
                denResult = rational1.den;
            }
            else
            {
                numResult = rational1.num * rational2.den - rational2.num * rational1.den;
                 denResult = rational1.den * rational2.den;

            }
            rational=new Calculator(numResult,denResult);
            return rational;
            //запретить ввод нулей недопустить результата нуля в числ или знаменателе
        }
        public static Calculator operator*(Calculator rational1, Calculator rational2)
        {
            if (rational1.den == 0 || rational2.den == 0)
            {
                throw new Exception(nameof(rational1));
            }

            int numResult;
            int denResult;
            Calculator rational;
            numResult = rational1.num * rational2.num;
            denResult = rational1.den * rational2.den;


            rational=new Calculator(numResult,denResult);
            return rational;
        }
        public static Calculator operator/(Calculator rational1, Calculator rational2)
        {
            if (rational1.den == Math.Abs(0) || rational2.den == Math.Abs(0))
            {
                throw new Exception(nameof(rational1));
            }

            int numResult;
            int denResult;
            Calculator rational;

            numResult = rational1.num * rational2.den;
            denResult = rational1.den * rational2.num;

            if (numResult == Math.Abs(0) || denResult == Math.Abs(0))
            {
                throw new Exception(nameof(rational1));
            }
            rational =new Calculator(numResult,denResult);
            return rational;
        }
        public override string ToString()
        {
            string result="";
            if (this.num != this.den)
            {
                result = $"{this.num} / {this.den}";

            }
             if (this.num == Math.Abs(0)) {
                result = $"{0}";
            }
             if(this.num==this.den)
            {
                result = $"{this.num}";
            }
            if (this.den == 1) {
                result = $"{this.num}";
            }
            return result;
        }
        public Calculator Evklid(Calculator rational) {
            
            int nod;
            int numResult=Math.Abs( this.num);
            int denResult=Math.Abs(this.den);
            Calculator result;
            if (numResult != denResult && numResult!=0)
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
                nod = numResult;
                numResult = this.num / nod;
                denResult = this.den / nod;

            }
            else if(numResult!=0){
                numResult = numResult / numResult;
                denResult = denResult / denResult;
            }
            result = new Calculator(numResult, denResult);
            return result;
        }
    }
}
