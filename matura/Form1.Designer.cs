
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
            this.components = new System.ComponentModel.Container();
            this.btUnesiUcenika = new System.Windows.Forms.Button();
            this.btEditUcenika = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btUnesiUcenika
            // 
            this.btUnesiUcenika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btUnesiUcenika.Location = new System.Drawing.Point(328, 342);
            this.btUnesiUcenika.Margin = new System.Windows.Forms.Padding(4);
            this.btUnesiUcenika.Name = "btUnesiUcenika";
            this.btUnesiUcenika.Size = new System.Drawing.Size(302, 141);
            this.btUnesiUcenika.TabIndex = 0;
            this.btUnesiUcenika.Text = "Unesi ucenika";
            this.btUnesiUcenika.UseVisualStyleBackColor = true;
            this.btUnesiUcenika.Click += new System.EventHandler(this.btUnesiUcenika_Click);
            // 
            // btEditUcenika
            // 
            this.btEditUcenika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditUcenika.Location = new System.Drawing.Point(482, 342);
            this.btEditUcenika.Margin = new System.Windows.Forms.Padding(4);
            this.btEditUcenika.Name = "btEditUcenika";
            this.btEditUcenika.Size = new System.Drawing.Size(285, 141);
            this.btEditUcenika.TabIndex = 1;
            this.btEditUcenika.Text = "edituj ucenika";
            this.btEditUcenika.UseVisualStyleBackColor = true;
            this.btEditUcenika.Click += new System.EventHandler(this.btEditUcenika_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Image = global::matura.Properties.Resources.pare_2;
            this.button1.Location = new System.Drawing.Point(682, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 177);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::matura.Properties.Resources.Masterpiece;
            this.pictureBox1.Location = new System.Drawing.Point(0, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1146, 681);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 666);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btEditUcenika);
            this.Controls.Add(this.btUnesiUcenika);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btUnesiUcenika;
        private System.Windows.Forms.Button btEditUcenika;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

