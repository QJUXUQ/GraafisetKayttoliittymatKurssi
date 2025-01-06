using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _01Form
{
    public partial class Form1 : Form
    {
        //Asetetaan oletusarvot laatikoille
        private string defaultID = "0";
        private string defaultName = "[Syötä elokuvan nimi]";
        private string defaultYear = DateTime.Now.Year.ToString()+" ";
        private string defaultDuration = "0"+" ";
        private string defaultReview = "[Kirjoita arvio tähän]";
        public Form1()
        {
            InitializeComponent();

            textBoxName.Click += TextBox_Click;
            textBoxYear.Click += TextBox_Click;
            textBoxDuration.Click += TextBox_Click;
            richTextBoxReview.Click += RichTextBox_Click;

            textBoxID.Leave += TextBox_Leave;
            textBoxName.Leave += TextBox_Leave;
            textBoxYear.Leave += TextBox_Leave;
            textBoxDuration.Leave += TextBox_Leave;
            richTextBoxReview.Leave += RichTextBox_Leave;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string name = textBoxName.Text;
            string year = textBoxYear.Text;
            string duration = textBoxDuration.Text;
            string review = richTextBoxReview.Text;
            int rating = (int)numericUpDownRating.Value;
            if (string.IsNullOrWhiteSpace(name)||name==defaultName) 
            {
                MessageBox.Show("Et ole syöttänyt nimeä!");

            }else if (string.IsNullOrWhiteSpace(year) || year == defaultYear)
            {
                MessageBox.Show("Et ole syöttänyt mitään Julkaisuvuosi-kenttään!");

            }
            else if (!int.TryParse(year,out _)) 
            {
                MessageBox.Show("Julkaisuvuosi ei ole vain numeroita!");
            }else if (string.IsNullOrWhiteSpace(duration)||duration==defaultDuration) 
            {
                MessageBox.Show("Et ole syöttänyt mitään kesto-kenttään!");
            }else if (!int.TryParse(duration,out _)) 
            {
                MessageBox.Show("Kesto-kenttä ei ole pelkkiä numeroita!");
            }
            else { MessageBox.Show("Kaikki OK!"); }


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void newInfo_Click(object sender, EventArgs e)
        {
            
            textBoxID.Text = defaultID;
            textBoxName.Text = defaultName;
            textBoxYear.Text = defaultYear;
            textBoxDuration.Text = defaultDuration;
            richTextBoxReview.Text = defaultReview;
            numericUpDownRating.Value = 0;


        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämän sovelluksen on tehnyt Justiina Laitinen");
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBox_Click(object sender, EventArgs e) //Boksin tyhjentäminen kun se valitaan
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;

            if (textBox != null)
            {
                textBox.Clear(); 
            }

            

        }

        private void TextBox_Leave(object sender, EventArgs e) //Palauttaa tekstin jos tyhjä
        {
            var textBox = sender as System.Windows.Forms.TextBox;

            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                
                if (textBox == textBoxID) textBox.Text = defaultID;
                else if (textBox == textBoxName) textBox.Text = defaultName;
                else if (textBox == textBoxYear) textBox.Text = defaultYear;
                else if (textBox == textBoxDuration) textBox.Text = defaultDuration;

            }
        }

        private void RichTextBox_Click(object sender, EventArgs e) //tyhjennä arvioboksi
        {
            if (richTextBoxReview.Text == defaultReview)
            {
                richTextBoxReview.Clear(); 
            }
        }

        private void RichTextBox_Leave(object sender, EventArgs e) //palauta teksti jos tyhjä
        {
            if (string.IsNullOrWhiteSpace(richTextBoxReview.Text))
            {
                richTextBoxReview.Text = defaultReview; 
            }
        }
    }
    }

