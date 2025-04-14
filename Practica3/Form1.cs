using System.Diagnostics;

namespace Practica3
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text); 
            int sum = num1 + num2;
            label3.Text = "sum = " + sum;  
         }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
