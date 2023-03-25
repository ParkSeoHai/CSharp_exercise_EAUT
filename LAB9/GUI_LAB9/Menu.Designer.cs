namespace GUI_LAB9
{
    partial class Menu
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
            this.radioQLH = new System.Windows.Forms.RadioButton();
            this.radioQLKH = new System.Windows.Forms.RadioButton();
            this.radioQLHD = new System.Windows.Forms.RadioButton();
            this.btnChon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU QUẢN LÝ";
            // 
            // radioQLH
            // 
            this.radioQLH.AutoSize = true;
            this.radioQLH.BackColor = System.Drawing.Color.White;
            this.radioQLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioQLH.Location = new System.Drawing.Point(311, 123);
            this.radioQLH.Name = "radioQLH";
            this.radioQLH.Size = new System.Drawing.Size(182, 33);
            this.radioQLH.TabIndex = 1;
            this.radioQLH.TabStop = true;
            this.radioQLH.Text = "Quản lý Hàng";
            this.radioQLH.UseVisualStyleBackColor = false;
            // 
            // radioQLKH
            // 
            this.radioQLKH.AutoSize = true;
            this.radioQLKH.BackColor = System.Drawing.Color.White;
            this.radioQLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioQLKH.Location = new System.Drawing.Point(272, 269);
            this.radioQLKH.Name = "radioQLKH";
            this.radioQLKH.Size = new System.Drawing.Size(261, 33);
            this.radioQLKH.TabIndex = 2;
            this.radioQLKH.TabStop = true;
            this.radioQLKH.Text = "Quản lý Khách  Hàng";
            this.radioQLKH.UseVisualStyleBackColor = false;
            // 
            // radioQLHD
            // 
            this.radioQLHD.AutoSize = true;
            this.radioQLHD.BackColor = System.Drawing.Color.White;
            this.radioQLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioQLHD.Location = new System.Drawing.Point(290, 199);
            this.radioQLHD.Name = "radioQLHD";
            this.radioQLHD.Size = new System.Drawing.Size(219, 33);
            this.radioQLHD.TabIndex = 3;
            this.radioQLHD.TabStop = true;
            this.radioQLHD.Text = "Quản lý Hóa Đơn";
            this.radioQLHD.UseVisualStyleBackColor = false;
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.White;
            this.btnChon.Location = new System.Drawing.Point(338, 351);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(131, 42);
            this.btnChon.TabIndex = 4;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.radioQLHD);
            this.Controls.Add(this.radioQLKH);
            this.Controls.Add(this.radioQLH);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioQLH;
        private System.Windows.Forms.RadioButton radioQLKH;
        private System.Windows.Forms.RadioButton radioQLHD;
        private System.Windows.Forms.Button btnChon;
    }
}

