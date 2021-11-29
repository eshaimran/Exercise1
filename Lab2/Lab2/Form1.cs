using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String message = "You purchased:\n";
            int amount = 0;
            if (checkBox1.Checked==true)
            {
                message = message + "\t" + checkBox1.Text + "\n";
                amount = amount + 20;
            }
            if (checkBox2.Checked == true)
            {
                message = message + "\t" + checkBox2.Text + "\n";
                amount = amount + 30;
            }
            if (checkBox3.Checked == true)
            {
                message = message + "\t" + checkBox1.Text + "\n";
                amount = amount + 50;
            }
            message = message + "\nThe total payment due is $" + amount;
            if (radioButton1.Checked == true)
            {
                message = message + "\nThe selected mode of payment is" + radioButton1.Text;
                if (textBox1.Text != "")
                {
                    message = message + "\nYour comments about us are: " + textBox1.Text;
                }
                MessageBox.Show(message, "Summary");
            }
            else if (radioButton2.Checked == true)
            {
                message = message + "\nThe selected mode of payment is" + radioButton1.Text;
                if (textBox1.Text != "")
                {
                    message = message + "\nYour comments about us are: " + textBox1.Text;
                }
                MessageBox.Show(message, "Summary");
            }
            else
            {
                MessageBox.Show("Please select payment mode first");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                button1.Enabled = false;
                groupBox2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                groupBox2.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                button1.Enabled = false;
                groupBox2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                groupBox2.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                button1.Enabled = false;
                groupBox2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                groupBox2.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit application?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
