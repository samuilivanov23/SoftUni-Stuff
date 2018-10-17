using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool turn = true; //true == X an false == O
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button button = (Button)c;
                    button.Enabled = true;
                    button.Text = "";
                }
            }
            catch { }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic Tac Toe game created by Samuil", "Tic Tac Toe");
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
            {
                button.Text = "X";
            }
            else button.Text = "O";

            turn = !turn;
            turn_count++;
            button.Enabled = false;
            ChekWinner();
        }

        private void ChekWinner()
        {
            bool winner = false;

            //Horizontal check.
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                winner = true;
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                winner = true;
            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                winner = true;

            //Vertical check.
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                winner = true;
            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                winner = true;
            if ((A3.Text ==B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                winner = true;

            //Diagonal check.
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                winner = true;
            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                winner = true;

            if (winner)
            {
                Disable_Buttons();
                string end = "";
                if (turn)
                {
                    end = "0";
                }
                else end = "X";
                MessageBox.Show(end + " wins", "Yay! :)");
            }
            else
            {
                if (turn_count == 9)
                {
                    MessageBox.Show("DA ti EBA MAIKATA", "Draw");
                }
            }
        }

        private void Disable_Buttons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button button = (Button)c;
                    button.Enabled = false;
                }
            }
            catch { };
        }

    }
}
