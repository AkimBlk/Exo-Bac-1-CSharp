using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demineur
{
	public partial class Form1 : Form
	{
		private const int MAX_BOMB = 5;
		private const int MAX_ROW = 8;
		private const int MAX_COL = 8;
        int [,]tab = new int[MAX_ROW, MAX_COL];
        private int casesRévélées = 0;


        public Form1()
		{
			InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			createGrid();
        }

		private void createGrid()
		{
			DataTable dt = new DataTable();

			for (int row = 0; row < MAX_ROW; row++)
				dt.Rows.Add();

			for (int col = 0; col < MAX_COL; col++)
				dt.Columns.Add();

			grid.DataSource = dt;

			for (int col = 0; col < MAX_COL; col++)
				grid.Columns[col].Width = (grid.Width / MAX_COL);

			for (int row = 0; row < MAX_ROW; row++)
				grid.Rows[row].Height = grid.Height / MAX_ROW;
		}

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)            {
                DataGridViewCell cell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Style.BackColor == Color.Gray)                {
                    if (tab[e.RowIndex, e.ColumnIndex] == -1)                    {
                        RévélerToutesLesBombes();                        MessageBox.Show("💥 BOOM ! Vous avez perdu !");
                        grid.Enabled = false;                        return;
                    }

                    if (tab[e.RowIndex, e.ColumnIndex] == 0)
                    {
                        RévélerCasesVides(e.RowIndex, e.ColumnIndex);
                    }
                    else
                    {
                        cell.Value = tab[e.RowIndex, e.ColumnIndex];                        cell.Style.BackColor = Color.White;                        casesRévélées++;
                    }

                    if (casesRévélées == (MAX_ROW * MAX_COL) - MAX_BOMB)
                    {
                        MessageBox.Show("Félicitations ! Vous avez gagné !");
                        bt_Start.Enabled = true;
                        grid.Enabled = false;
                    }
                }
            }
        }


        private void bt_Start_Click(object sender, EventArgs e)
        {
            clean_board();
            random_tab();
            calcul_board();
            tab2grid();
            casesRévélées = 0;
            grid.Enabled = true;
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void calcul_board()
        {
            for (int i = 0; i < MAX_ROW; i++)
            {
                for (int j = 0; j < MAX_COL; j++)
                {
                    calcul_case(i, j);                }
            }
        }

        private void calcul_case(int l, int c)
        {
            if(tab[l, c] !=-1)            {
                if (bombe(l - 1, c - 1))
                    tab[l, c]++;                if (bombe(l-1, c))
                    tab[l, c]++;                if (bombe(l-1, c+1))
                    tab[l, c]++;                if (bombe(l, c-1))
                    tab[l, c]++;                if (bombe(l,c+1))
                    tab[l, c]++;                if (bombe(l+1, c-1))
                    tab[l, c]++;                if (bombe(l+1, c))
                    tab[l, c]++;                if (bombe(l+1, c+1))
                    tab[l, c]++;            }
        }

        private bool bombe(int i, int j)
        {
            if (i < 0 || j < 0 || i == MAX_ROW || j == MAX_COL)                return false;
            else if (tab[i, j] == -1)                return true;
            else
                return false;
        }
        private void clean_board()
        {
            grid.ClearSelection();
            for (int i = 0; i < MAX_COL; i++)
            {
                for (int j = 0; j < MAX_ROW; j++)
                {
                    grid.Rows[i].Cells[j].Value = "0";
                    grid.Rows[i].Cells[j].Style.BackColor = Color.White;
                    tab[i, j] = 0;
                }
            }
        }

        private void random_tab()
        {
            Random rand = new Random();

            int i = 1;
            while(i <= MAX_BOMB)            {
                int rand_col = rand.Next(0, MAX_COL);
                int rand_row = rand.Next(0, MAX_ROW);
                if (tab[rand_row, rand_col] != -1)                {
                    tab[rand_row, rand_col] = -1;
                    i++;
                }
            }

        }

        private void tab2grid()
        {
            for (int i = 0; i < MAX_COL; i++)
            {
                for (int j = 0; j < MAX_ROW; j++)
                {
                    grid.Rows[i].Cells[j].Value = "";
                    grid.Rows[i].Cells[j].Style.BackColor = Color.Gray;
                }
            }
        }

        private void RévélerToutesLesBombes()
        {
            for (int i = 0; i < MAX_ROW; i++)
            {
                for (int j = 0; j < MAX_COL; j++)
                {
                    if (tab[i, j] == -1)
                    {
                        grid.Rows[i].Cells[j].Value = "💣"; 
                        grid.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    }
                }
            }
        }

        private void RévélerCasesVides(int row, int col)
        {
            if (row < 0 || col < 0 || row >= MAX_ROW || col >= MAX_COL) return;            DataGridViewCell cell = grid.Rows[row].Cells[col];

            if (cell.Style.BackColor != Color.Gray) return;
            cell.Value = tab[row, col];            cell.Style.BackColor = Color.White;
            casesRévélées++;
            if (tab[row, col] == 0)            {
                for (int i = -1; i <= 1; i++)                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (i != 0 || j != 0)                        {
                            RévélerCasesVides(row + i, col + j);
                        }
                    }
                }
            }
        }

    }
}
