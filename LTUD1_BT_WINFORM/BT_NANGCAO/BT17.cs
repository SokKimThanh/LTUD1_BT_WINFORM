using BT8_LISTBOX.BatLoiControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace BT8_LISTBOX.BT_NANGCAO
{
    /// <summary>
    /// Bài tập 17: Báo cáo tiêu thụ điện
    /// </summary>
    public partial class BT17 : Form
    {
        ErrTxt r;
        ErrFrm f;
        List<Control> controlList;
        BindingSource bindingSource;
        Dictionary<string, int> dictionary;
        double tongtien = 0;
        public BT17()
        {
            InitializeComponent();
            r = new ErrTxt(this);
            f = new ErrFrm(this);
        }

        private void BT17_Load(object sender, EventArgs e)
        {
            // tạo từ điển
            dictionary = new Dictionary<string, int>()
            {
                { "Khu vực 1", 50  },//index 0
                { "Khu vực 2", 100 },//index 1
                { "Khu vực 3", 100 }// index 2 
            };
            // tạo mới dữ liệu gán
            bindingSource = new BindingSource(dictionary, null);

            // gán dữ liệu vào combobox 
            cboKhuVuc.DataSource = bindingSource;
            // tên của khu vực 
            cboKhuVuc.DisplayMember = "Key";
            // giá trị của khu vực
            cboKhuVuc.ValueMember = "Value";
            // mặc định chọn 
            cboKhuVuc.SelectedIndex = 0;//"Khu vực 1"
            // gán giá trị định mức 
            txtDinhMuc.Text = cboKhuVuc.SelectedValue!.ToString();// value 50;

            // bắt lỗi cụ thể required field
            controlList = new List<Control> { txtSoCu, txtSoMoi, txtHoTen, cboKhuVuc };

            //required tất cả các field đc chọn
            //f.ValidateInputs(controlList);
        }

        private void cboKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cboSetDinhMuc = (ComboBox)sender;
            txtDinhMuc.Text = cboSetDinhMuc.SelectedValue!.ToString();

        }

        private void txtSoCu_TextChanged(object sender, EventArgs e)
        {
            r.NoSymTextSpaceChange(sender);
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            r.NoSymNumMinMaxChange(sender);
        }

        private void ValidateInputs_Enter(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (f.ValidateInput(control))
            {
                return;
            }
        }

        /// <summary>
        /// Tính tiền trả về kết quả tiêu thụ điện
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (f.IsValidateInputs(controlList))
            {
                // chặn số âm khi nhập chỉ số cũ và mới
                double soMoi = double.Parse(txtSoMoi.Text.ToString());
                double soCu = double.Parse(txtSoCu.Text.ToString());
                if (soCu >= soMoi)
                {
                    // phát hiện vi phạm
                    MessageBox.Show("Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ!");
                    txtSoMoi.Text = string.Empty;
                    txtSoMoi.Focus();
                    r.LblHint.Text = "Chặn số âm!";
                    r.PnError.BackColor = ErrColors.mes_black;
                    return;
                }

                // tính chỉ số tiêu thụ, đơn giá, thành tiền
                double tieuthu = (soMoi - soCu);
                bool isNgoaiDinhMuc = tieuthu > Convert.ToInt32(cboKhuVuc.SelectedValue);
                int dongia = isNgoaiDinhMuc ? 1000 : 500;
                double thanhtien = dongia * tieuthu;

                // Định dạng số tiền
                txtTieuThu.Text = tieuthu.ToString();
                txtThanhTien.Text = thanhtien.ToString("C");

                // khởi tạo item cho listview
                ListViewItem lvitem = new ListViewItem();

                // thêm item đầu tiên là họ tên
                lvitem.Text = txtHoTen.Text.ToString();

                // Lấy giá trị của Key khi chọn một mục trong ComboBox  
                lvitem.SubItems.Add(cboKhuVuc.Text);

                // thêm định mức
                lvitem.SubItems.Add(txtDinhMuc.Text);

                // thêm tiêu thụ
                lvitem.SubItems.Add(tieuthu.ToString());

                // thêm thành tiền
                lvitem.SubItems.Add(thanhtien.ToString());

                // thêm item vào listview
                lvBCTTD.Items.Add(lvitem);


                // tính tổng tiền đã trả theo tháng
                tongtien = 0;
                for (int i = 0; i < lvBCTTD.Items.Count; i++)
                {
                    tongtien += double.Parse(lvBCTTD.Items[i].SubItems[4].Text.ToString());
                }
                txtTongTien.Text = tongtien.ToString("C");

                // thông báo thêm thành công
                r.LblHint.Text = "Thêm thành công!";
                r.PnError.BackColor = ErrColors.mes_success;
            }
            else
            {
                r.LblHint.Text = "Vui lòng nhập giá trị hợp lệ.";
                r.PnError.BackColor = ErrColors.mes_error;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT17_FormClosing(object sender, FormClosingEventArgs e)
        {
            ErrFrm.FormClosingEvent(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // bắt lỗi chưa chọn dòng
            try
            {
                // số dòng được chọn
                int row = lvBCTTD.SelectedIndices[0];

                // hộp thông báo 
                DialogResult result = MessageBox.Show("Bạn có muốn xóa dữ liệu hay không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    lvBCTTD.Items.RemoveAt(row);

                }
                // tính tổng tiền đã trả theo tháng
                tongtien = 0;// reset tổng tiền để cập nhật tổng tiền mới 
                for (int i = 0; i < lvBCTTD.Items.Count; i++)
                {
                    tongtien += double.Parse(lvBCTTD.Items[i].SubItems[4].Text.ToString());
                }
                // định dạng tổng tiền
                txtTongTien.Text = tongtien.ToString("C");

                // thông báo xóa thành công 
                r.LblHint.Text = "Xóa thành công!";
                r.PnError.BackColor = ErrColors.mes_success;
            }
            catch (Exception ex)
            {
                // thông báo chưa chọn dòng để xóa
                r.LblHint.Text = "Vui lòng chọn dòng để xóa!";
                r.PnError.BackColor = ErrColors.mes_error;
                Console.WriteLine(ex.Message);
            }
        }

        private void BT17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtSoMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            r.NoSymTextPress(e);
        }

        private void txtSoCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            r.NoSymTextPress(e);
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            r.NoSymNumPress(e);
        }
        /// <summary>
        /// Nhập mới các trường dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = string.Empty;
            cboKhuVuc.SelectedIndex = 0;
            txtSoCu.Text = string.Empty;
            txtSoMoi.Text = string.Empty;
            txtTieuThu.Text = "0";
            txtThanhTien.Text = "0";
            txtHoTen.Focus();
        }

        /// <summary>
        /// Chặn rời đi khi chưa nhập input required
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateInputs_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (f.ValidateInput(control))
            {
                r.PnError.BackColor = ErrColors.mes_black;
                r.LblHint.Text = "Vui lòng nhập giá trị hợp lệ.";
                control.Focus();
            }
            else
            {
                r.PnError.BackColor = ErrColors.mes_success;
                r.LblHint.Text = "Nhập OK!";
            }
        }
    }
}

