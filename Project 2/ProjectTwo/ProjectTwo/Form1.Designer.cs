namespace ProjectTwo
{
    partial class rpsGame
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpsGame));
            this.playButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subTitleLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.rockRadioButton = new System.Windows.Forms.RadioButton();
            this.paperRadioButton = new System.Windows.Forms.RadioButton();
            this.scissorsRadioButton = new System.Windows.Forms.RadioButton();
            this.rockLabel = new System.Windows.Forms.Label();
            this.paperLabel = new System.Windows.Forms.Label();
            this.scissorsLabel = new System.Windows.Forms.Label();
            this.rockPicture = new System.Windows.Forms.PictureBox();
            this.paperPicture = new System.Windows.Forms.PictureBox();
            this.scissorsPicture = new System.Windows.Forms.PictureBox();
            this.selectionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rockPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(12, 115);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play!";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(175, 13);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Welcome to Rock, Paper, Scissors!";
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.AutoSize = true;
            this.subTitleLabel.Location = new System.Drawing.Point(13, 30);
            this.subTitleLabel.Name = "subTitleLabel";
            this.subTitleLabel.Size = new System.Drawing.Size(160, 13);
            this.subTitleLabel.TabIndex = 3;
            this.subTitleLabel.Text = "Select Rock, Paper, or Scissors:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(93, 120);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(10, 13);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = " ";
            // 
            // rockRadioButton
            // 
            this.rockRadioButton.AutoSize = true;
            this.rockRadioButton.Location = new System.Drawing.Point(12, 46);
            this.rockRadioButton.Name = "rockRadioButton";
            this.rockRadioButton.Size = new System.Drawing.Size(51, 17);
            this.rockRadioButton.TabIndex = 5;
            this.rockRadioButton.TabStop = true;
            this.rockRadioButton.Text = "Rock";
            this.rockRadioButton.UseVisualStyleBackColor = true;
            // 
            // paperRadioButton
            // 
            this.paperRadioButton.AutoSize = true;
            this.paperRadioButton.Location = new System.Drawing.Point(12, 69);
            this.paperRadioButton.Name = "paperRadioButton";
            this.paperRadioButton.Size = new System.Drawing.Size(53, 17);
            this.paperRadioButton.TabIndex = 6;
            this.paperRadioButton.TabStop = true;
            this.paperRadioButton.Text = "Paper";
            this.paperRadioButton.UseVisualStyleBackColor = true;
            // 
            // scissorsRadioButton
            // 
            this.scissorsRadioButton.AutoSize = true;
            this.scissorsRadioButton.Location = new System.Drawing.Point(12, 92);
            this.scissorsRadioButton.Name = "scissorsRadioButton";
            this.scissorsRadioButton.Size = new System.Drawing.Size(64, 17);
            this.scissorsRadioButton.TabIndex = 7;
            this.scissorsRadioButton.TabStop = true;
            this.scissorsRadioButton.Text = "Scissors";
            this.scissorsRadioButton.UseVisualStyleBackColor = true;
            // 
            // rockLabel
            // 
            this.rockLabel.AutoSize = true;
            this.rockLabel.Location = new System.Drawing.Point(93, 48);
            this.rockLabel.Name = "rockLabel";
            this.rockLabel.Size = new System.Drawing.Size(113, 13);
            this.rockLabel.TabIndex = 8;
            this.rockLabel.Text = "Rock breaks Scissors.";
            // 
            // paperLabel
            // 
            this.paperLabel.AutoSize = true;
            this.paperLabel.Location = new System.Drawing.Point(93, 71);
            this.paperLabel.Name = "paperLabel";
            this.paperLabel.Size = new System.Drawing.Size(102, 13);
            this.paperLabel.TabIndex = 9;
            this.paperLabel.Text = "Paper covers Rock.";
            // 
            // scissorsLabel
            // 
            this.scissorsLabel.AutoSize = true;
            this.scissorsLabel.Location = new System.Drawing.Point(91, 94);
            this.scissorsLabel.Name = "scissorsLabel";
            this.scissorsLabel.Size = new System.Drawing.Size(98, 13);
            this.scissorsLabel.TabIndex = 10;
            this.scissorsLabel.Text = "Scissors cut Paper.";
            // 
            // rockPicture
            // 
            this.rockPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rockPicture.BackgroundImage")));
            this.rockPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rockPicture.Location = new System.Drawing.Point(12, 157);
            this.rockPicture.Name = "rockPicture";
            this.rockPicture.Size = new System.Drawing.Size(215, 136);
            this.rockPicture.TabIndex = 11;
            this.rockPicture.TabStop = false;
            this.rockPicture.Visible = false;
            // 
            // paperPicture
            // 
            this.paperPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paperPicture.BackgroundImage")));
            this.paperPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paperPicture.Location = new System.Drawing.Point(12, 157);
            this.paperPicture.Name = "paperPicture";
            this.paperPicture.Size = new System.Drawing.Size(215, 136);
            this.paperPicture.TabIndex = 12;
            this.paperPicture.TabStop = false;
            this.paperPicture.Visible = false;
            // 
            // scissorsPicture
            // 
            this.scissorsPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scissorsPicture.BackgroundImage")));
            this.scissorsPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scissorsPicture.Location = new System.Drawing.Point(12, 157);
            this.scissorsPicture.Name = "scissorsPicture";
            this.scissorsPicture.Size = new System.Drawing.Size(215, 136);
            this.scissorsPicture.TabIndex = 13;
            this.scissorsPicture.TabStop = false;
            this.scissorsPicture.Visible = false;
            // 
            // selectionLabel
            // 
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.Location = new System.Drawing.Point(12, 141);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(72, 13);
            this.selectionLabel.TabIndex = 14;
            this.selectionLabel.Text = "You selected:";
            // 
            // rpsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 306);
            this.Controls.Add(this.selectionLabel);
            this.Controls.Add(this.scissorsPicture);
            this.Controls.Add(this.paperPicture);
            this.Controls.Add(this.rockPicture);
            this.Controls.Add(this.scissorsLabel);
            this.Controls.Add(this.paperLabel);
            this.Controls.Add(this.rockLabel);
            this.Controls.Add(this.scissorsRadioButton);
            this.Controls.Add(this.paperRadioButton);
            this.Controls.Add(this.rockRadioButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.subTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.playButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "rpsGame";
            this.Text = "Rock, Paper, Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.rockPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paperPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorsPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subTitleLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RadioButton rockRadioButton;
        private System.Windows.Forms.RadioButton paperRadioButton;
        private System.Windows.Forms.RadioButton scissorsRadioButton;
        private System.Windows.Forms.Label rockLabel;
        private System.Windows.Forms.Label paperLabel;
        private System.Windows.Forms.Label scissorsLabel;
        private System.Windows.Forms.PictureBox rockPicture;
        private System.Windows.Forms.PictureBox paperPicture;
        private System.Windows.Forms.PictureBox scissorsPicture;
        private System.Windows.Forms.Label selectionLabel;
    }
}

