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

            dictionary = new Dictionary<string, int>()
            {
                { "Khu vực 1", 50  },//index 0
                { "Khu vực 2", 100 },//index 1
                { "Khu vực 3", 100 }// index 2 
            };

            bindingSource = new BindingSource(dictionary, null);
            cboKhuVuc.DataSource = bindingSource;
            cboKhuVuc.DisplayMember = "Key";
            cboKhuVuc.ValueMember = "Value";

            cboKhuVuc.SelectedIndex = 0;//"Khu vực 1"
            txtDinhMuc.Text = cboKhuVuc.SelectedValue!.ToString();// value 50;

            controlList = new List<Control> { txtSoCu, txtSoMoi, txtHoTen, cboKhuVuc };

            //required tất cả các field
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
                r.LblHint.Text = "Nhập OK!";
                r.PnError.BackColor = Color.Green;

                double soMoi = double.Parse(txtSoMoi.Text.ToString());
                double soCu = double.Parse(txtSoCu.Text.ToString());
                if (soCu >= soMoi)
                {
                    // phát hiện vi phạm
                    MessageBox.Show("Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ!");
                    txtSoMoi.Text = string.Empty;
                    txtSoMoi.Focus();
                    return;
                }
                double tieuthu = (soMoi - soCu);
                bool isNgoaiDinhMuc = int.Parse(txtTieuThu.Text.ToString()) > Convert.ToInt32(cboKhuVuc.SelectedValue);
                int dongia = isNgoaiDinhMuc ? 1000 : 500;
                double thanhtien = dongia * tieuthu;

                txtTieuThu.Text = tieuthu.ToString();
                txtThanhTien.Text = thanhtien.ToString("C");

                ListViewItem lvitem = new ListViewItem();
                lvitem.Text = txtHoTen.Text.ToString();
                // Lấy giá trị của Key khi chọn một mục trong ComboBox  
                lvitem.SubItems.Add(cboKhuVuc.SelectedItem.ToString());
                lvitem.SubItems.Add(txtDinhMuc.Text);
                lvitem.SubItems.Add(tieuthu.ToString());
                lvitem.SubItems.Add(thanhtien.ToString());
                lvBCTTD.Items.Add(lvitem);


                // tính tổng tiền đã trả theo tháng
                tongtien = 0;
                for (int i = 0; i < lvBCTTD.Items.Count; i++)
                {
                    tongtien += double.Parse(lvBCTTD.Items[i].SubItems[4].Text.ToString());
                }
                txtTongTien.Text = tongtien.ToString("C");
            }
            else
            {
                r.LblHint.Text = "Vui lòng nhập giá trị hợp lệ.";
                r.PnError.BackColor = Color.Red;
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
            try
            {
                int row = lvBCTTD.SelectedIndices[0];
                DialogResult r = MessageBox.Show("Bạn có muốn xóa dữ liệu hay không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    lvBCTTD.Items.RemoveAt(row);
                }
                // tính tổng tiền đã trả theo tháng
                tongtien = 0;
                for (int i = 0; i < lvBCTTD.Items.Count; i++)
                {
                    tongtien += double.Parse(lvBCTTD.Items[i].SubItems[4].Text.ToString());
                }
                txtTongTien.Text = tongtien.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!");
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

        private void ValidateInputs_Leave(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (f.ValidateInput(control))
            {
                r.PnError.BackColor = Color.Black;
                r.LblHint.Text = "Vui lòng nhập giá trị hợp lệ.";
                control.Focus();
            }
            else
            {
                r.PnError.BackColor = Color.Green;
                r.LblHint.Text = "Nhập OK!";
            }
        }
    }
}

