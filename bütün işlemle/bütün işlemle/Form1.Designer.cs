namespace bütün_işlemle
{
    partial class FormButunislemler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBirinciSayi = new System.Windows.Forms.TextBox();
            this.lblBirinciSayi = new System.Windows.Forms.Label();
            this.lblIkincisayi = new System.Windows.Forms.Label();
            this.txtIkincisayi = new System.Windows.Forms.TextBox();
            this.btnToplama = new System.Windows.Forms.Button();
            this.btnEksi = new System.Windows.Forms.Button();
            this.btnCarpi = new System.Windows.Forms.Button();
            this.btnBolu = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBirinciSayi
            // 
            this.txtBirinciSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirinciSayi.Location = new System.Drawing.Point(190, 74);
            this.txtBirinciSayi.Name = "txtBirinciSayi";
            this.txtBirinciSayi.Size = new System.Drawing.Size(167, 26);
            this.txtBirinciSayi.TabIndex = 0;
            this.txtBirinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBirinciSayi_KeyPress);
            // 
            // lblBirinciSayi
            // 
            this.lblBirinciSayi.AutoSize = true;
            this.lblBirinciSayi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBirinciSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirinciSayi.ForeColor = System.Drawing.Color.Blue;
            this.lblBirinciSayi.Location = new System.Drawing.Point(6, 69);
            this.lblBirinciSayi.Name = "lblBirinciSayi";
            this.lblBirinciSayi.Size = new System.Drawing.Size(169, 31);
            this.lblBirinciSayi.TabIndex = 1;
            this.lblBirinciSayi.Text = "Birinci Sayı:";
            // 
            // lblIkincisayi
            // 
            this.lblIkincisayi.AutoSize = true;
            this.lblIkincisayi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblIkincisayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIkincisayi.ForeColor = System.Drawing.Color.Blue;
            this.lblIkincisayi.Location = new System.Drawing.Point(10, 112);
            this.lblIkincisayi.Name = "lblIkincisayi";
            this.lblIkincisayi.Size = new System.Drawing.Size(157, 31);
            this.lblIkincisayi.TabIndex = 2;
            this.lblIkincisayi.Text = "İkinci Sayı:";
            // 
            // txtIkincisayi
            // 
            this.txtIkincisayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIkincisayi.Location = new System.Drawing.Point(190, 112);
            this.txtIkincisayi.Name = "txtIkincisayi";
            this.txtIkincisayi.Size = new System.Drawing.Size(167, 26);
            this.txtIkincisayi.TabIndex = 3;
            this.txtIkincisayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIkincisayi_KeyPress);
            // 
            // btnToplama
            // 
            this.btnToplama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnToplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToplama.ForeColor = System.Drawing.Color.Blue;
            this.btnToplama.Location = new System.Drawing.Point(28, 160);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(66, 53);
            this.btnToplama.TabIndex = 4;
            this.btnToplama.Text = "+";
            this.btnToplama.UseVisualStyleBackColor = false;
            this.btnToplama.Click += new System.EventHandler(this.BtnToplama_Click);
            // 
            // btnEksi
            // 
            this.btnEksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEksi.ForeColor = System.Drawing.Color.Blue;
            this.btnEksi.Location = new System.Drawing.Point(117, 160);
            this.btnEksi.Name = "btnEksi";
            this.btnEksi.Size = new System.Drawing.Size(58, 53);
            this.btnEksi.TabIndex = 5;
            this.btnEksi.Text = "-";
            this.btnEksi.UseVisualStyleBackColor = false;
            this.btnEksi.Click += new System.EventHandler(this.BtnEksi_Click);
            // 
            // btnCarpi
            // 
            this.btnCarpi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCarpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCarpi.ForeColor = System.Drawing.Color.Blue;
            this.btnCarpi.Location = new System.Drawing.Point(202, 160);
            this.btnCarpi.Name = "btnCarpi";
            this.btnCarpi.Size = new System.Drawing.Size(64, 53);
            this.btnCarpi.TabIndex = 6;
            this.btnCarpi.Text = "*";
            this.btnCarpi.UseVisualStyleBackColor = false;
            this.btnCarpi.Click += new System.EventHandler(this.BtnCarpi_Click);
            // 
            // btnBolu
            // 
            this.btnBolu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolu.ForeColor = System.Drawing.Color.Blue;
            this.btnBolu.Location = new System.Drawing.Point(289, 160);
            this.btnBolu.Name = "btnBolu";
            this.btnBolu.Size = new System.Drawing.Size(68, 53);
            this.btnBolu.TabIndex = 7;
            this.btnBolu.Text = "/";
            this.btnBolu.UseVisualStyleBackColor = false;
            this.btnBolu.Click += new System.EventHandler(this.BtnBolu_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.Color.Blue;
            this.lblSonuc.Location = new System.Drawing.Point(62, 247);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(105, 31);
            this.lblSonuc.TabIndex = 8;
            this.lblSonuc.Text = "Sonuç:";
            // 
            // txtSonuc
            // 
            this.txtSonuc.Enabled = false;
            this.txtSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonuc.Location = new System.Drawing.Point(173, 228);
            this.txtSonuc.Multiline = true;
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(184, 50);
            this.txtSonuc.TabIndex = 9;
            // 
            // FormButunislemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(387, 305);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnBolu);
            this.Controls.Add(this.btnCarpi);
            this.Controls.Add(this.btnEksi);
            this.Controls.Add(this.btnToplama);
            this.Controls.Add(this.txtIkincisayi);
            this.Controls.Add(this.lblIkincisayi);
            this.Controls.Add(this.lblBirinciSayi);
            this.Controls.Add(this.txtBirinciSayi);
            this.Name = "FormButunislemler";
            this.Text = "Bütün İşlemler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBirinciSayi;
        private System.Windows.Forms.Label lblBirinciSayi;
        private System.Windows.Forms.Label lblIkincisayi;
        private System.Windows.Forms.TextBox txtIkincisayi;
        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.Button btnEksi;
        private System.Windows.Forms.Button btnCarpi;
        private System.Windows.Forms.Button btnBolu;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtSonuc;
    }
}

