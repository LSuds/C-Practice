using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        int turn = 1;
        string turnMarker;
        public Form1()
        {
            InitializeComponent();
        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        public void Button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = turnMarker;
                turnMarker =OnPush(1);
            }
            else
                MessageBox.Show("Select a box that is empty");

        }

        public void Button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = turnMarker;
                turnMarker = OnPush(2);
            }
            else
                MessageBox.Show("Select a box that is empty");
      
        }
   
        public void Button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = turnMarker;
                turnMarker = OnPush(3);
            }
            else
                MessageBox.Show("Select a box that is empty");
          
        }

        public void Button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = turnMarker;
                turnMarker = OnPush(4);
            }
            else
                MessageBox.Show("Select a box that is empty");
        
        }

        public void Button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = turnMarker;
                turnMarker = OnPush(5);
            }
            else
                MessageBox.Show("Select a box that is empty");
          
        }

        public void Button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = turnMarker;
                turnMarker = OnPush(6);
            }
            else
                MessageBox.Show("Select a box that is empty");
 
        }

        public void Button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = turnMarker;
                turnMarker = OnPush(7);
            }
            else
                MessageBox.Show("Select a box that is empty");
 
        }

        public void Button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                button8.Text = turnMarker;
                turnMarker = OnPush(8);
            }
            else
                MessageBox.Show("Select a box that is empty");
        }

        public void Button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                button9.Text = turnMarker;
                turnMarker = OnPush(9);
            }
            else
                MessageBox.Show("Select a box that is empty");
 
        }
        public string OnPush(int button)
        {
            string turnMarker;
            
                       if (turn % 2 == 0)
                           turnMarker = "O";
                       else
                           turnMarker = "X";
           
            if (turn == 9 && CheckWin(button,turnMarker)== "Empty")
            {
                MessageBox.Show("CAT Game :(");
                ClearBoard();
            }
            else
            { 
                 if (CheckWin(button, turnMarker) == "X")
                 {
                    MessageBox.Show(" Player 1 Wins!");
                    textBox2.Text = "1";
                    ClearBoard();

                 }
                else if (CheckWin(button, turnMarker) == "O")
                {
                    MessageBox.Show(" Player 2 Wins!");
                    textBox3.Text = "1";
                    ClearBoard();
                }
            }
            turn++;
            return turnMarker;
       }

        public void ClearBoard()
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
            turn = 0;
        }
        public string CheckWin(int button, string turnMarker)
        {
            string win = "Empty";
                if (button1.Text == turnMarker && button2.Text == turnMarker && button3.Text == turnMarker)
                {
                    win = turnMarker;
                }
                else if (button4.Text == turnMarker && button5.Text == turnMarker && button6.Text == turnMarker)
                {
                    win = turnMarker;
                }
                else if (button7.Text == turnMarker && button8.Text == turnMarker && button9.Text == turnMarker)
                {
                    win = turnMarker;
                }
                else if (button1.Text == turnMarker && button4.Text == turnMarker && button7.Text == turnMarker)
                {
                    win = turnMarker;
                }
                else if (button2.Text == turnMarker && button5.Text == turnMarker && button8.Text == turnMarker)
                {
                    win = turnMarker;
                }
                else if (button3.Text == turnMarker && button6.Text == turnMarker && button9.Text == turnMarker)
                {
                    win = turnMarker;
                }
                else if (button1.Text == turnMarker && button5.Text == turnMarker && button9.Text == turnMarker)
                {
                    win = turnMarker;
                }
                else if (button3.Text == turnMarker && button5.Text == turnMarker && button7.Text == turnMarker)
                {
                    win = turnMarker;
                }
            return win;
        }
    }
}
