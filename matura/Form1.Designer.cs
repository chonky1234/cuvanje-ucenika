
namespace matura
{
    partial class Form1
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
            this.btUnesiUcenika = new System.Windows.Forms.Button();
            this.btUcitajTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btUnesiUcenika
            // 
            this.btUnesiUcenika.Location = new System.Drawing.Point(284, 128);
            this.btUnesiUcenika.Name = "btUnesiUcenika";
            this.btUnesiUcenika.Size = new System.Drawing.Size(121, 50);
            this.btUnesiUcenika.TabIndex = 0;
            this.btUnesiUcenika.Text = "Unesi ucenika";
            this.btUnesiUcenika.UseVisualStyleBackColor = true;
            this.btUnesiUcenika.Click += new System.EventHandler(this.btUnesiUcenika_Click);
            // 
            // btUcitajTemplate
            // 
            this.btUcitajTemplate.Location = new System.Drawing.Point(483, 142);
            this.btUcitajTemplate.Name = "btUcitajTemplate";
            this.btUcitajTemplate.Size = new System.Drawing.Size(163, 36);
            this.btUcitajTemplate.TabIndex = 1;
            this.btUcitajTemplate.Text = "Ucitaj Template";
            this.btUcitajTemplate.UseVisualStyleBackColor = true;
            this.btUcitajTemplate.Click += new System.EventHandler(this.btUcitajTemplate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btUcitajTemplate);
            this.Controls.Add(this.btUnesiUcenika);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btUnesiUcenika;
        private System.Windows.Forms.Button btUcitajTemplate;
    }
}

