using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddingNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variables
        int intNumber1, intNumber2;
        float fAnswer;
        private void button3_Click(object sender, EventArgs e)
        {
            //Call the Halt Procedure
            Halt();
        }

        //procedure to exit
        public static void Halt()
        {
            //local variable to store result

            DialogResult dr;

            //accept the response
            dr = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Hand);

            //if yes the program should close
            if ( dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //txtnumber1.text = "";
            ClearDetails();
        }

        //clear details procedure
        public void ClearDetails()
        {
            //clear the text boxes
            txtnumber1.Text = "";
            txtnumber2.Text = "";

            //clear the label
            lblAnswer.Text = "";

            //clear variables
            intNumber1 = 0;
            fAnswer = 0;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            //code to read and convert numbers
            intNumber1 = Convert.ToInt32(txtnumber1.Text);
            intNumber2 = Convert.ToInt32(txtnumber2.Text);

            //calculate the number
            //fAnswer = (float)(intNumber1 - intNumber2);

            //display answer
            lblAnswer.Text = Convert.ToString(fAnswer);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            //code to read and convert numbers
            intNumber1 = Convert.ToInt32(txtnumber1.Text);
            intNumber2 = Convert.ToInt32(txtnumber2.Text);

            //calculate the number
            fAnswer = (float)(intNumber1 * intNumber2);

            //display answer
            lblAnswer.Text = Convert.ToString(fAnswer);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            //code to read and convert numbers
            intNumber1 = Convert.ToInt32(txtnumber1.Text);
            intNumber2 = Convert.ToInt32(txtnumber2.Text);

            //calculate the number
            fAnswer = (float)(intNumber1 / intNumber2);

            //display answer
            lblAnswer.Text = Convert.ToString(fAnswer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code to read and convert numbers
            intNumber1 = Convert.ToInt32(txtnumber1.Text);
            intNumber2 = Convert.ToInt32(txtnumber2.Text);

            //display answer
            fAnswer = (float)(intNumber1 * 100 / intNumber2);

            lblAnswer.Text = Convert.ToString(fAnswer) + "%";



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //code to read and convert numbers
            intNumber1 = Convert.ToInt32(txtnumber1.Text);
            intNumber2 = Convert.ToInt32(txtnumber2.Text);

            //calculate the number
            fAnswer = (float)(intNumber1 + intNumber2);

            //display answer
            lblAnswer.Text = Convert.ToString(fAnswer);

        }
    }
}
