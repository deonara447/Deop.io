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

namespace Deop.io
{
    public partial class HighScoreScreen : UserControl
    {
        List<HighScore> scores = new List<HighScore>();

        public HighScoreScreen()
        {
            InitializeComponent();
        }

        private void HighScoreScreen_Load(object sender, EventArgs e)
        {
            List<string> scoreList = File.ReadAllLines("Score.txt").ToList();

            for (int i = 0; i < scoreList.Count; i += 2)
            {
                string name = scoreList[i];
                int score = Convert.ToInt32(scoreList[i + 1]);

                HighScore hs = new HighScore(name, score);
                scores.Add(hs);
            }
            scores = scores.OrderByDescending(x => x.score).ToList();

            firstName.Text = scores[0].name;
            secondName.Text = scores[1].name;
            thirdName.Text = scores[2].name;

            firstScore.Text = Convert.ToString(scores[0].score);
            secondScore.Text = Convert.ToString(scores[1].score);
            thirdScore.Text = Convert.ToString(scores[2].score);


        }

      
        
        private void HighScoreScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    //close program
                    Application.Exit();
                    break;
                case Keys.Space:
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
    }
}
