namespace Regula_False_Yöntemi
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
            this.label1 = new System.Windows.Forms.Label();
            this.baslangicDeger1 = new System.Windows.Forms.TextBox();
            this.baslangicDeger2 = new System.Windows.Forms.TextBox();
            this.coz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regula False Yöntemi";
            // 
            // baslangicDeger1
            // 
            this.baslangicDeger1.Location = new System.Drawing.Point(163, 65);
            this.baslangicDeger1.Name = "baslangicDeger1";
            this.baslangicDeger1.Size = new System.Drawing.Size(100, 26);
            this.baslangicDeger1.TabIndex = 1;
            this.baslangicDeger1.Text = "1.0";
            // 
            // baslangicDeger2
            // 
            this.baslangicDeger2.Location = new System.Drawing.Point(269, 65);
            this.baslangicDeger2.Name = "baslangicDeger2";
            this.baslangicDeger2.Size = new System.Drawing.Size(100, 26);
            this.baslangicDeger2.TabIndex = 2;
            this.baslangicDeger2.Text = "2.0";
            // 
            // coz
            // 
            this.coz.Location = new System.Drawing.Point(385, 60);
            this.coz.Name = "coz";
            this.coz.Size = new System.Drawing.Size(75, 36);
            this.coz.TabIndex = 3;
            this.coz.Text = "Çöz";
            this.coz.UseVisualStyleBackColor = true;
            this.coz.Click += new System.EventHandler(this.coz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baslangıç Değerleri";
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(17, 102);
            this.data.Name = "data";
            this.data.RowTemplate.Height = 28;
            this.data.Size = new System.Drawing.Size(1448, 816);
            this.data.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 930);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.coz);
            this.Controls.Add(this.baslangicDeger2);
            this.Controls.Add(this.baslangicDeger1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox baslangicDeger1;
        private System.Windows.Forms.TextBox baslangicDeger2;
        private System.Windows.Forms.Button coz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView data;
    }
}

