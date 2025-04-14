namespace Practica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radius, height, baseArea, Lateralarea, Totalarea, volumen;
            radius = double.Parse(textBox1.Text);
            height = double.Parse(textBox2.Text);

            baseArea = radius * radius * Math.PI;
            Lateralarea = 2 * Math.PI * radius * Height;
            Totalarea = 2 * Math.PI * radius * (Height + radius);
            volumen = Math.PI * radius * radius * height;
            textBox3.Text = baseArea.ToString("0.##");
            textBox4.Text = Lateralarea.ToString("0.##");
            textBox5.Text = Totalarea.ToString("0.##");
            textBox6.Text = volumen.ToString("0.##");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
