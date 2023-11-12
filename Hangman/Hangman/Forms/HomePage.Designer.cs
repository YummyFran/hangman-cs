namespace Hangman.Forms
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.intro = new System.Windows.Forms.Panel();
            this.animation = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gameMode = new System.Windows.Forms.Label();
            this.Playbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.intro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animation)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // intro
            // 
            this.intro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.intro.BackColor = System.Drawing.Color.Transparent;
            this.intro.Controls.Add(this.animation);
            this.intro.Dock = System.Windows.Forms.DockStyle.Top;
            this.intro.Location = new System.Drawing.Point(0, 0);
            this.intro.Name = "intro";
            this.intro.Size = new System.Drawing.Size(800, 225);
            this.intro.TabIndex = 0;
            // 
            // animation
            // 
            this.animation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.animation.Image = ((System.Drawing.Image)(resources.GetObject("animation.Image")));
            this.animation.Location = new System.Drawing.Point(0, 93);
            this.animation.Name = "animation";
            this.animation.Size = new System.Drawing.Size(800, 132);
            this.animation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.animation.TabIndex = 0;
            this.animation.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gameMode);
            this.panel1.Controls.Add(this.Playbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 225);
            this.panel1.TabIndex = 1;
            // 
            // gameMode
            // 
            this.gameMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameMode.Location = new System.Drawing.Point(0, 46);
            this.gameMode.Name = "gameMode";
            this.gameMode.Size = new System.Drawing.Size(800, 23);
            this.gameMode.TabIndex = 2;
            this.gameMode.Text = "mode";
            this.gameMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Playbtn
            // 
            this.Playbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Playbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.Playbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Playbtn.ForeColor = System.Drawing.Color.White;
            this.Playbtn.Location = new System.Drawing.Point(328, 86);
            this.Playbtn.Name = "Playbtn";
            this.Playbtn.Size = new System.Drawing.Size(136, 51);
            this.Playbtn.TabIndex = 1;
            this.Playbtn.Text = "Play";
            this.Playbtn.UseVisualStyleBackColor = false;
            this.Playbtn.Click += new System.EventHandler(this.Playbtn_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Permanent Marker", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hangman";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.intro);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.intro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.animation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel intro;
        private System.Windows.Forms.PictureBox animation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Playbtn;
        private System.Windows.Forms.Label gameMode;
    }
}