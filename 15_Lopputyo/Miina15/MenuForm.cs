using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miina15
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            InitializeMenu();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeMenu()
        {
            this.Text = "Minesweeper - Menu";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(300, 200);

            // easy
            Button easyButton = new Button
            {
                Text = "Easy (9x9, 10 mines)",
                Location = new Point(50, 30),
                Size = new Size(200, 40)
            };
            easyButton.Click += (sender, e) => StartGame(9, 9, 10);
            this.Controls.Add(easyButton);

            // medium
            Button mediumButton = new Button
            {
                Text = "Medium (16x16, 40 mines)",
                Location = new Point(50, 80),
                Size = new Size(200, 40)
            };
            mediumButton.Click += (sender, e) => StartGame(16, 16, 40);
            this.Controls.Add(mediumButton);

            // hard
            Button hardButton = new Button
            {
                Text = "Hard (30x16, 99 mines)",
                Location = new Point(50, 130),
                Size = new Size(200, 40)
            };
            hardButton.Click += (sender, e) => StartGame(30, 16, 99);
            this.Controls.Add(hardButton);
        }

        private void StartGame(int rows, int cols, int mines)
        {
            
            Form1 gameForm = new Form1(rows, cols, mines);
            gameForm.Show();
            this.Hide(); 
        }

        public static void Exit()  
        {
            Application.Exit();
        }
    }
}
