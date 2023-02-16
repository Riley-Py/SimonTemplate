using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SimonSays
{
    public partial class MenuScreen : UserControl
    {


        public static System.Windows.Media.MediaPlayer backMedia = new System.Windows.Media.MediaPlayer();
        public MenuScreen()
        {
            InitializeComponent();
            backMedia.Open(new Uri(Application.StartupPath + "/Resources/menu.mp3"));
            backMedia.MediaEnded += new EventHandler(backMedia_MediaEnded);

        }
        
        private void newButton_Click(object sender, EventArgs e)
        {
            backMedia.Stop();         
            Form1.ChangeScreen(this, new GameScreen()); //Changes the screen to the game screen
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exits application
        }
     
        private void MenuScreen_Load_1(object sender, EventArgs e)
        {
            
            backMedia.Play();
        }
        private void backMedia_MediaEnded(object sender, EventArgs e)
        {
            backMedia.Stop();
            backMedia.Play();
        }
    }
}
