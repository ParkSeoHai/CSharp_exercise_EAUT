namespace Lab_6v2
{
    partial class Form2
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
            this.lbTong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTich = new System.Windows.Forms.Label();
            this.lbHieu = new System.Windows.Forms.Label();
            this.lbThuong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.BackColor = System.Drawing.Color.Yellow;
            this.lbTong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTong.ForeColor = System.Drawing.Color.Black;
            this.lbTong.Location = new System.Drawing.Point(223, 158);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(76, 32);
            this.lbTong.TabIndex = 0;
            this.lbTong.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(160, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhận kết quả từ Form1";
            // 
            // lbTich
            // 
            this.lbTich.AutoSize = true;
            this.lbTich.BackColor = System.Drawing.Color.Yellow;
            this.lbTich.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTich.ForeColor = System.Drawing.Color.Black;
            this.lbTich.Location = new System.Drawing.Point(223, 243);
            this.lbTich.Name = "lbTich";
            this.lbTich.Size = new System.Drawing.Size(76, 32);
            this.lbTich.TabIndex = 2;
            this.lbTich.Text = "label1";
            // 
            // lbHieu
            // 
            this.lbHieu.AutoSize = true;
            this.lbHieu.BackColor = System.Drawing.Color.Yellow;
            this.lbHieu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbHieu.ForeColor = System.Drawing.Color.Black;
            this.lbHieu.Location = new System.Drawing.Point(401, 158);
            this.lbHieu.Name = "lbHieu";
            this.lbHieu.Size = new System.Drawing.Size(76, 32);
            this.lbHieu.TabIndex = 3;
            this.lbHieu.Text = "label1";
            // 
            // lbThuong
            // 
            this.lbThuong.AutoSize = true;
            this.lbThuong.BackColor = System.Drawing.Color.Yellow;
            this.lbThuong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbThuong.ForeColor = System.Drawing.Color.Black;
            this.lbThuong.Location = new System.Drawing.Point(401, 243);
            this.lbThuong.Name = "lbThuong";
            this.lbThuong.Size = new System.Drawing.Size(76, 32);
            this.lbThuong.TabIndex = 4;
            this.lbThuong.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbThuong);
            this.Controls.Add(this.lbHieu);
            this.Controls.Add(this.lbTich);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTong);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTong;
        private Label label2;
        private Label lbTich;
        private Label lbHieu;
        private Label lbThuong;
    }
}