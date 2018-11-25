using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenis_Game
{
    public partial class Form1 : Form
    {
        public int speed_left = 4;      //speed of the ball
        public int speed_top = 4;
        public int points = 0;           //total score

        public Form1()
        {

            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;    // remove border form
            this.TopMost = true;                            //bring form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;      //fullscreen mode

            rocket.Top = playground.Bottom - (playground.Bottom / 10);     // set the position of rocket

            gameOver_label.Left = (playground.Width / 2) - (gameOver_label.Width / 2);
            gameOver_label.Top = (playground.Height / 2) - (gameOver_label.Height / 2);
            gameOver_label.Visible = false;

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            if(e.KeyCode == Keys.F1)
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                points = 0;
                point_label.Text = "0";
                timer1.Enabled = true;
                gameOver_label.Visible = false;
                playground.BackColor = Color.White;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rocket.Left = Cursor.Position.X - (rocket.Width / 2);    // set center of the rocket to the position of the cursor

            ball.Left += speed_left;   // move ball
            ball.Top += speed_top;


            if (ball.Bottom >= rocket.Top && ball.Bottom <= rocket.Bottom && ball.Left >= rocket.Left && ball.Right <= rocket.Right)
            {
                speed_top += 1;
                speed_left += 1;
                speed_top = -speed_top; // change direction
                points += 1;

                point_label.Text = points.ToString();

                Random r = new Random();
                playground.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
            }

            if (ball.Left <= playground.Left)
                speed_left = -speed_left;
            if (ball.Right >= playground.Right)
                speed_left = -speed_left;
            if (ball.Top <= playground.Top)
                speed_top = -speed_top;
            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;                     // ball is out - stop the game 
                gameOver_label.Visible = true;
            }
        }

    }
}
