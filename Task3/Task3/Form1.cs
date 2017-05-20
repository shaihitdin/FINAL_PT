using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        static int x = 0;

        public Form1()
        {
            InitializeComponent();
            button1.BackColor = Color.Red;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = (x + 1) % 3;
            if (x == 0)
            {
                button1.BackColor = Color.Red;
            }
            if (x == 1)
            {
                button1.BackColor = Color.Yellow;
            }
            if (x == 2)
            {
                button1.BackColor = Color.Blue;
            }
        }
    }
}
