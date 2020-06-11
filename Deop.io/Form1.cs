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
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deop.io
{
    //talk about game HERE:
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //go to MainScreen
            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
            ms.Size = this.Size;

            //hide cursor
            Cursor.Hide();
        }
    }
}
