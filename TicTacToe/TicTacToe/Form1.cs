using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        static int turn_number = 0; // keeps track of how many turns have passed
        static String player1, player2;
        static bool playerOneTurn { get; set; } // true = O's turn, false = Xs turn
        PlayAgain play_again = new PlayAgain();



        public Form1()
        {
            InitializeComponent();
        }

        public static void setPlayerNames(String name1, String name2)
        {
            player1 = name1;
            player2 = name2;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Etko's Tic Tac Toe", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (playerOneTurn)
            {
                b.Text = "O";
            }
            else
            {
                b.Text = "X";
            }
            playerOneTurn = !playerOneTurn;
            b.Enabled = false;

            turn_number++;

            checkForWinner();
        }

        private void checkForWinner()
        {
            bool winner = false; // There is no winner yet

            // Hoirizontal checks
            if ((A1.Text == A2.Text)&&(A2.Text == A3.Text) && (!A1.Enabled))
                winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                winner = true;

            // Vertical checks
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                winner = true;

            // Diagonal checks
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                winner = true;

            if (winner)
            {
                disableButtons();

                String winning_player = "";

                if (playerOneTurn)
                {
                    winning_player = player2;
                    x_win_count.Text = (int.Parse(x_win_count.Text) + 1).ToString();
                }
                else
                {
                    winning_player = player1;
                    o_win_count.Text = (int.Parse(o_win_count.Text) + 1).ToString();
                }

                MessageBox.Show($"{winning_player} is the winner!");

               playAgain(); // Ask players if they want to play again
            }
            else
            {
                if (turn_number == 9)
                {
                    draw_count.Text = (int.Parse(draw_count.Text) + 1).ToString();
                    MessageBox.Show("The game is a draw...");

                    playAgain();
                   
                    
                }
            }
        }

        private void disableButtons()
        {
          
                foreach (Control c in Controls)
                {
                    try
                    {
                    Button b = (Button)c;
                    c.Enabled = false;
                    }
                    catch { }
                }
           
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerOneTurn = true;
            turn_number = 0;

            
                foreach (Control c in Controls)
                {
                    try
                    {
                    Button b = (Button)c;
                    c.Enabled = true;
                    c.Text = "";
                    }
                    catch { }
                }
            
        }

        private void indicate_turn_player(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Enabled)
            {
                if (playerOneTurn)
                    b.Text = "O";
                else
                    b.Text = "X";
            }
           
        }

        private void remove_indicator(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Enabled)
                b.Text = "";
            
        }

        private void resetCountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NameEntryForm name_entry = new NameEntryForm();

            name_entry.ShowDialog(); // shows the name entry form before the main game form

            label1.Text = player1;
            label2.Text = player2;
        }

        private void playAgain()
        {

            play_again.yesButton.DialogResult = DialogResult.Yes; // Allows dialogue box to run smoothly
            play_again.noButton.DialogResult = DialogResult.No;
            play_again.ShowDialog();


            if (play_again.yesButtonClicked)
            {
                newGameToolStripMenuItem.PerformClick();

                play_again.yesButtonClicked = false;
            }
            else
            {
                exitToolStripMenuItem.PerformClick();
                play_again.noButtonClicked = false;
            }
        }
        
    }
}
