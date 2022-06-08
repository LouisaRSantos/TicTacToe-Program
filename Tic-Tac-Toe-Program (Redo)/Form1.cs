using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Program__Redo_
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        int turn = 0;

        private void TicTacB1_Click(object sender, EventArgs e)
        {
            turn = turn + 1;

            if (TicTacB1.Text == "")
            {
                if (turn % 2 == 0)
                {
                    TicTacB1.Text = "O";
                    TicTacB1.BackColor = Color.PaleGoldenrod;
                }
                else
                {
                    TicTacB1.Text = "X";
                    TicTacB1.BackColor = Color.LightGoldenrodYellow;
                }
            }
            TicTacB1.Enabled = false;

            //checking

            if ((TicTacB1.Text == TicTacB2.Text) && (TicTacB2.Text == TicTacB3.Text))
            {
                MessageBox.Show("YEY! " + TicTacB1.Text + " wins!");
            }
            if ((TicTacB1.Text == TicTacB4.Text) && (TicTacB4.Text == TicTacB7.Text))
            {
                MessageBox.Show("YEY! " + TicTacB1.Text + " wins!");
            }
            if ((TicTacB1.Text == TicTacB5.Text) && (TicTacB5.Text == TicTacB9.Text))
            {
                MessageBox.Show("YEY! " + TicTacB1.Text + " wins!");
            }
        }

        private void TicTacB4_Click(object sender, EventArgs e)
        {

        }

        private void TicTacB2_Click(object sender, EventArgs e)
        {
            turn = turn + 1;

            if (TicTacB2.Text == "")
            {
                if (turn % 2 == 0)
                {
                    TicTacB2.Text = "O";
                    TicTacB2.BackColor = Color.PaleGoldenrod;
                }
                else
                {
                    TicTacB2.Text = "X";
                    TicTacB2.BackColor = Color.LightGoldenrodYellow;
                }
            }
            TicTacB2.Enabled = false;

            //Checking

            
        }

        private void TicTacB3_Click(object sender, EventArgs e)
        {

        }

        private void TicTacB5_Click(object sender, EventArgs e)
        {

        }

        private void TicTacB6_Click(object sender, EventArgs e)
        {

        }

        private void TicTacB7_Click(object sender, EventArgs e)
        {

        }

        private void TicTacB8_Click(object sender, EventArgs e)
        {

        }

        private void TicTacB9_Click(object sender, EventArgs e)
        {

        }
       
    }
}
