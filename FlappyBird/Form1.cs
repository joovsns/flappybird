using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gameTimer.Start();
        }

        int obstacleSpeed = 5;
        int g = 5;
        int score  = 0;
        int gap, y;
        bool isGameOver = false;
        int gravity = 1;
        int velocity = 0; // brzina ptice


        int highscore = Properties.Settings.Default.Highscore;

        private void gameOver()
        {
            if (isGameOver) return;   
            isGameOver = true;

            gameTimer.Stop();
            //MessageBox.Show("Game Over!\nScore: " + score);
            this.KeyPreview = true;
            gameoverLabel.Visible = true;
            resetButton.Visible = true;
           // this.Focus();

            if (score > highscore)
            {
                highscore = score;
                Properties.Settings.Default.Highscore = highscore; // sačuvaj
                Properties.Settings.Default.Save();
            }
            highScoree.Text = Convert.ToString(highscore);
        }

        Random r = new Random();
        private void gameStart(object sender, EventArgs e)
        {
            if (isGameOver) return;
            // highScoree.Text = Math.Max(score, highscore).ToString();

            if (jumping)
            {
                velocity = -8;   // impuls skoka
                jumping = false; 
            }

            velocity += gravity;  // gravitacija stalno povlači dole
            ptica.Top += velocity;

            if (ptica.Top < 0)
                ptica.Top = 0;


            preprekaDonji.Left -= obstacleSpeed;
            preprekaGornji.Left -= obstacleSpeed;

            if (preprekaDonji.Left < -150)
            {
                int novaPozicija = this.Width + 50;

                preprekaDonji.Left = novaPozicija;
                preprekaGornji.Left = novaPozicija;

                gap = 130;
                y = r.Next(50, 200);   // povećala sam opseg

                preprekaDonji.Top = y + gap;
                preprekaGornji.Top = y - preprekaGornji.Height;

                score++;
            }

            if (ptica.Bounds.IntersectsWith(preprekaDonji.Bounds) || ptica.Bounds.IntersectsWith(preprekaGornji.Bounds) || ptica.Bounds.IntersectsWith(Zemlja.Bounds))
            {
                gameOver();
            }


            scoreTex.Text = Convert.ToString(score);

           /* if (g > 0)
                ptica.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            else
                ptica.Image.RotateFlip(RotateFlipType.Rotate270FlipNone); */


        }

        bool jumping = false;

        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                jumping = true;
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                jumping = false;
        }


        private void reset()
        {
            velocity = 0;


            gameTimer.Stop();
            isGameOver = false;
            jumping = false;
            //g = 0;

            ptica.Top = ClientRectangle.Height/2;
            preprekaDonji.Left = this.Width/2 + 200;
            preprekaGornji.Left = this.Width / 2 + 200;

            gameoverLabel.Visible = false;
            resetButton.Visible = false;

            gap = 130; // otvor između cevi
            y = r.Next(50, 200);

            preprekaDonji.Top = y + gap; 
            preprekaGornji.Top = y - preprekaGornji.Height;

            score = 0;
            scoreTex.Text = Convert.ToString(score);
            obstacleSpeed = 5;
            g = 5;


            highscore = Properties.Settings.Default.Highscore;
            highScoree.Text = highscore.ToString();

            gameTimer.Start();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
