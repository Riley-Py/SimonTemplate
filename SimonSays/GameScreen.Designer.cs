namespace SimonSays
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.yellowButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Goldenrod;
            this.yellowButton.Location = new System.Drawing.Point(24, 160);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(110, 110);
            this.yellowButton.TabIndex = 3;
            this.yellowButton.Tag = "buttonY";
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.AllButtons);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.DarkBlue;
            this.blueButton.Location = new System.Drawing.Point(173, 160);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(110, 110);
            this.blueButton.TabIndex = 2;
            this.blueButton.Tag = "buttonB";
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.AllButtons);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.DarkRed;
            this.redButton.Location = new System.Drawing.Point(173, 17);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(110, 110);
            this.redButton.TabIndex = 1;
            this.redButton.Tag = "buttonR";
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.AllButtons);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.ForestGreen;
            this.greenButton.Location = new System.Drawing.Point(24, 17);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(110, 110);
            this.greenButton.TabIndex = 0;
            this.greenButton.Tag = "buttonG";
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.AllButtons);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoEllipsis = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.scoreLabel.Location = new System.Drawing.Point(99, 93);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.scoreLabel.Size = new System.Drawing.Size(121, 113);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scoreLabel.UseMnemonic = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.greenButton);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(301, 300);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Label scoreLabel;
    }
}
