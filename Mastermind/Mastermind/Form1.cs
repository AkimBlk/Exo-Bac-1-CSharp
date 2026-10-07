using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CarreAs
{
    public partial class Form1 : Form
    {
        private const int MAX_COL = 10;
        private const int MAX_ROW = 6;

        private int valeurPick = -1;

        private int[,] tab = new int[MAX_ROW, 1];
        private int[,] verifTab = new int[MAX_ROW, 1];

        private int essaie = 0;
        private int colonne = 0;

        private int cptJ = 0;
        private int cptR = 0;
        private int cptB = 0;
        private int cptV = 0;

        private int cptJ2 = 0;
        private int cptR2 = 0;
        private int cptB2 = 0;
        private int cptV2 = 0;

        private int bonne_pos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createGrid(grid, MAX_ROW, MAX_COL);
            createGrid(grid2, 5, MAX_COL);
            init_tab();
        }

        private void init_tab()
        {
            Random random = new Random();

            cptJ = 0;
            cptR = 0;
            cptB = 0;
            cptV = 0;

            for (int j = 0; j < MAX_ROW; j++)
            {
                int rdm = random.Next(0, 4);
                tab[j, 0] = rdm;

                switch (rdm)
                {
                    case 0:
                        cptJ++;
                        break;

                    case 1:
                        cptR++;
                        break;

                    case 2:
                        cptB++;
                        break;

                    case 3:
                        cptV++;
                        break;
                }
            }
        }

        private void createGrid(DataGridView grid, int max_row, int max_col)
        {
            DataTable dt = new DataTable();

            for (int row = 0; row < max_row; row++)
                dt.Rows.Add();

            for (int col = 0; col < max_col; col++)
                dt.Columns.Add();

            grid.DataSource = dt;

            for (int i = 0; i < max_row; i++)
                grid.Rows[i].Height = grid.Height / max_row;

            for (int i = 0; i < max_col; i++)
                grid.Columns[i].Width = grid.Width / max_col;

            for (int row = 0; row < max_row; row++)
            {
                for (int col = 0; col < max_col; col++)
                {
                    grid.Rows[row].Cells[col].Style.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;

                    grid.Rows[row].Cells[col].Style.Font =
                        new Font("Arial", 14);

                    grid.Rows[row].Cells[col].Style.BackColor =
                        Color.Wheat;
                }
            }

            grid.ClearSelection();
        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_j_Click(object sender, EventArgs e)
        {
            valeurPick = 0;
        }

        private void bt_r_Click(object sender, EventArgs e)
        {
            valeurPick = 1;
        }

        private void bt_b_Click(object sender, EventArgs e)
        {
            valeurPick = 2;
        }

        private void bt_v_Click(object sender, EventArgs e)
        {
            valeurPick = 3;
        }

        private void bt_vide_Click(object sender, EventArgs e)
        {
            valeurPick = 4;
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            grid.ClearSelection();

            int row = e.RowIndex;

            switch (valeurPick)
            {
                case 0:
                    verifTab[row, 0] = 0;
                    grid.Rows[row].Cells[colonne].Style.BackColor = Color.Yellow;
                    break;

                case 1:
                    verifTab[row, 0] = 1;
                    grid.Rows[row].Cells[colonne].Style.BackColor = Color.Red;
                    break;

                case 2:
                    verifTab[row, 0] = 2;
                    grid.Rows[row].Cells[colonne].Style.BackColor = Color.Blue;
                    break;

                case 3:
                    verifTab[row, 0] = 3;
                    grid.Rows[row].Cells[colonne].Style.BackColor = Color.Green;
                    break;

                case 4:
                    verifTab[row, 0] = -1;
                    grid.Rows[row].Cells[colonne].Style.BackColor = Color.White;
                    break;
            }
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            if (essaie == 10)
            {
                MessageBox.Show("Trop de tentatives : " + essaie);
                grid.Enabled = false;
                grid2.Enabled = false;
                return;
            }

            essaie++;

            if (win())
            {
                MessageBox.Show(
                    "GG, vous avez gagné après " + essaie + " tentatives !");

                grid.Enabled = false;
                grid2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Essai : " + essaie);
                resetCounters();
            }

            clear_tab();
        }

        private void remplir_grid2()
        {
            for (int i = 0; i < MAX_ROW; i++)
            {
                switch (verifTab[i, 0])
                {
                    case 0:
                        cptJ2++;
                        break;

                    case 1:
                        cptR2++;
                        break;

                    case 2:
                        cptB2++;
                        break;

                    case 3:
                        cptV2++;
                        break;
                }
            }

            afficherResultat(0, cptJ, cptJ2);
            afficherResultat(1, cptR, cptR2);
            afficherResultat(2, cptB, cptB2);
            afficherResultat(3, cptV, cptV2);

            grid2.Rows[4].Cells[colonne].Value = bonne_pos;
            grid2.Rows[4].Cells[colonne].Style.BackColor = Color.Yellow;
        }

        private void afficherResultat(int row, int attendu, int obtenu)
        {
            bool correct = attendu == obtenu;

            grid2.Rows[row].Cells[colonne].Value = correct ? "V" : "X";
            grid2.Rows[row].Cells[colonne].Style.BackColor =
                correct ? Color.Green : Color.Red;
        }

        private void clear_tab()
        {
            for (int i = 0; i < MAX_ROW; i++)
                verifTab[i, 0] = -1;
        }

        private bool win()
        {
            bonne_pos = 0;

            for (int i = 0; i < MAX_ROW; i++)
            {
                if (tab[i, 0] == verifTab[i, 0])
                    bonne_pos++;
            }

            remplir_grid2();
            colonne++;

            return bonne_pos == MAX_ROW;
        }

        private void resetCounters()
        {
            cptJ2 = 0;
            cptR2 = 0;
            cptB2 = 0;
            cptV2 = 0;
            bonne_pos = 0;
        }

        private void bt_redemarrer_Click(object sender, EventArgs e)
        {
            init_tab();

            grid.Enabled = true;
            grid2.Enabled = true;

            valeurPick = -1;
            colonne = 0;
            essaie = 0;

            resetCounters();
            clear_tab();

            for (int i = 0; i < MAX_ROW; i++)
            {
                for (int j = 0; j < MAX_COL; j++)
                {
                    grid.Rows[i].Cells[j].Value = null;
                    grid.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }

        private void bt_demarrer_Click(object sender, EventArgs e)
        {
            grid2.Enabled = true;
            grid.Enabled = true;
        }
    }
}