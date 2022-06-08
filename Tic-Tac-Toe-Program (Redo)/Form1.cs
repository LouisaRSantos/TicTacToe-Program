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

            if (turn == 9)
            {
                MessageBox.Show("Draw!");
            }
        }

        private void TicTacB4_Click(object sender, EventArgs e)
        {
            turn = turn + 1;

            if (TicTacB4.Text == "")
            {
                if (turn % 2 == 0)
                {
                    TicTacB4.Text = "O";
                    TicTacB4.BackColor = Color.PaleGoldenrod;
                }
                else
                {
                    TicTacB4.Text = "X";
                    TicTacB4.BackColor = Color.LightGoldenrodYellow;
                }
            }
            TicTacB4.Enabled = false;
            
            //checking
            if ((TicTacB1.Text == TicTacB4.Text) && (TicTacB4.Text == TicTacB7.Text))
            {
                MessageBox.Show("YEY! " + TicTacB4.Text + " wins!");
            }
            if ((TicTacB4.Text == TicTacB5.Text) && (TicTacB5.Text == TicTacB6.Text))
            {
                MessageBox.Show("YEY! " + TicTacB4.Text + " wins!");
            }
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
            if ((TicTacB1.Text == TicTacB2.Text) && (TicTacB2.Text == TicTacB3.Text))
            {
                MessageBox.Show("YEY! " + TicTacB2.Text + " wins!");
            }
            if ((TicTacB2.Text == TicTacB5.Text) && (TicTacB5.Text == TicTacB8.Text))
            {
                MessageBox.Show("YEY! " + TicTacB2.Text + " wins!");
            }
        }

        private void TicTacB3_Click(object sender, EventArgs e)
        {
            turn = turn + 1;

            if (TicTacB3.Text == "")
            {
                if (turn % 2 == 0)
                {
                    TicTacB3.Text = "O";
                    TicTacB3.BackColor = Color.PaleGoldenrod;
                }
                else
                {
                    TicTacB3.Text = "X";
                    TicTacB3.BackColor = Color.LightGoldenrodYellow;
                }
            }
            TicTacB3.Enabled = false;

            //checking

            if ((TicTacB1.Text == TicTacB2.Text) && (TicTacB2.Text == TicTacB3.Text))
            {
                MessageBox.Show("Yey! " + TicTacB3.Text + " wins!");
            }
            if ((TicTacB3.Text == TicTacB6.Text) && (TicTacB6.Text == TicTacB9.Text))
            {
                MessageBox.Show("Yey! " + TicTacB3.Text + " wins!");
            }

        }

        private void TicTacB5_Click(object sender, EventArgs e)
        {
            turn = turn + 1;

            if (TicTacB5.Text == "")
            {
                if (turn % 2 == 0)
                {
                    TicTacB5.Text = "O";
                    TicTacB5.BackColor = Color.PaleGoldenrod;
                }
                else
                {
                    TicTacB5.Text = "X";
                    TicTacB5.BackColor = Color.LightGoldenrodYellow;
                }
            }
            TicTacB5.Enabled = false;
        }

        private void TicTacB6_Click(object sender, EventArgs e)
        {
            turn = turn + 1;

            if (TicTacB6.Text == "")
            {
                if (turn % 2 == 0)
                {
                    TicTacB6.Text = "O";
                    TicTacB6.BackColor = Color.PaleGoldenrod;
                }
                else
                {
                    TicTacB6.Text = "X";
                    TicTacB6.BackColor = Color.LightGoldenrodYellow;
                }
            }
            TicTacB6.Enabled = false;
        }

        private void TicTacB7_Click(object sender, EventArgs e)
        {
            turn = turn + 1;

            if (TicTacB7.Text == "")
            {
                if (turn % 2 == 0)
                {
                    TicTacB7.Text = "O";
                    TicTacB7.BackColor = Color.PaleGoldenrod;
                }
                else
                {
                    TicTacB7.Text = "X";
                    TicTacB7.BackColor = Color.LightGoldenrodYellow;
                }
            }
            TicTacB7.Enabled = false;
        }

        private void TicTacB8_Click(object sender, EventArgs e)
        {
            turn = turn + 1;

            if (TicTacB8.Text == "")
            {
                if (turn % 2 == 0)
                {
                    TicTacB8.Text = "O";
                    TicTacB8.BackColor = Color.PaleGoldenrod;
                }
                else
                {
                    TicTacB8.Text = "X";
                    TicTacB8.BackColor = Color.LightGoldenrodYellow;
                }
            }
            TicTacB8.Enabled = false;
        }

        private void TicTacB9_Click(object sender, EventArgs e)
        {
            turn = turn + 1;

            if (TicTacB9.Text == "")
            {
                if (turn % 2 == 0)
                {
                    TicTacB9.Text = "O";
                    TicTacB9.BackColor = Color.PaleGoldenrod;
                }
                else
                {
                    TicTacB9.Text = "X";
                    TicTacB9.BackColor = Color.LightGoldenrodYellow;
                }
            }
            TicTacB9.Enabled = false;
        }
       
    }
}
