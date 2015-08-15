using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool gameStarted = false;

        //ball starting position
        int ballX = 0;
        int ballY = 0;

        int bottomLimit = 0;
        int rightLimit = 0;
        int centerX = 0;

        //Various Paddle related variables
        
        //the starting Y value of the paddle
        int paddlePosition = 0;
        //the paddle's starting x pos
        int paddleX = 50;

        int AIPaddleX = 0;
        int AIPaddlePosition = 0;

        const int PADDLE_LENGTH = 60;

        public Form1()
        {
            InitializeComponent();

            //get the center of the game Board
            ballX = pictureBoxDisplay.Width / 2;
            ballY = pictureBoxDisplay.Height / 2;

            bottomLimit = pictureBoxDisplay.Height;
            rightLimit = pictureBoxDisplay.Width;
            centerX = pictureBoxDisplay.Width / 2;

            //get the starting X position of the AI paddle
            AIPaddleX = pictureBoxDisplay.Width - 50;

            //set the starting point for the player's paddle
            paddlePosition = centerX - (PADDLE_LENGTH /2);

        }

        /// <summary>
        /// Draw up some shizzle to make it look pretty at the start or something
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        /// <summary>
        /// set the board back to the original state
        /// </summary>
        private void NewGame()
        {
            gameStarted = false;

            ballX = pictureBoxDisplay.Width / 2;
            ballY = pictureBoxDisplay.Height / 2;

            xV = -10;
            yV = 0;

            pictureBoxDisplay.Refresh();
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.White, 10);
            Pen dashPen = new Pen(Color.White, 3);
            dashPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            DrawBoard(paper, dashPen, pen1);
            DrawABall(ballX, ballY);
            DrawPaddle(paper, pen1);

            //delete the no longer used graphics objects
            pen1.Dispose();
            dashPen.Dispose();
            paper.Dispose();
        }

        /// <summary>
        /// Close the Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        #region Paddle Control

        /// <summary>
        /// If an arrow key is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            gameStarted = true;  
            
            if (e.KeyCode == Keys.Up && paddlePosition > 0)
            {
                paddlePosition -= 12;
            }
            else if (e.KeyCode == Keys.Down && paddlePosition < (pictureBoxDisplay.Height - PADDLE_LENGTH))
            {
                paddlePosition += 12;
            }
            label1.Text = "Paddle Y = " + paddlePosition.ToString();
        }

        private void DrawPaddle(Graphics paper, Pen pen1)
        {
            //draw the paddle
            paper.DrawLine(pen1, paddleX, paddlePosition, paddleX, (paddlePosition + PADDLE_LENGTH));
        }

        #endregion

        /// <summary>
        /// On each tick of the clock, update the screen location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clockCycle_Tick(object sender, EventArgs e)
        {
            if (gameStarted)
            {
                pictureBoxDisplay.Refresh();
                Graphics paper = pictureBoxDisplay.CreateGraphics();
                Pen pen1 = new Pen(Color.White, 10);
                Pen dashPen = new Pen(Color.White, 3);
                dashPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                //draw the board
                DrawBoard(paper, dashPen, pen1);

                //draw the player paddle
                DrawPaddle(paper, pen1);

                //move the ball
                MoveBall();

                //move the AI Paddle
                MoveAIPaddle();

                //draw the AI Paddle
                DrawAIPaddle(paper, pen1);

                //draw the ball
                DrawABall(ballX, ballY);

                paper.Dispose();
                pen1.Dispose();
                dashPen.Dispose();
            }
        }

        private void DrawBoard(Graphics paper, Pen dashPen, Pen pen1)
        {
            paper.DrawLine(dashPen, centerX, 0, centerX, bottomLimit);
        }

        #region Ball Control

        Random rand = new Random();

        //the ball's speed in each direction (pixels per "clock cycle"
        int xV = -10;
        int yV = 0;

        /// <summary>
        /// Draw the Ball
        /// </summary>
        /// <param name="ballX">the ball X position</param>
        /// <param name="ballY">the ball Y position</param>
        private void DrawABall(int ballX, int ballY)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.White, 5);
            Rectangle ball = new Rectangle(ballX, ballY, 5, 5);

            //draw the ball
            paper.DrawRectangle(pen1, ball);
            
            //delete the drawing objects
            paper.Dispose();
            pen1.Dispose();
        }

        /// <summary>
        /// Moves the ball around the screen and bounces it off walls
        /// </summary>
        private void MoveBall()
        {
            if (ColisionDetection())
            {
                Boop();

                //come up with a random bounce direction

                //if the ball is coming UP
                if (yV <= 0)
                {
                    yV = rand.Next(-15, -5);
                }

                //if ball is going DOWN
                if (yV > 0)
                {                    
                    yV = rand.Next(5, 15);
                }
                xV = rand.Next(15, 20);
            }

            //if the ball has hit the bottom limit
            if (ballY > bottomLimit)
            {
                //bounce the ball
                yV = ToOppositeSign(yV);
            }

            //if the ball has hit the right limit
                //ie, it hits the computer paddle
            else if (ballX > rightLimit - 50)
            {
                Boop();
                //bounce the ball

                //if the ball is coming up
                //if the ball is coming UP
                if (yV <= 0)
                {
                    yV = rand.Next(-15, -5);
                }

                //if ball is going DOWN
                if (yV > 0)
                {
                    yV = rand.Next(5, 15);
                }
                xV = rand.Next(-20, -15);
            }

            //if the ball has hit the top of the board
            else if (ballY < 0)
            {
                
                //bounce the ball
                yV = ToOppositeSign(yV);

            }

            //if the ball has hit the left of the board
            else if (ballX < 0)
            {
                //bounce the ball
                //xV = ToOppositeSign(xV);
                NewGame();
            }

            //keep moving the ball as it is
            ballY += yV;
            ballX += xV;

            //update the labels and stuff
            labelBallX.Text = ballX.ToString();
            labelBallY.Text = ballY.ToString();
            labelYV.Text = yV.ToString();
            labelXV.Text = xV.ToString();
            labelPaddleY.Text = paddlePosition.ToString();
        }

        /// <summary>
        /// Checks if the ball is in colision with the paddle
        /// </summary>
        /// <returns></returns>
        private bool ColisionDetection()
        {
            if (ballX <= paddleX && ballY >= paddlePosition && ballY <= paddlePosition + PADDLE_LENGTH)
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Change an int to it's opposite - or + value
        /// this method is used to bounce the ball
        /// </summary>
        /// <param name="number">an int</param>
        /// <returns>number's opposite - or + value</returns>
        private int ToOppositeSign(int number)
        {
            //The ball has hit something, play a boop
            Boop();

            if (number > 0)
            {
                number = -number;
                return number;
            }
            else if (number < 0)
            {
                number = number + (number * -2);
                return number;
            }
            else return number;
        }

        /// <summary>
        /// Play a boop
        /// </summary>
        private void Boop()
        {          
            {
                //SoundPlayer simpleSound = new SoundPlayer(@"X:\C# Projects\Week 9\Pong\WindowsFormsApplication1\Resources\boop.wav");
                //simpleSound.Play();
            }
        }

        #endregion

        #region AI

        private void MoveAIPaddle()
        {
            //move the ai paddle
            AIPaddlePosition = ballY - PADDLE_LENGTH / 2;
        }

        private void DrawAIPaddle(Graphics paper, Pen pen1)
        {
            //draw the paddle
            paper.DrawLine(pen1, AIPaddleX, AIPaddlePosition, AIPaddleX, (AIPaddlePosition + PADDLE_LENGTH));

            //delete the drawing objects
            paper.Dispose();
            pen1.Dispose();
        }
                
        #endregion
        }
}

