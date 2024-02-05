using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WK5A_PartialClass
{
    public partial class Shape    // Rectangle
    {
        private int _width;   // width
        private int _height;      //height

        public Shape(int x, int y)
        {
            this._width = x;
            this._height = y;
        }
    }

    public partial class Shape
    {
        public string Name { get; set; }
        public int Width
        {
            get { return _width; } 
            set { _width = value; }
        }
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
    }
}
