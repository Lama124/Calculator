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
    public partial class Form1 : Form
    {
        bool isFirstInput = true;
        int commonFontSize = 34;

        public Form1()
        {
            InitializeComponent();
        }

        //Ввод с клавиатуры
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string key = e.KeyCode.ToString();
            int temp;

            if (e.KeyCode.Equals(Keys.Back))
                button5.PerformClick();
            if (e.KeyCode.Equals(Keys.Oemplus) || e.KeyCode.Equals(Keys.Add))
                button21.PerformClick();
            if (e.KeyCode.Equals(Keys.OemMinus) || e.KeyCode.Equals(Keys.Subtract))
                button17.PerformClick();
            if (e.KeyCode.Equals(Keys.OemQuestion) || e.KeyCode.Equals(Keys.Divide))
                button9.PerformClick();
            if (e.KeyCode.Equals(Keys.Oemcomma) || e.KeyCode.Equals(Keys.Decimal))
                button20.PerformClick();
            if ((e.Shift && e.KeyCode.Equals(Keys.D8)) || e.KeyCode.Equals(Keys.Multiply))
            {
                button13.PerformClick();
                key = " ";
            }

            if (key.Contains("D") && key.Length == 2)
            {
                int.TryParse(key.Remove(0, 1), out temp);
                foreach (Button b in tableLayoutPanel1.Controls.OfType<Button>())
                {
                    if (Convert.ToString(temp) == b.Text)
                    {
                        b.PerformClick();
                        break;
                    }
                }
            }
            if (key.Contains("NumPad"))
            {
                int.TryParse(key.Remove(0, 6), out temp);
                foreach (Button b in tableLayoutPanel1.Controls.OfType<Button>())
                {
                    if (Convert.ToString(temp) == b.Text)
                    {
                        b.PerformClick();
                        break;
                    }
                }
            }
        }

        //Цифровые кнопки
        private void NumButtons(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains("="))
                button4.PerformClick();
            if (textBox1.Text.Length <= 16)
            {
                Button b = (Button)sender;
                if (isFirstInput)
                {
                    if (b.Text != "0")
                    {
                        textBox1.Text = b.Text;
                        isFirstInput = false;

                    }
                }
                else
                {
                    textBox1.Text += b.Text;
                }
            }

        }

        //Кнопка запятой
        private void button20_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
                isFirstInput = false;
            }
        }

        //Кнопка +/-
        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                if (textBox1.Text[0] != '-')
                    textBox1.Text = textBox1.Text.Insert(0, "-");
                else
                    textBox1.Text = textBox1.Text.Remove(0, 1);
            }
        }

        //Кнопка С
        private void ClearAll(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            isFirstInput = true;
        }

        //Кнопка СЕ
        private void ClearEntry(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            isFirstInput = true;
        }

        //Кнопка стереть
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1 && textBox1.Text != "0,")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            else
            {

                button3.PerformClick();
                isFirstInput = true;
            }
        }

        //Обработчик для математических операторов
        private void Math_Operator(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox2.Text.Length == 0 || textBox2.Text.Contains("=") || isFirstInput)
            {
                textBox2.Text = textBox1.Text + b.Text;
                isFirstInput = true;
            }
            else
            {
                button1.PerformClick();
                textBox2.Text = textBox1.Text + b.Text;
                isFirstInput = true;
            }
        }

        //Кнопка равно
        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Contains("="))
            {
                string result = FindResult();
                if (result != "Ошибка")
                {
                    textBox2.Text += textBox1.Text + "=";
                    textBox1.Text = result;
                }
            }
        }

        string FindResult()
        {
            if (textBox2.Text.Length > 0)
            {
                double firstNum = double.Parse(textBox2.Text.Remove(textBox2.Text.Length - 1));
                double secondNum = double.Parse(textBox1.Text);
                char mathOperator = textBox2.Text[textBox2.Text.Length - 1];
                switch (mathOperator)
                {
                    case '+': return Convert.ToString(firstNum + secondNum);
                    case '-': return Convert.ToString(firstNum - secondNum);
                    case '*': return Convert.ToString(firstNum * secondNum);
                    case '/':
                        if (secondNum != 0)
                            return Convert.ToString(firstNum / secondNum);
                        else
                        { isFirstInput = true; return "Деление на ноль невозможно"; }

                }

            }
            return "Ошибка";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int growFontSize = commonFontSize, reduceFontSize = commonFontSize;
            if (textBox1.Text.Length > 10)
            {
                growFontSize -= 4;
                textBox1.Font = new Font("Consolas", growFontSize, FontStyle.Regular);
            }
            else if (textBox1.Text.Length <= 10)
            {
                textBox1.Font = new Font("Consolas", reduceFontSize, FontStyle.Regular);
            }
            if (textBox1.Text.Length > 12)
            {
                growFontSize -= 4;
                textBox1.Font = new Font("Consolas", growFontSize, FontStyle.Regular);
            }
            if(textBox1.Text.Length > 17)
            {
                growFontSize -= 4;
                textBox1.Font = new Font("Consolas", growFontSize, FontStyle.Regular);

            }
        }

        private void скоростьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
