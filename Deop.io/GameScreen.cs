/*
 * Description: Deop.io, based on the game Diep.io is both a PvP and PvE game in which players aim to shoot their opponents. 
 * In Deop.io squares and pentagons spawn randomly and when destroyed, players receive XP. After enough XP is obtained,
 * players level up allowing them to choose to improve an attribute. Destroy the mega square and a tremendous amount of
 * XP is obtained! When a player dies, they respawn at half their original XP. The game ends once a player reaches 8000 XP.
 * In the one player game, the objective is to reach as much XP as possible before you die. When bots die, they respawn 
 * with an upgraded attribute, thus the game gets gradually more difficult. Reach a high score and you'll be on the 
 * leaderboards.
 * Author: Deo Narayan         
 * Date: June 8, 2020    
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;


namespace Deop.io
{
    public partial class GameScreen : UserControl
    {
        //sounds
        SoundPlayer gameStart = new SoundPlayer(Properties.Resources.gameStart);
        SoundPlayer gameOver  = new SoundPlayer(Properties.Resources.gameOver);

        //whether keys are pressed
        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown;
        Boolean wArrowDown, aArrowDown, sArrowDown, dArrowDown;
        Boolean nDown, bDown, mDown, spaceDown;
        Boolean cDown, vDown, xDown, zDown;

        //if can shoot
        int p1CoolDown, p2CoolDown;

        //location of shapes
        int shapeX, shapeY;

        //shape sizes
        int squareSize = 30;
        int triangleSize = 21;
        int hexagonSize = 48;

        //if shape will be added
        Boolean addShape;

        //speed of shape generation
        int squareGenerationSpeed;

        //shape health and damage
        int squareHp = 10;
        int squareDamage = 10;
        int hexagonHp = 100;
        int hexagonDamage = 10;
        int triangleHp = 20;
        int triangleDamage = 20;

        //when health regen occurs
        int healthRegenCounter;

        //base bot attributes
        int baseMaxHealth = 150;
        int baseDamage = 9;
        int baseSpeed = 4;
        int baseBulletHealth = 5;
        int baseBulletDamage = 9;
        int baseBulletSpeed = 6;
        int baseReload = 25;
        int baseRegen = 5;

        //what attribute is being upgraded
        int attribute1, attribute2;

        //interval between key presses
        int keyCoolDown1, keyCoolDown2;

        //xp to next lvl upgrade
        int lvlUpgrade, lvl1Upgrade, lvl2Upgrade;

        //for drawing shapes
        Point d1, d2, d3, d4, d5, d6;

        //array of points for drawing shapes
        Point[] triangleArray = new Point[3];
        Point[] HexagonArray = new Point[6];

        //for determining Manhattan distance
        int d1x, d1y, d2x, d2y, d1t, d2t;

        //for drawing shapes
        public SolidBrush blueBrush = new SolidBrush(Color.DeepSkyBlue);
        public SolidBrush redBrush = new SolidBrush(Color.Red);
        public SolidBrush greyBrush = new SolidBrush(Color.Gray);

        //object lists
        List<Square> squareList = new List<Square>();
        List<Hexagon> hexagonList = new List<Hexagon>();
        List<Triangle> triangleList = new List<Triangle>();
        List<Bullet> bulletList = new List<Bullet>();
        List<Bot> botList = new List<Bot>();

        //list of objects to be removed
        List<Square> deadSquareList = new List<Square>();
        List<Hexagon> deadHexagonList = new List<Hexagon>();
        List<Triangle> deadTriangleList = new List<Triangle>();
        List<Bullet> deadBulletList = new List<Bullet>();

        //bot objects
        Bot p1, p2;

        //for checking collisions
        Rectangle newSquare;
        Rectangle r;

        //if time for upgrade
        Boolean boost1, boost2;

        //random number generator
        Random randGen = new Random();

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }
        public void OnStart()
        {
            //game start sound
            gameStart.Play();

            //reset variables
            keyCoolDown1 = keyCoolDown2 = attribute1 = attribute2 = healthRegenCounter = 0;
            squareGenerationSpeed = 300;

            //create bot objects with attributes and add them to botList
            p1 = new Bot(blueBrush, 1, 50, 430, 40, baseMaxHealth, baseDamage, baseSpeed, "none", baseBulletHealth, baseBulletDamage, baseBulletSpeed, baseReload, baseRegen, baseMaxHealth, 1, 0, 0);
            botList.Add(p1);
            p2 = new Bot(redBrush, 2, 1510, 430, 40, baseMaxHealth, baseDamage, baseSpeed, "none", baseBulletHealth, baseBulletDamage, baseBulletSpeed, baseReload, baseRegen, baseMaxHealth, 1, 0, 0);
            botList.Add(p2);

            //create mega square
            Square g = new Square(650, 300, 300, 2500, squareSize);
            squareList.Add(g);

            //create 20 squares
            for (int i = 0; i <= 20; i++)
            {
                addShape = true;

                //random location
                shapeX = randGen.Next(1, 1600 - squareSize - 1);
                shapeY = randGen.Next(1, 900 - squareSize - 1);
                newSquare = new Rectangle(shapeX, shapeY, squareSize, squareSize);

                //check to see if collision with a square
                foreach (Square s in squareList)
                {
                    r = new Rectangle(s.x - 1, s.y - 1, s.size + 1, s.size + 1);

                    if (r.IntersectsWith(newSquare))
                    {
                        addShape = false;
                    }
                }

                //if not colliding, add shape
                if (addShape == true)
                {
                    Square f = new Square(shapeX, shapeY, squareSize, squareHp, squareDamage);
                    squareList.Add(f);
                }
            }

            addShape = true;

            //create 5 hexagons
            for (int i = 0; i <= 5; i++)
            {
                shapeX = randGen.Next(1, 1600 - hexagonSize - 1);
                shapeY = randGen.Next(1, 900 - hexagonSize - 1);
                newSquare = new Rectangle(shapeX, shapeY, hexagonSize, hexagonSize);

                //check to see if collision with a square
                foreach (Square s in squareList)
                {
                    r = new Rectangle(s.x - 1, s.y - 1, s.size + 1, s.size + 1);

                    if (r.IntersectsWith(newSquare))
                    {
                        addShape = false;
                    }
                }

                //check to see if collision with a hexagon
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
                    Hexagon f = new Hexagon(shapeX, shapeY, hexagonSize, hexagonHp, hexagonDamage);
                    hexagonList.Add(f);
                }

                //start game
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
                case Keys.W:
                    wArrowDown = true;
                    break;
                case Keys.D:
                    dArrowDown = true;
                    break;
                case Keys.A:
                    aArrowDown = true;
                    break;
                case Keys.S:
                    sArrowDown = true;
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
                case Keys.X:
                    xDown = true;
                    break;
                case Keys.C:
                    cDown = true;
                    break;
                case Keys.Z:
                    zDown = true;
                    break;
                case Keys.V:
                    vDown = true;
                    break;
                case Keys.Escape:
                    //returns to MainScreen
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
                case Keys.W:
                    wArrowDown = false;
                    break;
                case Keys.D:
                    dArrowDown = false;
                    break;
                case Keys.A:
                    aArrowDown = false;
                    break;
                case Keys.S:
                    sArrowDown = false;
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
                case Keys.X:
                    xDown = false;
                    break;
                case Keys.C:
                    cDown = false;
                    break;
                case Keys.Z:
                    zDown = false;
                    break;
                case Keys.V:
                    vDown = false;
                    break;
            }
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            //each timer tick
            //if player reaches winning XP
            if (p1.xp >= 8000)
            {
                Form f = this.FindForm();
                if (f != null)
                {
                    //stop game
                    gameLoop.Enabled = false;

                    //play sound
                    gameOver.Play();

                    //2s pause
                    this.Refresh();
                    Thread.Sleep(2000);

                    //go to main screen
                    f.Controls.Remove(this);
                    MainScreen ms = new MainScreen();
                    ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);
                    ms.Size = f.Size;
                    f.Controls.Add(ms);
                    ms.Focus();

                    //display winner
                    ms.Winner(1);
                    return;
                }
            }
            if (p2.xp >= 8000)
            {
                Form f = this.FindForm();
                if (f != null)
                {
                    gameLoop.Enabled = false;

                    gameOver.Play();

                    this.Refresh();
                    Thread.Sleep(2000);

                    MainScreen ms = new MainScreen();
                    ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);
                    f.Controls.Remove(this);
                    ms.Size = f.Size;
                    f.Controls.Add(ms);
                    ms.Focus();
                    ms.Winner(2);
                }
            }

            //check if can upgrade attribute 
            if (p1.boost != p1.lvl)
            {
                boost1 = true;
            }
            if (p2.boost != p2.lvl)
            {
                boost2 = true;
            }


            //shape generation (same as OnStart)
            addShape = true;

            if (randGen.Next(1, squareGenerationSpeed) < 7)
            {
                shapeX = randGen.Next(1, this.Width - squareSize - 1);
                shapeY = randGen.Next(1, this.Height - squareSize - 1);
                newSquare = new Rectangle(shapeX, shapeY, squareSize, squareSize);

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
                    Square f = new Square(shapeX, shapeY, squareSize, squareHp, squareDamage);
                    squareList.Add(f);
                }
            }
            else if (randGen.Next(1, squareGenerationSpeed) == 11)
            {
                shapeX = randGen.Next(1, this.Width - hexagonSize - 1);
                shapeY = randGen.Next(1, this.Height - hexagonSize - 1);
                newSquare = new Rectangle(shapeX, shapeY, hexagonSize, hexagonSize);

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
                    Hexagon f = new Hexagon(shapeX, shapeY, hexagonSize, hexagonHp, hexagonDamage);
                    hexagonList.Add(f);

                    //increase shape generation speed
                    if (squareGenerationSpeed > 100)
                    {
                        squareGenerationSpeed -= 3;
                    }
                }
            }
            else if (randGen.Next(1, squareGenerationSpeed) == 12)
            {
                shapeX = randGen.Next(1, this.Width - triangleSize - 1);
                shapeY = randGen.Next(1, this.Height - triangleSize - 1);
                newSquare = new Rectangle(shapeX, shapeY, triangleSize, triangleSize);

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
                    Triangle t = new Triangle(shapeX, shapeY, triangleSize, triangleHp, triangleDamage, 3, "none");
                    triangleList.Add(t);
                }
            }

            //check if players collide
            p1.Collision(p2);


            foreach (Bullet b in bulletList)
            {
                //bullet move method
                b.Move(b.direction);

                //square collision method
                foreach (Square s in squareList)
                {
                    b.SquareCollision(s, p1, p2);
                }

                //hexagon collision method
                foreach (Hexagon h in hexagonList)
                {
                    b.HexagonCollision(h, p1, p2);
                }

                //triangle collision method
                foreach (Triangle t in triangleList)
                {
                    b.TriangleCollision(t);
                }

                //give xp to shooter if kills opponent
                if (b.shooter == 2)
                {
                    p2.xp += b.Collision(p1);
                }
                else
                {
                    p1.xp += b.Collision(p2);
                }

                //if bullet runs out of health or hits wall it gets removed
                if (b.hp <= 0 || b.x < 0 || b.x > this.Width - b.size || b.y < 0 || b.y > this.Height - b.size)
                {
                    deadBulletList.Add(b);
                }
            }

            foreach (Bot p in botList)
            {
                //move method for players
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
                    if (aArrowDown)
                    {
                        p.Move("left", this);
                    }

                    if (dArrowDown)
                    {
                        p.Move("right", this);
                    }

                    if (wArrowDown)
                    {
                        p.Move("up", this);
                    }

                    if (sArrowDown)
                    {
                        p.Move("down", this);
                    }
                }

                //shape collision methods
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

                //determine player lvl using xp
                if (p.xp >= 7500)
                {
                    p.lvl = 20;
                }
                else if (p.xp >= 6500)
                {
                    lvlUpgrade = 7500 - p.xp;
                    p.lvl = 19;
                }
                else if (p.xp >= 5550)
                {
                    lvlUpgrade = 6500 - p.xp;
                    p.lvl = 18;
                }
                else if (p.xp >= 4650)
                {
                    lvlUpgrade = 5550 - p.xp;
                    p.lvl = 17;
                }
                else if (p.xp >= 3800)
                {
                    lvlUpgrade = 4650 - p.xp;
                    p.lvl = 16;
                }
                else if (p.xp >= 3000)
                {
                    lvlUpgrade = 3800 - p.xp;
                    p.lvl = 15;
                }
                else if (p.xp >= 2250)
                {
                    lvlUpgrade = 3000 - p.xp;
                    p.lvl = 14;
                }
                else if (p.xp >= 1700)
                {
                    lvlUpgrade = 2250 - p.xp;
                    p.lvl = 13;
                }
                else if (p.xp >= 1300)
                {
                    lvlUpgrade = 1700 - p.xp;
                    p.lvl = 12;
                }
                else if (p.xp >= 1000)
                {
                    lvlUpgrade = 1300 - p.xp;
                    p.lvl = 11;
                }
                else if (p.xp >= 750)
                {
                    lvlUpgrade = 1000 - p.xp;
                    p.lvl = 10;
                }
                else if (p.xp >= 550)
                {
                    lvlUpgrade = 750 - p.xp;
                    p.lvl = 9;
                }
                else if (p.xp >= 400)
                {
                    lvlUpgrade = 550 - p.xp;
                    p.lvl = 8;
                }
                else if (p.xp >= 280)
                {
                    lvlUpgrade = 400 - p.xp;
                    p.lvl = 7;
                }
                else if (p.xp >= 180)
                {
                    lvlUpgrade = 280 - p.xp;
                    p.lvl = 6;
                }
                else if (p.xp >= 110)
                {
                    lvlUpgrade = 180 - p.xp;
                    p.lvl = 5;
                }
                else if (p.xp >= 60)
                {
                    lvlUpgrade = 110 - p.xp;
                    p.lvl = 4;
                }
                else if (p.xp >= 30)
                {
                    lvlUpgrade = 60 - p.xp;
                    p.lvl = 3;
                }
                else if (p.xp >= 10)
                {
                    lvlUpgrade = 30 - p.xp;
                    p.lvl = 2;
                }
                else
                {
                    lvlUpgrade = 10 - p.xp;
                    p.lvl = 1;
                }
                if (p.playerNumber == 1)
                {
                    lvl1Upgrade = lvlUpgrade;
                }
                else
                {
                    lvl2Upgrade = lvlUpgrade;
                }
            }

            foreach (Triangle t in triangleList)
            {
                //Manhattan distance between triangle and players
                d1x = (t.x - p1.x);
                d1y = (t.y - p1.y);
                d1t = Math.Abs(d1x) + Math.Abs(d1y);
                d2x = (t.x - p2.x);
                d2y = (t.y - p2.y);
                d2t = Math.Abs(d2x) + Math.Abs(d2y);

                //follows closest player
                if (d2t > d1t)
                {
                    if (d1x > 13)
                    {
                        t.Move("left");
                    }
                    else if (d1x < 7)
                    {
                        t.Move("right");
                    }
                    else if (d1y > 10)
                    {
                        t.Move("up");
                    }
                    else
                    {
                        t.Move("down");
                    }
                }
                else
                {
                    if (d2x > 13)
                    {
                        t.Move("left");
                    }
                    else if (d2x < 7)
                    {
                        t.Move("right");
                    }
                    else if (d2y > 10)
                    {
                        t.Move("up");
                    }
                    else
                    {
                        t.Move("down");
                    }
                }

                //shape collision methods
                foreach (Square s in squareList)
                {
                    t.SquareCollision(s);
                }
                foreach (Hexagon h in hexagonList)
                {
                    t.HexagonCollision(h);
                }

                //if runs out of health, it gets removed
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

            //remove dead objects
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

            //if shooting and has reloaded
            if (spaceDown == true)
            {
                if (p1CoolDown <= 0)
                {
                    //reset shoot cooldown
                    p1CoolDown = p1.reload;

                    //create bullet object in direction of movement
                    if (p1.direction == "left")
                    {
                        Bullet b = new Bullet(p1.x - 15, p1.y + 10, 20, p1.bulletHealth, p1.bulletDamage, p1.bulletSpeed, p1.direction, 1);
                        bulletList.Add(b);
                    }
                    else if (p1.direction == "right")
                    {
                        Bullet b = new Bullet(p1.x + p1.size - 5, p1.y + 10, 20, p1.bulletHealth, p1.bulletDamage, p1.bulletSpeed, p1.direction, 1);
                        bulletList.Add(b);
                    }
                    else if (p1.direction == "down")
                    {
                        Bullet b = new Bullet(p1.x + 10, p1.y + p1.size - 5, 20, p1.bulletHealth, p1.bulletDamage, p1.bulletSpeed, p1.direction, 1);
                        bulletList.Add(b);
                    }
                    else if (p1.direction == "up")
                    {
                        Bullet b = new Bullet(p1.x + 10, p1.y - 15, 20, p1.bulletHealth, p1.bulletDamage, p1.bulletSpeed, p1.direction, 1);
                        bulletList.Add(b);
                    }
                }
            }

            if (zDown == true)
            {
                if (p2CoolDown <= 0)
                {
                    p2CoolDown = p2.reload;
                    if (p2.direction == "left")
                    {
                        Bullet b = new Bullet(p2.x - 15, p2.y + 10, 20, p2.bulletHealth, p2.bulletDamage, p2.bulletSpeed, p2.direction, 2);
                        bulletList.Add(b);
                    }
                    else if (p2.direction == "right")
                    {
                        Bullet b = new Bullet(p2.x + 35, p2.y + 10, 20, p2.bulletHealth, p2.bulletDamage, p2.bulletSpeed, p2.direction, 2);
                        bulletList.Add(b);
                    }
                    else if (p2.direction == "down")
                    {
                        Bullet b = new Bullet(p2.x + 10, p2.y + 35, 20, p2.bulletHealth, p2.bulletDamage, p2.bulletSpeed, p2.direction, 2);
                        bulletList.Add(b);
                    }
                    else if (p2.direction == "up")
                    {
                        Bullet b = new Bullet(p2.x + 10, p2.y - 15, 20, p2.bulletHealth, p2.bulletDamage, p2.bulletSpeed, p2.direction, 2);
                        bulletList.Add(b);
                    }
                }
            }
            
          //if a player dies
            if (p1.hp <=0)
            {
                //respawn method
                p1.Respawn();

                //reset upgrades
                healthLabel.ForeColor = healthRegenLabel.ForeColor = bodyDamageLabel.ForeColor = bulletSpeedLabel.ForeColor = bulletHealthLabel.ForeColor = bulletDamageLabel.ForeColor = reloadLabel.ForeColor = speedLabel.ForeColor = Color.White;
            }

            if (p2.hp <= 0)
            {
                p2.Respawn();
                healthTwoLabel.ForeColor = healthRegenTwoLabel.ForeColor = bodyDamageTwoLabel.ForeColor = bulletSpeedTwoLabel.ForeColor = bulletHealthTwoLabel.ForeColor = bulletDamageTwoLabel.ForeColor = reloadTwoLabel.ForeColor = speedTwoLabel.ForeColor = Color.White;
            }

            //if time for health regen
            if (healthRegenCounter == 100)
            {
                foreach (Bot p in botList)
                {
                    //if not at max health
                    if (p.hp < p.maxHealth)
                    {
                        //will not surpass max health
                        if (p.hp > p.maxHealth - p.healthRegen)
                        {
                            p.hp = p.maxHealth;
                        }
                        else
                        {
                            //increase health by health regen attribute
                            p.hp += p.healthRegen;
                        }
                    }
                }

                //reset counter
                healthRegenCounter = 0;
            }

            //update labels
            health1Label.Text = Convert.ToString(p1.hp) + " hp";
            health2Label.Text = Convert.ToString(p2.hp) + " hp";
            level1Label.Text = "lvl " + Convert.ToString(p1.lvl);
            level2Label.Text = "lvl " + Convert.ToString(p2.lvl);

            if (p1.lvl != 20)
            {
                xp1Label.Text = Convert.ToString(lvl1Upgrade) + " xp to lvl " + Convert.ToString(p1.lvl + 1);
            }
            else
            {
                xp1Label.Text = "Max Level: " + Convert.ToString(p1.xp) + " xp";
            }
            if (p2.lvl != 20)
            {
                xp2Label.Text = Convert.ToString(lvl2Upgrade) + " xp to lvl " + Convert.ToString(p2.lvl + 1);
            }
            else
            {
                xp2Label.Text = "Max Level: " + Convert.ToString(p1.xp) + " xp";
            }

            //if upgrade possible, show upgrade labels
            if (boost1 == true)
            {
                healthLabel.Visible = true;
                healthRegenLabel.Visible = true;
                bodyDamageLabel.Visible = true;
                bulletSpeedLabel.Visible = true;
                bulletHealthLabel.Visible = true;
                bulletDamageLabel.Visible = true;
                reloadLabel.Visible = true;
                speedLabel.Visible = true;
                if (keyCoolDown1 < 0)
                {
                    //swaps between attributes to upgrade
                    if (mDown == true)
                    {
                        if (attribute1 < 7)
                        {
                            attribute1++;
                            keyCoolDown1 = 5;
                            Bold1Label();
                        }
                    }
                    if (bDown == true)
                    {
                        if (attribute1 > 0)
                        {
                            attribute1--;
                            keyCoolDown1 = 5;
                            Bold1Label();
                        }
                    }
                    //selects upgrade
                    if (nDown == true)
                    {
                        keyCoolDown1 = 5;
                        LevelUp(p1, attribute1);

                        //upgrade labels dissapear
                        boost1 = false;
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

            if (boost2 == true)
            {
                healthTwoLabel.Visible = true;
                healthRegenTwoLabel.Visible = true;
                bodyDamageTwoLabel.Visible = true;
                bulletSpeedTwoLabel.Visible = true;
                bulletHealthTwoLabel.Visible = true;
                bulletDamageTwoLabel.Visible = true;
                reloadTwoLabel.Visible = true;
                speedTwoLabel.Visible = true;
                if (keyCoolDown2 < 0)
                {
                    if (xDown == true)
                    {
                        if (attribute2 < 7)
                        {
                            attribute2++;
                            keyCoolDown2 = 5;
                            Bold2Label();
                        }
                    }
                    if (cDown == true)
                    {
                        if (attribute2 > 0)
                        {
                            attribute2--;
                            keyCoolDown2 = 5;
                            Bold2Label();
                        }
                    }
                    if (vDown == true)
                    {
                        keyCoolDown2 = 5;
                        LevelUp(p2, attribute2);
                        boost2 = false;
                        healthTwoLabel.Visible = false;
                        healthRegenTwoLabel.Visible = false;
                        bodyDamageTwoLabel.Visible = false;
                        bulletSpeedTwoLabel.Visible = false;
                        bulletHealthTwoLabel.Visible = false;
                        bulletDamageTwoLabel.Visible = false;
                        reloadTwoLabel.Visible = false;
                        speedTwoLabel.Visible = false;
                    }
                }
            }

            //counters count
            p1CoolDown--;
            p2CoolDown--;
            keyCoolDown1--;
            keyCoolDown2--;
            healthRegenCounter++;

            //clear object removal lists
            deadSquareList.Clear();
            deadTriangleList.Clear();
            deadHexagonList.Clear();
            deadBulletList.Clear();

            Refresh();
        }

        public void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw objects
            foreach (Square s in squareList)
            {
                e.Graphics.FillRectangle(s.squareBrush, s.x, s.y, s.size, s.size);
            }
            foreach (Hexagon h in hexagonList)
            {
                //vertexes
                d1 = new Point(h.x + 12, h.y);
                d2 = new Point(h.x + 36, h.y);
                d3 = new Point(h.x + hexagonSize, h.y + 24);
                d4 = new Point(h.x + 36, h.y + hexagonSize);
                d5 = new Point(h.x + 12, h.y + hexagonSize);
                d6 = new Point(h.x, h.y + 24);

                HexagonArray[0] = d1;
                HexagonArray[1] = d2;
                HexagonArray[2] = d3;
                HexagonArray[3] = d4;
                HexagonArray[4] = d5;
                HexagonArray[5] = d6;

                //draw hexagon using points
                e.Graphics.FillPolygon(h.hexagonBrush, HexagonArray);
            }

            foreach (Bullet b in bulletList)
            {
                e.Graphics.FillEllipse(b.bulletBrush, new Rectangle(b.x, b.y, b.size, b.size));
            }

            foreach (Bot b in botList)
            {
                //draw 'gun' in direction of movement
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
                //triangle tip in direction of movement
                if (t.direction == "left")
                {
                    d1 = new Point(t.x, t.y + 11);
                    d2 = new Point(t.x + triangleSize, t.y);
                    d3 = new Point(t.x + triangleSize, t.y + triangleSize);
                }
                else if (t.direction == "right")
                {
                    d1 = new Point(t.x, t.y);
                    d2 = new Point(t.x + triangleSize, t.y + 11);
                    d3 = new Point(t.x, t.y + triangleSize);
                }
                else if (t.direction == "down")
                {
                    d1 = new Point(t.x, t.y);
                    d2 = new Point(t.x + triangleSize, t.y);
                    d3 = new Point(t.x + 11, t.y + triangleSize);
                }
                else
                {
                    d1 = new Point(t.x, t.y + triangleSize);
                    d2 = new Point(t.x + 11, t.y);
                    d3 = new Point(t.x + triangleSize, t.y + triangleSize);
                }

                triangleArray[0] = d1;
                triangleArray[1] = d2;
                triangleArray[2] = d3;

                e.Graphics.FillPolygon(t.triangleBrush, triangleArray);
            }
        }

        private void Bold1Label()
        {
            //reset fonts
            healthLabel.Font = new Font(this.Font, FontStyle.Regular);
            healthRegenLabel.Font = new Font(this.Font, FontStyle.Regular);
            bodyDamageLabel.Font = new Font(this.Font, FontStyle.Regular);
            bulletSpeedLabel.Font = new Font(this.Font, FontStyle.Regular);
            bulletHealthLabel.Font = new Font(this.Font, FontStyle.Regular);
            bulletDamageLabel.Font = new Font(this.Font, FontStyle.Regular);
            reloadLabel.Font = new Font(this.Font, FontStyle.Regular);
            speedLabel.Font = new Font(this.Font, FontStyle.Regular);

            //bold selected attribute label
            if (attribute1 == 0)
            {
                healthLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (attribute1 == 1)
            {
                healthRegenLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (attribute1 == 2)
            {
                bodyDamageLabel.Font = new Font(this.Font, FontStyle.Bold); 
            }
            else if (attribute1 == 3)
            {
                bulletSpeedLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (attribute1 == 4)
            {
                bulletHealthLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (attribute1 == 5)
            {
                bulletDamageLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (attribute1 == 6)
            {
                reloadLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (attribute1 == 7)
            {
                speedLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
        }

        private void Bold2Label()
        {
            healthTwoLabel.Font = new Font(this.Font, FontStyle.Regular);
            healthRegenTwoLabel.Font = new Font(this.Font, FontStyle.Regular);
            bodyDamageTwoLabel.Font = new Font(this.Font, FontStyle.Regular);
            bulletSpeedTwoLabel.Font = new Font(this.Font, FontStyle.Regular);
            bulletHealthTwoLabel.Font = new Font(this.Font, FontStyle.Regular);
            bulletDamageTwoLabel.Font = new Font(this.Font, FontStyle.Regular);
            reloadTwoLabel.Font = new Font(this.Font, FontStyle.Regular);
            speedTwoLabel.Font = new Font(this.Font, FontStyle.Regular);

            if (attribute2 == 0)
            {
                healthTwoLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (attribute2 == 1)
            {
                healthRegenTwoLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (attribute2 == 2)
            {
                bodyDamageTwoLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (attribute2 == 3)
            {
                bulletSpeedTwoLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (attribute2 == 4)
            {
                bulletHealthTwoLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (attribute2 == 5)
            {
                bulletDamageTwoLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (attribute2 == 6)
            {
                reloadTwoLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (attribute2 == 7)
            {
                speedTwoLabel.Font = new Font(this.Font, FontStyle.Bold);
            }
        }
        private void LevelUp(Bot p, int attribute)
        {
            //upgrade attribute for specific player
            if (p.playerNumber == 1)
            {
                //upgrade selected attribute
                if (attribute == 0)
                {
                    //cannot upgrade if label forecolour is red
                    if (healthLabel.ForeColor != Color.Red)
                    {
                        p.hp += 50;
                        p.maxHealth += 50;
                        p.boost++;

                        //if max upgrade make label forecolour red
                        if (p.maxHealth > 375)
                        {
                            healthLabel.ForeColor = Color.Red;
                        }
                    }
                }
                else if (attribute == 1)
                {
                    if (healthRegenLabel.ForeColor != Color.Red)
                    {
                        p.healthRegen += 4;
                        p.boost++;
                        if (p.healthRegen > 24)
                        {
                            healthRegenLabel.ForeColor = Color.Red;
                        }
                    }
                }
                else if (attribute == 2)
                {
                    if (bodyDamageLabel.ForeColor != Color.Red)
                    {
                        p.damage += 10;
                        p.boost++;
                        if (p.damage > 58)
                        {
                            bodyDamageLabel.ForeColor = Color.Red;
                        }
                    }
                }
                else if (attribute == 3)
                {
                    if (bulletSpeedLabel.ForeColor != Color.Red)
                    {
                        p.bulletSpeed += 8;
                        p.boost++;
                        if (p.bulletSpeed > 44)
                        {
                            bulletSpeedLabel.ForeColor = Color.Red;
                        }
                    }
                }
                else if (attribute == 4)
                {
                    if (bulletHealthLabel.ForeColor != Color.Red)
                    {
                        p.bulletHealth += 13;
                        p.boost++;
                        if (p.bulletHealth > 69)
                        {
                            bulletHealthLabel.ForeColor = Color.Red;
                        }
                    }
                }
                else if (attribute == 5)
                {
                    if (bulletDamageLabel.ForeColor != Color.Red)
                    {
                        p.bulletDamage += 17;
                        p.boost++;
                        if (p.bulletDamage > 93)
                        {
                            bulletDamageLabel.ForeColor = Color.Red;
                        }
                    }
                }
                else if (attribute == 6)
                {
                    if (reloadLabel.ForeColor != Color.Red)
                    {
                        p.reload -= 4;
                        p.boost++;
                        if (p.reload < 6)
                        {
                            reloadLabel.ForeColor = Color.Red;
                        }
                    }
                }
                else
                {
                    if (speedLabel.ForeColor != Color.Red)
                    {
                        p.speed += 2;
                        p.boost++;
                        if (p.speed > 13)
                        {
                            speedLabel.ForeColor = Color.Red;
                        }
                    }
                }
            }
            else
            {
                if (attribute == 0)
                {
                    if (healthTwoLabel.ForeColor != Color.Red)
                    {
                        p.hp += 50;
                        p.maxHealth += 50;
                        p.boost++;
                        if (p.maxHealth > 375)
                        {
                            healthTwoLabel.ForeColor = Color.Red;
                        }
                    }
                }
                else if (attribute == 1)
                {
                    if (healthRegenTwoLabel.ForeColor != Color.Red)
                    {
                        p.healthRegen += 4;
                        p.boost++;
                        if (p.healthRegen > 24)
                        {
                            healthRegenTwoLabel.ForeColor = Color.Red;
                        }
                    }
                }
                else if (attribute == 2)
                {
                    if (bodyDamageTwoLabel.ForeColor != Color.Red)
                    {
                        p.damage += 10;
                        p.boost++;
                        if (p.damage > 58)
                        {
                            bodyDamageTwoLabel.ForeColor = Color.Red;
                        }
                    }
                }
                else if (attribute == 3)
                {
                    if (bulletSpeedTwoLabel.ForeColor != Color.Red)
                    {
                        p.bulletSpeed += 8;
                        p.boost++;
                        if (p.bulletSpeed > 44)
                        {
                            bulletSpeedTwoLabel.ForeColor = Color.Red;
                        }
                    }
                }
                else if (attribute == 4)
                {
                    if (bulletHealthTwoLabel.ForeColor != Color.Red)
                    {
                        p.bulletHealth += 13;
                        p.boost++;
                        if (p.bulletHealth > 69)
                        {
                            bulletHealthTwoLabel.ForeColor = Color.Red;
                        }
                    }
                }
                else if (attribute == 5)
                {
                    if (bulletDamageTwoLabel.ForeColor != Color.Red)
                    {
                        p.bulletDamage += 17;
                        p.boost++;
                        if (p.bulletDamage > 93)
                        {
                            bulletDamageTwoLabel.ForeColor = Color.Red;
                        }
                    }
                }
                else if (attribute == 6)
                {
                    if (reloadTwoLabel.ForeColor != Color.Red)
                    {
                        p.reload -= 4;
                        p.boost++;
                        if (p.reload < 6)
                        {
                            reloadTwoLabel.ForeColor = Color.Red;
                        }
                    }
                }
                else
                {
                    if (speedTwoLabel.ForeColor != Color.Red)
                    {
                        p.speed += 2;
                        p.boost++;
                        if (p.speed > 13)
                        {
                            speedTwoLabel.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }
    }
}