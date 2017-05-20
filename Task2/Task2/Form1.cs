using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        static Button[] b = new Button[9];
        static int[] clicks = new int[9];

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 9; ++i)
                clicks[i] = 0;
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    b[i * 3 + j] = new Button();
                    b[i * 3 + j].Location = new Point(50 + 40 * j, 50 + 40 * i);
                    b[i * 3 + j].Size = new Size(35, 35);
                    b[i * 3 + j].Name = (i * 3 + j).ToString();
                    b[i * 3 + j].Text = "0";
                    b[i * 3 + j].UseVisualStyleBackColor = true;
                    b[i * 3 + j].Click += new System.EventHandler(new System.EventHandler(this.button1_Click));
                    Controls.Add(b[i * 3 + j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; ++i)
            {
                if (sender == b[i])
                {
                    ++clicks[i];
                    if (clicks[i] % 2 == 0)
                    {
                        int now = Convert.ToInt32(textBox1.Text);
                        now++;
                        textBox1.Text = now.ToString();
                    }
                    b[i].Text = clicks[i].ToString();
                }
            }

        }
    }
}
