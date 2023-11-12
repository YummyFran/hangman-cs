using Hangman.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        private Button currentBtn;
        public Form activeForm;
        public Form1()
        {
            InitializeComponent();
            currentBtn = this.button1;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void activateButton(object sender)
        {
            if (sender != null)
            {
                if(currentBtn != (Button)sender)
                {
                    deactivateButton();
                    currentBtn = (Button)sender;
                    currentBtn.Enabled = false;
                    currentBtn.BackColor = ColorTranslator.FromHtml("#394867");
                    currentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(246)))), ((int)(((byte)(249))))); ;
                    currentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    displayHomePage();
                }
            }
        }

        private void deactivateButton()
        {
            foreach(Control prevBtn in Menu.Controls)
            {
                if(prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = Color.FromArgb(33, 42, 62);
                    prevBtn.ForeColor = Color.White;
                    prevBtn.Enabled = true;
                    prevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        public void displayAction(Form page)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            
            activeForm = page;
            page.TopLevel = false;
            page.TopMost = true;
            page.FormBorderStyle = FormBorderStyle.None;
            page.Dock = DockStyle.Fill;
            this.Game.Controls.Add(page);
            this.Game.Tag = page;
            page.BringToFront();
            page.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizebtn_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            } else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayHomePage();
        }

        private void displayHomePage()
        {
            HomePage homepage = new Forms.HomePage(this);
            homepage.setMode(currentBtn.Text);
            displayAction(homepage);
        }
    }
}
