namespace banque_graphic
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
            this.lbx = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCrediter = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDebiter = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decouvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propriétaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBMontant = new System.Windows.Forms.TextBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx
            // 
            this.lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx.FormattingEnabled = true;
            this.lbx.ItemHeight = 16;
            this.lbx.Location = new System.Drawing.Point(12, 27);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(776, 228);
            this.lbx.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuItem,
            this.modificationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StripMenuItem
            // 
            this.StripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(188)))), ((int)(((byte)(243)))));
            this.StripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCrediter,
            this.btnDebiter});
            this.StripMenuItem.Name = "StripMenuItem";
            this.StripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.StripMenuItem.Text = "Opérations";
            // 
            // btnCrediter
            // 
            this.btnCrediter.Name = "btnCrediter";
            this.btnCrediter.Size = new System.Drawing.Size(116, 22);
            this.btnCrediter.Text = "Créditer";
            this.btnCrediter.Click += new System.EventHandler(this.btnCrediter_Click);
            // 
            // btnDebiter
            // 
            this.btnDebiter.Name = "btnDebiter";
            this.btnDebiter.Size = new System.Drawing.Size(116, 22);
            this.btnDebiter.Text = "Débiter";
            this.btnDebiter.Click += new System.EventHandler(this.btnDebiter_Click);
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(203)))), ((int)(((byte)(254)))));
            this.modificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decouvertToolStripMenuItem,
            this.propriétaireToolStripMenuItem});
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.modificationToolStripMenuItem.Text = "Modification";
            // 
            // decouvertToolStripMenuItem
            // 
            this.decouvertToolStripMenuItem.Name = "decouvertToolStripMenuItem";
            this.decouvertToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.decouvertToolStripMenuItem.Text = "Decouvert";
            this.decouvertToolStripMenuItem.Click += new System.EventHandler(this.decouvertToolStripMenuItem_Click);
            // 
            // propriétaireToolStripMenuItem
            // 
            this.propriétaireToolStripMenuItem.Name = "propriétaireToolStripMenuItem";
            this.propriétaireToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.propriétaireToolStripMenuItem.Text = "Propriétaire";
            this.propriétaireToolStripMenuItem.Click += new System.EventHandler(this.propriétaireToolStripMenuItem_Click);
            // 
            // txtBMontant
            // 
            this.txtBMontant.Location = new System.Drawing.Point(361, 271);
            this.txtBMontant.Name = "txtBMontant";
            this.txtBMontant.Size = new System.Drawing.Size(100, 20);
            this.txtBMontant.TabIndex = 2;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.Location = new System.Drawing.Point(172, 271);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(95, 17);
            this.lblMontant.TabIndex = 3;
            this.lblMontant.Text = "Montant du ...";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(374, 332);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.txtBMontant);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LCL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCrediter;
        private System.Windows.Forms.TextBox txtBMontant;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ToolStripMenuItem btnDebiter;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decouvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propriétaireToolStripMenuItem;
    }
}

