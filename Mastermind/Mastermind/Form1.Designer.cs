namespace CarreAs
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new System.Windows.Forms.DataGridView();
            this.grid2 = new System.Windows.Forms.DataGridView();
            this.bt_j = new System.Windows.Forms.Button();
            this.bt_r = new System.Windows.Forms.Button();
            this.bt_b = new System.Windows.Forms.Button();
            this.bt_v = new System.Windows.Forms.Button();
            this.bt_vide = new System.Windows.Forms.Button();
            this.bt_demarrer = new System.Windows.Forms.Button();
            this.bt_valider = new System.Windows.Forms.Button();
            this.bt_quit = new System.Windows.Forms.Button();
            this.bt_redemarrer = new System.Windows.Forms.Button();
            this.lb_hint = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.ColumnHeadersVisible = false;
            this.grid.Enabled = false;
            this.grid.Location = new System.Drawing.Point(179, 62);
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid.Size = new System.Drawing.Size(584, 383);
            this.grid.TabIndex = 0;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // grid2
            // 
            this.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid2.ColumnHeadersVisible = false;
            this.grid2.Enabled = false;
            this.grid2.Location = new System.Drawing.Point(179, 473);
            this.grid2.Name = "grid2";
            this.grid2.RowHeadersVisible = false;
            this.grid2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid2.Size = new System.Drawing.Size(584, 149);
            this.grid2.TabIndex = 15;
            // 
            // bt_j
            // 
            this.bt_j.BackColor = System.Drawing.Color.Yellow;
            this.bt_j.Location = new System.Drawing.Point(247, 5);
            this.bt_j.Name = "bt_j";
            this.bt_j.Size = new System.Drawing.Size(75, 54);
            this.bt_j.TabIndex = 16;
            this.bt_j.Text = "0";
            this.bt_j.UseVisualStyleBackColor = false;
            this.bt_j.Click += new System.EventHandler(this.bt_j_Click);
            // 
            // bt_r
            // 
            this.bt_r.BackColor = System.Drawing.Color.Red;
            this.bt_r.Location = new System.Drawing.Point(337, 5);
            this.bt_r.Name = "bt_r";
            this.bt_r.Size = new System.Drawing.Size(75, 54);
            this.bt_r.TabIndex = 17;
            this.bt_r.Text = "1";
            this.bt_r.UseVisualStyleBackColor = false;
            this.bt_r.Click += new System.EventHandler(this.bt_r_Click);
            // 
            // bt_b
            // 
            this.bt_b.BackColor = System.Drawing.Color.Blue;
            this.bt_b.Location = new System.Drawing.Point(427, 5);
            this.bt_b.Name = "bt_b";
            this.bt_b.Size = new System.Drawing.Size(75, 54);
            this.bt_b.TabIndex = 18;
            this.bt_b.Text = "2";
            this.bt_b.UseVisualStyleBackColor = false;
            this.bt_b.Click += new System.EventHandler(this.bt_b_Click);
            // 
            // bt_v
            // 
            this.bt_v.BackColor = System.Drawing.Color.Green;
            this.bt_v.Location = new System.Drawing.Point(520, 5);
            this.bt_v.Name = "bt_v";
            this.bt_v.Size = new System.Drawing.Size(75, 54);
            this.bt_v.TabIndex = 19;
            this.bt_v.Text = "3";
            this.bt_v.UseVisualStyleBackColor = false;
            this.bt_v.Click += new System.EventHandler(this.bt_v_Click);
            // 
            // bt_vide
            // 
            this.bt_vide.Location = new System.Drawing.Point(612, 5);
            this.bt_vide.Name = "bt_vide";
            this.bt_vide.Size = new System.Drawing.Size(75, 54);
            this.bt_vide.TabIndex = 20;
            this.bt_vide.Text = "4";
            this.bt_vide.UseVisualStyleBackColor = true;
            this.bt_vide.Click += new System.EventHandler(this.bt_vide_Click);
            // 
            // bt_demarrer
            // 
            this.bt_demarrer.Location = new System.Drawing.Point(805, 62);
            this.bt_demarrer.Name = "bt_demarrer";
            this.bt_demarrer.Size = new System.Drawing.Size(100, 39);
            this.bt_demarrer.TabIndex = 21;
            this.bt_demarrer.Text = "Démarrer";
            this.bt_demarrer.UseVisualStyleBackColor = true;
            this.bt_demarrer.Click += new System.EventHandler(this.bt_demarrer_Click);
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(805, 117);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(100, 39);
            this.bt_valider.TabIndex = 22;
            this.bt_valider.Text = "Valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // bt_quit
            // 
            this.bt_quit.Location = new System.Drawing.Point(805, 411);
            this.bt_quit.Name = "bt_quit";
            this.bt_quit.Size = new System.Drawing.Size(101, 34);
            this.bt_quit.TabIndex = 23;
            this.bt_quit.Text = "Quitter";
            this.bt_quit.UseVisualStyleBackColor = true;
            this.bt_quit.Click += new System.EventHandler(this.bt_quit_Click);
            // 
            // bt_redemarrer
            // 
            this.bt_redemarrer.Location = new System.Drawing.Point(805, 364);
            this.bt_redemarrer.Name = "bt_redemarrer";
            this.bt_redemarrer.Size = new System.Drawing.Size(101, 34);
            this.bt_redemarrer.TabIndex = 24;
            this.bt_redemarrer.Text = "Redémarrer";
            this.bt_redemarrer.UseVisualStyleBackColor = true;
            this.bt_redemarrer.Click += new System.EventHandler(this.bt_redemarrer_Click);
            // 
            // lb_hint
            // 
            this.lb_hint.AutoSize = true;
            this.lb_hint.Location = new System.Drawing.Point(71, 62);
            this.lb_hint.Name = "lb_hint";
            this.lb_hint.Size = new System.Drawing.Size(16, 13);
            this.lb_hint.TabIndex = 25;
            this.lb_hint.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "nbr de jaune correct :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "nbr de rouge correct :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "nbr de bleu correct :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 570);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "nbr de vert correct :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 599);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "nbr cases a la bonne position :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 694);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_hint);
            this.Controls.Add(this.bt_redemarrer);
            this.Controls.Add(this.bt_quit);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.bt_demarrer);
            this.Controls.Add(this.bt_vide);
            this.Controls.Add(this.bt_v);
            this.Controls.Add(this.bt_b);
            this.Controls.Add(this.bt_r);
            this.Controls.Add(this.bt_j);
            this.Controls.Add(this.grid2);
            this.Controls.Add(this.grid);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam Mastermind";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridView grid2;
        private System.Windows.Forms.Button bt_j;
        private System.Windows.Forms.Button bt_r;
        private System.Windows.Forms.Button bt_b;
        private System.Windows.Forms.Button bt_v;
        private System.Windows.Forms.Button bt_vide;
        private System.Windows.Forms.Button bt_demarrer;
        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.Button bt_quit;
        private System.Windows.Forms.Button bt_redemarrer;
        private System.Windows.Forms.Label lb_hint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

