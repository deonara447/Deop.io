using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Deop.io
{
    class Square
    {
        //variables in my class
        public SolidBrush squareBrush;
        public int x, y, size, hp, damage;

        public Square(int _x, int _y, int _size, int _hp, int _damage)
        {
            x = _x;
            y = _y;
            size = _size;
            hp = _hp;
            damage = _damage;
            squareBrush = new SolidBrush(Color.Yellow);
        }
    }
}