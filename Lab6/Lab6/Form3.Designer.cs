namespace Lab6
{
    partial class Form3
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
            this.textTk = new System.Windows.Forms.TextBox();
            this.textMk = new System.Windows.Forms.TextBox();
            this.textMk2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(317, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(162, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(162, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(162, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // textTk
            // 
            this.textTk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTk.Location = new System.Drawing.Point(386, 142);
            this.textTk.Name = "textTk";
            this.textTk.Size = new System.Drawing.Size(246, 39);
            this.textTk.TabIndex = 4;
            // 
            // textMk
            // 
            this.textMk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textMk.Location = new System.Drawing.Point(386, 204);
            this.textMk.Name = "textMk";
            this.textMk.PasswordChar = '*';
            this.textMk.Size = new System.Drawing.Size(246, 39);
            this.textMk.TabIndex = 5;
            // 
            // textMk2
            // 
            this.textMk2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textMk2.Location = new System.Drawing.Point(386, 271);
            this.textMk2.Name = "textMk2";
            this.textMk2.PasswordChar = '*';
            this.textMk2.Size = new System.Drawing.Size(246, 39);
            this.textMk2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(520, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Đăng ký";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textMk2);
            this.Controls.Add(this.textMk);
            this.Controls.Add(this.textTk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textTk;
        private TextBox textMk;
        private TextBox textMk2;
        private Button button1;
    }
}