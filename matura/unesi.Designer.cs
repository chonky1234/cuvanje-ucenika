
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(132, 44);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.MaximumSize = new System.Drawing.Size(160, 22);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(160, 22);
            this.txtIme.TabIndex = 0;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(132, 76);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezime.MaximumSize = new System.Drawing.Size(160, 22);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(160, 22);
            this.txtPrezime.TabIndex = 1;
            // 
            // txtOdeljenje
            // 
            this.txtOdeljenje.Location = new System.Drawing.Point(132, 148);
            this.txtOdeljenje.Margin = new System.Windows.Forms.Padding(4);
            this.txtOdeljenje.MaximumSize = new System.Drawing.Size(160, 22);
            this.txtOdeljenje.Name = "txtOdeljenje";
            this.txtOdeljenje.Size = new System.Drawing.Size(160, 22);
            this.txtOdeljenje.TabIndex = 3;
            this.txtOdeljenje.TextChanged += new System.EventHandler(this.txtOdeljenje_TextChanged);
            // 
            // cbJezik
            // 
            this.cbJezik.FormattingEnabled = true;
            this.cbJezik.Items.AddRange(new object[] {
            "Srpski",
            "Engleski",
            "Ruski",
            "Madjarski",
            "Albanski"});
            this.cbJezik.Location = new System.Drawing.Point(132, 229);
            this.cbJezik.Margin = new System.Windows.Forms.Padding(4);
            this.cbJezik.MaximumSize = new System.Drawing.Size(160, 0);
            this.cbJezik.Name = "cbJezik";
            this.cbJezik.Size = new System.Drawing.Size(160, 24);
            this.cbJezik.TabIndex = 5;
            this.cbJezik.SelectedIndexChanged += new System.EventHandler(this.cbJezik_SelectedIndexChanged);
            // 
            // cbPrviPredmet
            // 
            this.cbPrviPredmet.FormattingEnabled = true;
            this.cbPrviPredmet.Location = new System.Drawing.Point(132, 276);
            this.cbPrviPredmet.Margin = new System.Windows.Forms.Padding(4);
            this.cbPrviPredmet.MaximumSize = new System.Drawing.Size(160, 0);
            this.cbPrviPredmet.Name = "cbPrviPredmet";
            this.cbPrviPredmet.Size = new System.Drawing.Size(160, 24);
            this.cbPrviPredmet.TabIndex = 6;
            // 
            // cbDrugiPredmet
            // 
            this.cbDrugiPredmet.FormattingEnabled = true;
            this.cbDrugiPredmet.Items.AddRange(new object[] {
            "Matematika"});
            this.cbDrugiPredmet.Location = new System.Drawing.Point(132, 322);
            this.cbDrugiPredmet.Margin = new System.Windows.Forms.Padding(4);
            this.cbDrugiPredmet.MaximumSize = new System.Drawing.Size(160, 0);
            this.cbDrugiPredmet.Name = "cbDrugiPredmet";
            this.cbDrugiPredmet.Size = new System.Drawing.Size(160, 24);
            this.cbDrugiPredmet.TabIndex = 7;
            // 
            // cbTreciPredmet
            // 
            this.cbTreciPredmet.FormattingEnabled = true;
            this.cbTreciPredmet.Items.AddRange(new object[] {
            "Programiranje",
            "Biologija",
            "Hemija"});
            this.cbTreciPredmet.Location = new System.Drawing.Point(132, 372);
            this.cbTreciPredmet.Margin = new System.Windows.Forms.Padding(4);
            this.cbTreciPredmet.MaximumSize = new System.Drawing.Size(160, 0);
            this.cbTreciPredmet.Name = "cbTreciPredmet";
            this.cbTreciPredmet.Size = new System.Drawing.Size(160, 24);
            this.cbTreciPredmet.TabIndex = 8;
            this.cbTreciPredmet.SelectedIndexChanged += new System.EventHandler(this.cbTreciPredmet_SelectedIndexChanged);
            // 
            // btSacuvaj
            // 
            this.btSacuvaj.Location = new System.Drawing.Point(405, 44);
            this.btSacuvaj.Margin = new System.Windows.Forms.Padding(4);
            this.btSacuvaj.MaximumSize = new System.Drawing.Size(145, 69);
            this.btSacuvaj.Name = "btSacuvaj";
            this.btSacuvaj.Size = new System.Drawing.Size(145, 69);
            this.btSacuvaj.TabIndex = 9;
            this.btSacuvaj.Text = "Sacuvaj";
            this.btSacuvaj.UseVisualStyleBackColor = true;
            this.btSacuvaj.Click += new System.EventHandler(this.btSacuvaj_Click);
            // 
            // btSacuvajTemplate
            // 
            this.btSacuvajTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSacuvajTemplate.Location = new System.Drawing.Point(784, 148);
            this.btSacuvajTemplate.Margin = new System.Windows.Forms.Padding(4);
            this.btSacuvajTemplate.MaximumSize = new System.Drawing.Size(245, 68);
            this.btSacuvajTemplate.Name = "btSacuvajTemplate";
            this.btSacuvajTemplate.Size = new System.Drawing.Size(245, 68);
            this.btSacuvajTemplate.TabIndex = 10;
            this.btSacuvajTemplate.Text = "Sacuvaj Template";
            this.btSacuvajTemplate.UseVisualStyleBackColor = true;
            this.btSacuvajTemplate.Click += new System.EventHandler(this.btSacuvajTemplate_Click);
            // 
            // cbTipMature
            // 
            this.cbTipMature.FormattingEnabled = true;
            this.cbTipMature.Items.AddRange(new object[] {
            "Opsti",
            "Strucni",
            "Umetnicki"});
            this.cbTipMature.Location = new System.Drawing.Point(132, 183);
            this.cbTipMature.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipMature.MaximumSize = new System.Drawing.Size(160, 0);
            this.cbTipMature.Name = "cbTipMature";
            this.cbTipMature.Size = new System.Drawing.Size(160, 24);
            this.cbTipMature.TabIndex = 4;
            this.cbTipMature.SelectedIndexChanged += new System.EventHandler(this.cbTipMature_SelectedIndexChanged);
            // 
            // cbSkola
            // 
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
            this.cbSkola.Location = new System.Drawing.Point(132, 111);
            this.cbSkola.Margin = new System.Windows.Forms.Padding(4);
            this.cbSkola.MaximumSize = new System.Drawing.Size(160, 0);
            this.cbSkola.Name = "cbSkola";
            this.cbSkola.Size = new System.Drawing.Size(160, 24);
            this.cbSkola.TabIndex = 11;
            this.cbSkola.SelectedIndexChanged += new System.EventHandler(this.cbSkola_SelectedIndexChanged);
            // 
            // btUcenikLevo
            // 
            this.btUcenikLevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btUcenikLevo.Location = new System.Drawing.Point(309, 470);
            this.btUcenikLevo.Margin = new System.Windows.Forms.Padding(4);
            this.btUcenikLevo.MaximumSize = new System.Drawing.Size(100, 28);
            this.btUcenikLevo.Name = "btUcenikLevo";
            this.btUcenikLevo.Size = new System.Drawing.Size(100, 28);
            this.btUcenikLevo.TabIndex = 12;
            this.btUcenikLevo.Text = "<";
            this.btUcenikLevo.UseVisualStyleBackColor = true;
            this.btUcenikLevo.Click += new System.EventHandler(this.btUcenikLevo_Click);
            // 
            // btUcenikDesno
            // 
            this.btUcenikDesno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btUcenikDesno.Location = new System.Drawing.Point(650, 470);
            this.btUcenikDesno.Margin = new System.Windows.Forms.Padding(4);
            this.btUcenikDesno.MaximumSize = new System.Drawing.Size(100, 28);
            this.btUcenikDesno.Name = "btUcenikDesno";
            this.btUcenikDesno.Size = new System.Drawing.Size(100, 28);
            this.btUcenikDesno.TabIndex = 13;
            this.btUcenikDesno.Text = ">";
            this.btUcenikDesno.UseVisualStyleBackColor = true;
            this.btUcenikDesno.Click += new System.EventHandler(this.btUcenikDesno_Click);
            // 
            // btnIzaberiTemplate
            // 
            this.btnIzaberiTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzaberiTemplate.Location = new System.Drawing.Point(784, 34);
            this.btnIzaberiTemplate.MaximumSize = new System.Drawing.Size(245, 88);
            this.btnIzaberiTemplate.Name = "btnIzaberiTemplate";
            this.btnIzaberiTemplate.Size = new System.Drawing.Size(245, 88);
            this.btnIzaberiTemplate.TabIndex = 14;
            this.btnIzaberiTemplate.Text = "Izaberi templejt";
            this.btnIzaberiTemplate.UseVisualStyleBackColor = true;
            this.btnIzaberiTemplate.Click += new System.EventHandler(this.btnIzaberiTemplate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::matura.Properties.Resources.slika;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1072, 556);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Skola";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Odeljenje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tip Mature";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Jezik";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Prvi Predmet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Drugi Predmet";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Treci Predmet";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(473, 226);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(502, 214);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // unesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "unesi";
            this.Text = "unesi";
            this.Load += new System.EventHandler(this.unesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
    }
}