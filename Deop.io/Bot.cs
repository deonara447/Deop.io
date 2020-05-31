using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Deop.io
{
    class Bot
    {
        //variables in my class
        public SolidBrush botBrush;
        public int x, y, size, hp, damage, playerNumber, speed, bulletHealth, bulletDamage, bulletSpeed, reload, healthRegen, maxHealth, lvl, xp, boost;
        public string direction;
        int random;

        //random generator
        Random randGen = new Random();

        public Bot(SolidBrush _botBrush, int _playerNumber, int _x, int _y, int _size, int _hp, int _damage, int _speed, string _direction, int _bulletHealth, int _bulletDamage, int _bulletSpeed, int _reload, int _healthRegen, int _maxHealth, int _lvl, int _xp, int _boost)
        {
            x = _x;
            y = _y;
            size = _size;
            hp = _hp;
            damage = _damage;
            botBrush = _botBrush;
            playerNumber = _playerNumber;
            speed = _speed;
            direction = _direction;
            bulletHealth = _bulletHealth;
            bulletDamage = _bulletDamage;
            bulletSpeed = _bulletSpeed;
            reload = _reload;
            healthRegen = _healthRegen;
            maxHealth = _maxHealth;
            lvl = _lvl;
            xp = _xp;
            boost = _boost;


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
        public void Move(string movement, SinglePlayerScreen hs)
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

            if (x < hs.Width - size)
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

            if (y < hs.Height - size)
            {
                if (direction == "down")
                {
                    y = y + speed;
                }
            }

        }
        public void Collision(Bot p2)
        {
            var dx = x - p2.x;
            var dy = y - p2.y;
            var distance = Math.Sqrt(dx * dx + dy * dy);


            //tells GameScreen if collision occurs
            if (distance < size / 2 + p2.size / 2)
            {
                hp = hp - p2.damage;
                p2.hp = p2.hp - damage;
                if (p2.hp <= 0)
                {
                    xp += p2.xp / 2;
                }
                if (hp <= 0)
                {
                    p2.xp += xp / 2;
                }
                if (p2.x > x)
                {
                    x = x - 5;
                    p2.x = p2.x + 5;
                }
                else if (p2.x < x)
                {
                    x = x + 5;
                    p2.x = p2.x - 5;
                }
                if (p2.y > y)
                {
                    y = y - 5;
                    p2.y = p2.y + 5;
                }
                else if (p2.y < y)
                {
                    y = y + 5;
                    p2.y = p2.y - 5;
                }

            }
        }
        public void SquareCollision(Square s)
        {
            double distX = Math.Abs(x + 20 - s.x - s.size / 2);
            double distY = Math.Abs(y + 20 - s.y - s.size / 2);
            double dx = distX - s.size / 2;
            double dy = distY - s.size / 2;
            if (distX > (s.size / 2 + 20) || distY > (s.size / 2 + 20))
            {
            }

            else if (dx * dx + dy * dy <= (20 * 20) || distX <= (s.size / 2) || distY <= (s.size / 2))
            {
                hp = hp - s.damage;
                s.hp = s.hp - damage;
                if (s.hp <= 0)
                {
                    if (s.size > 100)
                    {
                        xp += 5000;
                    }
                    else
                    {
                        xp += 10;
                    }

                }
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
        public void TriangleCollision(Triangle t)
        {
            double distX = Math.Abs(x + 20 - t.x - t.size / 2);
            double distY = Math.Abs(y + 20 - t.y - t.size / 2);
            double dx = distX - t.size / 2;
            double dy = distY - t.size / 2;
            if (distX > (t.size / 2 + 20) || distY > (t.size / 2 + 20))
            {
            }

            else if (dx * dx + dy * dy <= (20 * 20) || distX <= (t.size / 2) || distY <= (t.size / 2))
            {
                hp = hp - t.damage;
                t.hp = t.hp - damage;
                if (t.x < x)
                {
                    t.x = t.x - 10;

                }
                else if (t.x > x)
                {
                    t.x = t.x + 10;
                }
                if (t.y < y)
                {
                    t.y = t.y - 10;
                }
                else if (t.y > y)
                {
                    t.y = t.y + 10;
                }
            }
        }
        public void HexagonCollision(Hexagon h)
        {
            var dx = x - h.x;
            var dy = y - h.y;
            var distance = Math.Sqrt(dx * dx + dy * dy);


            //tells GameScreen if collision occurs
            if (distance < size / 2 + h.size / 2)
            {
                hp = hp - h.damage;
                h.hp = h.hp - damage;
                if (h.hp <= 0)
                {
                    xp += 100;
                }
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
        public void Respawn()
        {
            hp = 150;
            damage = 9;
            speed = 4;
            direction = "none";
            bulletHealth = 5;
            bulletDamage = 9;
            bulletSpeed = 6;
            reload = 25;
            healthRegen = 5;
            maxHealth = 150;
            boost = 0;
            xp = Convert.ToInt32(xp / 2);
            if (playerNumber == 1)
            {
                x = 50;
                y = 430;
            }
            else
            {
                x = 1510;
                y = 430;

            }

        }

        public void BotRespawn()
        {
            random = randGen.Next(0, 8);
            if (random == 0)
            {
                maxHealth += 50;
            }
            else if (random == 1)
            {
                healthRegen += 4;
            }
            else if (random == 2)
            {
                damage += 10;
            }
            else if (random == 3)
            {
                bulletSpeed += 8;
            }
            else if (random == 4)
            {
                bulletHealth += 13;
            }
            else if (random == 5)
            {
                bulletDamage += 17;
            }
            else if (random == 6)
            {
                reload -= 4;
            }
            else
            {
                speed += 2;
            }
            hp = maxHealth;
        }
    }
}

