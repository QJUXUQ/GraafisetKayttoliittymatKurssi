using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string text = "Valitse YES jatkaaksesi tai NO lopettaaksesi.";
            string title = "HUOM!";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult result;


            do
            {
                result = MessageBox.Show(text, title, button);
            }
            while (result == DialogResult.Yes); 
            
            if (result == DialogResult.No) 
            {
                this.Close();
            }
                
            
            
        }
    }
}
