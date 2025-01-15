using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Define a class Complex Number that represents a complex number with real and imaginary parts.
     *Note: Overload the +, - operator to add and subtract two complex numbers.*/

namespace Assignment_04_OOP
{
    internal class Complex
    {
        #region Properties
        public int Real { get; set; }
        public int Imag { get; set; }
        #endregion
        #region operator OverLoading
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex 
            { 
                Real =( c1?.Real??0 )+ (c2?.Real??0), 
                Imag = (c1?.Imag??0) + (c2?.Imag??0 )
            };
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex
            {
                Real = (c1?.Real ?? 0) - (c2?.Real ?? 0),
                Imag = (c1?.Imag ?? 0) - (c2?.Imag ?? 0)
            };
        }
        #endregion
    }
}
