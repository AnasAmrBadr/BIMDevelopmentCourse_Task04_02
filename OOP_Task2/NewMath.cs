using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task2
{
    public static class NewMath
    {

        //Power(2)
        public static double Square (double theBase)
        {
            double result = (theBase * theBase);
            return result;
        }

        //Power(n)
        public static double PowerN(double theBase, double thepower)
        {
            if (thepower % 1 != 0)
            {
                throw new Exception("ERROR: The power must be integer");
            }

            double theResult = 1;

            for (int i = 0; i <= thepower; i++) 
            {
                theResult *= theBase;
            }
            return theResult;

        }



        //MaxNumber
        public static double MaxNubmer(double numberOne, double numberTwo)
        {
            double maxNumber = 0;

            if (numberOne > numberTwo)
            {
                 maxNumber = numberOne;
            }
            else
            {
                maxNumber = numberTwo;
            }
            return maxNumber;
        }


        //MinNumber
        public static double MinNubmer(double numberOne, double numberTwo)
        {
            double minNumber = 0;

            if (numberOne < numberTwo)
            {
                minNumber = numberOne;
            }
            else
            {
                minNumber = numberTwo;
            }
            return minNumber;
        }

        //Absolute

        public static double Abso (double theNumber) 
        { 
            if (theNumber < 0) 
            {
                theNumber = -1 * theNumber;

            }
            return theNumber;
        
        }
    }
}
