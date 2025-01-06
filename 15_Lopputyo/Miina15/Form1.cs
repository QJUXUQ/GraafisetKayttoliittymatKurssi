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
    public partial class Form1 : Form
    {
        private int rows, cols, mines;
        private Button[,] buttons;
        private int[,] grid; //-1 miina, 0-8:naapurimiinojen määrä
        private bool[,] revealed;
        private bool gameEnded = false;

        public Form1(int rows, int cols, int mines)
        {
            this.rows = rows;
            this.cols = cols;
            this.mines = mines;

            InitializeGame();

            Button btnRestart = new Button
            {
                Text = "Restart",
                Size = new Size(100, 30),
                Location = new Point((cols * 30) / 2 - 50, rows * 30 + 10)
            };
            btnRestart.Click += btnRestart_Click;
            this.Controls.Add(btnRestart);

            
        }



        private void InitializeGame() 
        {
            //peli ikkuna
            this.ClientSize=new Size(cols*30,rows*30+50);
            this.Text = "Minesweeper";
            this.StartPosition=FormStartPosition.CenterScreen;

            // ruudut
            buttons=new Button[rows,cols];
            grid=new int[rows,cols];
            revealed=new bool[rows,cols];

            CreateGameBoard();
            PlaceMines();
            CalculateNumbers();
        }

        private void CreateGameBoard() 
        {
            for (int row=0; row<rows; row++) 
            {
                for(int col=0; col<cols; col++) 
                {
                    Button button = new Button();
                    button.Size = new Size(30, 30);
                    button.Location = new Point(col*30,row*30);
                    button.MouseDown += Button_MouseDown;
                    buttons[row,col]=button;
                    this.Controls.Add(button);
                }
            }
        }

        private void PlaceMines() 
        {
            Random rand = new Random();
            int placedMines = 0;

            while (placedMines < mines) 
            {
                int row=rand.Next(rows);
                int col=rand.Next(cols);
                
                if (grid[row, col] != -1) 
                {
                    grid[row, col] = -1;
                    placedMines++;
                }
            }
        }

        private void CalculateNumbers() 
        {
            for ( int row=0; row<rows;row++) 
            {
                for (int col=0; col<cols; col++) 
                {
                    if (grid[row, col] == -1) continue;
                    int mineCount = 0;

                    //Tarkista kaikki naapurit
                    for (int i=-1;i<=1;i++) 
                    {
                        for (int j = -1; j <= 1; j++) 
                        {
                            int neighborRow=row+i;
                            int neighborCol=col+j;
                            
                            if (neighborRow>=0 && neighborRow<rows && neighborCol >= 0 && neighborCol < cols && grid[neighborRow, neighborCol] == -1) 
                            {
                                mineCount++;
                            }
                        }
                    }
                    grid[row, col] = mineCount;
                }
            }
        }

        private void Button_MouseDown(object sender, MouseEventArgs e) 
        {
            if (gameEnded) return;
            Button button = sender as Button;
            int row = button.Top / button.Height;
            int col = button.Left / button.Width;

            if (e.Button == MouseButtons.Left)
            {
                RevealCell(row, col);
            }
            else if (e.Button == MouseButtons.Right)
            {
                ToggleFlag(button);
            }
        }

        private void CheckWin() 
        {
            for(int row=0;row<rows; row++) 
            {
                for (int col = 0; col < cols; col++)
                {
                    if (!revealed[row, col] && grid[row, col] != -1)
                    {
                        return; 
                    }
                }
            }
            EndGame(true);
        }

        private void RevealCell(int row, int col)
        {
            if (row < 0 || row >= rows || col < 0 || col >= cols || revealed[row, col]) return;

            revealed[row, col] = true;
            buttons[row, col].Enabled = false;

            if (grid[row, col] == -1)
            {
                buttons[row, col].Text = "X";
                buttons[row, col].BackColor = Color.Red;
                EndGame(false);
                return;
            }

            if (grid[row, col] > 0)
            {
                buttons[row, col].Text = grid[row, col].ToString();
                return;
            }

            // Jos ruutu on 0, paljasta kaikki naapurit
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    RevealCell(row + i, col + j);
                }
            }
            CheckWin();
            
        }

        private void ToggleFlag(Button button)
        {
            if (button.Text == "F")
            {
                button.Text = "";
                button.BackColor = DefaultBackColor;
            }
            else
            {
                button.Text = "F";
                button.BackColor = Color.Yellow;
            }
        }

        
        
        private void EndGame(bool won)
        {
            gameEnded = true;

            if (won)
            {
                MessageBox.Show("You won!", "Minesweeper", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Game over!", "Minesweeper", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RestartGame()
        {
            Form1 newGame = new Form1(rows, cols, mines);
            newGame.Show();
            this.Close();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        
    }
}
