using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Deop.io
{
    public partial class HighScoreScreen : UserControl
    {
        //for determining initials
        int upDown = 1;
        int leftRight = 1;
        string letter;

        //for holding new score
        HighScore hs;

        //for downloading and uploading high scores
        List<HighScore> scores = new List<HighScore>();

        public HighScoreScreen()
        {
            InitializeComponent();
        }

        private void HighScoreScreen_Load(object sender, EventArgs e)
        {
            //download information from text file
            List<string> scoreList = File.ReadAllLines("Score.txt").ToList();

            for (int i = 0; i < scoreList.Count; i += 2)
            {
                string name = scoreList[i];
                int score = Convert.ToInt32(scoreList[i + 1]);

                //turning text file information into objects (name, score)
                HighScore hs = new HighScore(name, score);
                scores.Add(hs);
            }

            //put objects in order of score
            scores = scores.OrderByDescending(x => x.score).ToList();

            //show names of top 3 scores
            firstName.Text = scores[0].name;
            secondName.Text = scores[1].name;
            thirdName.Text = scores[2].name;

            //show top 3 scores
            firstScore.Text = Convert.ToString(scores[0].score);
            secondScore.Text = Convert.ToString(scores[1].score);
            thirdScore.Text = Convert.ToString(scores[2].score);
        }

        private void HighScoreScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //when key is pressed
            switch (e.KeyCode)
            {
                case Keys.W:
                    //so that at Z returns to A
                    if (upDown == 26)
                    {
                        upDown = 1;
                    }
                    else
                    {
                        upDown++;
                    }
                    Initials();
                    break;
                case Keys.D:
                    if (leftRight == 3)
                    {
                        leftRight = 1;
                    }
                    else
                    {
                        leftRight++;
                    }
                    Initials();
                    break;
                case Keys.A:
                    if (leftRight == 1)
                    {
                        leftRight = 3;
                    }
                    else
                    {
                        leftRight--;
                    }
                    Initials();
                    break;
                case Keys.S:
                    if (upDown == 1)
                    {
                        upDown = 26;
                    }
                    else
                    {
                        upDown--;
                    }
                    Initials();
                    break;
                case Keys.Escape:
                    //close program
                    Application.Exit();
                    break;
                case Keys.Space:
                    try
                    {
                        //if saving high score
                        //add new high score object (your initials, your score)
                        scores.Remove(hs);
                        hs = new HighScore(yourName1.Text + yourName2.Text + yourName3.Text, Convert.ToInt16(yourScore.Text));
                        scores.Add(hs);
                        scores = scores.OrderByDescending(x => x.score).ToList();

                        List<string> tempList = new List<string>();

                        // Add all info from each HighScore object to temp list 
                        foreach (HighScore hs in scores)
                        {
                            tempList.Add(hs.name);
                            tempList.Add(Convert.ToString(hs.score));
                        }

                        //upload updated scores to text file
                        File.WriteAllLines("Score.txt", tempList);
                    }
                    catch
                    {
                        //if viewing high scores
                    }

                    //return to main screen
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

        public void Results(int xp)
        {
            //make labels visible
            yourName1.Visible = true;
            yourName2.Visible = true;
            yourName3.Visible = true;
            yourScore.Visible = true;
            yourPlace.Visible = true;

            //display your score
            yourScore.Text = Convert.ToString(xp);
            mainScreenLabel.Text = "save score";

            //update high scores
            hs = new HighScore("YOU", xp);
            scores.Add(hs);
            scores = scores.OrderByDescending(x => x.score).ToList();

            firstName.Text = scores[0].name;
            secondName.Text = scores[1].name;
            thirdName.Text = scores[2].name;

            firstScore.Text = Convert.ToString(scores[0].score);
            secondScore.Text = Convert.ToString(scores[1].score);
            thirdScore.Text = Convert.ToString(scores[2].score);

            yourPlace.Text = Convert.ToString(scores.IndexOf(hs) + 1);

            //3s pause
            this.Refresh();
            Thread.Sleep(3000);
        }

        public void Initials()
        {
            //unbold all labels
            yourName1.Font = yourName2.Font = yourName3.Font = new Font(Font, FontStyle.Regular);

            //each in assigned a letter
            if (upDown == 1)
            {
                letter = "A";
            }
            else if (upDown == 2)
            {
                letter = "B";
            }
            else if (upDown == 3)
            {
                letter = "C";
            }
            else if (upDown == 4)
            {
                letter = "D";
            }
            else if (upDown == 5)
            {
                letter = "E";
            }
            else if (upDown == 6)
            {
                letter = "F";
            }
            else if (upDown == 7)
            {
                letter = "G";
            }
            else if (upDown == 8)
            {
                letter = "H";
            }
            else if (upDown == 9)
            {
                letter = "I";
            }
            else if (upDown == 10)
            {
                letter = "J";
            }
            else if (upDown == 11)
            {
                letter = "K";
            }
            else if (upDown == 12)
            {
                letter = "L";
            }
            else if (upDown == 13)
            {
                letter = "M";
            }
            else if (upDown == 14)
            {
                letter = "N";
            }
            else if (upDown == 15)
            {
                letter = "O";
            }
            else if (upDown == 16)
            {
                letter = "P";
            }
            else if (upDown == 17)
            {
                letter = "Q";
            }
            else if (upDown == 18)
            {
                letter = "R";
            }
            else if (upDown == 19)
            {
                letter = "S";
            }
            else if (upDown == 20)
            {
                letter = "T";
            }
            else if (upDown == 21)
            {
                letter = "U";
            }
            else if (upDown == 22)
            {
                letter = "V";
            }
            else if (upDown == 23)
            {
                letter = "W";
            }
            else if (upDown == 24)
            {
                letter = "X";
            }
            else if (upDown == 25)
            {
                letter = "Y";
            }
            else
            {
                letter = "Z";
            }

            //each int assigned an initial 
            if (leftRight == 1)
            {
                //bold idenified letter of initial
                yourName1.Font = new Font(Font, FontStyle.Bold);
                yourName1.Text = letter;
            }
            else if (leftRight == 2)
            {
                yourName2.Font = new Font(Font, FontStyle.Bold);
                yourName2.Text = letter;
            }
            else
            {
                yourName3.Font = new Font(Font, FontStyle.Bold);
                yourName3.Text = letter;
            }

            //20 ms pause
            this.Refresh();
            Thread.Sleep(20);
        }
    }
}
