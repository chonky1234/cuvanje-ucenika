
namespace matura
{
    partial class templateovi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTemplateovi = new System.Windows.Forms.DataGridView();
            this.Templates = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odeljenje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipMature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jezik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrviPrijemni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrugiPrijemni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TreciPrijemni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btStaviTemplate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemplateovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTemplateovi
            // 
            this.dgvTemplateovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemplateovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Templates,
            this.Ime,
            this.Prezime,
            this.Skola,
            this.Odeljenje,
            this.TipMature,
            this.Jezik,
            this.PrviPrijemni,
            this.DrugiPrijemni,
            this.TreciPrijemni});
            this.dgvTemplateovi.Location = new System.Drawing.Point(12, 11);
            this.dgvTemplateovi.Name = "dgvTemplateovi";
            this.dgvTemplateovi.RowHeadersWidth = 30;
            this.dgvTemplateovi.Size = new System.Drawing.Size(776, 388);
            this.dgvTemplateovi.TabIndex = 0;
            this.dgvTemplateovi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTemplateovi_CellContentClick);
            // 
            // Templates
            // 
            this.Templates.Frozen = true;
            this.Templates.HeaderText = "Templates";
            this.Templates.Name = "Templates";
            this.Templates.Width = 75;
            // 
            // Ime
            // 
            this.Ime.Frozen = true;
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.Width = 75;
            // 
            // Prezime
            // 
            this.Prezime.Frozen = true;
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.Width = 75;
            // 
            // Skola
            // 
            this.Skola.Frozen = true;
            this.Skola.HeaderText = "Skola";
            this.Skola.Name = "Skola";
            this.Skola.Width = 75;
            // 
            // Odeljenje
            // 
            this.Odeljenje.Frozen = true;
            this.Odeljenje.HeaderText = "Odeljenje";
            this.Odeljenje.Name = "Odeljenje";
            this.Odeljenje.Width = 75;
            // 
            // TipMature
            // 
            this.TipMature.Frozen = true;
            this.TipMature.HeaderText = "TipMature";
            this.TipMature.Name = "TipMature";
            this.TipMature.Width = 75;
            // 
            // Jezik
            // 
            this.Jezik.Frozen = true;
            this.Jezik.HeaderText = "Jezik";
            this.Jezik.Name = "Jezik";
            this.Jezik.Width = 75;
            // 
            // PrviPrijemni
            // 
            this.PrviPrijemni.Frozen = true;
            this.PrviPrijemni.HeaderText = "PrviPrijemni";
            this.PrviPrijemni.Name = "PrviPrijemni";
            this.PrviPrijemni.Width = 75;
            // 
            // DrugiPrijemni
            // 
            this.DrugiPrijemni.Frozen = true;
            this.DrugiPrijemni.HeaderText = "DrugiPrijemni";
            this.DrugiPrijemni.Name = "DrugiPrijemni";
            this.DrugiPrijemni.Width = 75;
            // 
            // TreciPrijemni
            // 
            this.TreciPrijemni.Frozen = true;
            this.TreciPrijemni.HeaderText = "TreciPrijemni";
            this.TreciPrijemni.Name = "TreciPrijemni";
            this.TreciPrijemni.Width = 75;
            // 
            // btStaviTemplate
            // 
            this.btStaviTemplate.Location = new System.Drawing.Point(12, 406);
            this.btStaviTemplate.Name = "btStaviTemplate";
            this.btStaviTemplate.Size = new System.Drawing.Size(776, 32);
            this.btStaviTemplate.TabIndex = 1;
            this.btStaviTemplate.Text = "Iskoristi template";
            this.btStaviTemplate.UseVisualStyleBackColor = true;
            this.btStaviTemplate.Click += new System.EventHandler(this.btStaviTemplate_Click);
            // 
            // templateovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btStaviTemplate);
            this.Controls.Add(this.dgvTemplateovi);
            this.Name = "templateovi";
            this.Text = "templateovi";
            this.Load += new System.EventHandler(this.templateovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemplateovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTemplateovi;
        private System.Windows.Forms.DataGridViewButtonColumn Templates;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odeljenje;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipMature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jezik;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrviPrijemni;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugiPrijemni;
        private System.Windows.Forms.DataGridViewTextBoxColumn TreciPrijemni;
        private System.Windows.Forms.Button btStaviTemplate;
    }
}