﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Deop.io
{
    class Bullet
    {
        //variables in my class
        public SolidBrush bulletBrush;
        public int x, y, size, hp, damage, speed, shooter;
        public string  direction;

        public Bullet(int _x, int _y, int _size, int _hp, int _damage, int _speed, string _direction, int _shooter)
        {
            shooter = _shooter;
            x = _x;
            y = _y;
            size = _size;
            hp = _hp;
            damage = _damage;
            speed = _speed;
            direction = _direction;
            bulletBrush = new SolidBrush(Color.Black);
        }

        public void Move(string movement)
        {
            direction = movement;

            //move bullet at movement speed 
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

        public int Collision(Bot p)
        {
            //bullet-bot collision
            var dx = x - p.x - 10;
            var dy = y - p.y - 10;
            var distance = Math.Sqrt(dx * dx + dy * dy);

            if (distance < size / 2 + p.size / 2)
            {
                //deal damage
                hp = hp - p.damage;
                p.hp = p.hp - damage;

                if (p.hp <= 0)
                {
                    //if dead award xp to killer
                    return p.xp / 2;
                }
                return 0;
            }
            return 0;
        }

        public void SquareCollision(Square s, Bot p1, Bot p2)
        {
            //square-bullet collision detection
            double distX = Math.Abs(x + 10 - s.x - s.size / 2);
            double distY = Math.Abs(y + 10 - s.y - s.size / 2);
            double dx = distX - s.size / 2;
            double dy = distY - s.size / 2;

            if (distX > (s.size / 2 + 10) || distY > (s.size / 2 + 10))
            {
            }
            else if (dx * dx + dy * dy <= (10 * 10) || distX <= (s.size / 2) || distY <= (s.size / 2))
            {
                //deal damage
                hp = hp - s.damage;
                s.hp = s.hp - damage;

                if (s.hp <= 0)
                {
                    //if dead award xp
                    //if mega square award lots of xp
                    if (s.size > 100)
                    {
                        //award xp to shooter
                        if (shooter == 1)
                        {
                            p1.xp += 5000;
                        }
                        else
                        {
                            p2.xp += 5000;
                        }
                    }
                    else
                    {
                        if (shooter == 1)
                        {
                            p1.xp += 10;
                        }
                        else
                        {
                            p2.xp += 10;
                        }
                    }
                }
            }
        }

        public void TriangleCollision(Triangle t)
        {
            //triangle-bullet collision detection
            double distX = Math.Abs(x + 10 - t.x - t.size / 2);
            double distY = Math.Abs(y + 10 - t.y - t.size / 2);
            double dx = distX - t.size / 2;
            double dy = distY - t.size / 2;

            if (distX > (t.size / 2 + 10) || distY > (t.size / 2 + 10))
            {
            }
            else if (dx * dx + dy * dy <= (10 * 10) || distX <= (t.size / 2) || distY <= (t.size / 2))
            {
                //deal damage
                hp = hp - t.damage;
                t.hp = t.hp - damage;
            }
        }
        public void HexagonCollision(Hexagon h, Bot p1, Bot p2)
        {
            //hexagon-bullet collision detection
            var dx = x + (size/2) - h.x - (h.size/2);
            var dy = y + (size / 2) - h.y - (h.size / 2);
            var distance = Math.Sqrt(dx * dx + dy * dy);

            if (distance < size / 2 + h.size / 2)
            {
                hp = hp - h.damage;
                h.hp = h.hp - damage;

                if (h.hp<= 0)
                {
                    if (shooter == 1)
                    {
                        p1.xp += 100;
                    }
                    else
                    {
                        p2.xp += 100;
                    }
                }
            }
        }
    }
}