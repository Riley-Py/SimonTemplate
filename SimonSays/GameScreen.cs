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
                   
                    greenButton.BackColor = Color.White;
                    this.Refresh();
                    Thread.Sleep(900);
                    greenButton.BackColor = Color.ForestGreen;
                        
                }
                else if (Form1.pattern[i] == 1) //Yellow button is 1
                {
                    yellowButton.BackColor = Color.White;
                    this.Refresh();
                    Thread.Sleep(900);
                    yellowButton.BackColor = Color.Goldenrod;
                }
                else if (Form1.pattern[i] == 2) //Red button is 2
                {
                    redButton.BackColor = Color.White;
                    this.Refresh();
                    Thread.Sleep(900);
                    redButton.BackColor = Color.DarkRed;
                }
                else if (Form1.pattern[i] == 3) //Blue button is 3
                {
                    blueButton.BackColor = Color.White;
                    this.Refresh();
                    Thread.Sleep(900);
                    blueButton.BackColor = Color.DarkBlue;
                }
            }

            guess = 0;
            
        }

        //TODO: create one of these event methods for each button
        private void greenButton_Click(object sender, EventArgs e)
        {
            SoundPlayer("green");

            if (Form1.pattern[guess] == 0)
            {
                greenButton.BackColor = Color.White;
                
                

            }
            //TODO: is the value in the pattern list at index [guess] equal to a green?
            // change button color
            // play sound
            // refresh
            // pause
            // set button colour back to original
            // add one to the guess variable

            //TODO:check to see if we are at the end of the pattern, (guess is the same as pattern list count).
            // call ComputerTurn() method
            // else call GameOver method
        }

        public void GameOver()
        {
            //TODO: Play a game over sound

            //TODO: close this screen and open the GameOverScreen

        }
        public void SoundPlayer(String sound)
        {
            

        }
    }
}
