namespace WinFormsArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] student = new String[5];
            student[0] = "เจ๋ง";
            student[1] = "เจ๋งแจ๋ว";
            student[2] = "เจ๋งจัด";
            student[3] = "เจ๋งดี";
            student[4] = "เจ๋งมาก";
            string test = "";
            int n = student.Length; // หาขนาดของ Array
            for (int i = 0; i < n; i++)
            {
                test += student[i] + Environment.NewLine;
            }
            MessageBox.Show(test);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Fruite = { "แดง", "เขียว", "ดำ", "ชมพู", "น้ำเงิน" };
            string myFruite = "";
            foreach (string str in Fruite)
            {
                myFruite += str + ",";
            }
            MessageBox.Show(myFruite, "สีของฉัน");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines; // นำข้อมูลแต่ละบรรทัดไปใส่ใน Array
            string result = "";
            foreach (string str in data)
            {
                if (str != "")
                {
                    result += str + Environment.NewLine;
                }

            }
            label1.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;
            string result = "";
            int sum = 0;
            foreach (var str in data)
            {
                int x = 0;
                if (int.TryParse(str, out x))
                {
                    sum += x;
                    result += x.ToString() + Environment.NewLine;

                }

            }
            label1.Text = result;
            MessageBox.Show(sum.ToString(), "ผลรวมตัวเลข");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[,] student = new string[3, 2];
            student[0, 0] = "เจ๋ง";
            student[0, 1] = "เลย";
            student[1, 0] = "เจ๋งจัด";
            student[1, 1] = "หนองคาย";
            student[2, 0] = "เจ๋งมาก";
            student[2, 1] = "โคราช";
            string ResultData = "";
            int m = student.GetLength(0);
            int n = student.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ResultData += student[i, j] + "_";
                }
                ResultData += Environment.NewLine;
            }
            MessageBox.Show(ResultData, "แสดงข้อมูลใน Array 2 มิติ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Fruite = { "แดง", "เขียว", "ดำ", "ชมพู", "น้ำเงิน" };
            comboBox1.Items.AddRange(Fruite);
            listBox1.Items.AddRange(Fruite);
            checkedListBox1.Items.AddRange(Fruite);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedIndex.ToString() + "_";
            str += comboBox1.SelectedItem;
            MessageBox.Show(str);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedIndex.ToString() + "_";
            str += comboBox1.SelectedItem;
            MessageBox.Show(str);
        }
    }
}
