using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.CreateGraphics();
                /*
                 * Bitmap
                 * fromImage
                 * creategraphics (unnecessary)
                 * no circle
                 * 
                 * 
                 * */
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            g.Draw
        }
    }
}
