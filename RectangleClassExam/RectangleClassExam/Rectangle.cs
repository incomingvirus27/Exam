using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleClassExam
{
    class Rectangle
    {
        private float length = 1.0f;
        private float width = 1.0f;

        public Rectangle(float length, float width)
        {
            Length = length;
            Width = width;
        }

        public float Length
        {
            get { return length; }
            set
            {
                if (length > 0.0f && length < 20.0f)
                {
                    length = value;
                }
                else
                {
                    length = 1.0f;
                }
            }
        }
        public float Width
        {
            get { return width; }
            set
            {
                if (width > 0.0f && width < 20.0f)
                {
                    width = value;
                }
                else
                {
                    width = 1.0f;
                }
            }
        }
        public float Perimeter
        {
            get
            {
                return 2 * (length + width);
            }
         
        }
        public float Area
        {
            get
            {
                return length * width;
            }
           
        }
        public override string ToString()
        {
            return string.Format("The perimeter and the area of the rectangle is {0:f} {1:f}", Perimeter, Area); 
        }
    }
}