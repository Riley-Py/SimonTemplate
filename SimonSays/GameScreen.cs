using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {


        int guess = 0; //Get guesses

        SoundPlayer greenSound = new SoundPlayer(Properties.Resources.green);
        SoundPlayer blueSound = new SoundPlayer(Properties.Resources.blue);
        SoundPlayer redSound = new SoundPlayer(Properties.Resources.red);
        SoundPlayer yellowSound = new SoundPlayer(Properties.Resources.yellow);
        SoundPlayer gameOverSound = new SoundPlayer(Properties.Resources.mistake);
        
       


        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

            Form1.pattern.Clear();
            this.Refresh();
            Thread.Sleep(1000);
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            //Gets a random integer between 0 and 3
            Random random = new Random();
            Form1.pattern.Add(random.Next(0, 4));


           
            for (int i = 0; i < Form1.pattern.Count; i++)
            {
                if (Form1.pattern[i] == 0) //Green button is 0
                {
                   
                    greenButton.BackColor = Color.LimeGreen;
                    Refresh();
                    Thread.Sleep(1250);
                    greenButton.BackColor = Color.ForestGreen;
                        
                }
                else if (Form1.pattern[i] == 1) //Yellow button is 1
                {
                    yellowButton.BackColor = Color.Yellow;
                    Refresh();
                    Thread.Sleep(1250);
                    yellowButton.BackColor = Color.Goldenrod;
                }
                else if (Form1.pattern[i] == 2) //Red button is 2
                {
                    redButton.BackColor = Color.Red;
                    Refresh();
                    Thread.Sleep(1250);
                    redButton.BackColor = Color.DarkRed;
                }
                else if (Form1.pattern[i] == 3) //Blue button is 3
                {
                    blueButton.BackColor = Color.Blue;
                    Refresh();
                    Thread.Sleep(1250);
                    blueButton.BackColor = Color.DarkBlue;
                }
            }

            Refresh();
            greenButton.BackColor = Color.ForestGreen;
            blueButton.BackColor = Color.DarkBlue;
            yellowButton.BackColor = Color.Goldenrod;
            redButton.BackColor = Color.DarkRed;
            Thread.Sleep(1000);

            guess = 0;
            
        }

        //TODO: create one of these event methods for each button
        private void greenButton_Click(object sender, EventArgs e)
        {
            

            if (Form1.pattern[guess] == 0)
            {
                greenButton.BackColor = Color.LimeGreen;
                greenSound.Play();
                Refresh();
                Thread.Sleep(800);
                greenButton.BackColor = Color.ForestGreen;
                Refresh();
                guess++;

                if (Form1.pattern.Count == guess)
                {

                    Refresh();
                    Thread.Sleep(500);
                    ComputerTurn();
                }


            }
          
            else
            {
                GameOver();
            }
           

           
        }

        public void GameOver()
        {
            //TODO: Play a game over sound

            gameOverSound.Play();
            Form1.ChangeScreen(this, new GameOverScreen());

            //TODO: close this screen and open the GameOverScreen

        }

        private void redButton_Click(object sender, EventArgs e)
        {

            if (Form1.pattern[guess] == 2)
            {
                redButton.BackColor = Color.Red;
                redSound.Play();
                Refresh();
                Thread.Sleep(800);
                redButton.BackColor = Color.DarkRed;
                guess++;

                if (Form1.pattern.Count == guess)
                {
                    Refresh();
                    Thread.Sleep(500);
                    ComputerTurn();
                }
            }
            
            else
            {
                Refresh();
                GameOver();
            }

        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 1)
            {
                yellowButton.BackColor = Color.Yellow;
                yellowSound.Play();
                Refresh();
                Thread.Sleep(800);
                yellowButton.BackColor = Color.Goldenrod;
                guess++;

                if (Form1.pattern.Count == guess)
                {
                    Refresh();
                    Thread.Sleep(500);
                    ComputerTurn();
                }
            }
           
            else
            {
                GameOver();
            }

        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guess] == 3)
            {
                blueButton.BackColor = Color.Blue;
                blueSound.Play();
                Refresh();
                Thread.Sleep(800);
                blueButton.BackColor = Color.DarkBlue;
                guess++;

                if (Form1.pattern.Count == guess)
                {
                    Refresh();
                    Thread.Sleep(500);
                    ComputerTurn();
                }
            }
           
            else
            {
                GameOver();
            }
        }
    }
}
