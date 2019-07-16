using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsForms1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(RemoveNewLine(textBox2.Text));
                Result2.Text = Result.Text[i].ToString();
            }
            catch (FormatException fex)
            {
                Result.Text = fex.Message;
            }
            catch (OverflowException oex)
            {
                Result.Text = oex.Message;
            }
            catch (IndexOutOfRangeException iex)
            {
                Result.Text = iex.Message;
            }
            catch (Exception ex)
            {
                Result.Text = ex.Message;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a = 0;
            foreach (char c in Result.Text)
            {
                if ((c == 'a') || (c == 'u') || (c == 'o') || (c == 'e') || (c == 'i') || (c == 'y'))
                {
                    a++;
                }

                Result.Text = a.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Result.Text = "Введите новую строку";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result.Text = Convert.ToString(Result.TextLength);
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Result.Text = Result.Text.Replace(RemoveNewLine(textBox2.Text), RemoveNewLine(Result2.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = 0;
            foreach (char c in Result.Text)
            {
                if ((c == 'q') || (c == 'w') || (c == 'r') || (c == 't') || (c == 'p') || (c == 's') || (c == 'd') || (c == 'f') || (c == 'g') || (c == 'h') || (c == 'j') || (c == 'k') || (c == 'l') || (c == 'z') || (c == 'x') || (c == 'c') || (c == 'v') || (c == 'b') || (c == 'n') || (c == 'm'))
                {
                    a++;
                }

                Result.Text = a.ToString();
            }
        }

        private string RemoveNewLine(string s)
        {
           return  s.Replace("\r\n", "");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Result.Text = Result.Text.Replace(RemoveNewLine(textBox2.Text), "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 1;
            foreach (char c in Result.Text)
            {
                if (c == ' ')
                {
                    a++;
                }
            }

            Result.Text = a.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = 0;
            foreach (char c in Result.Text)
            {
                if (c == '.')
                {
                    a++;
                }
            }

            Result.Text = a.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 Myform2 = new Form2();
            Myform2.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
