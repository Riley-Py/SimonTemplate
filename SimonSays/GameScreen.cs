using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {


        int guess = 0; //Get guesses

        //All the sounds required
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
            Refreshing(1000);
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
                    Refreshing(600);
                    greenButton.BackColor = Color.ForestGreen;
                    Refreshing(600);
                        
                }
                else if (Form1.pattern[i] == 1) //Yellow button is 1
                {
                    yellowButton.BackColor = Color.Yellow;
                    Refreshing(600);
                    yellowButton.BackColor = Color.Goldenrod;
                    Refreshing(600);
                }
                else if (Form1.pattern[i] == 2) //Red button is 2
                {
                    redButton.BackColor = Color.Red;
                    Refreshing(600);
                    redButton.BackColor = Color.DarkRed;
                    Refreshing(600);
                }
                else if (Form1.pattern[i] == 3) //Blue button is 3
                {
                    blueButton.BackColor = Color.Blue;
                    Refreshing(600);
                    blueButton.BackColor = Color.DarkBlue;
                    Refreshing(600);
                }
            }

            
            guess = 0;          
        }

        public void GameOver()
        {
            gameOverSound.Play();
            Form1.ChangeScreen(this, new GameOverScreen());        
        }

        /// <summary>
        /// Refreshes the screen and takes a time to sleep
        /// </summary>
        /// <param name="time"></param>
        private void Refreshing(int time)
        {
            Refresh();
            Thread.Sleep(time);
        }

        /// <summary>
        /// Puts buttons in method and calls on their tag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllButtons(object sender, EventArgs e)
        {
            switch(((Button)sender).Tag) {
                case "buttonG":
                    if (Form1.pattern[guess] == 0)
                    {
                        greenButton.BackColor = Color.LimeGreen;
                        greenSound.Play();
                        Refreshing(800);
                        greenButton.BackColor = Color.ForestGreen;
                        guess++;
                        if (Form1.pattern.Count == guess)
                        {
                            Refreshing(800);
                            ComputerTurn();
                        }
                    }
                    else
                    {
                        GameOver();
                    }
                    break;
                case "buttonB":
                    if (Form1.pattern[guess] == 3)
                    {
                        blueButton.BackColor = Color.Blue;
                        blueSound.Play();
                        Refreshing(800);
                        blueButton.BackColor = Color.DarkBlue;
                        guess++;

                        if (Form1.pattern.Count == guess)
                        {
                            Refreshing(800);
                            ComputerTurn();
                        }
                    }

                    else
                    {
                        GameOver();
                    }
                    break;
                case "buttonR":
                    if (Form1.pattern[guess] == 2)
                    {
                        redButton.BackColor = Color.Red;
                        redSound.Play();
                        Refreshing(800);
                        redButton.BackColor = Color.DarkRed;
                        guess++;

                        if (Form1.pattern.Count == guess)
                        {
                            Refreshing(800);
                            ComputerTurn();
                        }
                    }

                    else
                    {

                        GameOver();
                    }

                    break;
                case "buttonY":
                    if (Form1.pattern[guess] == 1)
                    {
                        yellowButton.BackColor = Color.Yellow;
                        yellowSound.Play();
                        Refreshing(800);
                        yellowButton.BackColor = Color.Goldenrod;
                        guess++;

                        if (Form1.pattern.Count == guess)
                        {
                            Refreshing(800);
                            ComputerTurn();
                        }
                    }

                    else
                    {
                        GameOver();
                    }
                    break;
            }
        }
    }
}
