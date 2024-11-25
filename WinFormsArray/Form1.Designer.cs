namespace WinFormsArray
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 47);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(248, 110);
            button1.TabIndex = 0;
            button1.Text = "Array1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(30, 196);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(248, 110);
            button2.TabIndex = 1;
            button2.Text = "Array2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(300, 58);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 549);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(790, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(252, 559);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(322, 24);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 5;
            label3.Text = "พิมพ์รายชื่อ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(790, 24);
            label4.Name = "label4";
            label4.Size = new Size(120, 21);
            label4.TabIndex = 6;
            label4.Text = "รายชื่อที่บันทึกแล้ว";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(632, 96);
            button3.Name = "button3";
            button3.Size = new Size(151, 112);
            button3.TabIndex = 7;
            button3.Text = "GetData";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(632, 271);
            button4.Name = "button4";
            button4.Size = new Size(148, 102);
            button4.TabIndex = 8;
            button4.Text = "GetNumber";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(30, 356);
            button5.Name = "button5";
            button5.Size = new Size(242, 104);
            button5.TabIndex = 9;
            button5.Text = "Array 2 มิติ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1070, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 28);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(1070, 155);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(194, 124);
            listBox1.TabIndex = 11;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(1070, 339);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(194, 148);
            checkedListBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 702);
            Controls.Add(checkedListBox1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button button3;
        private Button button4;
        private Button button5;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private CheckedListBox checkedListBox1;
    }
}
