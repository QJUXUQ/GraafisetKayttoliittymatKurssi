using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array07
{
    public partial class Form1 : Form
    {
        private int[] numbers;
        public Form1()
        {
            InitializeComponent();
        }

        private void createChartB_Click(object sender, EventArgs e)
        {

            int taulunKoko = Convert.ToInt32(chartBox.Text);
            numbers = new int[taulunKoko];
            
            
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            int savedNumber=Convert.ToInt32(saveNumBox.Text);
            int indexNumber=Convert.ToInt32(indexBox.Text) -1; //miinustetaan, että lista on kuin se alkaisi 1 eikä 0
            
            if(indexNumber>=0 && indexNumber< numbers.Length) 
            {
                numbers[indexNumber] = savedNumber;
                
            }
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            int indexNumber=Convert.ToInt32(searchBox.Text) -1; //-1, että saadaan käyttäjän antama numero, kun etsitään viimeistä indeksin numeroa

            if (indexNumber>=0 &&indexNumber< numbers.Length) 
            {
                int foundNumber = numbers[indexNumber];
                label8.Text = foundNumber.ToString();
            }
        }
    }
}
