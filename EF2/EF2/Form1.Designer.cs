namespace EF2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            comboBox1 = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(658, 451);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.MouseDown += dataGridView1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(709, 32);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 1;
            label1.Text = "Search (Fname)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(709, 117);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(709, 174);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(709, 228);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 4;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(709, 289);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 5;
            label5.Text = "Salary";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(826, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(826, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(826, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(826, 225);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(161, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(826, 286);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(161, 27);
            textBox5.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(1032, 29);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(709, 451);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "create";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(873, 451);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 13;
            button3.Text = "update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1032, 451);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 14;
            button4.Text = "delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(709, 400);
            button5.Name = "button5";
            button5.Size = new Size(159, 29);
            button5.TabIndex = 15;
            button5.Text = "get all employees";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(826, 352);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(161, 28);
            comboBox1.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(709, 355);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 17;
            label6.Text = "Department";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private ComboBox comboBox1;
        private Label label6;
    }
}
