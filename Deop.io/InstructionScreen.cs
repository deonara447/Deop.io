using System;
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
    public partial class InstructionScreen : UserControl
    {
        public InstructionScreen()
        {
            InitializeComponent();
        }

        private void InstructionScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //if key pressed
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    //close program
                    Application.Exit();
                    break;
                case Keys.Space:
                    //go to MainScreen
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
