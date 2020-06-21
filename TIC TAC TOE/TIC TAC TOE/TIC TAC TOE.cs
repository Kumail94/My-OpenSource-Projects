using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class Form1 : Form
    {
        private int count;
        private bool isPlayerOne;
        private bool isWinner;
        public Form1()
        {
            InitializeComponent();
        }
        private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckValidate();
            EnableOptions(true);
            isPlayerOne = true;
            count = 0;
            EnableButtons(true);
            ClearButtons();
        }
        private void CheckValidate()
        {
            if (textBox1.Text.Trim() == string.Empty && textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please choose a players:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClearButtons();
                EnableButtons(true);
            }
        }
        private void ClearButtons()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
        private void EnableOptions(bool v)
        {
            groupBox1.Enabled = v;
            groupBox2.Enabled = v;
            groupBox3.Enabled = v;
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
        private void EnableButtons(bool v)
        {
            button1.Enabled = v;
            button2.Enabled = v;
            button3.Enabled = v;
            button4.Enabled = v;
            button5.Enabled = v;
            button6.Enabled = v;
            button7.Enabled = v;
            button8.Enabled = v;
            button9.Enabled = v;
        }
        private void ResetGame()
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            ClearButtons();
            EnableButtons(true);
            EnableOptions(true);
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void button7_Click(object sender, EventArgs e)
        {
        }
        private void ButtonsClicks(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            {
                b.ForeColor = Color.White;
                if (isPlayerOne)
                {

                    b.Text = "X";
                    isPlayerOne = false;
                    b.Enabled = false;
                }
                else
                {
                    b.Text = "O";
                    isPlayerOne = true;
                    b.Enabled = false;
                }
                count = count + 1;
                CheckTheWinner();
            }
        }
        private void CheckTheWinner()
        {
            isWinner = false;
            if (count == 9)
            {
                MessageBox.Show("The Game is Drawn!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGame();
            }
            else
            {
                if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled))
                    isWinner = true;
                else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
                    isWinner = true;
                else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled))
                    isWinner = true;
                else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button7.Enabled))
                    isWinner = true;
                else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button8.Enabled))
                    isWinner = true;
                else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button9.Enabled))
                    isWinner = true;
                else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button9.Enabled))
                    isWinner = true;
                else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button7.Enabled))
                    isWinner = true;

                if (isWinner)
                {
                    if (!isPlayerOne)

                        MessageBox.Show(textBox1.Text + " is winner ..", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(textBox2.Text + " is winner ..", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetGame();
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
        private void aboutTicTacToeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            About_Tic_Tac_Toe obj = new About_Tic_Tac_Toe();
            obj.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            EnableOptions(false);
            EnableButtons(false);
        }
    }
}