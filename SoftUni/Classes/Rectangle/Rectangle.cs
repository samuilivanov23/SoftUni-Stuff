using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        public string id;
        public int width;
        public int height;
        public int x;
        public int y;

        public Rectangle(string id, int width, int height, int x, int y)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
        }

        public bool OverLapping(Rectangle rect)
        {
            if(Math.Abs(rect.x - this.x) > this.width && Math.Abs(rect.y - this.y) > rect.height)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
