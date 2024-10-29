using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculatorlabel1 : Form
    {
        public Calculatorlabel1()
        {
            InitializeComponent();
        }

        private void Calculatorlabel3_Click(object sender, EventArgs e)
        {

        }

        private void Calculatorlabel4_Click(object sender, EventArgs e)
        {

        }

        private void Calculatorbutton1_Click(object sender, EventArgs e)
        {
            if (Calculatorentry1.Text == "" || Calculatorentry2.Text == "")
            {
                MessageBox.Show("Please enter all numbers","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            try
            {
                int number_1 = Convert.ToInt32(Calculatorentry1.Text);
                int number_2 = Convert.ToInt32(Calculatorentry2.Text);
                int total = number_1 + number_2;
                Calculatorentry3.Text = total.ToString();
            }catch
            {
                MessageBox.Show("Please enter valid numbers", "Warninig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
             
            
        

        private void Calculatorbutton2_Click(object sender, EventArgs e)
        {
            if (Calculatorentry1.Text == "" || Calculatorentry2.Text == "")
            {
                MessageBox.Show("Please enter all numbers","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            try
            {
                int number_1 = Convert.ToInt32(Calculatorentry1.Text);
                int number_2 = Convert.ToInt32(Calculatorentry2.Text);
                int total = number_1 - number_2;
                Calculatorentry3.Text = total.ToString();
            }catch
            {
                MessageBox.Show("Please enter valid number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
        }

        private void Calculatorbuton3_Click(object sender, EventArgs e)
        {
            if (Calculatorentry1.Text == "" || Calculatorentry2.Text == "")
            {
                MessageBox.Show("Please enter all numbers","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            try
            {
                int number_1 = Convert.ToInt32(Calculatorentry1.Text);
                int number_2 = Convert.ToInt32(Calculatorentry2.Text);
                int total = number_1 * number_2;
                Calculatorentry3.Text = total.ToString();
            }catch
            {
                MessageBox.Show("Please enter valid numbers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return ;
            }
            
        }

        private void Calculatorbutton4_Click(object sender, EventArgs e)
        {
            if (Calculatorentry1.Text == "" || Calculatorentry2.Text == "")
            {
                MessageBox.Show("Please enter all numbers","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            try
            {
                float number_1 = Convert.ToInt32(Calculatorentry1.Text);
                float number_2 = Convert.ToInt32(Calculatorentry2.Text);
                float total = number_1 / number_2;
                Calculatorentry3.Text = total.ToString();
            }catch
            {
                MessageBox.Show("Please enter valid numbers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
        }

        private void Calculatorbutton5_Click(object sender, EventArgs e)
        {
            if (Calculatorentry1.Text == "" || Calculatorentry2.Text == "")
            {
                MessageBox.Show("Please enter all numbers","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            try
            {
                int number_1 = Convert.ToInt32(Calculatorentry1.Text);
                int number_2 = Convert.ToInt32(Calculatorentry2.Text);
                int total = number_1 % number_2;
                Calculatorentry3.Text = total.ToString();
            }catch
            {
                MessageBox.Show("Please enter valid numbers","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            
        }

        private void Calculatorentry2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculatorbutton6_Click(object sender, EventArgs e)
        {
            if (Calculatorentry1.Text == "" & Calculatorentry2.Text == "")
            {
                MessageBox.Show("Please enter all number","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            Calculatorentry1.Text = "";
            Calculatorentry2.Text = "";
            Calculatorentry3.Text = "0";
        }

        private void Calculatorlabel1_Load(object sender, EventArgs e)
        {

        }

        private void Calculatorbutton7_Click(object sender, EventArgs e)
        {
            if (Calculatorentry1.Text == "" & Calculatorentry2.Text == "")
            {
                MessageBox.Show("Please enter the first number","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (Calculatorentry1.Text.Length > 0 & Calculatorentry2.Text.Length > 0)
            {
                MessageBox.Show("Please only enter the first number","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return ;
            }
            try
            {
                int number_1 = Convert.ToInt32(Calculatorentry1.Text);
                int total = number_1 * number_1;
                Calculatorentry3.Text = total.ToString();
            }catch
            {
                MessageBox.Show("Please enter valid numbers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Calculatorentry1.Text.Length == 0)
            {
                MessageBox.Show("Please enter all number", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Calculatorentry1.Text.Length > 0)
            {
                Calculatorentry1.Text = Calculatorentry1.Text.Substring(0, Calculatorentry1.Text.Length - 1);
            }
            
        }

        private void Calculatorbutton9_Click(object sender, EventArgs e)
        {
            if (Calculatorentry2.Text.Length == 0)
            {
                MessageBox.Show("Please enter all number", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Calculatorentry2.Text.Length > 0)
            {
                Calculatorentry2.Text = Calculatorentry2.Text.Substring(0, Calculatorentry2.Text.Length - 1);
            }
        }
    }
}
