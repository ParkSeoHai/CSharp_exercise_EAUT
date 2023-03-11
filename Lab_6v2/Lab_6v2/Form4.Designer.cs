namespace Lab_6v2
{
    partial class Form4
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
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textMaH = new System.Windows.Forms.TextBox();
            this.textTenH = new System.Windows.Forms.TextBox();
            this.textGiaH = new System.Windows.Forms.TextBox();
            this.btnSend4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(163, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin hàng hóa";
            // 
            // lable1
            // 
            this.lable1.BackColor = System.Drawing.Color.White;
            this.lable1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lable1.Location = new System.Drawing.Point(126, 143);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(113, 38);
            this.lable1.TabIndex = 1;
            this.lable1.Text = "Mã hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(126, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên hàng";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(126, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giá";
            // 
            // textMaH
            // 
            this.textMaH.Location = new System.Drawing.Point(296, 150);
            this.textMaH.Name = "textMaH";
            this.textMaH.Size = new System.Drawing.Size(230, 31);
            this.textMaH.TabIndex = 4;
            // 
            // textTenH
            // 
            this.textTenH.Location = new System.Drawing.Point(296, 215);
            this.textTenH.Name = "textTenH";
            this.textTenH.Size = new System.Drawing.Size(230, 31);
            this.textTenH.TabIndex = 5;
            // 
            // textGiaH
            // 
            this.textGiaH.Location = new System.Drawing.Point(296, 276);
            this.textGiaH.Name = "textGiaH";
            this.textGiaH.Size = new System.Drawing.Size(230, 31);
            this.textGiaH.TabIndex = 6;
            // 
            // btnSend4
            // 
            this.btnSend4.AutoSize = true;
            this.btnSend4.BackColor = System.Drawing.Color.Yellow;
            this.btnSend4.Location = new System.Drawing.Point(389, 349);
            this.btnSend4.Name = "btnSend4";
            this.btnSend4.Size = new System.Drawing.Size(227, 47);
            this.btnSend4.TabIndex = 7;
            this.btnSend4.Text = "Gửi thông tin sang Form5";
            this.btnSend4.UseVisualStyleBackColor = false;
            this.btnSend4.Click += new System.EventHandler(this.btnSend4_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSend4);
            this.Controls.Add(this.textGiaH);
            this.Controls.Add(this.textTenH);
            this.Controls.Add(this.textMaH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lable1;
        private Label label2;
        private Label label3;
        private TextBox textMaH;
        private TextBox textTenH;
        private TextBox textGiaH;
        private Button btnSend4;
    }
}