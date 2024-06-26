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
    public partial class Form2 : Form
    {

        bool isFirstInput = true;
        int commonFontSize = 34;
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public Form2()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 2;

        }


        //Ввод с клавиатуры
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string key = e.KeyCode.ToString();
            int temp;

            if (e.KeyCode.Equals(Keys.Back))
                button5.PerformClick();
            if (e.KeyCode.Equals(Keys.Oemcomma) || e.KeyCode.Equals(Keys.Decimal))
                button20.PerformClick();

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

        //Кнопка С
        private void ClearAll(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "Нажмите \"=\"";
            isFirstInput = true;
        }

        //Кнопка стереть
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1 && textBox1.Text != "0,")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            else
            {
                button4.PerformClick();
                isFirstInput = true;
            }
        }
        //Кнопка равно
        private void button1_Click(object sender, EventArgs e)
        {
            string result = convertValue();
            textBox2.Text = result;
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
            if (textBox1.Text.Length > 17)
            {
                growFontSize -= 4;
                textBox1.Font = new Font("Consolas", growFontSize, FontStyle.Regular);

            }
        }

        string convertValue()
        {
            double firstNum = double.Parse(textBox1.Text);
            int firstValue = comboBox1.SelectedIndex;
            int secondValue = comboBox2.SelectedIndex;

            if (firstValue == 0)
            {
                switch (secondValue)
                {
                    case 0:
                        return Convert.ToString(firstNum);// км/ч
                    case 1:
                        return Convert.ToString(Math.Round(firstNum / 3.6f, 4)); // м/с
                    case 2:
                        return Convert.ToString(Math.Round(firstNum * 0.911, 4));// ф/с
                    case 3:
                        return Convert.ToString(Math.Round(firstNum * 0.621, 4)); // миль/ч
                    case 4:
                        return Convert.ToString(Math.Round(firstNum * 0.54, 4));// узлов
                }

            }
            if (firstValue == 1)
            {
                switch (secondValue)
                {
                    case 0:
                        return Convert.ToString(Math.Round(firstNum * 3.6, 4));
                    case 1:
                        return Convert.ToString(firstNum);
                    case 2:
                        return Convert.ToString(Math.Round(firstNum * 3.28, 4));
                    case 3:
                        return Convert.ToString(Math.Round(firstNum * 2.23, 4));
                    case 4:
                        return Convert.ToString(Math.Round(firstNum * 1.94, 4));

                }

            }
            if (firstValue == 2)
            {
                switch (secondValue)
                {
                    case 0:
                        return Convert.ToString(Math.Round(firstNum * 1.09, 4));
                    case 1:
                        return Convert.ToString(Math.Round(firstNum * 0.3, 4));
                    case 2:
                        return Convert.ToString(firstNum);
                    case 3:
                        return Convert.ToString(Math.Round(firstNum * 0.68, 4));
                    case 4:
                        return Convert.ToString(Math.Round(firstNum * 0.59, 4));

                }
            }
            if (firstValue == 3)
            {
                switch (secondValue)
                {
                    case 0:
                        return Convert.ToString(Math.Round(firstNum * 1.6, 4));
                    case 1:
                        return Convert.ToString(Math.Round(firstNum * 0.44, 4));
                    case 2:
                        return Convert.ToString(Math.Round(firstNum * 1.46, 4));
                    case 3:
                        return Convert.ToString(firstNum);
                    case 4:
                        return Convert.ToString(Math.Round(firstNum * 0.87, 4));

                }
            }
            if (firstValue == 4)
            {
                switch (secondValue)
                {
                    case 0:
                        return Convert.ToString(Math.Round(firstNum * 1.85, 4));
                    case 1:
                        return Convert.ToString(Math.Round(firstNum * 0.51, 4));
                    case 2:
                        return Convert.ToString(Math.Round(firstNum * 1.68, 4));
                    case 3:
                        return Convert.ToString(Math.Round(firstNum * 1.15, 4));
                    case 4:
                        return Convert.ToString(firstNum);

                }
            }
            return "";
        }
    }
}