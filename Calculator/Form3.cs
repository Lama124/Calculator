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
    public partial class Form3 : Form
    {
        bool isFirstInput = true;
        int commonFontSize = 34;
        public Form3()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 2;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

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
                        return Convert.ToString(firstNum); //см
                    case 1:
                        return Convert.ToString(Math.Round(firstNum * 0.01, 5)); //м 
                    case 2:
                        return Convert.ToString(Math.Round(firstNum * 0.00001, 5)); //км
                    case 3:
                        return Convert.ToString(Math.Round(firstNum * 0.000006, 5)); //мили
                    case 4:
                        return Convert.ToString(Math.Round(firstNum * 0.0328, 5)); // футы
                }

            }
            if (firstValue == 1)
            {
                switch (secondValue)
                {
                    case 0:
                        return Convert.ToString(Math.Round(firstNum * 100, 5));
                    case 1:
                        return Convert.ToString(firstNum);
                    case 2:
                        return Convert.ToString(Math.Round(firstNum * 0.001, 5));
                    case 3:
                        return Convert.ToString(Math.Round(firstNum * 0.00062, 5));
                    case 4:
                        return Convert.ToString(Math.Round(firstNum * 3.28, 5));

                }

            }
            if (firstValue == 2)
            {
                switch (secondValue)
                {
                    case 0:
                        return Convert.ToString(Math.Round(firstNum * 100000, 4));
                    case 1:
                        return Convert.ToString(Math.Round(firstNum * 1000, 4));
                    case 2:
                        return Convert.ToString(firstNum);
                    case 3:
                        return Convert.ToString(Math.Round(firstNum * 0.62, 4));
                    case 4:
                        return Convert.ToString(Math.Round(firstNum * 3280.84, 4));

                }
            }
            if (firstValue == 3)
            {
                switch (secondValue)
                {
                    case 0:
                        return Convert.ToString(Math.Round(firstNum * 160934.4, 4));
                    case 1:
                        return Convert.ToString(Math.Round(firstNum * 1609, 4));
                    case 2:
                        return Convert.ToString(Math.Round(firstNum * 1.609, 4));
                    case 3:
                        return Convert.ToString(firstNum);
                    case 4:
                        return Convert.ToString(Math.Round(firstNum * 5280, 4));

                }
            }
            if (firstValue == 4)
            {
                switch (secondValue)
                {
                    case 0:
                        return Convert.ToString(Math.Round(firstNum * 30.48, 4));
                    case 1:
                        return Convert.ToString(Math.Round(firstNum * 0.3048, 4));
                    case 2:
                        return Convert.ToString(Math.Round(firstNum * 0.00031, 4));
                    case 3:
                        return Convert.ToString(Math.Round(firstNum * 0.000189, 4));
                    case 4:
                        return Convert.ToString(firstNum);

                }
            }
            return "";
        }

        //Выбор режима
        private void обычныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void скоростьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        private void углыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int growFontSize = commonFontSize, reduceFontSize = commonFontSize;
            if (textBox2.Text.Length > 10)
            {
                growFontSize -= 4;
                textBox2.Font = new Font("Consolas", growFontSize, FontStyle.Regular);
            }
            else if (textBox2.Text.Length <= 10)
            {
                textBox2.Font = new Font("Consolas", reduceFontSize, FontStyle.Regular);
            }
            if (textBox2.Text.Length > 12)
            {
                growFontSize -= 4;
                textBox2.Font = new Font("Consolas", growFontSize, FontStyle.Regular);
            }
            if (textBox2.Text.Length > 17)
            {
                growFontSize -= 4;
                textBox2.Font = new Font("Consolas", growFontSize, FontStyle.Regular);
            }
        }
    }
}
