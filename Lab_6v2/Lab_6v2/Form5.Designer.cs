namespace Lab_6v2
{
    partial class Form5
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTenH = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbMH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(151, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhận thông tin từ Form4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(151, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(151, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(151, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // lbTenH
            // 
            this.lbTenH.AutoSize = true;
            this.lbTenH.BackColor = System.Drawing.Color.White;
            this.lbTenH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTenH.Location = new System.Drawing.Point(315, 231);
            this.lbTenH.Name = "lbTenH";
            this.lbTenH.Size = new System.Drawing.Size(83, 32);
            this.lbTenH.TabIndex = 4;
            this.lbTenH.Text = "Lable2";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.BackColor = System.Drawing.Color.White;
            this.lbGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGia.Location = new System.Drawing.Point(315, 297);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(78, 32);
            this.lbGia.TabIndex = 5;
            this.lbGia.Text = "lable3";
            // 
            // lbMH
            // 
            this.lbMH.AutoSize = true;
            this.lbMH.BackColor = System.Drawing.Color.White;
            this.lbMH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMH.Location = new System.Drawing.Point(315, 159);
            this.lbMH.Name = "lbMH";
            this.lbMH.Size = new System.Drawing.Size(78, 32);
            this.lbMH.TabIndex = 6;
            this.lbMH.Text = "lable1";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbMH);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbTenH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbTenH;
        private Label lbGia;
        private Label lbMH;
    }
}