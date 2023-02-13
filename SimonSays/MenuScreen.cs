﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new GameScreen()); //Changes the screen to the game screen
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exits application
        }
    }
}
