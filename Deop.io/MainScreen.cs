using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Diagnostics;

namespace Deop.io
{
    public partial class MainScreen : UserControl
    {
        //sound
        SoundPlayer winner = new SoundPlayer(Properties.Resources.winner);

        //stopwatch
        Stopwatch myWatch = new Stopwatch();

        //if focused on this screen
        Boolean focus = true;
        
        public MainScreen()
        {
            InitializeComponent();

            //start watch
            myWatch.Start();
        }

        public void MainScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //if focused on screen or enough time has passed
            if (myWatch.ElapsedMilliseconds > 4000 || focus == true)
            {
                //stop watch
                myWatch.Stop();

                Form f = this.FindForm();
                //if key is pressed
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        //close program
                        Application.Exit();
                        break;
                    case Keys.N:
                        //go to sps screen
                        SinglePlayerScreen sps = new SinglePlayerScreen
                        {
                            Location = new Point(f.Location.X, f.Location.Y)
                        };
                        f.Controls.Remove(this);
                        sps.Size = f.Size;
                        f.Controls.Add(sps);
                        sps.Focus();
                        break;
                    case Keys.B:
                        //go to hs screen
                        HighScoreScreen hs = new HighScoreScreen();
                        hs.Location = new Point((f.Width - hs.Width) / 2, (f.Height - hs.Height) / 2);
                        f.Controls.Remove(this);
                        hs.Size = f.Size;
                        f.Controls.Add(hs);
                        hs.Focus();
                        break;
                    case Keys.M:
                        //go to ins screen
                        InstructionScreen ins = new InstructionScreen();
                        ins.Location = new Point((f.Width - ins.Width) / 2, (f.Height - ins.Height) / 2);
                        f.Controls.Remove(this);
                        ins.Size = f.Size;
                        f.Controls.Add(ins);
                        ins.Focus();
                        break;
                    case Keys.Space:
                        //go to game screen
                        GameScreen gs = new GameScreen
                        {
                            Location = new Point(f.Location.X, f.Location.Y)
                        };
                        f.Controls.Remove(this);
                        gs.Size = f.Size;
                        f.Controls.Add(gs);
                        gs.Focus();
                        break;
                }
            }
        }

        public void Winner(int p)
        {
            //not focused on screen
            focus = false;

            //display winner
            titleLabel.Text = "Player " + Convert.ToString(p) + " is the winner!";

            //play sound
            winner.Play();

            //two second pause
            this.Refresh();
            Thread.Sleep(2000);

            //returns label to original
            titleLabel.Text = "Deop.io";

            
        }
    }
}
