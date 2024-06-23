namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мамаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скоростьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.площадьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.длиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.весИМассаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 392);
            this.panel1.MaximumSize = new System.Drawing.Size(660, 60);
            this.panel1.MinimumSize = new System.Drawing.Size(294, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 50);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keybord_Input);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button9, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button11, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button12, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button13, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button14, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button15, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button16, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button17, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button18, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button19, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button20, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button21, 3, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 174);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 218);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Bisque;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 37);
            this.button2.TabIndex = 20;
            this.button2.Text = "%";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keybord_Input);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Bisque;
            this.button3.Location = new System.Drawing.Point(76, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 37);
            this.button3.TabIndex = 1;
            this.button3.Text = "CE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ClearEntry);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Orange;
            this.button4.Location = new System.Drawing.Point(149, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 37);
            this.button4.TabIndex = 2;
            this.button4.Text = "C";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ClearAll);
            this.button4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keybord_Input);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Consolas", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Bisque;
            this.button5.Location = new System.Drawing.Point(222, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 37);
            this.button5.TabIndex = 3;
            this.button5.Text = "⌫";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Bisque;
            this.button6.Location = new System.Drawing.Point(3, 46);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 37);
            this.button6.TabIndex = 4;
            this.button6.Text = "7";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.NumButtons);
            this.button6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keybord_Input);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Bisque;
            this.button7.Location = new System.Drawing.Point(76, 46);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 37);
            this.button7.TabIndex = 5;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.NumButtons);
            this.button7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keybord_Input);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Bisque;
            this.button8.Location = new System.Drawing.Point(149, 46);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 37);
            this.button8.TabIndex = 6;
            this.button8.Text = "9";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.NumButtons);
            this.button8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keybord_Input);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Bisque;
            this.button9.Location = new System.Drawing.Point(222, 46);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(69, 37);
            this.button9.TabIndex = 7;
            this.button9.Text = "/";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keybord_Input);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Bisque;
            this.button10.Location = new System.Drawing.Point(3, 89);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(67, 37);
            this.button10.TabIndex = 8;
            this.button10.Text = "4";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.NumButtons);
            this.button10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keybord_Input);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.Bisque;
            this.button11.Location = new System.Drawing.Point(76, 89);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(67, 37);
            this.button11.TabIndex = 9;
            this.button11.Text = "5";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.NumButtons);
            this.button11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keybord_Input);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Bisque;
            this.button12.Location = new System.Drawing.Point(149, 89);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(67, 37);
            this.button12.TabIndex = 10;
            this.button12.Text = "6";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.NumButtons);
            this.button12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keybord_Input);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.Bisque;
            this.button13.Location = new System.Drawing.Point(222, 89);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(69, 37);
            this.button13.TabIndex = 11;
            this.button13.Text = "*";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keybord_Input);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.Bisque;
            this.button14.Location = new System.Drawing.Point(3, 132);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(67, 37);
            this.button14.TabIndex = 12;
            this.button14.Text = "1";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.NumButtons);
            this.button14.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keybord_Input);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.Bisque;
            this.button15.Location = new System.Drawing.Point(76, 132);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(67, 37);
            this.button15.TabIndex = 13;
            this.button15.Text = "2";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.NumButtons);
            this.button15.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keybord_Input);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.Bisque;
            this.button16.Location = new System.Drawing.Point(149, 132);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(67, 37);
            this.button16.TabIndex = 14;
            this.button16.Text = "3";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.NumButtons);
            this.button16.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keybord_Input);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Transparent;
            this.button17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.Bisque;
            this.button17.Location = new System.Drawing.Point(222, 132);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(69, 37);
            this.button17.TabIndex = 15;
            this.button17.Text = "-";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keybord_Input);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Transparent;
            this.button18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.Bisque;
            this.button18.Location = new System.Drawing.Point(3, 175);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(67, 40);
            this.button18.TabIndex = 16;
            this.button18.Text = "+/-";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keybord_Input);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Transparent;
            this.button19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.Bisque;
            this.button19.Location = new System.Drawing.Point(76, 175);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(67, 40);
            this.button19.TabIndex = 17;
            this.button19.Text = "0";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.NumButtons);
            this.button19.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keybord_Input);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Transparent;
            this.button20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button20.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.Color.Bisque;
            this.button20.Location = new System.Drawing.Point(149, 175);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(67, 40);
            this.button20.TabIndex = 18;
            this.button20.Text = ",";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            this.button20.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keybord_Input);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Transparent;
            this.button21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.button21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(184)))));
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.Bisque;
            this.button21.Location = new System.Drawing.Point(222, 175);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(69, 40);
            this.button21.TabIndex = 19;
            this.button21.Text = "+";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keybord_Input);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(0, 119);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(294, 57);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(202)))), ((int)(((byte)(209)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.Location = new System.Drawing.Point(0, 98);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(294, 21);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "123+";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(294, 27);
            this.menuStrip1.TabIndex = 22;
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мамаToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.помощьToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.помощьToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.помощьToolStripMenuItem.Text = "Меню";
            // 
            // мамаToolStripMenuItem
            // 
            this.мамаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скоростьToolStripMenuItem,
            this.площадьToolStripMenuItem,
            this.длиныToolStripMenuItem,
            this.весИМассаToolStripMenuItem});
            this.мамаToolStripMenuItem.Name = "мамаToolStripMenuItem";
            this.мамаToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.мамаToolStripMenuItem.Text = "Сменить Режим";
            // 
            // скоростьToolStripMenuItem
            // 
            this.скоростьToolStripMenuItem.Name = "скоростьToolStripMenuItem";
            this.скоростьToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.скоростьToolStripMenuItem.Text = "Скорость";
            // 
            // площадьToolStripMenuItem
            // 
            this.площадьToolStripMenuItem.Name = "площадьToolStripMenuItem";
            this.площадьToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.площадьToolStripMenuItem.Text = "Объём";
            // 
            // длиныToolStripMenuItem
            // 
            this.длиныToolStripMenuItem.Name = "длиныToolStripMenuItem";
            this.длиныToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.длиныToolStripMenuItem.Text = "Длины";
            // 
            // весИМассаToolStripMenuItem
            // 
            this.весИМассаToolStripMenuItem.Name = "весИМассаToolStripMenuItem";
            this.весИМассаToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.весИМассаToolStripMenuItem.Text = "Вес и масса";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(294, 441);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(675, 640);
            this.MinimumSize = new System.Drawing.Size(310, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мамаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скоростьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem площадьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem длиныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem весИМассаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

