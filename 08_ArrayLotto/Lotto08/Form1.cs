using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto08
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private List<int> mainLottoNum ;
        private List<int> extraLottoNum;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainLottoNum = GenerateUniqueNumbers(7,1,40);
            
            extraLottoNum = GenerateUniqueNumbers(2, 1, 40, mainLottoNum);

            mainLottoNum.Sort();
            extraLottoNum.Sort();

            
            string lottoNum = string.Join(", ", mainLottoNum)+" , "+ string.Join(" , ", extraLottoNum);

            label1.Text = lottoNum;

            List<int> userNumber = new List<int>
            {
                Convert.ToInt32(textBox1.Text),
                Convert.ToInt32(textBox2.Text),
                Convert.ToInt32(textBox3.Text),
                Convert.ToInt32(textBox4.Text),
                Convert.ToInt32(textBox5.Text),
                Convert.ToInt32(textBox6.Text),
                Convert.ToInt32(textBox7.Text)
            };

            int matchingCount = userNumber.Intersect(mainLottoNum).Count();
            MessageBox.Show($"Sinulla meni {matchingCount} numero(a) oikein!");

        }

        
        private List<int> GenerateUniqueNumbers(int count, int min, int max, List<int> exclude = null)
        {
            List<int> numbers = new List<int>();
            HashSet<int> uniqueNums= new HashSet<int>(exclude ?? Enumerable.Empty<int>());

            while (numbers.Count < count)
            {
                int num = random.Next(min, max + 1);
                if (uniqueNums.Add(num))
                {
                    numbers.Add(num);
                }
            }
            return numbers;
        }

        
    }
    }

