namespace Practica1_Do_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            do
            {
                listBox1.Items.Add(x);
                x++;
            } while (x <= 10);
        }
    }
}
