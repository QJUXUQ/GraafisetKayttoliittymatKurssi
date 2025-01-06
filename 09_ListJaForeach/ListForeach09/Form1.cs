using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListForeach09
{
    public partial class Form1 : Form
    {
        private List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void createList_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            list.Add(textBox1.Text);
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            foreach (string item in list) 
            {
                comboBox1.Items.Add(item);
            }
        }
    }
}
