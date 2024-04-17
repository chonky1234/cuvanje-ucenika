
namespace matura
{
    partial class unesi
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtOdeljenje = new System.Windows.Forms.TextBox();
            this.cbJezik = new System.Windows.Forms.ComboBox();
            this.cbPrviPredmet = new System.Windows.Forms.ComboBox();
            this.cbDrugiPredmet = new System.Windows.Forms.ComboBox();
            this.cbTreciPredmet = new System.Windows.Forms.ComboBox();
            this.btSacuvaj = new System.Windows.Forms.Button();
            this.btSacuvajTemplate = new System.Windows.Forms.Button();
            this.cbTipMature = new System.Windows.Forms.ComboBox();
            this.cbSkola = new System.Windows.Forms.ComboBox();
            this.btUcenikLevo = new System.Windows.Forms.Button();
            this.btUcenikDesno = new System.Windows.Forms.Button();
            this.btnIzaberiTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(104, 44);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(132, 22);
            this.txtIme.TabIndex = 0;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(104, 76);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(132, 22);
            this.txtPrezime.TabIndex = 1;
            // 
            // txtOdeljenje
            // 
            this.txtOdeljenje.Location = new System.Drawing.Point(104, 140);
            this.txtOdeljenje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOdeljenje.Name = "txtOdeljenje";
            this.txtOdeljenje.Size = new System.Drawing.Size(132, 22);
            this.txtOdeljenje.TabIndex = 3;
            this.txtOdeljenje.TextChanged += new System.EventHandler(this.txtOdeljenje_TextChanged);
            // 
            // cbJezik
            // 
            this.cbJezik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJezik.FormattingEnabled = true;
            this.cbJezik.Items.AddRange(new object[] {
            "Srpski",
            "Engleski",
            "Ruski",
            "Madjarski",
            "Albanski"});
            this.cbJezik.Location = new System.Drawing.Point(91, 229);
            this.cbJezik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbJezik.Name = "cbJezik";
            this.cbJezik.Size = new System.Drawing.Size(160, 24);
            this.cbJezik.TabIndex = 5;
            this.cbJezik.SelectedIndexChanged += new System.EventHandler(this.cbJezik_SelectedIndexChanged);
            // 
            // cbPrviPredmet
            // 
            this.cbPrviPredmet.FormattingEnabled = true;
            this.cbPrviPredmet.Location = new System.Drawing.Point(91, 276);
            this.cbPrviPredmet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPrviPredmet.Name = "cbPrviPredmet";
            this.cbPrviPredmet.Size = new System.Drawing.Size(160, 24);
            this.cbPrviPredmet.TabIndex = 6;
            // 
            // cbDrugiPredmet
            // 
            this.cbDrugiPredmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrugiPredmet.FormattingEnabled = true;
            this.cbDrugiPredmet.Items.AddRange(new object[] {
            "Matematika"});
            this.cbDrugiPredmet.Location = new System.Drawing.Point(91, 322);
            this.cbDrugiPredmet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDrugiPredmet.Name = "cbDrugiPredmet";
            this.cbDrugiPredmet.Size = new System.Drawing.Size(160, 24);
            this.cbDrugiPredmet.TabIndex = 7;
            // 
            // cbTreciPredmet
            // 
            this.cbTreciPredmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTreciPredmet.FormattingEnabled = true;
            this.cbTreciPredmet.Items.AddRange(new object[] {
            "Programiranje",
            "Biologija",
            "Hemija"});
            this.cbTreciPredmet.Location = new System.Drawing.Point(91, 372);
            this.cbTreciPredmet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTreciPredmet.Name = "cbTreciPredmet";
            this.cbTreciPredmet.Size = new System.Drawing.Size(160, 24);
            this.cbTreciPredmet.TabIndex = 8;
            this.cbTreciPredmet.SelectedIndexChanged += new System.EventHandler(this.cbTreciPredmet_SelectedIndexChanged);
            // 
            // btSacuvaj
            // 
            this.btSacuvaj.Location = new System.Drawing.Point(479, 198);
            this.btSacuvaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSacuvaj.Name = "btSacuvaj";
            this.btSacuvaj.Size = new System.Drawing.Size(100, 28);
            this.btSacuvaj.TabIndex = 9;
            this.btSacuvaj.Text = "Sacuvaj";
            this.btSacuvaj.UseVisualStyleBackColor = true;
            this.btSacuvaj.Click += new System.EventHandler(this.btSacuvaj_Click);
            // 
            // btSacuvajTemplate
            // 
            this.btSacuvajTemplate.Location = new System.Drawing.Point(660, 198);
            this.btSacuvajTemplate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSacuvajTemplate.Name = "btSacuvajTemplate";
            this.btSacuvajTemplate.Size = new System.Drawing.Size(168, 28);
            this.btSacuvajTemplate.TabIndex = 10;
            this.btSacuvajTemplate.Text = "Sacuvaj Template";
            this.btSacuvajTemplate.UseVisualStyleBackColor = true;
            this.btSacuvajTemplate.Click += new System.EventHandler(this.btSacuvajTemplate_Click);
            // 
            // cbTipMature
            // 
            this.cbTipMature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipMature.FormattingEnabled = true;
            this.cbTipMature.Items.AddRange(new object[] {
            "Opsti",
            "Strucni",
            "Umetnicki"});
            this.cbTipMature.Location = new System.Drawing.Point(91, 183);
            this.cbTipMature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTipMature.Name = "cbTipMature";
            this.cbTipMature.Size = new System.Drawing.Size(160, 24);
            this.cbTipMature.TabIndex = 4;
            this.cbTipMature.SelectedIndexChanged += new System.EventHandler(this.cbTipMature_SelectedIndexChanged);
            // 
            // cbSkola
            // 
            this.cbSkola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkola.FormattingEnabled = true;
            this.cbSkola.Items.AddRange(new object[] {
            "Prva Beogradska Gimnazija",
            "Druga  Beogradska Gimnazija",
            "Treca  Beogradska Gimnazija",
            "Cetvrta  Beogradska Gimnazija",
            "Peta  Beogradska Gimnazija",
            "Sesta  Beogradska Gimnazija",
            "Sedma  Beogradska Gimnazija",
            "Elektrotehnica skola Tesla",
            "Sveti Sava",
            "Graficka Skola",
            "Medicinska Skola",
            "Masinska skola",
            ""});
            this.cbSkola.Location = new System.Drawing.Point(104, 107);
            this.cbSkola.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSkola.Name = "cbSkola";
            this.cbSkola.Size = new System.Drawing.Size(160, 24);
            this.cbSkola.TabIndex = 11;
            this.cbSkola.SelectedIndexChanged += new System.EventHandler(this.cbSkola_SelectedIndexChanged);
            // 
            // btUcenikLevo
            // 
            this.btUcenikLevo.Location = new System.Drawing.Point(309, 470);
            this.btUcenikLevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btUcenikLevo.Name = "btUcenikLevo";
            this.btUcenikLevo.Size = new System.Drawing.Size(100, 28);
            this.btUcenikLevo.TabIndex = 12;
            this.btUcenikLevo.Text = "<";
            this.btUcenikLevo.UseVisualStyleBackColor = true;
            this.btUcenikLevo.Click += new System.EventHandler(this.btUcenikLevo_Click);
            // 
            // btUcenikDesno
            // 
            this.btUcenikDesno.Location = new System.Drawing.Point(707, 470);
            this.btUcenikDesno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btUcenikDesno.Name = "btUcenikDesno";
            this.btUcenikDesno.Size = new System.Drawing.Size(100, 28);
            this.btUcenikDesno.TabIndex = 13;
            this.btUcenikDesno.Text = ">";
            this.btUcenikDesno.UseVisualStyleBackColor = true;
            this.btUcenikDesno.Click += new System.EventHandler(this.btUcenikDesno_Click);
            // 
            // btnIzaberiTemplate
            // 
            this.btnIzaberiTemplate.Location = new System.Drawing.Point(651, 74);
            this.btnIzaberiTemplate.Name = "btnIzaberiTemplate";
            this.btnIzaberiTemplate.Size = new System.Drawing.Size(245, 88);
            this.btnIzaberiTemplate.TabIndex = 14;
            this.btnIzaberiTemplate.Text = "Izaberi templejt";
            this.btnIzaberiTemplate.UseVisualStyleBackColor = true;
            this.btnIzaberiTemplate.Click += new System.EventHandler(this.btnIzaberiTemplate_Click);
            // 
            // unesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnIzaberiTemplate);
            this.Controls.Add(this.btUcenikDesno);
            this.Controls.Add(this.btUcenikLevo);
            this.Controls.Add(this.cbSkola);
            this.Controls.Add(this.cbTipMature);
            this.Controls.Add(this.btSacuvajTemplate);
            this.Controls.Add(this.btSacuvaj);
            this.Controls.Add(this.cbTreciPredmet);
            this.Controls.Add(this.cbDrugiPredmet);
            this.Controls.Add(this.cbPrviPredmet);
            this.Controls.Add(this.cbJezik);
            this.Controls.Add(this.txtOdeljenje);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "unesi";
            this.Text = "unesi";
            this.Load += new System.EventHandler(this.unesi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtOdeljenje;
        private System.Windows.Forms.ComboBox cbJezik;
        private System.Windows.Forms.ComboBox cbPrviPredmet;
        private System.Windows.Forms.ComboBox cbDrugiPredmet;
        private System.Windows.Forms.ComboBox cbTreciPredmet;
        private System.Windows.Forms.Button btSacuvaj;
        private System.Windows.Forms.Button btSacuvajTemplate;
        private System.Windows.Forms.ComboBox cbTipMature;
        private System.Windows.Forms.ComboBox cbSkola;
        private System.Windows.Forms.Button btUcenikLevo;
        private System.Windows.Forms.Button btUcenikDesno;
        private System.Windows.Forms.Button btnIzaberiTemplate;
    }
}