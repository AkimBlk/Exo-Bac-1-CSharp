using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Puissance4
{
    public partial class Form1 : Form
    {
        private const int MAX_ROW = 6;
        private const int MAX_COL = 7;
        private Bitmap[] tabImage = new Bitmap[3];
        int cpt = 0;

        public Form1()
        {
            InitializeComponent();
        }



        private void initTabImage()
        {
            tabImage[0] = new Bitmap("red circle.ico");
            tabImage[1] = new Bitmap("black circle.ico");
            tabImage[2] = new Bitmap(1, 1);
        }

        private void createGame()
        {
            initTabImage();

            emptyGrid();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            createGrid();
            createGame();
            grid.ClearSelection();
        }

        private void createGrid()
        {
            DataTable dt = new DataTable();
            DataGridViewImageColumn imageCol = null;

            for (int row = 0; row < MAX_ROW; row++)
                dt.Rows.Add();

            for (int col = 0; col < MAX_COL; col++)
            {
                dt.Columns.Add();
                imageCol = new DataGridViewImageColumn();
                grid.Columns.Add(imageCol);
            }

            grid.DataSource = dt;

            for (int col = 0; col < MAX_COL; col++)
                grid.Columns[col].Width = (grid.Width / MAX_COL);

            for (int row = 0; row < MAX_ROW; row++)
                grid.Rows[row].Height = grid.Height / MAX_ROW;
        }

        private void emptyGrid()
        {
            for (int row = 0; row < MAX_ROW; row++)
            {
                for (int col = 0; col < MAX_COL; col++)
                {
                    grid.Rows[row].Cells[col].Style.BackColor = Color.Wheat;
                    grid.Rows[row].Cells[col].Value = tabImage[2];
                }
            }
        }


        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid.ClearSelection();
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            int cptCaseLibre = MAX_ROW-1;
            int a = 0;

            if (cpt % 2 == 0 && grid.Rows[row].Cells[col].Value == tabImage[2])
            {
                while(a==0)
                {
                    if (grid.Rows[cptCaseLibre].Cells[col].Value == tabImage[2] && cptCaseLibre > -1)
                    {
                        grid.Rows[cptCaseLibre].Cells[col].Value = tabImage[0];
                        cpt++;
                        a = 1;
                        lb_playerTurn.Text = "player turn : 2";
                        verifWin();
                        
                    }
                    else if (grid.Rows[cptCaseLibre].Cells[col].Value != tabImage[2] && cptCaseLibre > -1)
                    {
                        cptCaseLibre--;
                    }
                    else
                    {
                        a = 1;
                    }
                }
            }
            else if (cpt % 2 != 0 && grid.Rows[row].Cells[col].Value == tabImage[2])
            {
                while (a == 0)
                {
                    if (grid.Rows[cptCaseLibre].Cells[col].Value == tabImage[2] && cptCaseLibre > -1)
                    {
                        grid.Rows[cptCaseLibre].Cells[col].Value = tabImage[1];
                        cpt++;
                        a = 1;
                        lb_playerTurn.Text = "player turn : 1";
                        verifWin();

                    }
                    else if (grid.Rows[cptCaseLibre].Cells[col].Value != tabImage[2] && cptCaseLibre > -1)
                    {
                        cptCaseLibre--;
                    }
                    else
                    {
                        a = 1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Cliquer sur une case vide");
            }
        }

        private void verifWin()
        {
            if (cpt == MAX_ROW * MAX_COL)
            {
                MessageBox.Show("Match nul");
                grid.Enabled = false;
            }
            else if (cpt >= 7)
            {
                //ligne
                for (int i = 0; i < MAX_ROW; i++)
                {
                    for (int j = 0; j < MAX_COL - 3; j++)
                    {
                        if (grid.Rows[i].Cells[j].Value == tabImage[0] && grid.Rows[i].Cells[j + 1].Value == tabImage[0] && grid.Rows[i].Cells[j + 2].Value == tabImage[0] && grid.Rows[i].Cells[j + 3].Value == tabImage[0])
                        {
                            messageBoxWinJoueur1();
                        }

                        if (grid.Rows[i].Cells[j].Value == tabImage[1] && grid.Rows[i].Cells[j + 1].Value == tabImage[1] && grid.Rows[i].Cells[j + 2].Value == tabImage[1] &&  grid.Rows[i].Cells[j + 3].Value == tabImage[1])
                        {
                            messageBoxWinJoueur2();
                        }
                    }
                }

                //colonne
                for (int j = 0; j < MAX_COL; j++)
                {
                    for (int i = 0; i < MAX_ROW -3; i++)
                    {
                        if (grid.Rows[i].Cells[j].Value == tabImage[0] && grid.Rows[i + 1].Cells[j].Value == tabImage[0] &&  grid.Rows[i + 2].Cells[j].Value == tabImage[0] && grid.Rows[i + 3].Cells[j].Value == tabImage[0])
                        {
                            messageBoxWinJoueur1();
                        }

                        if (grid.Rows[i].Cells[j].Value == tabImage[1] && grid.Rows[i + 1].Cells[j].Value == tabImage[1] && grid.Rows[i + 2].Cells[j].Value == tabImage[1] && grid.Rows[i + 3].Cells[j].Value == tabImage[1])
                        {
                            messageBoxWinJoueur2();
                        }
                    }
                }

                //diagonale haut gauche -> bas droite
                for (int i = 0; i < MAX_ROW -3; i++)
                {
                    for (int j = 0; j < MAX_COL-3; j++)
                    {
                        if (grid.Rows[i].Cells[j].Value == tabImage[0] && grid.Rows[i + 1].Cells[j + 1].Value == tabImage[0] && grid.Rows[i + 2].Cells[j + 2].Value == tabImage[0] && grid.Rows[i + 3].Cells[j + 3].Value == tabImage[0])
                        {
                            messageBoxWinJoueur1();
                        }
                    }
                }

                for (int i = 0; i < MAX_ROW - 3; i++)
                {
                    for (int j = 0; j < MAX_COL - 3; j++)
                    {
                        if (grid.Rows[i].Cells[j].Value == tabImage[1] && grid.Rows[i + 1].Cells[j + 1].Value == tabImage[1] && grid.Rows[i + 2].Cells[j + 2].Value == tabImage[1] && grid.Rows[i + 3].Cells[j + 3].Value == tabImage[1])
                        {
                            messageBoxWinJoueur2();
                        }
                    }
                }

                //diagonale bas gauche -> haut droite 
                for (int i = MAX_ROW-1; i>= 3; i--)
                {
                    for (int j = 0; j < MAX_COL - 4; j++)
                    {
                        if (grid.Rows[i].Cells[j].Value == tabImage[0] && grid.Rows[i - 1].Cells[j + 1].Value == tabImage[0] && grid.Rows[i - 2].Cells[j + 2].Value == tabImage[0] && grid.Rows[i - 3].Cells[j + 3].Value == tabImage[0])
                        {
                            messageBoxWinJoueur1();
                        }
                    }
                }

                for (int i = MAX_ROW - 1; i >=3; i--)
                {
                    for (int j = 0; j < MAX_COL - 4; j++)
                    {
                        if (grid.Rows[i].Cells[j].Value == tabImage[1] && grid.Rows[i - 1].Cells[j + 1].Value == tabImage[1] && grid.Rows[i - 2].Cells[j + 2].Value == tabImage[1] && grid.Rows[i - 3].Cells[j + 3].Value == tabImage[1])
                        {
                            messageBoxWinJoueur2();
                        }
                    }
                }
            }
        }

        private void messageBoxWinJoueur2()
        {
            lb_playerTurn.Text = "Joueur 2 win !";
            MessageBox.Show("joueur 2 win");
            grid.Enabled = false;
        }

        private void messageBoxWinJoueur1()
        {
            lb_playerTurn.Text = "Joueur 1 win !";
            MessageBox.Show("joueur 1 win");
            grid.Enabled = false;
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            grid.Enabled = true;
            lb_playerTurn.Text = "player turn : 1";
        }

        private void bQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bt_reset_Click(object sender, EventArgs e)
        {
            cpt = 0;
            lb_playerTurn.Text = "player turn :";
            for (int i = 0; i < MAX_ROW; i++)
                for (int j = 0; j < MAX_COL; j++)
                    grid.Rows[i].Cells[j].Value = tabImage[2];
        }

    }
}
