using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture13
{
    public partial class Form1 : Form
    {
        private Bitmap kuva; 
        private Point piste=new Point(0,0);
        
        public Form1()
        {
            InitializeComponent();
            kuva = new Bitmap("D:\\Koulu\\Graafinen\\000-graafiset-kayttoliittymat-QJUXUQ\\13_Picture\\Picture13\\Resources\\picture04.png");
            kuva.MakeTransparent(Color.Blue);
            this.Paint += Form1_Paint;
            this.MouseDown += Form1_MouseDown;
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(kuva, piste.X,piste.Y);

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                piste = e.Location;
                Invalidate();
            }
        }
    }
}
