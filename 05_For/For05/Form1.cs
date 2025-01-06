using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private async void button1_Click(object sender, EventArgs e)
        {
            string input=textBox1.Text;
            int number;



            if (int.TryParse(input, out number))
            {
                for (int i = 0; i <= number; i++)
                {
                    label1.Text = i.ToString();

                    Thread.Sleep(1000); //odotetaan sekuntti kunnes päivitetään numero
                    label1.Update();
                }
            }
        }
    }
}
