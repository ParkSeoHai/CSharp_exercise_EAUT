namespace Lab7
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMsv = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbGioiTinh = new System.Windows.Forms.TextBox();
            this.btnAddGridView = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbClass = new System.Windows.Forms.TextBox();
            this.dataGridSv = new System.Windows.Forms.DataGridView();
            this.btnSuaGrid = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập sơ yếu lý lịch sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(71, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sinh viên";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(445, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Họ tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(71, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Giới tính";
            // 
            // tbMsv
            // 
            this.tbMsv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMsv.Location = new System.Drawing.Point(71, 98);
            this.tbMsv.Name = "tbMsv";
            this.tbMsv.Size = new System.Drawing.Size(235, 34);
            this.tbMsv.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(445, 98);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(235, 34);
            this.tbName.TabIndex = 9;
            // 
            // tbGioiTinh
            // 
            this.tbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbGioiTinh.Location = new System.Drawing.Point(71, 175);
            this.tbGioiTinh.Name = "tbGioiTinh";
            this.tbGioiTinh.Size = new System.Drawing.Size(235, 34);
            this.tbGioiTinh.TabIndex = 11;
            // 
            // btnAddGridView
            // 
            this.btnAddGridView.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddGridView.Location = new System.Drawing.Point(71, 236);
            this.btnAddGridView.Name = "btnAddGridView";
            this.btnAddGridView.Size = new System.Drawing.Size(121, 40);
            this.btnAddGridView.TabIndex = 12;
            this.btnAddGridView.Text = "Add";
            this.btnAddGridView.UseVisualStyleBackColor = true;
            this.btnAddGridView.Click += new System.EventHandler(this.btnAddGridView_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(445, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Lớp";
            // 
            // tbClass
            // 
            this.tbClass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbClass.Location = new System.Drawing.Point(445, 175);
            this.tbClass.Name = "tbClass";
            this.tbClass.Size = new System.Drawing.Size(235, 34);
            this.tbClass.TabIndex = 14;
            // 
            // dataGridSv
            // 
            this.dataGridSv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSv.Location = new System.Drawing.Point(71, 299);
            this.dataGridSv.Name = "dataGridSv";
            this.dataGridSv.RowHeadersWidth = 62;
            this.dataGridSv.RowTemplate.Height = 33;
            this.dataGridSv.Size = new System.Drawing.Size(609, 301);
            this.dataGridSv.TabIndex = 15;
            this.dataGridSv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSv_CellClick);
            // 
            // btnSuaGrid
            // 
            this.btnSuaGrid.Location = new System.Drawing.Point(223, 236);
            this.btnSuaGrid.Name = "btnSuaGrid";
            this.btnSuaGrid.Size = new System.Drawing.Size(112, 40);
            this.btnSuaGrid.TabIndex = 16;
            this.btnSuaGrid.Text = "Sửa";
            this.btnSuaGrid.UseVisualStyleBackColor = true;
            this.btnSuaGrid.Click += new System.EventHandler(this.btnSuaGrid_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(364, 236);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 40);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(513, 236);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(117, 40);
            this.btnSort.TabIndex = 18;
            this.btnSort.Text = "Sắp xếp";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 612);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSuaGrid);
            this.Controls.Add(this.dataGridSv);
            this.Controls.Add(this.tbClass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddGridView);
            this.Controls.Add(this.tbGioiTinh);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbMsv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private TextBox tbMsv;
        private TextBox tbName;
        private TextBox tbGioiTinh;
        private Button btnAddGridView;
        private Label label7;
        private TextBox tbClass;
        private DataGridView dataGridSv;
        private Button btnSuaGrid;
        private Button btnRemove;
        private Button btnSort;
    }
}