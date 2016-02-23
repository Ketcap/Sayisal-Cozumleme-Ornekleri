namespace Sekant_Yöntemi
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
            this.baslangicDeger1 = new System.Windows.Forms.TextBox();
            this.textboxlabel = new System.Windows.Forms.Label();
            this.baslik = new System.Windows.Forms.Label();
            this.baslangicDeger2 = new System.Windows.Forms.TextBox();
            this.coz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // baslangicDeger1
            // 
            this.baslangicDeger1.Location = new System.Drawing.Point(174, 59);
            this.baslangicDeger1.Name = "baslangicDeger1";
            this.baslangicDeger1.Size = new System.Drawing.Size(100, 26);
            this.baslangicDeger1.TabIndex = 2;
            this.baslangicDeger1.Text = "2.0";
            // 
            // textboxlabel
            // 
            this.textboxlabel.AutoSize = true;
            this.textboxlabel.Location = new System.Drawing.Point(12, 62);
            this.textboxlabel.Name = "textboxlabel";
            this.textboxlabel.Size = new System.Drawing.Size(146, 20);
            this.textboxlabel.TabIndex = 3;
            this.textboxlabel.Text = "Başlangıç Değerleri";
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.Location = new System.Drawing.Point(13, 13);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(196, 29);
            this.baslik.TabIndex = 4;
            this.baslik.Text = "Sekant Yöntemi";
            // 
            // baslangicDeger2
            // 
            this.baslangicDeger2.Location = new System.Drawing.Point(280, 59);
            this.baslangicDeger2.Name = "baslangicDeger2";
            this.baslangicDeger2.Size = new System.Drawing.Size(100, 26);
            this.baslangicDeger2.TabIndex = 5;
            this.baslangicDeger2.Text = "0.0";
            // 
            // coz
            // 
            this.coz.Location = new System.Drawing.Point(385, 54);
            this.coz.Name = "coz";
            this.coz.Size = new System.Drawing.Size(75, 35);
            this.coz.TabIndex = 6;
            this.coz.Text = "Çöz";
            this.coz.UseVisualStyleBackColor = true;
            this.coz.Click += new System.EventHandler(this.coz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(982, 761);
            this.dataGridView1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 877);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.coz);
            this.Controls.Add(this.baslangicDeger2);
            this.Controls.Add(this.baslik);
            this.Controls.Add(this.textboxlabel);
            this.Controls.Add(this.baslangicDeger1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox baslangicDeger1;
        private System.Windows.Forms.Label textboxlabel;
        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.TextBox baslangicDeger2;
        private System.Windows.Forms.Button coz;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

