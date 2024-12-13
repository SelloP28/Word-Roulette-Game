namespace u13238940_INF154PROJECT
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
            this.gbxPlay = new System.Windows.Forms.GroupBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTheme = new System.Windows.Forms.Label();
            this.btnplayGame = new System.Windows.Forms.Button();
            this.gbxplayGame = new System.Windows.Forms.GroupBox();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.txtguessLetter3 = new System.Windows.Forms.TextBox();
            this.txtguessLetter2 = new System.Windows.Forms.TextBox();
            this.txtguessLetter1 = new System.Windows.Forms.TextBox();
            this.lblmissingLetter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxSettings = new System.Windows.Forms.GroupBox();
            this.btnhow_to_Play = new System.Windows.Forms.Button();
            this.btnchangeBackground = new System.Windows.Forms.Button();
            this.gbxDifficulty = new System.Windows.Forms.GroupBox();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.gbxScore = new System.Windows.Forms.GroupBox();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxDetails = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbchangeBackground = new System.Windows.Forms.ComboBox();
            this.gbxchangeBackground = new System.Windows.Forms.GroupBox();
            this.tmrcountDown = new System.Windows.Forms.Timer(this.components);
            this.gbxPlay.SuspendLayout();
            this.gbxplayGame.SuspendLayout();
            this.gbxSettings.SuspendLayout();
            this.gbxDifficulty.SuspendLayout();
            this.gbxScore.SuspendLayout();
            this.gbxDetails.SuspendLayout();
            this.gbxchangeBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPlay
            // 
            this.gbxPlay.Controls.Add(this.lblTimer);
            this.gbxPlay.Controls.Add(this.lblMessage);
            this.gbxPlay.Controls.Add(this.lblTime);
            this.gbxPlay.Controls.Add(this.lblTheme);
            this.gbxPlay.Controls.Add(this.btnplayGame);
            this.gbxPlay.Controls.Add(this.gbxplayGame);
            this.gbxPlay.Controls.Add(this.gbxSettings);
            this.gbxPlay.Controls.Add(this.gbxDifficulty);
            this.gbxPlay.Controls.Add(this.gbxScore);
            this.gbxPlay.Location = new System.Drawing.Point(136, 12);
            this.gbxPlay.Name = "gbxPlay";
            this.gbxPlay.Size = new System.Drawing.Size(656, 395);
            this.gbxPlay.TabIndex = 0;
            this.gbxPlay.TabStop = false;
            this.gbxPlay.Visible = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI Historic", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(546, 246);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(49, 59);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "0";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(287, 367);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(16, 13);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "...";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Miriam Libre", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTime.Location = new System.Drawing.Point(524, 230);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(85, 16);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Seconds left:";
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(255, 102);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(16, 13);
            this.lblTheme.TabIndex = 6;
            this.lblTheme.Text = "...";
            // 
            // btnplayGame
            // 
            this.btnplayGame.Location = new System.Drawing.Point(269, 131);
            this.btnplayGame.Name = "btnplayGame";
            this.btnplayGame.Size = new System.Drawing.Size(92, 23);
            this.btnplayGame.TabIndex = 5;
            this.btnplayGame.Text = "PLAY GAME!";
            this.btnplayGame.UseVisualStyleBackColor = true;
            this.btnplayGame.Click += new System.EventHandler(this.btnplayGame_Click);
            // 
            // gbxplayGame
            // 
            this.gbxplayGame.Controls.Add(this.btnHint);
            this.gbxplayGame.Controls.Add(this.btnGuess);
            this.gbxplayGame.Controls.Add(this.txtguessLetter3);
            this.gbxplayGame.Controls.Add(this.txtguessLetter2);
            this.gbxplayGame.Controls.Add(this.txtguessLetter1);
            this.gbxplayGame.Controls.Add(this.lblmissingLetter);
            this.gbxplayGame.Controls.Add(this.label3);
            this.gbxplayGame.Location = new System.Drawing.Point(131, 171);
            this.gbxplayGame.Name = "gbxplayGame";
            this.gbxplayGame.Size = new System.Drawing.Size(326, 185);
            this.gbxplayGame.TabIndex = 4;
            this.gbxplayGame.TabStop = false;
            this.gbxplayGame.Text = "PLAY GAME";
            this.gbxplayGame.Visible = false;
            // 
            // btnHint
            // 
            this.btnHint.Location = new System.Drawing.Point(265, 146);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(55, 23);
            this.btnHint.TabIndex = 5;
            this.btnHint.Text = "Hint?";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Visible = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(127, 146);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 5;
            this.btnGuess.Text = "GUESS!";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // txtguessLetter3
            // 
            this.txtguessLetter3.Location = new System.Drawing.Point(225, 100);
            this.txtguessLetter3.Name = "txtguessLetter3";
            this.txtguessLetter3.Size = new System.Drawing.Size(25, 20);
            this.txtguessLetter3.TabIndex = 4;
            // 
            // txtguessLetter2
            // 
            this.txtguessLetter2.Location = new System.Drawing.Point(153, 100);
            this.txtguessLetter2.Name = "txtguessLetter2";
            this.txtguessLetter2.Size = new System.Drawing.Size(25, 20);
            this.txtguessLetter2.TabIndex = 3;
            // 
            // txtguessLetter1
            // 
            this.txtguessLetter1.Location = new System.Drawing.Point(85, 100);
            this.txtguessLetter1.Name = "txtguessLetter1";
            this.txtguessLetter1.Size = new System.Drawing.Size(25, 20);
            this.txtguessLetter1.TabIndex = 2;
            // 
            // lblmissingLetter
            // 
            this.lblmissingLetter.AutoSize = true;
            this.lblmissingLetter.Location = new System.Drawing.Point(136, 59);
            this.lblmissingLetter.Name = "lblmissingLetter";
            this.lblmissingLetter.Size = new System.Drawing.Size(25, 13);
            this.lblmissingLetter.TabIndex = 1;
            this.lblmissingLetter.Text = "___";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Guess the missing letter:";
            // 
            // gbxSettings
            // 
            this.gbxSettings.Controls.Add(this.btnhow_to_Play);
            this.gbxSettings.Controls.Add(this.btnchangeBackground);
            this.gbxSettings.Location = new System.Drawing.Point(450, 28);
            this.gbxSettings.Name = "gbxSettings";
            this.gbxSettings.Size = new System.Drawing.Size(200, 100);
            this.gbxSettings.TabIndex = 3;
            this.gbxSettings.TabStop = false;
            this.gbxSettings.Text = "Settings";
            // 
            // btnhow_to_Play
            // 
            this.btnhow_to_Play.Location = new System.Drawing.Point(42, 64);
            this.btnhow_to_Play.Name = "btnhow_to_Play";
            this.btnhow_to_Play.Size = new System.Drawing.Size(117, 23);
            this.btnhow_to_Play.TabIndex = 1;
            this.btnhow_to_Play.Text = "How to play?";
            this.btnhow_to_Play.UseVisualStyleBackColor = true;
            this.btnhow_to_Play.Click += new System.EventHandler(this.btnhow_to_Play_Click);
            // 
            // btnchangeBackground
            // 
            this.btnchangeBackground.Location = new System.Drawing.Point(42, 26);
            this.btnchangeBackground.Name = "btnchangeBackground";
            this.btnchangeBackground.Size = new System.Drawing.Size(117, 23);
            this.btnchangeBackground.TabIndex = 0;
            this.btnchangeBackground.Text = "Change Background";
            this.btnchangeBackground.UseVisualStyleBackColor = true;
            this.btnchangeBackground.Click += new System.EventHandler(this.btnchangeBackground_Click);
            // 
            // gbxDifficulty
            // 
            this.gbxDifficulty.Controls.Add(this.cmbDifficulty);
            this.gbxDifficulty.Location = new System.Drawing.Point(234, 28);
            this.gbxDifficulty.Name = "gbxDifficulty";
            this.gbxDifficulty.Size = new System.Drawing.Size(159, 64);
            this.gbxDifficulty.TabIndex = 2;
            this.gbxDifficulty.TabStop = false;
            this.gbxDifficulty.Text = "Difficulty";
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Intermediate",
            "Advanced"});
            this.cmbDifficulty.Location = new System.Drawing.Point(24, 24);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(111, 21);
            this.cmbDifficulty.TabIndex = 0;
            // 
            // gbxScore
            // 
            this.gbxScore.Controls.Add(this.txtPoints);
            this.gbxScore.Controls.Add(this.lblPlayer);
            this.gbxScore.Controls.Add(this.label2);
            this.gbxScore.Controls.Add(this.label1);
            this.gbxScore.Location = new System.Drawing.Point(6, 19);
            this.gbxScore.Name = "gbxScore";
            this.gbxScore.Size = new System.Drawing.Size(168, 80);
            this.gbxScore.TabIndex = 1;
            this.gbxScore.TabStop = false;
            this.gbxScore.Text = "Score board";
            // 
            // txtPoints
            // 
            this.txtPoints.Enabled = false;
            this.txtPoints.Location = new System.Drawing.Point(54, 47);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(39, 20);
            this.txtPoints.TabIndex = 2;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(51, 16);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(16, 13);
            this.lblPlayer.TabIndex = 2;
            this.lblPlayer.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Points:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player:";
            // 
            // gbxDetails
            // 
            this.gbxDetails.Controls.Add(this.btnPlay);
            this.gbxDetails.Controls.Add(this.txtName);
            this.gbxDetails.Location = new System.Drawing.Point(12, 12);
            this.gbxDetails.Name = "gbxDetails";
            this.gbxDetails.Size = new System.Drawing.Size(118, 79);
            this.gbxDetails.TabIndex = 0;
            this.gbxDetails.TabStop = false;
            this.gbxDetails.Text = "Enter Your Name:";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(21, 56);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(71, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "PLAY!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // cmbchangeBackground
            // 
            this.cmbchangeBackground.FormattingEnabled = true;
            this.cmbchangeBackground.Items.AddRange(new object[] {
            "Blue/Yellow/Brown",
            "Red/White/Green",
            "Purple/Orange/Pink"});
            this.cmbchangeBackground.Location = new System.Drawing.Point(12, 40);
            this.cmbchangeBackground.Name = "cmbchangeBackground";
            this.cmbchangeBackground.Size = new System.Drawing.Size(100, 21);
            this.cmbchangeBackground.TabIndex = 8;
            this.cmbchangeBackground.SelectedIndexChanged += new System.EventHandler(this.cmbchangeBackground_SelectedIndexChanged);
            // 
            // gbxchangeBackground
            // 
            this.gbxchangeBackground.Controls.Add(this.cmbchangeBackground);
            this.gbxchangeBackground.Location = new System.Drawing.Point(18, 242);
            this.gbxchangeBackground.Name = "gbxchangeBackground";
            this.gbxchangeBackground.Size = new System.Drawing.Size(131, 92);
            this.gbxchangeBackground.TabIndex = 8;
            this.gbxchangeBackground.TabStop = false;
            this.gbxchangeBackground.Text = "Change Background";
            this.gbxchangeBackground.Visible = false;
            // 
            // tmrcountDown
            // 
            this.tmrcountDown.Interval = 1000;
            this.tmrcountDown.Tick += new System.EventHandler(this.tmrcountDown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.gbxchangeBackground);
            this.Controls.Add(this.gbxDetails);
            this.Controls.Add(this.gbxPlay);
            this.Name = "Form1";
            this.Text = "WORD ROULETTE RIDDLE";
            this.gbxPlay.ResumeLayout(false);
            this.gbxPlay.PerformLayout();
            this.gbxplayGame.ResumeLayout(false);
            this.gbxplayGame.PerformLayout();
            this.gbxSettings.ResumeLayout(false);
            this.gbxDifficulty.ResumeLayout(false);
            this.gbxScore.ResumeLayout(false);
            this.gbxScore.PerformLayout();
            this.gbxDetails.ResumeLayout(false);
            this.gbxDetails.PerformLayout();
            this.gbxchangeBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxDetails;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gbxScore;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxSettings;
        private System.Windows.Forms.Button btnhow_to_Play;
        private System.Windows.Forms.Button btnchangeBackground;
        private System.Windows.Forms.GroupBox gbxDifficulty;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Button btnplayGame;
        private System.Windows.Forms.GroupBox gbxplayGame;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox txtguessLetter3;
        private System.Windows.Forms.TextBox txtguessLetter2;
        private System.Windows.Forms.TextBox txtguessLetter1;
        private System.Windows.Forms.Label lblmissingLetter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cmbchangeBackground;
        private System.Windows.Forms.GroupBox gbxchangeBackground;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer tmrcountDown;
    }
}

