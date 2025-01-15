using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_OOP
{
    internal class Rectangle
    {

        // A parameterless constructor that sets the width and height to 0.
        // A constructor that accepts width and height as integers.
        //A constructor that accepts a single integer and sets both width and height to that value.

        #region Properties
        public int Length { get; set; }
        public int Width { get; set; }
        #endregion
        #region Constructors
        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }
        public Rectangle(int value)
        {
            Length = Width = value;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Length: {Length} , Width: {Width}";
        }
        #endregion
    }
}
