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
        public Form1()
        {
            InitializeComponent();
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

            if (textBox1.Text.Length > 1)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            else
            {
                button3.PerformClick();
                isFirstInput=true;
            }


        }

        private void Keybord_Input(object sender, KeyEventArgs e)
        {
            foreach (Button b in tableLayoutPanel1.Controls.OfType<Button>())
            {
                if (e.KeyCode.ToString() == b.Text)
                {
                    b.PerformClick();
                    break;
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
    }
}
