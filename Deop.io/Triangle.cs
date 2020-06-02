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

        public void Move(string movement)
        {
            direction = movement;

            //move triangles at movement speed
            if (direction == "left")
            {
                x = x - speed;
            }

            if (direction == "right")
            {
                x = x + speed;
            }

            if (direction == "up")
            {
                y = y - speed;
            }

            if (direction == "down")
            {
                y = y + speed;
            }
        }

        public void SquareCollision(Square s)
        {
            //square triangle collision detection
            Rectangle square = new Rectangle(s.x, s.y, s.size, s.size);
            Rectangle triangle = new Rectangle(x, y, size, size);

            if (triangle.IntersectsWith(square))
            {
                //deal damage
                hp = hp - s.damage;
                s.hp = s.hp - damage;

                //repel triangle
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
            //triangle-hexagon collision detection (square-circle)
            double distX = Math.Abs(h.x + 23 - x - size / 2);
            double distY = Math.Abs(h.y + 23 - y - size / 2);
            double dx = distX - size / 2;
            double dy = distY - size / 2;

            if (distX > (size / 2 + 23) || distY > (size / 2 + 23))
            {
            }
            else if (dx * dx + dy * dy <= (23 * 23) || distX <= (size / 2) || distY <= (size / 2))
            {
                //deal damage
                hp = hp - h.damage;
                h.hp = h.hp - damage;

                //repel triangle
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
