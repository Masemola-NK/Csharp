namespace CRUD_stored_procedures
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(223, 22);
            label1.Name = "label1";
            label1.Size = new Size(750, 26);
            label1.TabIndex = 0;
            label1.Text = "Employee Managament System {CRUD Stored Procedures} ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 9F);
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(112, 17);
            label2.TabIndex = 1;
            label2.Text = "Employee_ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Broadway", 9F);
            label3.Location = new Point(12, 147);
            label3.Name = "label3";
            label3.Size = new Size(143, 17);
            label3.TabIndex = 2;
            label3.Text = "Employee_Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Broadway", 9F);
            label4.Location = new Point(12, 207);
            label4.Name = "label4";
            label4.Size = new Size(171, 17);
            label4.TabIndex = 3;
            label4.Text = "Employee_Surname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Broadway", 9F);
            label5.Location = new Point(12, 263);
            label5.Name = "label5";
            label5.Size = new Size(194, 17);
            label5.TabIndex = 4;
            label5.Text = "Employee_Department";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Broadway", 9F);
            label6.Location = new Point(12, 326);
            label6.Name = "label6";
            label6.Size = new Size(197, 17);
            label6.TabIndex = 5;
            label6.Text = "Employee_Joining date";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(223, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(223, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(208, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(223, 207);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(208, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(223, 260);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(208, 27);
            textBox4.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Broadway", 12F);
            button1.Location = new Point(34, 455);
            button1.Name = "button1";
            button1.Size = new Size(157, 82);
            button1.TabIndex = 11;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 0);
            button2.Font = new Font("Broadway", 12F);
            button2.Location = new Point(252, 455);
            button2.Name = "button2";
            button2.Size = new Size(180, 82);
            button2.TabIndex = 12;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Fuchsia;
            button3.Font = new Font("Broadway", 12F);
            button3.Location = new Point(34, 586);
            button3.Name = "button3";
            button3.Size = new Size(157, 82);
            button3.TabIndex = 13;
            button3.Text = "Load*";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Broadway", 12F);
            button4.Location = new Point(252, 586);
            button4.Name = "button4";
            button4.Size = new Size(180, 82);
            button4.TabIndex = 14;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Broadway", 9F);
            label7.Location = new Point(12, 381);
            label7.Name = "label7";
            label7.Size = new Size(124, 17);
            label7.TabIndex = 15;
            label7.Text = "Employee_Sex";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(223, 326);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 27);
            dateTimePicker1.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(445, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(757, 582);
            dataGridView1.TabIndex = 18;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(220, 383);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(68, 21);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(335, 383);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(90, 21);
            radioButton2.TabIndex = 20;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 689);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Employee Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}
