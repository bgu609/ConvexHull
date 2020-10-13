using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graphic01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Graphics graphics = CreateGraphics();
            Show();

            Pen BluePen = new Pen(Color.Blue, 3);
            graphics.DrawLine(BluePen, 20, 70, 30, 80);
            graphics.DrawLine(BluePen, 30, 80, 40, 70);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
