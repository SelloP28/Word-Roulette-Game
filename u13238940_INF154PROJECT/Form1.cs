using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u13238940_INF154PROJECT
{
    /*Sello Phakoe
     * u13238940
     * INF154 PROJECT
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
           
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter your name!");
            }
                
               
            else
            {
                gbxPlay.Visible = true;
                gbxDetails.Visible = false;
                lblPlayer.Text = txtName.Text;
            }
                
        }

        // Timer function
        int _easyTimerCount_ = 10,
            _intermediateTimerCount_ = 20,
            _advancedTimerCount_ = 25;


        private void timerCountDown()
        {

            if (tmrcountDown.Enabled)
                tmrcountDown.Stop();

            else
                tmrcountDown.Start();

        }

        private void btnplayGame_Click(object sender, EventArgs e)
        {

            if (cmbDifficulty.Text == "")
                MessageBox.Show("Please select a level.");

            else
            {
                gbxplayGame.Visible = true;
                btnplayGame.Visible = false;
                gbxDifficulty.Enabled = false;
                timerCountDown();


                //disable other two input textboxes
                if (cmbDifficulty.Text == "Easy")
                {
                    lblmissingLetter.Text = easyWords();
                    txtguessLetter2.Enabled = false;
                    txtguessLetter3.Enabled = false;

                }

                else if (cmbDifficulty.Text == "Intermediate")
                {
                    lblTheme.Text = "Theme: TRAGEDY";
                    lblmissingLetter.Text = intermediateWords();
                    txtguessLetter3.Enabled = false;
                }

                else if (cmbDifficulty.Text == "Advanced")
                {
                    lblTheme.Text = "Theme: THE SCIENCES";
                    lblmissingLetter.Text = advancedWords();
                    //add some code here
                }

            }
                
        }

        //Create 'Hint' text 
        private string getHint_Text(int i)
        {
            string[] hintText = new string[2];

            hintText[0] = "THINK OF WORDS ASSOCIATED WITH THE THEME: TRAGEDY. " + "\n" + "\n" +
                          "Riddle: \n\n" +
                          "The children shall STARVE in my presence alone." + "\n" +
                          "Shan't cease 'til PAIN surrounds every UNFORTUNATE bone." + "\n" +
                          "Every attempt, committed in VAIN. 'Til you read each line all over again.";

            hintText[1] = "THINK OF WORDS ASSOCIATED WITH THE THEME: THE SCIENCES. " + "\n" + "\n" +
                          "Think EXTINCT FLYING REPTILE; Think TURING MACHINES and COMPUTER THEORY" + "\n" +
                          "Think RANDOMNESS; Think QUANTUM MECHANICS; Think MICROPROCESSOR DESIGN.";

            return hintText[i]; 
        }

        // Method for when the Hint button is clicked
        private void btnHint_Click(object sender, EventArgs e)
        {
            if(cmbDifficulty.Text == "Intermediate")
            {
                MessageBox.Show(getHint_Text(0));
            }

            else if(cmbDifficulty.Text == "Advanced")
            {
                MessageBox.Show(getHint_Text(1));
            }
        }

        //Method for when How To Play button is clicked
        private void btnhow_to_Play_Click(object sender, EventArgs e)
        {
            string howTo;

            howTo = "Welcome to WORD ROULETTE RIDDLE!" + "\n\n\n" +
                    "Instructions: " + "\n" +
                    "1. Enter your name to play." + "\n" +
                    "2. Select difficulty level." + "\n" +
                    "3. Press PLAY GAME!" + "\n" +
                    "4. Random word will be picked with missing letter/s" + "\n" +
                    "5. Guess the correct letter/s before the time runs out!" + "\n\n\n" +
                    "And if the game gets too difficult, look out for the Hint button!" + "\n" +
                    "Also look out for the THEME lable to get an idea of the subject matter of the words to guess!" + "\n\n" +
                    "GOOD LUCK!!!";

            MessageBox.Show(howTo);
        }

        //Method for when the Change Background button is clicked
        private void btnchangeBackground_Click(object sender, EventArgs e)
        {
            gbxchangeBackground.Visible = true;
            gbxPlay.Visible = false;

            //timer has to pause during this
        }

        //Method for changing the background colours of the group boxes 
        private void cmbchangeBackground_SelectedIndexChanged(object sender, EventArgs e)
        {
            string change = cmbchangeBackground.Text;

            switch (change)
            {
                case "Blue/Yellow/Brown":
                    this.gbxplayGame.BackColor = Color.LightGoldenrodYellow;
                    this.gbxScore.BackColor = Color.AliceBlue;
                    this.gbxDifficulty.BackColor = Color.AliceBlue;
                    this.gbxSettings.BackColor = Color.AliceBlue;
                    this.gbxPlay.BackColor = Color.SaddleBrown;
                    //image here???
                    break;

                case "Red/White/Green":
                    this.gbxplayGame.BackColor = Color.GreenYellow;
                    this.gbxScore.BackColor = Color.MediumVioletRed;
                    this.gbxDifficulty.BackColor = Color.MediumVioletRed;
                    this.gbxSettings.BackColor = Color.MediumVioletRed;
                    this.gbxPlay.BackColor = Color.GhostWhite;
                    //image here??
                    break;

                case "Purple/Orange/Pink":
                    this.gbxplayGame.BackColor = Color.Orange;
                    this.gbxScore.BackColor = Color.MediumPurple;
                    this.gbxDifficulty.BackColor = Color.MediumPurple;
                    this.gbxSettings.BackColor = Color.MediumPurple;
                    this.gbxPlay.BackColor = Color.HotPink;
                    //image here??
                    break;

                default:
                    MessageBox.Show("Please selecte a valid option.");
                    break;
            }

            gbxchangeBackground.Visible = false;
            gbxPlay.Visible = true;
        }

        // Method for displaying correct message
        private void correctMessageDisplay()
        {
            lblMessage.Text = "CORRECT!";
        }

        // Method for displaying incorrect message
        private void incorrectMessageDisplay()
        {
            lblMessage.Text = "INCORRECT!";
        }

        // Define a random number
        Random randNumber = new Random();
        // create method for easy word difficulty
        private string easyWords()
        {
            string[] ezWords = new string[3];
            //randomly select a word
            int guess = randNumber.Next(0, 3);

            ezWords[0] = "_abbit";
            ezWords[1] = "c_own";
            ezWords[2] = "dra_on";

            return ezWords[guess];
        }

        //create method for intermediate difficulty
        private string intermediateWords()
        {
            string[] interWords = new string[4];

            int guess = randNumber.Next(0, 4);

            interWords[0] = "_a_ine";
            interWords[1] = "_gon_";
            interWords[2] = "fu_i_e";
            interWords[3] = "h_p_ess";

            return interWords[guess];
        }

        //create method for advanced difficulty
        private string advancedWords()
        {
            string[] advncdWords = new string[5];

            int guess = randNumber.Next(0, 5);

            advncdWords[0] = "_ter_dac_l";
            advncdWords[1] = "a_to_at_";
            advncdWords[2] = "sto_ _a_tic";
            advncdWords[3] = "_n_ang_ement";
            advncdWords[4] = "_ab_ic_tion";

            return advncdWords[guess];
        }

        //create advanced option
        private void difficultyAdvanced()
        {
            string advancedWordList = advancedWords();
            string guessLetter1 = txtguessLetter1.Text,
                   guessLetter2 = txtguessLetter2.Text,
                   guessLetter3 = txtguessLetter3.Text;

            int score = 0;


            if (lblmissingLetter.Text == "_ter_dac_l" && guessLetter1 == "p" && guessLetter2 == "o" && guessLetter3 == "y")
            {
                score += 5;
                correctMessageDisplay();
                clearTextBoxes();
                txtPoints.Text = score.ToString();
            }

            else if (lblmissingLetter.Text == "a_to_at_" && guessLetter1 == "u" && guessLetter2 == "m" && guessLetter3 == "a")
            {
                score = Convert.ToInt32(score) + 10;
                correctMessageDisplay();
                clearTextBoxes();
                txtPoints.Text = score.ToString();
            }

            else if (lblmissingLetter.Text == "sto_ _a_tic" && guessLetter1 == "c" && guessLetter2 == "h" && guessLetter3 == "s")
            {
                score = Convert.ToInt32(score) + 15;
                correctMessageDisplay();
                clearTextBoxes();
                txtPoints.Text = score.ToString();
            }

            else if (lblmissingLetter.Text == "_n_ang_ement" && guessLetter1 == "e" && guessLetter2 == "t" && guessLetter3 == "l")
            {
                score = Convert.ToInt32(score) + 20;
                correctMessageDisplay();
                clearTextBoxes();
                txtPoints.Text = score.ToString();
            }

            else if (lblmissingLetter.Text == "_ab_ic_tion" && guessLetter1 == "f" && guessLetter2 == "r" && guessLetter3 == "a")
            {
                score = Convert.ToInt32(score) + 25;
                correctMessageDisplay();
                clearTextBoxes();
                txtPoints.Text = score.ToString();
            }

            else
            {
                incorrectMessageDisplay();
                clearTextBoxes();
            }
                

            lblmissingLetter.Text = advancedWordList;

        }

        //create intermediate option
        private void difficultyIntermediate()
        {
            string intermediateWordList = intermediateWords();
            string guessLetter1 = txtguessLetter1.Text,
                   guessLetter2 = txtguessLetter2.Text;

            int score = 0;


            if (lblmissingLetter.Text == "_a_ine" && guessLetter1 == "f" && guessLetter2 == "m")
            {
                score += 5;
                correctMessageDisplay();
                clearTextBoxes();
                txtPoints.Text = score.ToString();
            }

            else if (lblmissingLetter.Text == "_gon_" && guessLetter1 == "a" && guessLetter2 == "y")
            {
                score = Convert.ToInt32(score) + 10; 
                correctMessageDisplay();
                clearTextBoxes();
                txtPoints.Text = score.ToString();
            }

            else if (lblmissingLetter.Text == "fu_i_e" && guessLetter1 == "t" && guessLetter2 == "l")
            {
                score = Convert.ToInt32(score) + 15;
                correctMessageDisplay();
                clearTextBoxes();
                txtPoints.Text = score.ToString();
            }

            else if (lblmissingLetter.Text == "h_p_ess" && guessLetter1 == "a" && guessLetter2 == "l")
            {
                score = Convert.ToInt32(score) + 20;
                correctMessageDisplay();
                clearTextBoxes();
                txtPoints.Text = score.ToString();
            }

            else
            {
                incorrectMessageDisplay();
                clearTextBoxes();
            }
                

            lblmissingLetter.Text = intermediateWordList;
        }

        //Method to remove letter
        /*private char missing_Letter(string words)
        {
            //int random_Letter = randNumber.Next(0, 4);
            string missing_Letter = words.Remove(0,5);
            char m = Convert.ToChar(missing_Letter);

            return m;
        } //does not work...*/

        //create easy difficulty option
        private void difficultyEasy()
        {
            string easyWordList = easyWords();
            string guessLetter1 = txtguessLetter1.Text;

            int score = 0;


            if (lblmissingLetter.Text == "_abbit" && guessLetter1 == "r")
            {
                score += 5;
                correctMessageDisplay();
                clearTextBoxes();
                txtPoints.Text = score.ToString();
            }

            else if (lblmissingLetter.Text == "c_own" && guessLetter1 == "l")
            {
                score = Convert.ToInt32(score) + 10;
                correctMessageDisplay();
                clearTextBoxes();
                txtPoints.Text = score.ToString();
            }

            else if (lblmissingLetter.Text == "dra_on" && guessLetter1 == "g")
            {
                score = Convert.ToInt32(score) + 15;
                correctMessageDisplay();
                clearTextBoxes();
                txtPoints.Text = score.ToString();
            }

            else
            {
                incorrectMessageDisplay();
                clearTextBoxes();
            }

            lblmissingLetter.Text = easyWordList;
        }

        //When the GUESS button is clicked 
        private void btnGuess_Click(object sender, EventArgs e)
        {

            switch (cmbDifficulty.Text)
            {
                case "Easy":
                    difficultyEasy();
                    break;

                case "Intermediate":
                    difficultyIntermediate();
                    break;

                case "Advanced":
                    difficultyAdvanced();
                    break;

                default:
                    MessageBox.Show("Error");
                    break;
            }

        }

        //Clear function 
        private void clearTextBoxes()
        {
            if(cmbDifficulty.Text == "Easy")
            {
                txtguessLetter1.Clear();
            }

            else if(cmbDifficulty.Text == "Intermediate")
            {
                txtguessLetter1.Clear();
                txtguessLetter2.Clear();
            }

            else if (cmbDifficulty.Text == "Advanced")
            {
                txtguessLetter1.Clear();
                txtguessLetter2.Clear();
                txtguessLetter3.Clear();
            }
        }

        //Timer function
        private void tmrcountDown_Tick(object sender, EventArgs e)
        {
            // Easy option timer count
            if (cmbDifficulty.Text == "Easy")
            {
                if (_easyTimerCount_ >= 0)
                {
                    lblTimer.Text = Convert.ToString(_easyTimerCount_--);

                    if (_easyTimerCount_ < 5)
                    {
                        this.lblTimer.BackColor = Color.MediumVioletRed;

                    }
                }

                else
                {
                    tmrcountDown.Enabled = false;
                    MessageBox.Show("YOUR TIME IS UP!!");
                    gbxplayGame.Enabled = false;
                    //add score
                }

            }

            // Intermediate timer count
            else if (cmbDifficulty.Text == "Intermediate")
            {
                if (_intermediateTimerCount_ >= 0)
                {
                    lblTimer.Text = Convert.ToString(_intermediateTimerCount_--);

                    if (_intermediateTimerCount_ < 10)
                    {
                        this.lblTimer.BackColor = Color.MediumVioletRed;
                        btnHint.Visible = true;

                    }
                }

                else
                {
                    tmrcountDown.Enabled = false;
                    MessageBox.Show("YOUR TIME IS UP!!");
                    gbxplayGame.Enabled = false;
                    //add score
                }
            }

            // Advanced timer count
            else if (cmbDifficulty.Text == "Advanced")
            {
                if (_advancedTimerCount_ >= 0)
                {
                    lblTimer.Text = Convert.ToString(_advancedTimerCount_--);

                    if (_advancedTimerCount_ < 15)
                    {
                        this.lblTimer.BackColor = Color.MediumVioletRed;
                        btnHint.Visible = true;

                    }
                }

                else
                {
                    tmrcountDown.Enabled = false;
                    MessageBox.Show("YOUR TIME IS UP!!");
                    gbxplayGame.Enabled = false;
                }

            }
        }
    }
}
