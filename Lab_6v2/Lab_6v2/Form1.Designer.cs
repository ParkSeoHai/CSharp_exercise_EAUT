namespace Lab_6v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textTsA = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textMsA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTsB = new System.Windows.Forms.TextBox();
            this.textMsB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textTsA
            // 
            this.textTsA.Location = new System.Drawing.Point(222, 140);
            this.textTsA.Name = "textTsA";
            this.textTsA.Size = new System.Drawing.Size(123, 31);
            this.textTsA.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = true;
            this.btnSend.Location = new System.Drawing.Point(95, 285);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(213, 35);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Gửi kết quả sang Form2";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(95, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phân số A";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(95, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tử số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(95, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mẫu số";
            // 
            // textMsA
            // 
            this.textMsA.Location = new System.Drawing.Point(222, 207);
            this.textMsA.Name = "textMsA";
            this.textMsA.Size = new System.Drawing.Size(123, 31);
            this.textMsA.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(435, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phân số B";
            // 
            // textTsB
            // 
            this.textTsB.Location = new System.Drawing.Point(435, 140);
            this.textTsB.Name = "textTsB";
            this.textTsB.Size = new System.Drawing.Size(123, 31);
            this.textTsB.TabIndex = 7;
            // 
            // textMsB
            // 
            this.textMsB.Location = new System.Drawing.Point(435, 210);
            this.textMsB.Name = "textMsB";
            this.textMsB.Size = new System.Drawing.Size(123, 31);
            this.textMsB.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textMsB);
            this.Controls.Add(this.textTsB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textMsA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textTsA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textTsA;
        private Button btnSend;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textMsA;
        private Label label4;
        private TextBox textTsB;
        private TextBox textMsB;
    }
}