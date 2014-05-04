using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
                                                                                                                // Written by: Thomas Freeman
namespace ProjectTwo {                                                                                          // This is my namespace.
    
    public partial class rpsGame : Form {                                                                       // This is a class.

        public char userGuess;                                                                                  // Dem be variables.
        public int computerGuess;

        
        
        public rpsGame() {InitializeComponent();}

        private void playButton_Click(object sender, EventArgs e) {                                             // The button does all the work, and resets the game.

            resultLabel.Text = " ";
            rockPicture.Visible = false;
            paperPicture.Visible = false;
            scissorsPicture.Visible = false;
            
            Random ranNumberGenerator = new Random();                                                           // Random number generator for computer guess.
            computerGuess = ranNumberGenerator.Next(1, 3);                                                      // Sets the random number to computerGuess.
            
                if (rockRadioButton.Checked == true) {                                                          // Player chose rock.

                    rockPicture.Visible = true;
                    if (computerGuess == 0) { resultLabel.Text = "I chose Rock. Tie game!"; }                   // Outputs the result.
                    else if (computerGuess == 1) { resultLabel.Text = "I chose Paper. You lose!"; }
                    else if (computerGuess == 2) { resultLabel.Text = "I chose Scissors. You won!"; }

                }

                else if (paperRadioButton.Checked == true) {                                                    // Player chose Paper.

                    paperPicture.Visible = true;
                    if (computerGuess == 0) { resultLabel.Text = "I chose Rock. You won!"; }                    // Outputs the result.
                    else if (computerGuess == 1) { resultLabel.Text = "I chose Paper. Tie game!"; }
                    else if (computerGuess == 2) { resultLabel.Text = "I chose Scissors. You lose!"; }

                }

                else if (scissorsRadioButton.Checked == true) {                                                 // Player chose scissors.

                    scissorsPicture.Visible = true;
                    if (computerGuess == 0) { resultLabel.Text = "I chose Rock. You lose!"; }                   // Outputs the result.
                    else if (computerGuess == 1) { resultLabel.Text = "I chose Paper. You won!"; }
                    else if (computerGuess == 2) { resultLabel.Text = "I chose Scissors. Tie game!"; }

                }

                else {

                    resultLabel.Text = "Please make a selection!";
                
                }

        }                                                                                                       // End of playButton.   

    }                                                                                                           // End of class rpsGame.

}                                                                                                               
