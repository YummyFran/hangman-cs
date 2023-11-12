using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman.Forms
{
    public partial class PhraseGameMode : Form
    {
        private string secretWord;
        private int attemptsLeft;
        private static String currPath = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
        private String imagePath = Path.Combine(currPath, "..\\..\\..\\assets");
        private String[] images = { "bitay0.png", "bitay1.png", "bitay2.png", "bitay3.png", "bitay4.png", "bitay5.png", "bitay6.png" };
        public PhraseGameMode()
        {
            InitializeComponent();
        }

        private void PhraseGameMode_Load(object sender, EventArgs e)
        {
            this.startGame();
        }

        private void startGame()
        {
            string[] words = { "good morning", "how are you", "thank you", "have a nice day", "see you later" };
            Random random = new Random();
            secretWord = words[random.Next(words.Length)];
            attemptsLeft = 6;

            secretLbl.Text = GetSecretWord();
            bitay.ImageLocation = Path.Combine(imagePath, images[0]);

            foreach (Control btn in keyboard.Controls)
            {
                btn.Enabled = true;
                btn.BackColor = ColorTranslator.FromHtml("#212A3E");
            }
        }

        private string GetSecretWord()
        {
            string secret = "";
            foreach (char c in secretWord)
            {
                if (c == ' ')
                {
                    secret += "  ";
                }
                else
                {
                    secret += "_ ";
                }
            }
            return secret;
        }

        private void playerMoved(char letter, object button)
        {
            bool found = false;

            Button clickedButton = (Button)button;
            clickedButton.Enabled = false;
            clickedButton.BackColor = ColorTranslator.FromHtml("#394867");

            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == letter)
                {
                    found = true;
                    secretLbl.Text = secretLbl.Text.Substring(0, i * 2) + letter + " " + secretLbl.Text.Substring(i * 2 + 2);
                }
            }
            if (!found)
            {
                attemptsLeft--;
                bitay.ImageLocation = Path.Combine(imagePath, images[6 - attemptsLeft]);
            }

            if (secretLbl.Text.IndexOf("_") == -1)
            {
                MessageBox.Show("You win!");
                this.startGame();
            }
            else if (attemptsLeft == 0)
            {
                MessageBox.Show($"You lose! The secret word was \"{secretWord}\".");
                this.startGame();
            }
        }

        private void a_Click(object sender, EventArgs e)
        {
            playerMoved('a', sender);
        }

        private void b_Click(object sender, EventArgs e)
        {
            playerMoved('b', sender);
        }

        private void c_Click(object sender, EventArgs e)
        {
            playerMoved('c', sender);
        }

        private void d_Click(object sender, EventArgs e)
        {
            playerMoved('d', sender);
        }

        private void e_Click(object sender, EventArgs e)
        {
            playerMoved('e', sender);
        }

        private void f_Click(object sender, EventArgs e)
        {
            playerMoved('f', sender);
        }

        private void g_Click(object sender, EventArgs e)
        {
            playerMoved('g', sender);
        }

        private void h_Click(object sender, EventArgs e)
        {
            playerMoved('h', sender);
        }

        private void i_Click(object sender, EventArgs e)
        {
            playerMoved('i', sender);
        }

        private void j_Click(object sender, EventArgs e)
        {
            playerMoved('j', sender);
        }

        private void k_Click(object sender, EventArgs e)
        {
            playerMoved('k', sender);
        }

        private void l_Click(object sender, EventArgs e)
        {
            playerMoved('l', sender);
        }

        private void m_Click(object sender, EventArgs e)
        {
            playerMoved('m', sender);
        }

        private void n_Click(object sender, EventArgs e)
        {
            playerMoved('n', sender);
        }

        private void o_Click(object sender, EventArgs e)
        {
            playerMoved('o', sender);
        }

        private void p_Click(object sender, EventArgs e)
        {
            playerMoved('p', sender);
        }

        private void q_Click(object sender, EventArgs e)
        {
            playerMoved('q', sender);
        }

        private void r_Click(object sender, EventArgs e)
        {
            playerMoved('r', sender);
        }

        private void s_Click(object sender, EventArgs e)
        {
            playerMoved('s', sender);
        }

        private void t_Click(object sender, EventArgs e)
        {
            playerMoved('t', sender);
        }

        private void u_Click(object sender, EventArgs e)
        {
            playerMoved('u', sender);
        }

        private void v_Click(object sender, EventArgs e)
        {
            playerMoved('v', sender);
        }

        private void w_Click(object sender, EventArgs e)
        {
            playerMoved('w', sender);
        }

        private void x_Click(object sender, EventArgs e)
        {
            playerMoved('x', sender);
        }

        private void y_Click(object sender, EventArgs e)
        {
            playerMoved('y', sender);
        }

        private void z_Click(object sender, EventArgs e)
        {
            playerMoved('z', sender);
        }

        private void PhraseGameMode_SizeChanged(object sender, EventArgs e)
        {
            bitay.SizeMode = PictureBoxSizeMode.Zoom;
            bitay.Height = ClientSize.Height / 3;
        }
    }
}
