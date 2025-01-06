using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary10
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> dictionary;
        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            dictionary = new Dictionary<string, string>();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string key =keyTextBox.Text;
            string value =valueTextBox.Text;
            
            if(string.IsNullOrWhiteSpace(key)||string.IsNullOrWhiteSpace(value) ) //tarkistetaan, että molemmat laatikot on täytetty
            {
                MessageBox.Show("Molemmat kentät täytyy olla täytettyinä!");
                return;
            }

            dictionary.Add(key, value);
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchKey=textBox3.Text;

            if (dictionary.ContainsKey(searchKey) ) 
            {
                label8.Text = dictionary[searchKey];
            }
        }
    }
}
