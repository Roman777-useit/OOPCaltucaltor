using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Calculator
    {
        public int[] result;
        int num1, num2, den1, den2;

        public Calculator(int num1, int num2, int den1, int den2)
        {

            this.num1 = num1;
            this.num2 = num2;
            this.den1 = den1;
            this.den2 = den2;
        }

        public int[] Summ() {
            result = new int[2];
            if (den1 == den2)
            {
                result[0] = num1 + num2;
                result[1] = den1;
            }
            else {
                result[0] = num1 * den2 + num2 * den1;
                result[1] = den1 * den2;

            }
            return result;
        }
        public int[] Subtraction()
        {
            result = new int[2];
            if (den1 == den2)
            {
                result[0] = num1 - num2;
                result[1] = den1;
            }
            else
            {
                result[0] = num1 * den2 - num2 * den1;
                result[1] = den1 * den2;

            }
            return result;
        }
        public int[] Multiplication()
        {
            result = new int[2];

            result[0] = num1 * num2;
            result[1] = den1 * den2;


            return result;
        }
        public int[] Division()
        {
            result = new int[2];

            result[0] = num1 * den2;
            result[1] = den1 * num2;


            return result;
        }
   
    }
}
