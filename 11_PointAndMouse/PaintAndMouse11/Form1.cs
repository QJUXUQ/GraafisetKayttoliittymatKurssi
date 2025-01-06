using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintAndMouse11
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        public Form1()
        {
            InitializeComponent();

            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
            
        }

        Point piste = new Point(0, 0);

        // Talletetaan grafiikkaobjekti. Grafiikkaobjekti tarvitaan 

        // grafikan piirtämiseksi näytölle. 

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Graf = e.Graphics;

            // - Pää 

            Graf.FillEllipse(Brushes.IndianRed, piste.X - 4, piste.Y - 8, 49, 49);

            Graf.DrawEllipse(Pens.Black, piste.X - 4, piste.Y - 8, 49, 49);

            // - Selkä 

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 41,

            piste.X + 21, piste.Y + 131);

            // - Kädet 

            Graf.DrawLine(Pens.Black, piste.X - 30, piste.Y + 60,

            piste.X + 70, piste.Y + 60);

            // - Jalat 

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,

            piste.X - 30, piste.Y + 181);

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,

            piste.X + 70, piste.Y + 181);



            // Kutsutaan DrawCoordinates()-metodia. 

            DrawCoordinates(Graf);

        }

        // DrawCoordinates() -metodi PIIRTÄÄ pisteen koordinaatit lomakkeelle. 

        private void DrawCoordinates(Graphics Graf)

        {

            // Piirretään piirtokoordinaattien arvot näytölle. 

            Graf.DrawString("(" + piste.X + " ," + piste.Y + ")",

                            new Font("Arial", 14, System.Drawing.FontStyle.Regular),

                            new SolidBrush(Color.Black),ClientSize.Width -100, ClientSize.Height-30);

        }

        private void piirraButton_Click(object sender, EventArgs e)
        {
            int x=int.Parse(textBoxX.Text);
            int y=int.Parse(textBoxY.Text);
            piste=new Point(x,y);
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                // Talletetaan hiiren klikkauskohdan koordinaatit. Piste (0, 0) 

                // on formin työalueen vasemmassa ylä nurkassa 

                piste = e.Location;
                dragging=true;


                // Merkitään formin työalue epäkelvoksi, jolloin saadaan aikaiseksi 

                // paint-eventin signalointi ja tämän jälkeen Paint()-metodin kutsu. 

                Invalidate();

            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging) 
            {
                piste=e.Location;
                Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left) 
            {
                dragging=false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) 
            {
                piste.X -= 1;

            }else if (e.KeyCode == Keys.D) 
            {
                piste.X += 1;

            }else if(e.KeyCode == Keys.W) 
            {
                piste.Y -= 1;

            }else if(e.KeyCode == Keys.S) 
            {
                piste.Y += 1;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Invalidate();
        }
    }

}

