
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
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(78, 36);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 0;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(78, 62);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 1;
            // 
            // txtOdeljenje
            // 
            this.txtOdeljenje.Location = new System.Drawing.Point(78, 114);
            this.txtOdeljenje.Name = "txtOdeljenje";
            this.txtOdeljenje.Size = new System.Drawing.Size(100, 20);
            this.txtOdeljenje.TabIndex = 3;
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
            this.cbJezik.Location = new System.Drawing.Point(68, 186);
            this.cbJezik.Name = "cbJezik";
            this.cbJezik.Size = new System.Drawing.Size(121, 21);
            this.cbJezik.TabIndex = 5;
            this.cbJezik.SelectedIndexChanged += new System.EventHandler(this.cbJezik_SelectedIndexChanged);
            // 
            // cbPrviPredmet
            // 
            this.cbPrviPredmet.FormattingEnabled = true;
            this.cbPrviPredmet.Location = new System.Drawing.Point(68, 224);
            this.cbPrviPredmet.Name = "cbPrviPredmet";
            this.cbPrviPredmet.Size = new System.Drawing.Size(121, 21);
            this.cbPrviPredmet.TabIndex = 6;
            // 
            // cbDrugiPredmet
            // 
            this.cbDrugiPredmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrugiPredmet.FormattingEnabled = true;
            this.cbDrugiPredmet.Items.AddRange(new object[] {
            "Matematika"});
            this.cbDrugiPredmet.Location = new System.Drawing.Point(68, 262);
            this.cbDrugiPredmet.Name = "cbDrugiPredmet";
            this.cbDrugiPredmet.Size = new System.Drawing.Size(121, 21);
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
            this.cbTreciPredmet.Location = new System.Drawing.Point(68, 302);
            this.cbTreciPredmet.Name = "cbTreciPredmet";
            this.cbTreciPredmet.Size = new System.Drawing.Size(121, 21);
            this.cbTreciPredmet.TabIndex = 8;
            this.cbTreciPredmet.SelectedIndexChanged += new System.EventHandler(this.cbTreciPredmet_SelectedIndexChanged);
            // 
            // btSacuvaj
            // 
            this.btSacuvaj.Location = new System.Drawing.Point(359, 161);
            this.btSacuvaj.Name = "btSacuvaj";
            this.btSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btSacuvaj.TabIndex = 9;
            this.btSacuvaj.Text = "Sacuvaj";
            this.btSacuvaj.UseVisualStyleBackColor = true;
            this.btSacuvaj.Click += new System.EventHandler(this.btSacuvaj_Click);
            // 
            // btSacuvajTemplate
            // 
            this.btSacuvajTemplate.Location = new System.Drawing.Point(495, 161);
            this.btSacuvajTemplate.Name = "btSacuvajTemplate";
            this.btSacuvajTemplate.Size = new System.Drawing.Size(126, 23);
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
            this.cbTipMature.Location = new System.Drawing.Point(68, 149);
            this.cbTipMature.Name = "cbTipMature";
            this.cbTipMature.Size = new System.Drawing.Size(121, 21);
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
            this.cbSkola.Location = new System.Drawing.Point(78, 87);
            this.cbSkola.Name = "cbSkola";
            this.cbSkola.Size = new System.Drawing.Size(121, 21);
            this.cbSkola.TabIndex = 11;
            this.cbSkola.SelectedIndexChanged += new System.EventHandler(this.cbSkola_SelectedIndexChanged);
            // 
            // btUcenikLevo
            // 
            this.btUcenikLevo.Location = new System.Drawing.Point(232, 382);
            this.btUcenikLevo.Name = "btUcenikLevo";
            this.btUcenikLevo.Size = new System.Drawing.Size(75, 23);
            this.btUcenikLevo.TabIndex = 12;
            this.btUcenikLevo.Text = "<";
            this.btUcenikLevo.UseVisualStyleBackColor = true;
            this.btUcenikLevo.Click += new System.EventHandler(this.btUcenikLevo_Click);
            // 
            // btUcenikDesno
            // 
            this.btUcenikDesno.Location = new System.Drawing.Point(530, 382);
            this.btUcenikDesno.Name = "btUcenikDesno";
            this.btUcenikDesno.Size = new System.Drawing.Size(75, 23);
            this.btUcenikDesno.TabIndex = 13;
            this.btUcenikDesno.Text = ">";
            this.btUcenikDesno.UseVisualStyleBackColor = true;
            this.btUcenikDesno.Click += new System.EventHandler(this.btUcenikDesno_Click);
            // 
            // unesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}