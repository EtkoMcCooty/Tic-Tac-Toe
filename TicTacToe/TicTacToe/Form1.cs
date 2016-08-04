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
        bool playerOneTurn = true; // true = O's turn, false = Xs turn
        int turn_number = 0; // keeps track of how many turns have passed

        public Form1()
        {
            InitializeComponent();
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
                    winning_player = "X";
                    x_win_count.Text = (int.Parse(x_win_count.Text) + 1).ToString();
                }
                else
                {
                    winning_player = "O";
                    o_win_count.Text = (int.Parse(o_win_count.Text) + 1).ToString();
                }

                MessageBox.Show($"{winning_player} is the winner!");
                newGameToolStripMenuItem.PerformClick();
            }
            else
            {
                if (turn_number == 9)
                {
                    draw_count.Text = (int.Parse(draw_count.Text) + 1).ToString();
                    MessageBox.Show("The game is a draw...");
                    newGameToolStripMenuItem.PerformClick();
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
    }
}
