using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman.Forms
{
    public partial class HomePage : Form
    {
        private Form1 main;
        private String currentMode;

        private String modestr = "Guess the ";
        public HomePage(Form1 _main)
        {
            InitializeComponent();
            main = _main;
            this.SizeChanged += new EventHandler(Form1_SizeChanged);
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int windowWidth = this.ClientSize.Width;
            int windowHeight = this.ClientSize.Height;

            intro.Width = windowWidth / 2;
            intro.Height = windowHeight / 2;
            animation.SizeMode = PictureBoxSizeMode.Zoom;
            animation.Height = windowHeight / 4;
        }

        public void setMode(object mode)
        {
            gameMode.Text = modestr + mode;
            currentMode = mode.ToString();
        }

        private void Playbtn_Click(object sender, EventArgs e)
        {

            Controls.Remove(panel1);
            intro.Controls.Remove(animation);
           
            if(currentMode == "Word")
            {
                WordGameMode word = new Forms.WordGameMode();
                main.displayAction(word);
            } else
            {
                PhraseGameMode phrase = new Forms.PhraseGameMode();
                main.displayAction(phrase);
            }
        }
    }
}
