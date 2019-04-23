namespace Mini_Paint
{
    partial class frmMiniPaint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgObrazek = new System.Windows.Forms.PictureBox();
            this.cmdZapisz = new System.Windows.Forms.Button();
            this.lblKolor = new System.Windows.Forms.Label();
            this.cmdKolor = new System.Windows.Forms.Button();
            this.cmdCzysc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgObrazek)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.imgObrazek);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 0;
            // 
            // imgObrazek
            // 
            this.imgObrazek.Location = new System.Drawing.Point(0, 0);
            this.imgObrazek.Name = "imgObrazek";
            this.imgObrazek.Size = new System.Drawing.Size(400, 400);
            this.imgObrazek.TabIndex = 0;
            this.imgObrazek.TabStop = false;
            this.imgObrazek.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.imgObrazek.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // cmdZapisz
            // 
            this.cmdZapisz.Location = new System.Drawing.Point(426, 79);
            this.cmdZapisz.Name = "cmdZapisz";
            this.cmdZapisz.Size = new System.Drawing.Size(75, 23);
            this.cmdZapisz.TabIndex = 1;
            this.cmdZapisz.Text = "Zapisz";
            this.cmdZapisz.UseVisualStyleBackColor = true;
            this.cmdZapisz.Click += new System.EventHandler(this.cmdZapisz_Click);
            // 
            // lblKolor
            // 
            this.lblKolor.BackColor = System.Drawing.Color.Black;
            this.lblKolor.Location = new System.Drawing.Point(423, 21);
            this.lblKolor.Name = "lblKolor";
            this.lblKolor.Size = new System.Drawing.Size(23, 23);
            this.lblKolor.TabIndex = 2;
            // 
            // cmdKolor
            // 
            this.cmdKolor.Location = new System.Drawing.Point(450, 21);
            this.cmdKolor.Name = "cmdKolor";
            this.cmdKolor.Size = new System.Drawing.Size(51, 23);
            this.cmdKolor.TabIndex = 3;
            this.cmdKolor.Text = "Kolor";
            this.cmdKolor.UseVisualStyleBackColor = true;
            this.cmdKolor.Click += new System.EventHandler(this.cmdKolor_Click);
            // 
            // cmdCzysc
            // 
            this.cmdCzysc.Location = new System.Drawing.Point(426, 50);
            this.cmdCzysc.Name = "cmdCzysc";
            this.cmdCzysc.Size = new System.Drawing.Size(75, 23);
            this.cmdCzysc.TabIndex = 4;
            this.cmdCzysc.Text = "Czyœæ";
            this.cmdCzysc.UseVisualStyleBackColor = true;
            this.cmdCzysc.Click += new System.EventHandler(this.cmdCzysc_Click);
            // 
            // frmMiniPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(506, 444);
            this.Controls.Add(this.cmdCzysc);
            this.Controls.Add(this.cmdKolor);
            this.Controls.Add(this.lblKolor);
            this.Controls.Add(this.cmdZapisz);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmMiniPaint";
            this.Text = "Mini Paint";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgObrazek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgObrazek;
        private System.Windows.Forms.Button cmdZapisz;
        private System.Windows.Forms.Label lblKolor;
        private System.Windows.Forms.Button cmdKolor;
        private System.Windows.Forms.Button cmdCzysc;
    }
}

