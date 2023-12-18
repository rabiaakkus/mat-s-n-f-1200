namespace mat_sınıfı_1200
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
            this.btnHesaplama = new System.Windows.Forms.Button();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.lblUst = new System.Windows.Forms.Label();
            this.lblKok = new System.Windows.Forms.Label();
            this.lblYuvarla = new System.Windows.Forms.Label();
            this.lblYukarıYuvarla = new System.Windows.Forms.Label();
            this.lblAsagıYuvarla = new System.Windows.Forms.Label();
            this.lblMutlak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesaplama
            // 
            this.btnHesaplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesaplama.Location = new System.Drawing.Point(27, 59);
            this.btnHesaplama.Name = "btnHesaplama";
            this.btnHesaplama.Size = new System.Drawing.Size(149, 64);
            this.btnHesaplama.TabIndex = 0;
            this.btnHesaplama.Text = "Hesaplama ;";
            this.btnHesaplama.UseVisualStyleBackColor = true;
            this.btnHesaplama.Click += new System.EventHandler(this.btnHesaplama_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(27, 24);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(149, 20);
            this.txtSayi.TabIndex = 1;
            // 
            // lblUst
            // 
            this.lblUst.AutoSize = true;
            this.lblUst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUst.Location = new System.Drawing.Point(193, 24);
            this.lblUst.Name = "lblUst";
            this.lblUst.Size = new System.Drawing.Size(108, 25);
            this.lblUst.TabIndex = 2;
            this.lblUst.Text = "Ust alma ;";
            // 
            // lblKok
            // 
            this.lblKok.AutoSize = true;
            this.lblKok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKok.Location = new System.Drawing.Point(204, 59);
            this.lblKok.Name = "lblKok";
            this.lblKok.Size = new System.Drawing.Size(217, 25);
            this.lblKok.TabIndex = 3;
            this.lblKok.Text = "Karakök Hesaplama ;";
            // 
            // lblYuvarla
            // 
            this.lblYuvarla.AutoSize = true;
            this.lblYuvarla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYuvarla.Location = new System.Drawing.Point(204, 98);
            this.lblYuvarla.Name = "lblYuvarla";
            this.lblYuvarla.Size = new System.Drawing.Size(127, 25);
            this.lblYuvarla.TabIndex = 4;
            this.lblYuvarla.Text = "Yuvarlama ;";
            // 
            // lblYukarıYuvarla
            // 
            this.lblYukarıYuvarla.AutoSize = true;
            this.lblYukarıYuvarla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYukarıYuvarla.Location = new System.Drawing.Point(204, 136);
            this.lblYukarıYuvarla.Name = "lblYukarıYuvarla";
            this.lblYukarıYuvarla.Size = new System.Drawing.Size(195, 25);
            this.lblYukarıYuvarla.TabIndex = 5;
            this.lblYukarıYuvarla.Text = "Yukarı Yuvarlama ;";
            // 
            // lblAsagıYuvarla
            // 
            this.lblAsagıYuvarla.AutoSize = true;
            this.lblAsagıYuvarla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAsagıYuvarla.Location = new System.Drawing.Point(204, 177);
            this.lblAsagıYuvarla.Name = "lblAsagıYuvarla";
            this.lblAsagıYuvarla.Size = new System.Drawing.Size(187, 25);
            this.lblAsagıYuvarla.TabIndex = 6;
            this.lblAsagıYuvarla.Text = "Aşağı Yuvarlama ;";
            // 
            // lblMutlak
            // 
            this.lblMutlak.AutoSize = true;
            this.lblMutlak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMutlak.Location = new System.Drawing.Point(204, 216);
            this.lblMutlak.Name = "lblMutlak";
            this.lblMutlak.Size = new System.Drawing.Size(152, 25);
            this.lblMutlak.TabIndex = 7;
            this.lblMutlak.Text = "Mutlak Değer ;";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(475, 305);
            this.Controls.Add(this.lblMutlak);
            this.Controls.Add(this.lblAsagıYuvarla);
            this.Controls.Add(this.lblYukarıYuvarla);
            this.Controls.Add(this.lblYuvarla);
            this.Controls.Add(this.lblKok);
            this.Controls.Add(this.lblUst);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.btnHesaplama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesaplama;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Label lblUst;
        private System.Windows.Forms.Label lblKok;
        private System.Windows.Forms.Label lblYuvarla;
        private System.Windows.Forms.Label lblYukarıYuvarla;
        private System.Windows.Forms.Label lblAsagıYuvarla;
        private System.Windows.Forms.Label lblMutlak;
    }
}

