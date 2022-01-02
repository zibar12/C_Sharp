
namespace WindowsFormsApp3
{
    partial class giris
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
            this.par = new System.Windows.Forms.TextBox();
            this.but = new System.Windows.Forms.Button();
            this.kul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // par
            // 
            this.par.Location = new System.Drawing.Point(391, 144);
            this.par.Name = "par";
            this.par.Size = new System.Drawing.Size(157, 22);
            this.par.TabIndex = 0;
            // 
            // but
            // 
            this.but.Location = new System.Drawing.Point(403, 226);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(109, 76);
            this.but.TabIndex = 1;
            this.but.Text = "button1";
            this.but.UseVisualStyleBackColor = true;
            this.but.Click += new System.EventHandler(this.button1_Click);
            // 
            // kul
            // 
            this.kul.Location = new System.Drawing.Point(391, 77);
            this.kul.Name = "kul";
            this.kul.Size = new System.Drawing.Size(156, 22);
            this.kul.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "uzun kena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "kısa kenar";
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kul);
            this.Controls.Add(this.but);
            this.Controls.Add(this.par);
            this.Name = "giris";
            this.Text = "giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox par;
        private System.Windows.Forms.Button but;
        private System.Windows.Forms.TextBox kul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}