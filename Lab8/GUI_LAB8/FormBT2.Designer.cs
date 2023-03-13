namespace GUI_LAB8
{
    partial class FormBT2
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCanhA = new System.Windows.Forms.TextBox();
            this.txtCanhC = new System.Windows.Forms.TextBox();
            this.txtCanhB = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnChuVi = new System.Windows.Forms.Button();
            this.btnDienTich = new System.Windows.Forms.Button();
            this.dtGridViewBT2 = new System.Windows.Forms.DataGridView();
            this.btnAddCSDL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewBT2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÀI TẬP 2 - LAB 8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cạnh a: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cạnh c: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cạnh b:";
            // 
            // txtCanhA
            // 
            this.txtCanhA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanhA.Location = new System.Drawing.Point(203, 118);
            this.txtCanhA.Name = "txtCanhA";
            this.txtCanhA.Size = new System.Drawing.Size(159, 30);
            this.txtCanhA.TabIndex = 5;
            // 
            // txtCanhC
            // 
            this.txtCanhC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanhC.Location = new System.Drawing.Point(203, 246);
            this.txtCanhC.Name = "txtCanhC";
            this.txtCanhC.Size = new System.Drawing.Size(159, 30);
            this.txtCanhC.TabIndex = 6;
            // 
            // txtCanhB
            // 
            this.txtCanhB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanhB.Location = new System.Drawing.Point(203, 182);
            this.txtCanhB.Name = "txtCanhB";
            this.txtCanhB.Size = new System.Drawing.Size(159, 30);
            this.txtCanhB.TabIndex = 7;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(40, 346);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(118, 42);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnChuVi
            // 
            this.btnChuVi.Location = new System.Drawing.Point(40, 445);
            this.btnChuVi.Name = "btnChuVi";
            this.btnChuVi.Size = new System.Drawing.Size(118, 42);
            this.btnChuVi.TabIndex = 9;
            this.btnChuVi.Text = "Tính chu vi";
            this.btnChuVi.UseVisualStyleBackColor = true;
            this.btnChuVi.Click += new System.EventHandler(this.btnChuVi_Click);
            // 
            // btnDienTich
            // 
            this.btnDienTich.Location = new System.Drawing.Point(203, 432);
            this.btnDienTich.Name = "btnDienTich";
            this.btnDienTich.Size = new System.Drawing.Size(118, 55);
            this.btnDienTich.TabIndex = 10;
            this.btnDienTich.Text = "Tính diện tích";
            this.btnDienTich.UseVisualStyleBackColor = true;
            this.btnDienTich.Click += new System.EventHandler(this.btnDienTich_Click);
            // 
            // dtGridViewBT2
            // 
            this.dtGridViewBT2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewBT2.Location = new System.Drawing.Point(412, 104);
            this.dtGridViewBT2.Name = "dtGridViewBT2";
            this.dtGridViewBT2.RowHeadersWidth = 62;
            this.dtGridViewBT2.RowTemplate.Height = 28;
            this.dtGridViewBT2.Size = new System.Drawing.Size(774, 397);
            this.dtGridViewBT2.TabIndex = 11;
            // 
            // btnAddCSDL
            // 
            this.btnAddCSDL.Location = new System.Drawing.Point(203, 346);
            this.btnAddCSDL.Name = "btnAddCSDL";
            this.btnAddCSDL.Size = new System.Drawing.Size(118, 53);
            this.btnAddCSDL.TabIndex = 12;
            this.btnAddCSDL.Text = "Thêm vào CSDL";
            this.btnAddCSDL.UseVisualStyleBackColor = true;
            this.btnAddCSDL.Click += new System.EventHandler(this.btnAddCSDL_Click);
            // 
            // FormBT2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 539);
            this.Controls.Add(this.btnAddCSDL);
            this.Controls.Add(this.dtGridViewBT2);
            this.Controls.Add(this.btnDienTich);
            this.Controls.Add(this.btnChuVi);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtCanhB);
            this.Controls.Add(this.txtCanhC);
            this.Controls.Add(this.txtCanhA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormBT2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BT2 - LAB 8";
            this.Load += new System.EventHandler(this.FormBT2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewBT2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCanhA;
        private System.Windows.Forms.TextBox txtCanhC;
        private System.Windows.Forms.TextBox txtCanhB;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnChuVi;
        private System.Windows.Forms.Button btnDienTich;
        private System.Windows.Forms.DataGridView dtGridViewBT2;
        private System.Windows.Forms.Button btnAddCSDL;
    }
}