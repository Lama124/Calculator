﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form4 : Form
    {
        bool isFirstInput = true;
        int commonFontSize = 34;
        public Form4()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
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
                        return Convert.ToString(firstNum); //градусы
                    case 1:
                        return Convert.ToString(Math.Round(firstNum * 0.017453, 6)); //радианы 
                    case 2:
                        return Convert.ToString(Math.Round(firstNum * 1.111111, 6)); //градианы
                }

            }
            if (firstValue == 1)
            {
                switch (secondValue)
                {
                    case 0:
                        return Convert.ToString(Math.Round(firstNum * 57.2957, 6));
                    case 1:
                        return Convert.ToString(firstNum);
                    case 2:
                        return Convert.ToString(Math.Round(firstNum * 63.66198, 6));

                }

            }
            if (firstValue == 2)
            {
                switch (secondValue)
                {
                    case 0:
                        return Convert.ToString(Math.Round(firstNum * 0.9, 6));
                    case 1:
                        return Convert.ToString(Math.Round(firstNum * 0.015708, 6));
                    case 2:
                        return Convert.ToString(firstNum);

                }
            }
          
            return "";
        }

        //Выбор режима
        private void скоростьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void обычныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void скоростьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void длиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"
Версия программы: alpha
Разработчик: Вердыш Дмитрий (Lama124)
Примечание: Во всех кроме классического режима используется округление до 4 или 6 знаков после запятой.", "Информация", new MessageBoxButtons(), MessageBoxIcon.Information);
        }

        private void сохранитьРезультатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Contains("="))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveFileDialog.FileName = "Result";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    streamWriter.WriteLine($"{textBox1.Text} {comboBox1.Text} = {textBox2.Text} {comboBox2.Text}");
                    streamWriter.Close();
                }
            }
            else
                MessageBox.Show("Невозможно сохранить результат.\nПример не является полным\nнеобходимо нажать кнопку \"=\"", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Contains("="))
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                PrintPreviewDialog dlg = new PrintPreviewDialog();
                dlg.Document = printDocument;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            else
                MessageBox.Show("Невозможно напечатать результат.\nПример не является полным\nнеобходимо нажать кнопку \"=\"", "Ошибка печати", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string result = $"{textBox1.Text} {comboBox1.Text} = {textBox2.Text} {comboBox2.Text}";
            e.Graphics.DrawString(result, new Font("Consolas", 14), Brushes.Black, new Point(10, 10));
        }

    }
}
