
namespace WindowsFormsApp3
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
            this.but = new System.Windows.Forms.Button();
            this.kul = new System.Windows.Forms.TextBox();
            this.par = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but
            // 
            this.but.Location = new System.Drawing.Point(378, 256);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(126, 95);
            this.but.TabIndex = 0;
            this.but.Text = "bitir";
            this.but.UseVisualStyleBackColor = true;
            this.but.Click += new System.EventHandler(this.button1_Click);
            // 
            // kul
            // 
            this.kul.Location = new System.Drawing.Point(378, 73);
            this.kul.Name = "kul";
            this.kul.Size = new System.Drawing.Size(232, 22);
            this.kul.TabIndex = 1;
            // 
            // par
            // 
            this.par.Location = new System.Drawing.Point(378, 127);
            this.par.Name = "par";
            this.par.Size = new System.Drawing.Size(231, 22);
            this.par.TabIndex = 2;
            this.par.TextChanged += new System.EventHandler(this.par_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "kulanıcı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "parola";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.par);
            this.Controls.Add(this.kul);
            this.Controls.Add(this.but);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but;
        private System.Windows.Forms.TextBox kul;
        private System.Windows.Forms.TextBox par;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

