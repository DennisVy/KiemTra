using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT_Buoi7
{
    public partial class FrmSinhVien : Form
    {
        private ListViewItem itemBeingEdited = null;
        private Button btSua; // Khai báo btSua


        public FrmSinhVien()
        {
            InitializeComponent();
            //this.Load += new System.EventHandler(this.FrmSinhVien_Load);
            //this.btXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            //this.btSua.Click += new System.EventHandler(this.buttonSua_Click);
            //this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            //this.lvSinhvien.SelectedIndexChanged += new System.EventHandler(this.lvSinhvien_SelectedIndexChanged);
            //// Khởi tạo btSua
            //btSua = new Button();
            //btSua.Text = "Sửa";
            //btSua.Location = new Point(100, 100); // Đặt vị trí của nút trên form
            this.Controls.Add(btSua); // Thêm nút vào form

            this.Load += new System.EventHandler(this.FrmSinhVien_Load);
            this.btXoa.Click += new System.EventHandler(this.buttonXoa_Click);
           // this.btSua.Click += new System.EventHandler(this.buttonSua_Click);
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            this.lvSinhvien.SelectedIndexChanged += new System.EventHandler(this.lvSinhvien_SelectedIndexChanged);
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các điều khiển
            string maSV = txtMaSV.Text;
            string hoTen = txtHotenSV.Text;
            string ngaySinh = dtNgaysinh.Value.ToString("dd/MM/yyyy");
            string lopHoc = choLop.SelectedItem != null ? choLop.SelectedItem.ToString() : "";

            // Kiểm tra nếu các trường bắt buộc không được điền
            if (string.IsNullOrEmpty(maSV) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(lopHoc))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (itemBeingEdited != null)
            {
                // Cập nhật mục đang được sửa
                itemBeingEdited.SubItems[0].Text = maSV;
                itemBeingEdited.SubItems[1].Text = hoTen;
                itemBeingEdited.SubItems[2].Text = ngaySinh;
                itemBeingEdited.SubItems[3].Text = lopHoc;

                // Đặt lại biến itemBeingEdited
                itemBeingEdited = null;
            }
            else
            {
                // Tạo một mảng chứa các giá trị của một dòng mới
                string[] row = { maSV, hoTen, ngaySinh, lopHoc };

                // Tạo một ListViewItem mới từ mảng giá trị
                ListViewItem item = new ListViewItem(row);

                // Thêm ListViewItem vào ListView
                lvSinhvien.Items.Add(item);
            }

            // Xóa dữ liệu trong các điều khiển sau khi thêm hoặc sửa
            txtMaSV.Clear();
            txtHotenSV.Clear();
            dtNgaysinh.Value = DateTime.Now;
            choLop.SelectedIndex = -1;
        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            // Thêm các lựa chọn vào ComboBox
            choLop.Items.Add("Công Nghệ Thông Tin");
            choLop.Items.Add("Kế toán Khoa 1");
            choLop.Items.Add("Kế toán Khoa 2");
            choLop.SelectedIndex = 0; // Chỉ số 0 tương ứng với mục đầu tiên trong ComboBox

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn trong ListView không
            if (lvSinhvien.SelectedItems.Count > 0)
            {
                // Hiển thị hộp thoại xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Xóa mục đã chọn
                    foreach (ListViewItem item in lvSinhvien.SelectedItems)
                    {
                        lvSinhvien.Items.Remove(item);
                    }
                }
            }
            else
            {
                //MessageBox.Show("Vui lòng chọn mục cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn trong ListView không
            if (lvSinhvien.SelectedItems.Count > 0)
            {
                // Lấy mục được chọn
                itemBeingEdited = lvSinhvien.SelectedItems[0];

                // Hiển thị dữ liệu của mục được chọn lên các điều khiển
                if (itemBeingEdited != null)
                {
                    txtMaSV.Text = itemBeingEdited.SubItems[0].Text;
                    txtHotenSV.Text = itemBeingEdited.SubItems[1].Text;
                    dtNgaysinh.Value = DateTime.Parse(itemBeingEdited.SubItems[2].Text);
                    choLop.SelectedItem = itemBeingEdited.SubItems[3].Text;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btLuu_Click(object sender, EventArgs e)
        {
            if (itemBeingEdited != null)
            {
                // Cập nhật mục đang được sửa
                itemBeingEdited.SubItems[0].Text = txtMaSV.Text;
                itemBeingEdited.SubItems[1].Text = txtHotenSV.Text;
                itemBeingEdited.SubItems[2].Text = dtNgaysinh.Value.ToString("dd/MM/yyyy");
                itemBeingEdited.SubItems[3].Text = choLop.SelectedItem != null ? choLop.SelectedItem.ToString() : "";

                // Đặt lại biến itemBeingEdited
                itemBeingEdited = null;

                // Xóa dữ liệu trong các điều khiển sau khi lưu
                txtMaSV.Clear();
                txtHotenSV.Clear();
                dtNgaysinh.Value = DateTime.Now;
                choLop.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lvSinhvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có mục nào được chọn trong ListView không
            if (lvSinhvien.SelectedItems.Count > 0)
            {
                // Lấy mục được chọn
                ListViewItem selectedItem = lvSinhvien.SelectedItems[0];

                // Hiển thị dữ liệu của mục được chọn lên các điều khiển
                txtMaSV.Text = selectedItem.SubItems[0].Text;
                txtHotenSV.Text = selectedItem.SubItems[1].Text;
                dtNgaysinh.Value = DateTime.Parse(selectedItem.SubItems[2].Text);
                choLop.SelectedItem = selectedItem.SubItems[3].Text;
            }
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            string searchValue = textBox3.Text;
            bool found = false;

            foreach (ListViewItem item in lvSinhvien.Items)
            {
                if (item.SubItems[0].Text == searchValue || item.SubItems[1].Text == searchValue)
                {
                    item.Selected = true;
                    lvSinhvien.Select();
                    found = true;
                    break;
                }
            }

            if (found)
            {
                MessageBox.Show("Đã tìm thấy sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Thoát ứng dụng
                    Application.Exit();
                }
            }
        }

        private void btKhong_Click(object sender, EventArgs e)
        {
            {
                // Đặt lại các điều khiển về trạng thái ban đầu
                txtMaSV.Clear();
                txtHotenSV.Clear();
                dtNgaysinh.Value = DateTime.Now;
                choLop.SelectedIndex = -1;

                // Đặt lại biến itemBeingEdited
                itemBeingEdited = null;

                MessageBox.Show("Các thay đổi đã bị hủy bỏ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}