using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Deop.io
{
    class Hexagon
    {
        //variables in my class
        public SolidBrush hexagonBrush;
        public int x, y, size, hp, damage;

        //random generator
        Random randGen = new Random();

        public Hexagon(int _x, int _y, int _size, int _hp, int _damage)
        {
            x = _x;
            y = _y;
            size = _size;
            hp = _hp;
            damage = _damage;
            hexagonBrush = new SolidBrush(Color.MediumPurple);
        }
    }
}
