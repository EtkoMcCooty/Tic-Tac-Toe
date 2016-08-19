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
    public partial class PlayAgain : Form
    {
        public bool yesButtonClicked = false;
        public bool noButtonClicked = false;
        
        public PlayAgain()
        {
            InitializeComponent();
        }

        public void yesButton_Click(object sender, EventArgs e)
        {
            yesButtonClicked = true;
        }

        public void noButton_Click(object sender, EventArgs e)
        {
            noButtonClicked = true;
        }

       
    }
}
