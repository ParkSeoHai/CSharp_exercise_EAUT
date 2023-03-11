namespace Lab7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textGt = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textClass = new System.Windows.Forms.TextBox();
            this.textMsv = new System.Windows.Forms.TextBox();
            this.listViewSv = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.textUrlImg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUrlImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(291, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 45);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhập thông tin sinh viên";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(42, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(488, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Họ tên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(42, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lớp";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textGt
            // 
            this.textGt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textGt.Location = new System.Drawing.Point(218, 148);
            this.textGt.Name = "textGt";
            this.textGt.Size = new System.Drawing.Size(205, 39);
            this.textGt.TabIndex = 13;
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textName.Location = new System.Drawing.Point(655, 88);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(250, 39);
            this.textName.TabIndex = 14;
            // 
            // textClass
            // 
            this.textClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textClass.Location = new System.Drawing.Point(218, 206);
            this.textClass.Name = "textClass";
            this.textClass.Size = new System.Drawing.Size(205, 39);
            this.textClass.TabIndex = 15;
            // 
            // textMsv
            // 
            this.textMsv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textMsv.Location = new System.Drawing.Point(218, 90);
            this.textMsv.Name = "textMsv";
            this.textMsv.Size = new System.Drawing.Size(205, 39);
            this.textMsv.TabIndex = 17;
            // 
            // listViewSv
            // 
            this.listViewSv.Location = new System.Drawing.Point(42, 326);
            this.listViewSv.Name = "listViewSv";
            this.listViewSv.Size = new System.Drawing.Size(538, 205);
            this.listViewSv.TabIndex = 18;
            this.listViewSv.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(232, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 47);
            this.button2.TabIndex = 19;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textUrlImg
            // 
            this.textUrlImg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textUrlImg.Location = new System.Drawing.Point(655, 143);
            this.textUrlImg.Name = "textUrlImg";
            this.textUrlImg.Size = new System.Drawing.Size(250, 39);
            this.textUrlImg.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(488, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 39);
            this.label6.TabIndex = 21;
            this.label6.Text = "Url Image";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(694, 326);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(198, 205);
            this.pictureBox.TabIndex = 22;
            this.pictureBox.TabStop = false;
            this.pictureBox.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(709, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 28);
            this.label7.TabIndex = 23;
            this.label7.Text = "Hiển thị ảnh ở đây";
            // 
            // btnUrlImg
            // 
            this.btnUrlImg.AutoSize = true;
            this.btnUrlImg.BackColor = System.Drawing.Color.White;
            this.btnUrlImg.Location = new System.Drawing.Point(655, 206);
            this.btnUrlImg.Name = "btnUrlImg";
            this.btnUrlImg.Size = new System.Drawing.Size(161, 35);
            this.btnUrlImg.TabIndex = 24;
            this.btnUrlImg.Text = "Choose url image";
            this.btnUrlImg.UseVisualStyleBackColor = false;
            this.btnUrlImg.Click += new System.EventHandler(this.btnUrlImg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(960, 543);
            this.Controls.Add(this.btnUrlImg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textUrlImg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listViewSv);
            this.Controls.Add(this.textMsv);
            this.Controls.Add(this.textClass);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textGt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label5;
        private Button button1;
        private Label label2;
        private Label label4;
        private TextBox textGt;
        private TextBox textName;
        private TextBox textClass;
        private TextBox textMsv;
        private ListView listViewSv;
        private Button button2;
        private TextBox textUrlImg;
        private Label label6;
        private PictureBox pictureBox;
        private Label label7;
        private Button btnUrlImg;
    }
}