using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Deop.io
{
    class Triangle
    {
        //variables in my class
        public SolidBrush triangleBrush;
        public int x, y, size, hp, damage, speed;
        public string direction;

        //random generator
        Random randGen = new Random();

        public Triangle(int _x, int _y, int _size, int _hp, int _damage, int _speed, string _direction)
        {
            x = _x;
            y = _y;
            size = _size;
            hp = _hp;
            damage = _damage;
            triangleBrush = new SolidBrush(Color.Pink);
            speed = _speed;
            direction = _direction;

        }
        public void Move(string movement, GameScreen gs)
        {
            direction = movement;
            //move players at movement speed but not off screen
            if (x > 0)
            {
                if (direction == "left")
                {
                    x = x - speed;


                }
            }

            if (x < gs.Width - size)
            {
                if (direction == "right")
                {
                    x = x + speed;
                }
            }

            if (y > 0)
            {
                if (direction == "up")
                {
                    y = y - speed;
                }
            }

            if (y < gs.Height - size)
            {
                if (direction == "down")
                {
                    y = y + speed;
                }
            }

        }
        public void SquareCollision(Square s)
        {
            Rectangle square = new Rectangle(s.x, s.y, s.size , s.size);
            Rectangle triangle = new Rectangle(x, y, size, size);
            if (triangle.IntersectsWith(square))
                {
                hp = hp - s.damage;
                s.hp = s.hp - damage;
                if (s.x > x)
                {
                    x = x - 5;
                }
                else if (s.x < x)
                {
                    x = x + 5;
                }
                if (s.y > y)
                {
                    y = y - 5;
                }
                else if (s.y < y)
                {
                    y = y + 5;
                }
            }
        }
        public void HexagonCollision(Hexagon h)
        {
            double distX = Math.Abs(h.x + 23 - x - size / 2);
            double distY = Math.Abs(h.y + 23 - y - size / 2);
            double dx = distX - size / 2;
            double dy = distY - size / 2;
            if (distX > (size / 2 + 23) || distY > (size / 2 + 23))
            {
            }

            else if (dx * dx + dy * dy <= (23 * 23) || distX <= (size / 2) || distY <= (size / 2))
            {
                hp = hp - h.damage;
                h.hp = h.hp - damage;
                if (h.x > x)
                {
                    x = x - 5;
                }
                else if (h.x < x)
                {
                    x = x + 5;
                }
                if (h.y > y)
                {
                    y = y - 5;
                }
                else if (h.y < y)
                {
                    y = y + 5;
                }
            }
        }
    }
}
