using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taquin
{
	public partial class Form1 : Form
	{
		private const int MAX_ROW = 3;
		private const int MAX_COL = 3;
		int [,] tab = new int [MAX_ROW,MAX_COL];

        object valeur1 = null;
        int row1 = 0;
        int col1 = 0;
        

        /*object valeur1 = null;
        int val1 = 0;
        int val2 = 0;
        */


        public Form1()
		{
			InitializeComponent();
            
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

		private void Form1_Load(object sender, EventArgs e)
		{
			createGrid();
            init();
        }

        private void init()
        {
            grid.ClearSelection();
            
            init_tab();
            tab2grid();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid.ClearSelection();
            int row = e.RowIndex;
            int col = e.ColumnIndex;


            if (case_adj(row,col))
            {
                pos_case_vide();
                tab[row1, col1] = tab[row, col];
                tab[row, col] = 0;
                tab2grid();
                win_or_not();
            }

                /*if (valeur1 == null)
                {
                    valeur1 = grid.Rows[row].Cells[col].Value;
                    val1 = row;
                    val2 = col;
                }
                else
                {
                    var valeur2 = grid.Rows[row].Cells[col].Value;

                    grid.Rows[row].Cells[col].Value = valeur1;
                    grid.Rows[val1].Cells[val2].Value = valeur2;

                    valeur1 = null;
                }*/

            }

        private bool case_adj(int l, int c)
        {

            if (l > 0 && tab[l - 1, c] == 0)
                return true;

            if (l < MAX_ROW - 1 && tab[l + 1, c] == 0)
                return true;

            if (c > 0 && tab[l, c - 1] == 0)
                return true;

            if (c < MAX_COL - 1 && tab[l, c + 1] == 0)
                return true;

            return false;
        }

        private void win_or_not()
        {
            int win = 0;
            int cpt = 0;

            for (int i=0; i < MAX_ROW; i++)
            {
                for (int j =0; j < MAX_COL; j++)
                {
                    cpt++;
                    if (cpt==MAX_COL*MAX_ROW)
                    {
                        cpt = 0;
                    }
                    else if (tab[i,j]!=cpt)
                    {
                        win = 1;
                    }
                }
            }
            if (win == 0)
            {
                lb_text_demarrer.Text = ("Partie terminée : vous avez gagné !");
                grid.Enabled = false;
                bt_melanger.Enabled = false;    
                MessageBox.Show("Bravo Winnn");
            }
        }

        private void pos_case_vide()
        {
            for (int i =0;  i < MAX_ROW; i++)
            {
                for (int j =0; j < MAX_COL; j++)
                {
                    if (grid.Rows[i].Cells[j].Value == "")
                    {
                        row1 = i;
                        col1= j;
                    }
                }
            }
        }

        private void bt_melanger_Click(object sender, EventArgs e)
        {
            random_tab();
            tab2grid();
        }

        private void init_tab()
        {
            int cpt = 0;
			for (int i = 0;i < MAX_ROW; i++)
			{
                for (int j = 0; j < MAX_COL; j++)
                {
                    tab[i, j] = cpt++;
                }
			}
        }

        private void random_tab()
        {
            int tmp;
            Random x= new Random();

            /*Random rdm= new Random();
            for (int i = 0; i < 1000; i++)
            {
                pos_case_vide();
                int row = row1;
                int col = col1;
                int x = rdm.Next(0,MAX_COL);
                if (x == 0 && row > 0)
                {
                    row--;
                }
                else if (x == 1 && row < MAX_ROW-1)
                {
                    row++;
                }
                else if(x == 2 && col > 0)
                {
                    col--;
                }
                else if (x == 1 && col < MAX_COL-1)
                {
                    col++;
                }

                tab[row1, col1] = tab[row, col];
                tab[row, col] = 0;
                row1= row;
                col1= col;

            }*/


            for (int i = 0; i < 200; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    int a = x.Next(0, MAX_ROW);
                    int b = x.Next(0, MAX_COL);
                    int a2 = x.Next(0, MAX_ROW);
                    int b2 = x.Next(0, MAX_COL);
                    tmp = tab[a,b];
                    tab[a, b] = tab[a2, b2];
                    tab[a2, b2] = tmp;
                }
            }
        }

        private void tab2grid()
        {
            int cpt = 0;
            for (int i = 0; i < MAX_ROW; i++)
            {
                for (int j = 0; j < MAX_COL; j++)
                {
                    cpt++;
                    grid.Rows[i].Cells[j].Value = tab[i,j];
                    grid.Rows[i].Cells[j].Style.BackColor= Color.PapayaWhip;
                    if (tab[i,j]==0)
                    {
                        grid.Rows[i].Cells[j].Value = "";
                        grid.Rows[i].Cells[j].Style.BackColor= Color.White;
                    }
                }
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            grid.Enabled = true;
            bt_melanger.Enabled = true;
            lb_text_demarrer.Text = ("Partie en cours...");
        }
    }
}
