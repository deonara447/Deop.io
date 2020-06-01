﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deop.io
{
    public partial class SinglePlayerScreen : UserControl
    {
        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown;
        Boolean nDown, bDown, mDown, spaceDown;

        int p1CoolDown, p2CoolDown, p3CoolDown, p4CoolDown;
        int squareX, squareY;
        int hexagonX, hexagonY;
        int triangleX, triangleY;
        int squareSize = 30;
        int triangleSize = 21;
        int hexagonSize = 48;
        Boolean addShape;
        int squareGenerationSpeed;
        int squareHp = 10;
        int squareDamage = 10;
        int hexagonHp = 100;
        int hexagonDamage = 10;
        int triangleHp = 20;
        int triangleDamage = 20;
        int healthRegenCounter;
        int baseMaxHealth = 150;
        int baseDamage = 9;
        int baseSpeed = 6;
        int baseBulletHealth = 5;
        int baseBulletDamage = 9;
        int baseBulletSpeed = 6;
        int baseReload = 25;
        int baseRegen = 5;


        int attribute;

        int keyCoolDown;


        int lvlUpgrade
            ;
        Point d1, d2, d3, d4, d5, d6;

        public SolidBrush blueBrush = new SolidBrush(Color.DeepSkyBlue);
        public SolidBrush redBrush = new SolidBrush(Color.Red);
        public SolidBrush greyBrush = new SolidBrush(Color.Gray);

        List<Square> squareList = new List<Square>();
        List<Hexagon> hexagonList = new List<Hexagon>();
        List<Triangle> triangleList = new List<Triangle>();
        List<Bullet> bulletList = new List<Bullet>();
        List<Bot> botList = new List<Bot>();
        List<Square> deadSquareList = new List<Square>();
        List<Hexagon> deadHexagonList = new List<Hexagon>();
        List<Triangle> deadTriangleList = new List<Triangle>();
        List<Bullet> deadBulletList = new List<Bullet>();
        Bot p1, p2, p3, p4;
        Rectangle newSquare;
        Rectangle r;

        Boolean boost;


        //random number generator
        Random randGen = new Random();
        public SinglePlayerScreen()
        {
            InitializeComponent();
            OnStart();
            p1.hp = 150;
        }
        public void OnStart()
        {
            boost = false;
            keyCoolDown = attribute = 0;
            healthRegenCounter = 0;
            p1 = new Bot(blueBrush, 1, 40, 40, 40, baseMaxHealth, baseDamage, baseSpeed, "none", baseBulletHealth, baseBulletDamage, baseBulletSpeed, baseReload, baseRegen, baseMaxHealth, 1, 0, 0);
            botList.Add(p1);
            p2 = new Bot(redBrush, 2, 1520, 40, 40, baseMaxHealth, baseDamage, baseSpeed, "none", baseBulletHealth, baseBulletDamage, baseBulletSpeed, baseReload, 0, baseMaxHealth, 1, 0, 0);
            botList.Add(p2);
            p3 = new Bot(redBrush, 3, 40, 820, 40, baseMaxHealth, baseDamage, baseSpeed, "none", baseBulletHealth, baseBulletDamage, baseBulletSpeed, baseReload, 0, baseMaxHealth, 1, 0, 0);
            botList.Add(p3);
            p4 = new Bot(redBrush, 4, 1520, 820, 40, baseMaxHealth, baseDamage, baseSpeed, "none", baseBulletHealth, baseBulletDamage, baseBulletSpeed, baseReload, 0, baseMaxHealth, 1, 0, 0);
            botList.Add(p4);
            p1CoolDown = p1.reload;
            p2CoolDown = p2.reload;

            squareGenerationSpeed = 300;
            for (int i = 0; i <= 20; i++)
            {
                addShape = true;
                squareX = randGen.Next(1, 1600 - squareSize - 1);
                squareY = randGen.Next(1, 900 - squareSize - 1);
                newSquare = new Rectangle(squareX, squareY, squareSize, squareSize);

                foreach (Square s in squareList)
                {
                    r = new Rectangle(s.x - 1, s.y - 1, s.size + 1, s.size + 1);
                    if (r.IntersectsWith(newSquare))
                    {
                        addShape = false;
                    }
                }
                if (addShape == true)
                {
                    Square f = new Square(squareX, squareY, squareSize, squareHp, squareDamage);
                    squareList.Add(f);
                }
            }
            addShape = true;
            for (int i = 0; i <= 5; i++)
            {
                hexagonX = randGen.Next(1, 1600 - hexagonSize - 1);
                hexagonY = randGen.Next(1, 900 - hexagonSize - 1);

                newSquare = new Rectangle(hexagonX, hexagonY, hexagonSize, hexagonSize);

                foreach (Square s in squareList)
                {
                    r = new Rectangle(s.x - 1, s.y - 1, s.size + 1, s.size + 1);
                    if (r.IntersectsWith(newSquare))
                    {
                        addShape = false;
                    }
                }

                foreach (Hexagon h in hexagonList)
                {
                    r = new Rectangle(h.x - 1, h.y - 1, h.size + 1, h.size + 1);
                    if (r.IntersectsWith(newSquare))
                    {
                        addShape = false;
                    }
                }
                if (addShape == true)
                {
                    Hexagon f = new Hexagon(hexagonX, hexagonY, hexagonSize, hexagonHp, hexagonDamage);
                    hexagonList.Add(f);
                }
                gameLoop.Enabled = true;
            }
        }
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //if key is pressed boolean is true
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.N:
                    nDown = true;
                    break;
                case Keys.B:
                    bDown = true;
                    break;
                case Keys.M:
                    mDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.Escape:
                    MainScreen ms = new MainScreen();
                    Form f = this.FindForm();
                    ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);
                    f.Controls.Remove(this);
                    ms.Size = f.Size;
                    f.Controls.Add(ms);
                    ms.Focus();
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //if keys are released, booleans are false
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.N:
                    nDown = false;
                    break;
                case Keys.B:
                    bDown = false;
                    break;
                case Keys.M:
                    mDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
            }
        }
        private void gameLoop_Tick(object sender, EventArgs e)
        {
            if (p1.boost != p1.lvl)
            {
                boost = true;
            }
            addShape = true;
            if (randGen.Next(1, squareGenerationSpeed) < 7)
            {
                squareX = randGen.Next(1, this.Width - squareSize - 1);
                squareY = randGen.Next(1, this.Height - squareSize - 1);

                newSquare = new Rectangle(squareX, squareY, squareSize, squareSize);

                foreach (Square s in squareList)
                {
                    r = new Rectangle(s.x - 1, s.y - 1, s.size + 1, s.size + 1);
                    if (r.IntersectsWith(newSquare))
                    {
                        addShape = false;
                    }
                }
                foreach (Hexagon h in hexagonList)
                {
                    r = new Rectangle(h.x - 1, h.y - 1, h.size + 1, h.size + 1);
                    if (r.IntersectsWith(newSquare))
                    {
                        addShape = false;
                    }
                }
                if (addShape == true)
                {
                    Square f = new Square(squareX, squareY, squareSize, squareHp, squareDamage);
                    squareList.Add(f);
                }
            }
            else if (randGen.Next(1, squareGenerationSpeed) == 11)
            {
                hexagonX = randGen.Next(1, this.Width - hexagonSize - 1);
                hexagonY = randGen.Next(1, this.Height - hexagonSize - 1);

                newSquare = new Rectangle(hexagonX, hexagonY, hexagonSize, hexagonSize);

                foreach (Square s in squareList)
                {
                    r = new Rectangle(s.x - 1, s.y - 1, s.size + 1, s.size + 1);
                    if (r.IntersectsWith(newSquare))
                    {
                        addShape = false;
                    }
                }

                foreach (Hexagon h in hexagonList)
                {
                    r = new Rectangle(h.x - 1, h.y - 1, h.size + 1, h.size + 1);
                    if (r.IntersectsWith(newSquare))
                    {
                        addShape = false;
                    }
                }
                if (addShape == true)
                {
                    Hexagon f = new Hexagon(hexagonX, hexagonY, hexagonSize, hexagonHp, hexagonDamage);
                    hexagonList.Add(f);
                    //later add to pentagon gen
                    if (squareGenerationSpeed > 100)
                    {
                        squareGenerationSpeed -= 3;
                    }
                }
            }
            else if (randGen.Next(1, squareGenerationSpeed) == 12)
            {
                triangleX = randGen.Next(1, this.Width - triangleSize - 1);
                triangleY = randGen.Next(1, this.Height - triangleSize - 1);

                newSquare = new Rectangle(triangleX, triangleY, triangleSize, triangleSize);

                foreach (Square s in squareList)
                {
                    r = new Rectangle(s.x - 1, s.y - 1, s.size + 1, s.size + 1);
                    if (r.IntersectsWith(newSquare))
                    {
                        addShape = false;
                    }
                }
                foreach (Hexagon h in hexagonList)
                {
                    r = new Rectangle(h.x - 1, h.y - 1, h.size + 1, h.size + 1);
                    if (r.IntersectsWith(newSquare))
                    {
                        addShape = false;
                    }
                }
                if (addShape == true)
                {
                    Triangle t = new Triangle(triangleX, triangleY, triangleSize, triangleHp, triangleDamage, 6, "none");
                    triangleList.Add(t);
                }
            }
            p1.Collision(p2);
            p1.Collision(p3);
            p1.Collision(p4);

            foreach (Bullet b in bulletList)
            {
                b.Move(b.direction);
                foreach (Square s in squareList)
                {
                    b.SquareCollision(s, p1, p2);
                }
                foreach (Hexagon h in hexagonList)
                {
                    b.HexagonCollision(h, p1, p2);
                }
                foreach (Triangle t in triangleList)
                {
                    b.TriangleCollision(t);
                }
                if (b.shooter != 1)
                {
                    b.Collision(p1);
                }
                else
                {
                    if (b.Collision(p2) != 0)
                    {
                        p1.xp += 50 * p2.lvl;
                    }
                    if (b.Collision(p3) != 0)
                    {
                        p1.xp += 50 * p3.lvl;
                    }
                    if (b.Collision(p4) != 0)
                    {
                        p1.xp += 50 * p4.lvl;
                    }
                }
                if (b.hp <= 0 || b.x < 0 || b.x > this.Width - b.size || b.y < 0 || b.y > this.Height - b.size)
                {
                    deadBulletList.Add(b);
                }
            }

            foreach (Bot p in botList)
            {
                if (p.playerNumber == 1)
                {
                    if (leftArrowDown)
                    {
                        p.Move("left", this);
                    }

                    if (rightArrowDown)
                    {
                        p.Move("right", this);
                    }

                    if (upArrowDown)
                    {
                        p.Move("up", this);
                    }

                    if (downArrowDown)
                    {
                        p.Move("down", this);
                    }
                }
                else
                {
                    if (p.y > p1.y + 10)
                    {
                        p.Move("up", this);
                    }
                    else if (p.y < p1.y - 10)
                    {
                        p.Move("down", this);
                    }
                    else if (p.x > p1.x + 10)
                    {
                        p.Move("left", this);
                    }
                    else
                    {
                        p.Move("right", this);
                    }
                }
                foreach (Square s in squareList)
                {
                    p.SquareCollision(s);
                }
                foreach (Hexagon h in hexagonList)
                {
                    p.HexagonCollision(h);
                }
                foreach (Triangle t in triangleList)
                {
                    p.TriangleCollision(t);
                }
            }
            if (p1.xp >= 7500)
            {
                p1.lvl = 20;
            }
            else if (p1.xp >= 6500)
            {
                lvlUpgrade = 7500 - p1.xp;
                p1.lvl = 19;
            }
            else if (p1.xp >= 5550)
            {
                lvlUpgrade = 6500 - p1.xp;
                p1.lvl = 18;
            }
            else if (p1.xp >= 4650)
            {
                lvlUpgrade = 5550 - p1.xp;
                p1.lvl = 17;
            }
            else if (p1.xp >= 3800)
            {
                lvlUpgrade = 4650 - p1.xp;
                p1.lvl = 16;
            }
            else if (p1.xp >= 3000)
            {
                lvlUpgrade = 3800 - p1.xp;
                p1.lvl = 15;
            }
            else if (p1.xp >= 2250)
            {
                lvlUpgrade = 3000 - p1.xp;
                p1.lvl = 14;
            }
            else if (p1.xp >= 1700)
            {
                lvlUpgrade = 2250 - p1.xp;
                p1.lvl = 13;
            }
            else if (p1.xp >= 1300)
            {
                lvlUpgrade = 1700 - p1.xp;
                p1.lvl = 12;
            }
            else if (p1.xp >= 1000)
            {
                lvlUpgrade = 1300 - p1.xp;
                p1.lvl = 11;
            }
            else if (p1.xp >= 750)
            {
                lvlUpgrade = 1000 - p1.xp;
                p1.lvl = 10;
            }
            else if (p1.xp >= 550)
            {
                lvlUpgrade = 750 - p1.xp;
                p1.lvl = 9;
            }
            else if (p1.xp >= 400)
            {
                lvlUpgrade = 550 - p1.xp;
                p1.lvl = 8;
            }
            else if (p1.xp >= 280)
            {
                lvlUpgrade = 400 - p1.xp;
                p1.lvl = 7;
            }
            else if (p1.xp >= 180)
            {
                lvlUpgrade = 280 - p1.xp;
                p1.lvl = 6;
            }
            else if (p1.xp >= 110)
            {
                lvlUpgrade = 180 - p1.xp;
                p1.lvl = 5;
            }
            else if (p1.xp >= 60)
            {
                lvlUpgrade = 110 - p1.xp;
                p1.lvl = 4;
            }
            else if (p1.xp >= 30)
            {
                lvlUpgrade = 60 - p1.xp;
                p1.lvl = 3;
            }
            else if (p1.xp >= 10)
            {
                lvlUpgrade = 30 - p1.xp;
                p1.lvl = 2;
            }
            else
            {
                lvlUpgrade = 10 - p1.xp;
                p1.lvl = 1;
            }

            foreach (Triangle t in triangleList)
            {

                if (t.x > p1.x + 10)
                {
                    t.Move("left");
                }
                else if (t.x < p1.x - 10)
                {
                    t.Move("right");
                }
                else if (t.y > p1.y + 10)
                {
                    t.Move("up");
                }
                else
                {
                    t.Move("down");
                }

                foreach (Square s in squareList)
                {
                    t.SquareCollision(s);
                }
                foreach (Hexagon h in hexagonList)
                {
                    t.HexagonCollision(h);
                }

                if (t.hp <= 0)
                {
                    deadTriangleList.Add(t);
                }
            }

            foreach (Square s in squareList)
            {
                if (s.hp <= 0)
                {
                    deadSquareList.Add(s);
                }
            }
            foreach (Hexagon h in hexagonList)
            {
                if (h.hp <= 0)
                {
                    deadHexagonList.Add(h);
                }
            }
            foreach (Square s in deadSquareList)
            {
                squareList.Remove(s);
            }
            foreach (Hexagon h in deadHexagonList)
            {
                hexagonList.Remove(h);
            }
            foreach (Triangle t in deadTriangleList)
            {
                triangleList.Remove(t);
            }
            foreach (Bullet b in deadBulletList)
            {
                bulletList.Remove(b);
            }

            if (spaceDown == true)
            {
                if (p1CoolDown <= 0)
                {
                    p1CoolDown = p1.reload;
                    if (p1.direction == "left")
                    {
                        Bullet b = new Bullet(p1.x - 15, p1.y + 10, 20, p1.bulletHealth, p1.bulletDamage, p1.bulletSpeed, p1.direction, p1.playerNumber);
                        bulletList.Add(b);
                    }
                    else if (p1.direction == "right")
                    {
                        Bullet b = new Bullet(p1.x + p1.size - 5, p1.y + 10, 20, p1.bulletHealth, p1.bulletDamage, p1.bulletSpeed, p1.direction, p1.playerNumber);
                        bulletList.Add(b);
                    }
                    else if (p1.direction == "down")
                    {
                        Bullet b = new Bullet(p1.x + 10, p1.y + p1.size - 5, 20, p1.bulletHealth, p1.bulletDamage, p1.bulletSpeed, p1.direction, p1.playerNumber);
                        bulletList.Add(b);
                    }
                    else if (p1.direction == "up")
                    {
                        Bullet b = new Bullet(p1.x + 10, p1.y - 15, 20, p1.bulletHealth, p1.bulletDamage, p1.bulletSpeed, p1.direction, p1.playerNumber);
                        bulletList.Add(b);
                    }
                }
            }

            if (p2CoolDown <= 0)
            {
                p2CoolDown = p2.reload;
                if (p2.direction == "left")
                {
                    Bullet b = new Bullet(p2.x - 15, p2.y + 10, 20, p2.bulletHealth, p2.bulletDamage, p2.bulletSpeed, p2.direction, p2.playerNumber);
                    bulletList.Add(b);
                }
                else if (p2.direction == "right")
                {
                    Bullet b = new Bullet(p2.x + p2.size - 5, p2.y + 10, 20, p2.bulletHealth, p2.bulletDamage, p2.bulletSpeed, p2.direction, p2.playerNumber);
                    bulletList.Add(b);
                }
                else if (p2.direction == "down")
                {
                    Bullet b = new Bullet(p2.x + 10, p2.y + p2.size - 5, 20, p2.bulletHealth, p2.bulletDamage, p2.bulletSpeed, p2.direction, p2.playerNumber);
                    bulletList.Add(b);
                }
                else if (p2.direction == "up")
                {
                    Bullet b = new Bullet(p2.x + 10, p2.y - 15, 20, p2.bulletHealth, p2.bulletDamage, p2.bulletSpeed, p2.direction, p2.playerNumber);
                    bulletList.Add(b);
                }
            }
            if (p3CoolDown <= 0)
            {
                p3CoolDown = p3.reload;
                if (p3.direction == "left")
                {
                    Bullet b = new Bullet(p3.x - 15, p3.y + 10, 20, p3.bulletHealth, p3.bulletDamage, p3.bulletSpeed, p3.direction, p3.playerNumber);
                    bulletList.Add(b);
                }
                else if (p3.direction == "right")
                {
                    Bullet b = new Bullet(p3.x + p3.size - 5, p3.y + 10, 20, p3.bulletHealth, p3.bulletDamage, p3.bulletSpeed, p3.direction, p3.playerNumber);
                    bulletList.Add(b);
                }
                else if (p3.direction == "down")
                {
                    Bullet b = new Bullet(p3.x + 10, p3.y + p3.size - 5, 20, p3.bulletHealth, p3.bulletDamage, p3.bulletSpeed, p3.direction, p3.playerNumber);
                    bulletList.Add(b);
                }
                else if (p3.direction == "up")
                {
                    Bullet b = new Bullet(p3.x + 10, p3.y - 15, 20, p3.bulletHealth, p3.bulletDamage, p3.bulletSpeed, p3.direction, p3.playerNumber);
                    bulletList.Add(b);
                }
            }
            if (p4CoolDown <= 0)
            {
                p4CoolDown = p4.reload;
                if (p4.direction == "left")
                {
                    Bullet b = new Bullet(p4.x - 15, p4.y + 10, 20, p4.bulletHealth, p4.bulletDamage, p4.bulletSpeed, p4.direction, p4.playerNumber);
                    bulletList.Add(b);
                }
                else if (p4.direction == "right")
                {
                    Bullet b = new Bullet(p4.x + p4.size - 5, p4.y + 10, 20, p4.bulletHealth, p4.bulletDamage, p4.bulletSpeed, p4.direction, p4.playerNumber);
                    bulletList.Add(b);
                }
                else if (p1.direction == "down")
                {
                    Bullet b = new Bullet(p4.x + 10, p4.y + p4.size - 5, 20, p4.bulletHealth, p4.bulletDamage, p4.bulletSpeed, p4.direction, p4.playerNumber);
                    bulletList.Add(b);
                }
                else if (p4.direction == "up")
                {
                    Bullet b = new Bullet(p4.x + 10, p4.y - 15, 20, p4.bulletHealth, p4.bulletDamage, p4.bulletSpeed, p4.direction, p4.playerNumber);
                    bulletList.Add(b);
                }
            }


            if (p1.hp <= 0)
            {
                Form z = FindForm();
                if (z != null)
                {
                    gameLoop.Enabled = false;
                    HighScoreScreen hss = new HighScoreScreen();
                    this.Focus();
                    this.Refresh();
                    hss.Location = new Point((z.Width - hss.Width) / 2, (z.Height - hss.Height) / 2);
                    z.Controls.Remove(this);
                    hss.Size = z.Size;
                    z.Controls.Add(hss);
                    hss.Focus();
                    hss.Results(p1.xp);
                }
                
            }
            if (p2.hp <= 0)
            {
                p1.xp += p2.lvl * 50;
                p2.BotRespawn(randGen.Next(0, 8));
                p2.x = 1520;
                p2.y = 40;
            }
            if (p3.hp <= 0)
            {
                p1.xp += p3.lvl * 50;
                p3.x = 40;
                p3.y = 820;
                p3.BotRespawn(randGen.Next(0, 8));
            }
            if (p4.hp <= 0)
            {
                p1.xp += p4.lvl * 50;
                p4.x = 1520;
                p4.y = 820;
                p4.BotRespawn(randGen.Next(0, 8));
            }

            if (healthRegenCounter == 100)
            {
                foreach (Bot p in botList)
                {
                    if (p.hp < p.maxHealth)
                    {
                        if (p.hp > p.maxHealth - p.healthRegen)
                        {
                            p.hp = p.maxHealth;
                        }
                        else
                        {
                            p.hp += p.healthRegen;
                        }
                    }
                }
                healthRegenCounter = 0;
            }

            health1Label.Text = Convert.ToString(p1.hp) + " hp";
            level1Label.Text = "lvl " + Convert.ToString(p1.lvl);

            if (p1.lvl != 20)
            {
                xp1Label.Text = Convert.ToString(lvlUpgrade) + " xp to lvl " + Convert.ToString(p1.lvl + 1);
            }
            else
            {
                xp1Label.Text = "Max Level: " + Convert.ToString(p1.xp) + " xp";
            }

            if (boost == true)
            {
                healthLabel.Visible = true;
                healthRegenLabel.Visible = true;
                bodyDamageLabel.Visible = true;
                bulletSpeedLabel.Visible = true;
                bulletHealthLabel.Visible = true;
                bulletDamageLabel.Visible = true;
                reloadLabel.Visible = true;
                speedLabel.Visible = true;
                if (keyCoolDown < 0)
                {
                    if (mDown == true)
                    {
                        if (attribute < 7)
                        {
                            attribute++;
                            keyCoolDown = 5;
                            BoldLabel();
                        }
                    }
                    if (bDown == true)
                    {
                        if (attribute > 0)
                        {
                            attribute--;
                            keyCoolDown = 5;
                            BoldLabel();
                        }
                    }
                    if (nDown == true)
                    {
                        keyCoolDown = 5;
                        LevelUp();
                        boost = false;
                        healthLabel.Visible = false;
                        healthRegenLabel.Visible = false;
                        bodyDamageLabel.Visible = false;
                        bulletSpeedLabel.Visible = false;
                        bulletHealthLabel.Visible = false;
                        bulletDamageLabel.Visible = false;
                        reloadLabel.Visible = false;
                        speedLabel.Visible = false;
                    }
                }
            }
            p2.xp = p3.xp = p4.xp = 0;

            p1CoolDown--;
            p2CoolDown--;
            p3CoolDown--;
            p4CoolDown--;
            keyCoolDown--;

            deadSquareList.Clear();
            deadTriangleList.Clear();
            deadHexagonList.Clear();
            deadBulletList.Clear();

            healthRegenCounter++;
            Refresh();
        }
        public void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw food, mines, and powerups
            foreach (Square s in squareList)
            {
                e.Graphics.FillRectangle(s.squareBrush, s.x, s.y, s.size, s.size);
            }
            foreach (Hexagon h in hexagonList)
            {
                d1 = new Point(h.x + 12, h.y);
                d2 = new Point(h.x + 36, h.y);
                d3 = new Point(h.x + 48, h.y + 24);
                d4 = new Point(h.x + 36, h.y + 48);
                d5 = new Point(h.x + 12, h.y + 48);
                d6 = new Point(h.x, h.y + 24);


                Point[] pointArray = { d1, d2, d3, d4, d5, d6, };
                e.Graphics.FillPolygon(h.hexagonBrush, pointArray);
            }
            foreach (Bullet b in bulletList)
            {
                e.Graphics.FillEllipse(b.bulletBrush, new Rectangle(b.x, b.y, b.size, b.size));
            }
            foreach (Bot b in botList)
            {
                if (b.direction == "right")
                {
                    e.Graphics.FillRectangle(greyBrush, b.x + b.size - 5, b.y + 10, 20, 20);
                }
                else if (b.direction == "left")
                {
                    e.Graphics.FillRectangle(greyBrush, b.x - 15, b.y + 10, 20, 20);
                }
                else if (b.direction == "down")
                {
                    e.Graphics.FillRectangle(greyBrush, b.x + 10, b.y + b.size - 5, 20, 20);
                }
                else if (b.direction == "up")
                {
                    e.Graphics.FillRectangle(greyBrush, b.x + 10, b.y - 15, 20, 20);
                }
                e.Graphics.FillEllipse(b.botBrush, new Rectangle(b.x, b.y, b.size, b.size));
            }

            foreach (Triangle t in triangleList)
            {
                if (t.direction == "left")
                {
                    d1 = new Point(t.x, t.y + 11);
                    d2 = new Point(t.x + 21, t.y);
                    d3 = new Point(t.x + 21, t.y + 21);
                }
                else if (t.direction == "right")
                {
                    d1 = new Point(t.x, t.y);
                    d2 = new Point(t.x + 21, t.y + 11);
                    d3 = new Point(t.x, t.y + 21);
                }
                else if (t.direction == "down")
                {
                    d1 = new Point(t.x, t.y);
                    d2 = new Point(t.x + 21, t.y);
                    d3 = new Point(t.x + 11, t.y + 21);
                }
                else
                {
                    d1 = new Point(t.x, t.y + 21);
                    d2 = new Point(t.x + 11, t.y);
                    d3 = new Point(t.x + 21, t.y + 21);
                }

                Point[] pointArray = { d1, d2, d3 };
                e.Graphics.FillPolygon(t.triangleBrush, pointArray);
            }
        }
        private void BoldLabel()
        {
            healthLabel.Font = new Font(this.Font, FontStyle.Regular);
            healthRegenLabel.Font = new Font(this.Font, FontStyle.Regular);
            bodyDamageLabel.Font = new Font(this.Font, FontStyle.Regular);
            bulletSpeedLabel.Font = new Font(this.Font, FontStyle.Regular);
            bulletHealthLabel.Font = new Font(this.Font, FontStyle.Regular);
            bulletDamageLabel.Font = new Font(this.Font, FontStyle.Regular);
            reloadLabel.Font = new Font(this.Font, FontStyle.Regular);
            speedLabel.Font = new Font(this.Font, FontStyle.Regular);

            if (attribute == 0)
            {
                healthLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (attribute == 1)
            {
                healthRegenLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (attribute == 2)
            {
                bodyDamageLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (attribute == 3)
            {
                bulletSpeedLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (attribute == 4)
            {
                bulletHealthLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (attribute == 5)
            {
                bulletDamageLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (attribute == 6)
            {
                reloadLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (attribute == 7)
            {
                speedLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
        }


        private void LevelUp()
        {
            if (attribute == 0)
            {
                if (healthLabel.ForeColor != Color.Red)
                {
                    p1.hp += 50;
                    p1.maxHealth += 50;
                    p1.boost++;
                    if (p1.maxHealth > 375)
                    {
                        healthLabel.ForeColor = Color.Red;
                    }
                }
            }
            else if (attribute == 1)
            {
                if (healthRegenLabel.ForeColor != Color.Red)
                {
                    p1.healthRegen += 4;
                    p1.boost++;
                    if (p1.healthRegen > 24)
                    {
                        healthRegenLabel.ForeColor = Color.Red;
                    }
                }
            }
            else if (attribute == 2)
            {
                if (bodyDamageLabel.ForeColor != Color.Red)
                {
                    p1.damage += 10;
                    p1.boost++;
                    if (p1.damage > 58)
                    {
                        bodyDamageLabel.ForeColor = Color.Red;
                    }
                }
            }
            else if (attribute == 3)
            {
                if (bulletSpeedLabel.ForeColor != Color.Red)
                {
                    p1.bulletSpeed += 8;
                    p1.boost++;
                    if (p1.bulletSpeed > 44)
                    {
                        bulletSpeedLabel.ForeColor = Color.Red;
                    }

                }
            }
            else if (attribute == 4)
            {
                if (bulletHealthLabel.ForeColor != Color.Red)
                {
                    p1.bulletHealth += 13;
                    p1.boost++;
                    if (p1.bulletHealth > 69)
                    {
                        bulletHealthLabel.ForeColor = Color.Red;
                    }
                }
            }
            else if (attribute == 5)
            {
                if (bulletDamageLabel.ForeColor != Color.Red)
                {
                    p1.bulletDamage += 17;
                    p1.boost++;
                    if (p1.bulletDamage > 93)
                    {
                        bulletDamageLabel.ForeColor = Color.Red;
                    }
                }
            }
            else if (attribute == 6)
            {
                if (reloadLabel.ForeColor != Color.Red)
                {
                    p1.reload -= 4;
                    p1.boost++;
                    if (p1.reload < 6)
                    {
                        reloadLabel.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                if (speedLabel.ForeColor != Color.Red)
                {
                    p1.speed += 2;
                    p1.boost++;
                    if (p1.speed > 13)
                    {
                        speedLabel.ForeColor = Color.Red;
                    }
                }
            }
        }

    }
}
