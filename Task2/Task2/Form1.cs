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
        public Form1()
        {
            InitializeComponent();
            Button[] b = new Button[9];
            int[] clicks = new int[9];
            for (int i = 0; i < 9; ++i)
                clicks[i] = 0;
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    b[i * 3 + j] = new Button();
                    b[i * 3 + j].Location = new Point(50 + 40 * j, 50 + 40 * i);
                    b[i * 3 + j].Size = new Size(30, 30);
                    b[i * 3 + j].Name = (i * 3 + j).ToString();
                    b[i * 3 + j].UseVisualStyleBackColor = true;
                }
            }
        }

    }
}
