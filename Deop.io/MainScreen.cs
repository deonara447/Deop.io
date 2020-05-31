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

namespace Deop.io
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }


        public void MainScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Form f = this.FindForm();
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    //close program
                    Application.Exit();
                    break;
                case Keys.N:
                    SinglePlayerScreen sps = new SinglePlayerScreen();
                    sps.Location = new Point(f.Location.X, f.Location.Y);
                    f.Controls.Remove(this);
                    sps.Size = f.Size;
                    f.Controls.Add(sps);
                    sps.Focus();
                    break;
                case Keys.B:
                    HighScoreScreen hs = new HighScoreScreen();
                    hs.Location = new Point((f.Width - hs.Width) / 2, (f.Height - hs.Height) / 2);
                    f.Controls.Remove(this);
                    hs.Size = f.Size;
                    f.Controls.Add(hs);
                    hs.Focus();
                    break;
                case Keys.M:
                    InstructionScreen ins = new InstructionScreen();
                    ins.Location = new Point((f.Width - ins.Width) / 2, (f.Height - ins.Height) / 2);
                    f.Controls.Remove(this);
                    ins.Size = f.Size;
                    f.Controls.Add(ins);
                    ins.Focus();
                    break;
                case Keys.Space:
                    GameScreen gs = new GameScreen();
                    gs.Location = new Point(f.Location.X, f.Location.Y);
                    f.Controls.Remove(this);
                    gs.Size = f.Size;
                    f.Controls.Add(gs);
                    gs.Focus();
                    break;
            }
        }
        public void Winner(int p)
        {
            titleLabel.Text = "Player " + Convert.ToString(p) + " is the winner!";
           
            //one and half second pause
            this.Refresh();
            Thread.Sleep(1500);

            //returns label to original
            titleLabel.Text = "Deop.io";
        }
    }
}
