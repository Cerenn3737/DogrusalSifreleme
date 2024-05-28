namespace DoğrusalŞifreleme
{
    partial class Form1
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
            this.txtmetin = new System.Windows.Forms.TextBox();
            this.txtsifrelimetin = new System.Windows.Forms.TextBox();
            this.txtdesifrelimetin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numA = new System.Windows.Forms.NumericUpDown();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.btnsifrele = new System.Windows.Forms.Button();
            this.btndesifrele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmetin
            // 
            this.txtmetin.BackColor = System.Drawing.Color.LightBlue;
            this.txtmetin.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmetin.ForeColor = System.Drawing.Color.Black;
            this.txtmetin.Location = new System.Drawing.Point(192, 25);
            this.txtmetin.Multiline = true;
            this.txtmetin.Name = "txtmetin";
            this.txtmetin.Size = new System.Drawing.Size(280, 124);
            this.txtmetin.TabIndex = 0;
            // 
            // txtsifrelimetin
            // 
            this.txtsifrelimetin.BackColor = System.Drawing.Color.LightBlue;
            this.txtsifrelimetin.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifrelimetin.ForeColor = System.Drawing.Color.Black;
            this.txtsifrelimetin.Location = new System.Drawing.Point(192, 201);
            this.txtsifrelimetin.Multiline = true;
            this.txtsifrelimetin.Name = "txtsifrelimetin";
            this.txtsifrelimetin.Size = new System.Drawing.Size(280, 128);
            this.txtsifrelimetin.TabIndex = 1;
            // 
            // txtdesifrelimetin
            // 
            this.txtdesifrelimetin.BackColor = System.Drawing.Color.LightBlue;
            this.txtdesifrelimetin.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdesifrelimetin.ForeColor = System.Drawing.Color.Black;
            this.txtdesifrelimetin.Location = new System.Drawing.Point(192, 373);
            this.txtdesifrelimetin.Multiline = true;
            this.txtdesifrelimetin.Name = "txtdesifrelimetin";
            this.txtdesifrelimetin.Size = new System.Drawing.Size(280, 126);
            this.txtdesifrelimetin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(109, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Metin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(61, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifreli Metin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(43, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Deşifreli Metin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(656, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "y=ax+b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(626, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "a:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(626, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "b:";
            // 
            // numA
            // 
            this.numA.BackColor = System.Drawing.Color.Gainsboro;
            this.numA.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numA.ForeColor = System.Drawing.SystemColors.InfoText;
            this.numA.Location = new System.Drawing.Point(660, 71);
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(72, 27);
            this.numA.TabIndex = 9;
            // 
            // numB
            // 
            this.numB.BackColor = System.Drawing.Color.Gainsboro;
            this.numB.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numB.Location = new System.Drawing.Point(660, 121);
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(72, 27);
            this.numB.TabIndex = 10;
            // 
            // btnsifrele
            // 
            this.btnsifrele.BackColor = System.Drawing.Color.Navy;
            this.btnsifrele.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsifrele.ForeColor = System.Drawing.Color.White;
            this.btnsifrele.Location = new System.Drawing.Point(192, 161);
            this.btnsifrele.Name = "btnsifrele";
            this.btnsifrele.Size = new System.Drawing.Size(97, 34);
            this.btnsifrele.TabIndex = 11;
            this.btnsifrele.Text = "ŞİFRELE";
            this.btnsifrele.UseVisualStyleBackColor = false;
            this.btnsifrele.Click += new System.EventHandler(this.btnsifrele_Click);
            // 
            // btndesifrele
            // 
            this.btndesifrele.BackColor = System.Drawing.Color.Navy;
            this.btndesifrele.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndesifrele.ForeColor = System.Drawing.Color.White;
            this.btndesifrele.Location = new System.Drawing.Point(192, 335);
            this.btndesifrele.Name = "btndesifrele";
            this.btndesifrele.Size = new System.Drawing.Size(111, 32);
            this.btndesifrele.TabIndex = 12;
            this.btndesifrele.Text = "DEŞİFRELE";
            this.btndesifrele.UseVisualStyleBackColor = false;
            this.btndesifrele.Click += new System.EventHandler(this.btndesifrele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 520);
            this.Controls.Add(this.btndesifrele);
            this.Controls.Add(this.btnsifrele);
            this.Controls.Add(this.numB);
            this.Controls.Add(this.numA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdesifrelimetin);
            this.Controls.Add(this.txtsifrelimetin);
            this.Controls.Add(this.txtmetin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doğrusal Şifreleme";
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmetin;
        private System.Windows.Forms.TextBox txtsifrelimetin;
        private System.Windows.Forms.TextBox txtdesifrelimetin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numA;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.Button btnsifrele;
        private System.Windows.Forms.Button btndesifrele;
    }
}

