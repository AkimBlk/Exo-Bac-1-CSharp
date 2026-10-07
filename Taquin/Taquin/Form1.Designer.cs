namespace Taquin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.bt_melanger = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.lb_text_demarrer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle4;
            this.grid.Enabled = false;
            this.grid.Location = new System.Drawing.Point(65, 56);
            this.grid.Margin = new System.Windows.Forms.Padding(2);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.RowTemplate.Height = 24;
            this.grid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid.Size = new System.Drawing.Size(504, 474);
            this.grid.TabIndex = 0;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // bt_melanger
            // 
            this.bt_melanger.Enabled = false;
            this.bt_melanger.Location = new System.Drawing.Point(224, 567);
            this.bt_melanger.Name = "bt_melanger";
            this.bt_melanger.Size = new System.Drawing.Size(75, 23);
            this.bt_melanger.TabIndex = 1;
            this.bt_melanger.Text = "Mélanger";
            this.bt_melanger.UseVisualStyleBackColor = true;
            this.bt_melanger.Click += new System.EventHandler(this.bt_melanger_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(325, 567);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 23);
            this.bt_exit.TabIndex = 2;
            this.bt_exit.Text = "Quitter";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(21, 16);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 23);
            this.bt_start.TabIndex = 3;
            this.bt_start.Text = "Démarrer";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // lb_text_demarrer
            // 
            this.lb_text_demarrer.AutoSize = true;
            this.lb_text_demarrer.Location = new System.Drawing.Point(103, 21);
            this.lb_text_demarrer.Name = "lb_text_demarrer";
            this.lb_text_demarrer.Size = new System.Drawing.Size(163, 13);
            this.lb_text_demarrer.TabIndex = 4;
            this.lb_text_demarrer.Text = "Appuyer sur démarrer pour jouer !";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 625);
            this.Controls.Add(this.lb_text_demarrer);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_melanger);
            this.Controls.Add(this.grid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button bt_melanger;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Label lb_text_demarrer;
    }
}

