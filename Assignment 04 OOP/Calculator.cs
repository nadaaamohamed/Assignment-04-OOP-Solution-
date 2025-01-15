using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_OOP
{
    internal class Calculator
    {
      
        #region Methods
        //Accept two integers and return their sum.
       //Accept three integers and return their sum.
        //Accept two doubles and return their sum.

        public int Add(int a, int b)
        {
            return a + b;
        }    

        public int Add(int a , int b , int c)
        {
            return a + b + c;
        }

        public double Add (double a , double b)
        {
            return a + b;
        }


        #endregion
    }
}
