namespace FlappyBird
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreTex = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Zemlja = new System.Windows.Forms.PictureBox();
            this.preprekaDonji = new System.Windows.Forms.PictureBox();
            this.ptica = new System.Windows.Forms.PictureBox();
            this.preprekaGornji = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.highScore = new System.Windows.Forms.Label();
            this.gameoverLabel = new System.Windows.Forms.Label();
            this.highScoree = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Zemlja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preprekaDonji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preprekaGornji)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.LightSalmon;
            this.scoreLabel.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scoreLabel.Location = new System.Drawing.Point(31, 40);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(146, 46);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "SCORE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 44);
            this.label2.TabIndex = 1;
            // 
            // scoreTex
            // 
            this.scoreTex.AutoSize = true;
            this.scoreTex.BackColor = System.Drawing.Color.LightSalmon;
            this.scoreTex.Font = new System.Drawing.Font("Showcard Gothic", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTex.Location = new System.Drawing.Point(180, 40);
            this.scoreTex.Name = "scoreTex";
            this.scoreTex.Size = new System.Drawing.Size(138, 44);
            this.scoreTex.TabIndex = 6;
            this.scoreTex.Text = "label1";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameStart);
            // 
            // Zemlja
            // 
            this.Zemlja.Image = global::FlappyBird.Properties.Resources.groundd;
            this.Zemlja.Location = new System.Drawing.Point(-6, 366);
            this.Zemlja.Name = "Zemlja";
            this.Zemlja.Size = new System.Drawing.Size(816, 115);
            this.Zemlja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zemlja.TabIndex = 5;
            this.Zemlja.TabStop = false;
            // 
            // preprekaDonji
            // 
            this.preprekaDonji.Image = global::FlappyBird.Properties.Resources.donjiii_removebg_preview;
            this.preprekaDonji.Location = new System.Drawing.Point(362, 248);
            this.preprekaDonji.Name = "preprekaDonji";
            this.preprekaDonji.Size = new System.Drawing.Size(118, 337);
            this.preprekaDonji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.preprekaDonji.TabIndex = 4;
            this.preprekaDonji.TabStop = false;
            // 
            // ptica
            // 
            this.ptica.Image = global::FlappyBird.Properties.Resources.pticurina_removebg_preview;
            this.ptica.Location = new System.Drawing.Point(12, 175);
            this.ptica.Name = "ptica";
            this.ptica.Size = new System.Drawing.Size(54, 34);
            this.ptica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptica.TabIndex = 3;
            this.ptica.TabStop = false;
            // 
            // preprekaGornji
            // 
            this.preprekaGornji.Image = global::FlappyBird.Properties.Resources.gornji_removebg_preview;
            this.preprekaGornji.Location = new System.Drawing.Point(362, -210);
            this.preprekaGornji.Name = "preprekaGornji";
            this.preprekaGornji.Size = new System.Drawing.Size(118, 330);
            this.preprekaGornji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.preprekaGornji.TabIndex = 2;
            this.preprekaGornji.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "highest score:";
            // 
            // highScore
            // 
            this.highScore.AutoSize = true;
            this.highScore.BackColor = System.Drawing.Color.Transparent;
            this.highScore.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScore.Location = new System.Drawing.Point(204, 21);
            this.highScore.Name = "highScore";
            this.highScore.Size = new System.Drawing.Size(0, 23);
            this.highScore.TabIndex = 8;
            // 
            // gameoverLabel
            // 
            this.gameoverLabel.AutoSize = true;
            this.gameoverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameoverLabel.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameoverLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gameoverLabel.Location = new System.Drawing.Point(66, 151);
            this.gameoverLabel.Name = "gameoverLabel";
            this.gameoverLabel.Size = new System.Drawing.Size(414, 79);
            this.gameoverLabel.TabIndex = 9;
            this.gameoverLabel.Text = "GAME OVER!";
            this.gameoverLabel.Visible = false;
            // 
            // highScoree
            // 
            this.highScoree.AutoSize = true;
            this.highScoree.BackColor = System.Drawing.Color.PeachPuff;
            this.highScoree.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoree.Location = new System.Drawing.Point(178, 17);
            this.highScoree.Name = "highScoree";
            this.highScoree.Size = new System.Drawing.Size(0, 20);
            this.highScoree.TabIndex = 10;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.resetButton.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.Firebrick;
            this.resetButton.Location = new System.Drawing.Point(207, 233);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(104, 37);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Try again";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.gameoverLabel);
            this.Controls.Add(this.scoreTex);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.highScoree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.highScore);
            this.Controls.Add(this.Zemlja);
            this.Controls.Add(this.preprekaDonji);
            this.Controls.Add(this.ptica);
            this.Controls.Add(this.preprekaGornji);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.onKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Zemlja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preprekaDonji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preprekaGornji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox preprekaGornji;
        private System.Windows.Forms.PictureBox ptica;
        private System.Windows.Forms.PictureBox preprekaDonji;
        private System.Windows.Forms.PictureBox Zemlja;
        private System.Windows.Forms.Label scoreTex;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label highScore;
        private System.Windows.Forms.Label gameoverLabel;
        private System.Windows.Forms.Label highScoree;
        private System.Windows.Forms.Button resetButton;
    }
}

