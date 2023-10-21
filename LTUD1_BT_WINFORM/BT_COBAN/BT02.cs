using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BT8_LISTBOX.BatLoiControl;

namespace BT8_LISTBOX
{
    public partial class BT02 : Form
    {
        public BT02()
        {
            InitializeComponent();
        }

        private void BT02_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Giải phương trình bậc nhất ax + b = 0".ToUpper();
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.BorderStyle = BorderStyle.FixedSingle;
            lblTitle.SetBounds(0, 0, lblTitle.Text.Length, 0);
            lblTitle.AutoSize = false;
            lblNhapA.Text = "lblNhapA";
            lblNhapB.Text = "lblNhapB";
            btnXoa.Enabled = false;
            btnXoa.Text = "Xóa";
            btnGiai.Text = "Giải";
            btnThoat.Text = "Thoát";
            lblKetQua.Enabled = true;
            txtKetQua.ReadOnly = true;
            lblKetQua.Text = "Đang chờ phép tính";

        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            if (txtNhapA.Text.Length <= 0 || txtNhapB.Text.Length <= 0)
            {
                errorProvider1.SetError(txtNhapA, "Required field");
                errorProvider1.SetError(txtNhapB, "Required field");
                btnXoa.Enabled = false;
            }
            else
            {
                btnGiai.Enabled = false;// tinh xong thi khoa lai
                btnXoa.Enabled = true;
                errorProvider1.SetError(txtNhapA, "");
                errorProvider1.SetError(txtNhapB, "");
                //giai bai tap o day
                string ketqua = CongThuc.PhuongTrinhBac1(txtNhapA.Text, txtNhapB.Text);
                if (ketqua != "vosonghiem" && ketqua != "vonghiem")
                {
                    lblKetQua.Text = "Phương trình có 2 nghiệm phân biệt -b/a";
                    txtKetQua.Text = ketqua.ToString();
                }
                else
                {
                    if (ketqua == "vosonghiem")
                    {
                        lblKetQua.Text = "Phương trình có vô số nghiệm";
                        txtKetQua.Text = lblKetQua.Text;
                    }
                    else if (ketqua == "vonghiem")
                    {
                        lblKetQua.Text = "Phương trình vô nghiệm";
                        txtKetQua.Text = lblKetQua.Text;
                    }
                }
            }


        }

        private void BT02_FormClosing(object sender, FormClosingEventArgs e)
        {
            //da test chay duoc
            ErrFrm.FormClosingEvent(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhapA.Clear();
            txtNhapB.Clear();
            txtKetQua.Clear();
            lblKetQua.Text = "Đang chờ phép tính";
            txtNhapA.Focus();//xoa xong focus lai A
            btnXoa.Enabled = false;
            btnGiai.Enabled = true;
        }
    }
}
