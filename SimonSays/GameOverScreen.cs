using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
            MenuScreen.backMedia.Open(new Uri(Application.StartupPath + "/Resources/ending.mp3"));
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            
            lengthLabel.Text = $"{Form1.pattern.Count}";
            MenuScreen.backMedia.Play();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            
            MenuScreen.backMedia.Stop();
            Form1.ChangeScreen(this, new MenuScreen());
           
        }
    }
}
