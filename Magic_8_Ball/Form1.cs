using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_8_Ball
{
    public partial class FrmMain : Form
    {
        //Create random class
        Random r = new Random();

        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Shake Button Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Declare some strings
            string
                case1 = "Yes!",
                case2 = "No!",
                case3 = "Maybe",
                case4 = "It is a Possibility",
                case5 = "Not in a Million Years",
                case6 = "It is very likely",
                case7 = "Certainly",
                case8 = "Try Again";

            //Store number generated from the random generator
            int numAnswer = r.Next(1, 9);

            //Interpret each random number as a specific case and display appropriate string
            switch (numAnswer)
            {
                case 1:
                    lblAnswer.Text = case1;
                    break;

                case 2:
                    lblAnswer.Text = case2;
                    break;

                case 3:
                    lblAnswer.Text = case3;
                    break;

                case 4:
                    lblAnswer.Text = case4;
                    break;

                case 5:
                    lblAnswer.Text = case5;
                    break;

                case 6:
                    lblAnswer.Text = case6;
                    break;

                case 7:
                    lblAnswer.Text = case7;
                    break;

                case 8:
                    lblAnswer.Text = case8;
                    break;
            }
        }

        /// <summary>
        /// About Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display message box showing programmers name and class
            MessageBox.Show("Matthew Vaughan\nCS1400 Sec 003");
        }

        /// <summary>
        /// Exit Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close out of the program
            this.Close();
        }
    }
}
