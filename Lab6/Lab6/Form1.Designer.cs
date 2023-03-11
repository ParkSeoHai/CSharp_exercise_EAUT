namespace Lab6
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
            this.labelA = new System.Windows.Forms.Label();
            this.lableB = new System.Windows.Forms.Label();
            this.tSoA = new System.Windows.Forms.TextBox();
            this.mSoA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tSoB = new System.Windows.Forms.TextBox();
            this.mSoB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.BackColor = System.Drawing.Color.Red;
            this.labelA.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelA.Location = new System.Drawing.Point(166, 70);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(141, 38);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "Phân số A";
            // 
            // lableB
            // 
            this.lableB.AutoSize = true;
            this.lableB.BackColor = System.Drawing.Color.Red;
            this.lableB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lableB.Location = new System.Drawing.Point(411, 70);
            this.lableB.Name = "lableB";
            this.lableB.Size = new System.Drawing.Size(139, 38);
            this.lableB.TabIndex = 1;
            this.lableB.Text = "Phân số B";
            // 
            // tSoA
            // 
            this.tSoA.Location = new System.Drawing.Point(166, 164);
            this.tSoA.Name = "tSoA";
            this.tSoA.Size = new System.Drawing.Size(150, 31);
            this.tSoA.TabIndex = 2;
            // 
            // mSoA
            // 
            this.mSoA.Location = new System.Drawing.Point(166, 236);
            this.mSoA.Name = "mSoA";
            this.mSoA.Size = new System.Drawing.Size(150, 31);
            this.mSoA.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tử số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mẫu số";
            // 
            // tSoB
            // 
            this.tSoB.Location = new System.Drawing.Point(411, 166);
            this.tSoB.Name = "tSoB";
            this.tSoB.Size = new System.Drawing.Size(150, 31);
            this.tSoB.TabIndex = 6;
            // 
            // mSoB
            // 
            this.mSoB.Location = new System.Drawing.Point(411, 236);
            this.mSoB.Name = "mSoB";
            this.mSoB.Size = new System.Drawing.Size(150, 31);
            this.mSoB.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(166, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kết quả";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mSoB);
            this.Controls.Add(this.tSoB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mSoA);
            this.Controls.Add(this.tSoA);
            this.Controls.Add(this.lableB);
            this.Controls.Add(this.labelA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelA;
        private Label lableB;
        private TextBox tSoA;
        private TextBox mSoA;
        private Label label1;
        private Label label2;
        private TextBox tSoB;
        private TextBox mSoB;
        private Button button1;
    }
}