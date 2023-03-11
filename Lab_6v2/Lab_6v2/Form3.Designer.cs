namespace Lab_6v2
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
            this.radioBt1 = new System.Windows.Forms.RadioButton();
            this.radioBt2 = new System.Windows.Forms.RadioButton();
            this.btnLc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(306, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lựa chọn";
            // 
            // radioBt1
            // 
            this.radioBt1.AutoSize = true;
            this.radioBt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioBt1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBt1.Location = new System.Drawing.Point(179, 168);
            this.radioBt1.Name = "radioBt1";
            this.radioBt1.Size = new System.Drawing.Size(149, 42);
            this.radioBt1.TabIndex = 1;
            this.radioBt1.TabStop = true;
            this.radioBt1.Text = "Bài tập 1";
            this.radioBt1.UseVisualStyleBackColor = false;
            // 
            // radioBt2
            // 
            this.radioBt2.AutoSize = true;
            this.radioBt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioBt2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBt2.Location = new System.Drawing.Point(179, 248);
            this.radioBt2.Name = "radioBt2";
            this.radioBt2.Size = new System.Drawing.Size(149, 42);
            this.radioBt2.TabIndex = 2;
            this.radioBt2.TabStop = true;
            this.radioBt2.Text = "Bài tập 2";
            this.radioBt2.UseVisualStyleBackColor = false;
            // 
            // btnLc
            // 
            this.btnLc.BackColor = System.Drawing.Color.White;
            this.btnLc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLc.Location = new System.Drawing.Point(179, 319);
            this.btnLc.Name = "btnLc";
            this.btnLc.Size = new System.Drawing.Size(112, 34);
            this.btnLc.TabIndex = 3;
            this.btnLc.Text = "Chọn";
            this.btnLc.UseVisualStyleBackColor = false;
            this.btnLc.Click += new System.EventHandler(this.btnLc_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(353, 319);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLc);
            this.Controls.Add(this.radioBt2);
            this.Controls.Add(this.radioBt1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton radioBt1;
        private RadioButton radioBt2;
        private Button btnLc;
        private Button btnExit;
    }
}