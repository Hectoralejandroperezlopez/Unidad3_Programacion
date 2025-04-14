namespace Practica5
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 32);
            label1.TabIndex = 0;
            label1.Text = "Area Triangulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 142);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 1;
            label2.Text = "BASE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            label3.Location = new Point(4, 227);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 2;
            label3.Text = "ALTURA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            label4.Location = new Point(12, 312);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 3;
            label4.Text = "AREA";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            button1.Location = new Point(192, 400);
            button1.Name = "button1";
            button1.Size = new Size(150, 34);
            button1.TabIndex = 4;
            button1.Text = "RESULTADO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            textBox1.Location = new Point(192, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            textBox2.Location = new Point(192, 221);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold);
            textBox3.Location = new Point(192, 306);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 7;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(463, 400);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 8;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(587, 446);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
    }
}
