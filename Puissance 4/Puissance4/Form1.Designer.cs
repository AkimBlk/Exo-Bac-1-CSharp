namespace Puissance4
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
            this.bStart = new System.Windows.Forms.Button();
            this.bQuit = new System.Windows.Forms.Button();
            this.Bt_reset = new System.Windows.Forms.Button();
            this.lb_playerTurn = new System.Windows.Forms.Label();
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
            this.grid.Enabled = false;
            this.grid.Location = new System.Drawing.Point(98, 25);
            this.grid.Margin = new System.Windows.Forms.Padding(2);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 24;
            this.grid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid.Size = new System.Drawing.Size(397, 327);
            this.grid.TabIndex = 0;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(149, 393);
            this.bStart.Margin = new System.Windows.Forms.Padding(2);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(94, 50);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Commencer";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bQuit
            // 
            this.bQuit.Location = new System.Drawing.Point(349, 393);
            this.bQuit.Margin = new System.Windows.Forms.Padding(2);
            this.bQuit.Name = "bQuit";
            this.bQuit.Size = new System.Drawing.Size(94, 50);
            this.bQuit.TabIndex = 2;
            this.bQuit.Text = "Quitter";
            this.bQuit.UseVisualStyleBackColor = true;
            this.bQuit.Click += new System.EventHandler(this.bQuit_Click);
            // 
            // Bt_reset
            // 
            this.Bt_reset.Location = new System.Drawing.Point(262, 393);
            this.Bt_reset.Name = "Bt_reset";
            this.Bt_reset.Size = new System.Drawing.Size(75, 50);
            this.Bt_reset.TabIndex = 3;
            this.Bt_reset.Text = "Reset";
            this.Bt_reset.UseVisualStyleBackColor = true;
            this.Bt_reset.Click += new System.EventHandler(this.Bt_reset_Click);
            // 
            // lb_playerTurn
            // 
            this.lb_playerTurn.AutoSize = true;
            this.lb_playerTurn.Location = new System.Drawing.Point(3, 25);
            this.lb_playerTurn.Name = "lb_playerTurn";
            this.lb_playerTurn.Size = new System.Drawing.Size(62, 13);
            this.lb_playerTurn.TabIndex = 4;
            this.lb_playerTurn.Text = "player turn :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 499);
            this.Controls.Add(this.lb_playerTurn);
            this.Controls.Add(this.Bt_reset);
            this.Controls.Add(this.bQuit);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.grid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puissance 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView grid;
		private System.Windows.Forms.Button bStart;
		private System.Windows.Forms.Button bQuit;
        private System.Windows.Forms.Button Bt_reset;
        private System.Windows.Forms.Label lb_playerTurn;
    }
}

