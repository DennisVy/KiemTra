namespace KT_Buoi7
{
    partial class FrmSinhVien
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
            this.lvSinhvien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btKhong = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHotenSV = new System.Windows.Forms.TextBox();
            this.choLop = new System.Windows.Forms.ComboBox();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btTim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvSinhvien
            // 
            this.lvSinhvien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvSinhvien.FullRowSelect = true;
            this.lvSinhvien.HideSelection = false;
            this.lvSinhvien.Location = new System.Drawing.Point(34, 269);
            this.lvSinhvien.Name = "lvSinhvien";
            this.lvSinhvien.Size = new System.Drawing.Size(868, 338);
            this.lvSinhvien.TabIndex = 0;
            this.lvSinhvien.UseCompatibleStateImageBehavior = false;
            this.lvSinhvien.View = System.Windows.Forms.View.Details;
            this.lvSinhvien.SelectedIndexChanged += new System.EventHandler(this.lvSinhvien_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã SV";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ Và Tên";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Sinh";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lớp";
            this.columnHeader4.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(433, 221);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(514, 221);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(75, 23);
            this.buttonSua.TabIndex = 1;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(612, 221);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 23);
            this.btLuu.TabIndex = 1;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btKhong
            // 
            this.btKhong.Location = new System.Drawing.Point(715, 221);
            this.btKhong.Name = "btKhong";
            this.btKhong.Size = new System.Drawing.Size(75, 23);
            this.btKhong.TabIndex = 1;
            this.btKhong.Text = "Không";
            this.btKhong.UseVisualStyleBackColor = true;
            this.btKhong.Click += new System.EventHandler(this.btKhong_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(836, 221);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 1;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lớp Học";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(269, 75);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(200, 22);
            this.txtMaSV.TabIndex = 3;
            // 
            // txtHotenSV
            // 
            this.txtHotenSV.Location = new System.Drawing.Point(570, 78);
            this.txtHotenSV.Name = "txtHotenSV";
            this.txtHotenSV.Size = new System.Drawing.Size(181, 22);
            this.txtHotenSV.TabIndex = 3;
            // 
            // choLop
            // 
            this.choLop.FormattingEnabled = true;
            this.choLop.Location = new System.Drawing.Point(570, 134);
            this.choLop.Name = "choLop";
            this.choLop.Size = new System.Drawing.Size(181, 24);
            this.choLop.TabIndex = 4;
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.Location = new System.Drawing.Point(269, 136);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(200, 22);
            this.dtNgaysinh.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "THÔNG TIN CHI TIẾT";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(5, 221);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 22);
            this.textBox3.TabIndex = 3;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(152, 221);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 23);
            this.btTim.TabIndex = 1;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // FrmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 608);
            this.Controls.Add(this.dtNgaysinh);
            this.Controls.Add(this.choLop);
            this.Controls.Add(this.txtHotenSV);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btKhong);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvSinhvien);
            this.Name = "FrmSinhVien";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSinhvien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btKhong;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHotenSV;
        private System.Windows.Forms.ComboBox choLop;
        private System.Windows.Forms.DateTimePicker dtNgaysinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btTim;
    }
}

