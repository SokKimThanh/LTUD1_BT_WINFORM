using System;
using System.Collections;
using System.Windows.Forms;
using BT8_LISTBOX.BatLoiControl;

namespace BT8_LISTBOX
{
    public partial class BT08 : Form
    {
        int count = 0;
        public BT08()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInput.MaxLength = 9;
        }

        public bool checkNhapLienTiepSoKhong()
        {
            for (int i = 0; i < txtInput.Text.Length; i++)
            {
                if (txtInput.Text[i].ToString() == "0" && txtInput.Text[i].Equals(txtInput.Text[i + 1]))
                {
                    return true;// phat hien 2 so khong lien tiep
                }
            }
            return false;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

            // kiem tra tung lan go
            // khong phai la so thi dung lai 
            if (txtInput.Text.Length > 0 && !checkNhapLienTiepSoKhong())
            {
                lstNumber.Items.Add(txtInput.Text);
                txtInput.Text = string.Empty;
                txtInput.Focus();
            }
            else
            {
                MessageBox.Show("Không nhập nhiều số 0 liên tiếp nhau", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Nhap()
        {
            if (txtInput.Text.Length > 0)
            {
                lstNumber.Items.Add(txtInput.Text);
                txtInput.Text = string.Empty;
                txtInput.Focus();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstNumber.SelectedIndex;
            bool isSelectedItem = lstNumber.SelectedItem == null ? true : false;
            if (index >= 0)
            {
                lstNumber.Items.RemoveAt(index);
                lstNumber.Refresh();
            }
            else if (isSelectedItem)
            {
                MessageBox.Show("Chưa chọn phần tử cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Danh sách rỗng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteFirstTail_Click(object sender, EventArgs e)
        {
            int first = 0;
            int last = lstNumber.Items.Count - 2;
            if (lstNumber.Items.Count > 1)
            {
                lstNumber.Items.RemoveAt(first);
                lstNumber.Items.RemoveAt(last);

            }
            else if (lstNumber.Items.Count == 1)
            {
                lstNumber.Items.RemoveAt(first);
            }
            else
            {
                MessageBox.Show("Danh sách rỗng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            lstNumber.Refresh();
            //các trường hợp khác thì không làm gì cả
            return;
        }

        public int warning_danhsachrong()
        {
            if (lstNumber.Items.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
            return 0;
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            if (warning_danhsachrong() != 1)
            {
                for (int i = 0; i < lstNumber.Items.Count; i++)
                {
                    lstNumber.Items[i] = (int.Parse(lstNumber.Items[i].ToString()) + 2).ToString();
                }
            };
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            count++;
            ErrTxt.NoText_TextChange(sender);
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            ErrTxt.NoText_KeyPress(e);
        }
        //xoa text


        private void txtInput_Leave(object sender, EventArgs e)
        {
            //required
            if (txtInput.Text.Length < 8)
            {
                txtInput.BackColor = Color.Yellow;
                txtInput.ForeColor = Color.Red;
            }
        }

        private void txtInput_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtInput_Enter(object sender, EventArgs e)
        {
            //Nhap();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT8_LISTBOX_FormClosing(object sender, FormClosingEventArgs e)
        {
            ErrFrm.FormClosingEvent(sender, e);
        }

        private void btnPow2_Click(object sender, EventArgs e)
        {
            if (warning_danhsachrong() != -1)
            {
                for (int i = 0; i < lstNumber.Items.Count; i++)
                {
                    double a = Math.Pow(double.Parse(lstNumber.Items[i].ToString()), 2);
                    lstNumber.Items[i] = a;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (warning_danhsachrong() != -1)
            {
                PrintEvenNumber();
            }
        }
        public void PrintEvenNumber()
        {
            string sum = "";
            lstNumber.SelectionMode = SelectionMode.MultiSimple;
            lstNumber.ClearSelected();

            for (int i = 0; i < lstNumber.Items.Count; i++)
            {
                if (int.Parse(lstNumber.Items[i].ToString()) % 2 == 0)
                {
                    sum += lstNumber.Items[i].ToString() + " ";
                    lstNumber.SetSelected(i, true);
                }

            }
            if (sum.Length > 0)
            {
                MessageBox.Show(sum, "Các số chẵn là: ");
            }
            else
            {
                MessageBox.Show("Không tìm số chẵn nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void PrintOddNumber()
        {
            string sum = "";

            lstNumber.SelectionMode = SelectionMode.MultiSimple;
            lstNumber.ClearSelected();

            for (int i = 0; i < lstNumber.Items.Count; i++)
            {
                if (int.Parse(lstNumber.Items[i].ToString()) % 2 != 0)
                {
                    sum += lstNumber.Items[i].ToString() + " ";
                    lstNumber.SetSelected(i, true);
                }
            }
            if (sum.Length > 0)
            {
                MessageBox.Show(sum, "Các số lẻ là: ");
            }
            else
            {
                MessageBox.Show("Không tìm số lẻ nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (warning_danhsachrong() != -1)
            {
                PrintOddNumber();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtInput.Focus();
            txtInput.BackColor = Color.Yellow;
            txtInput.ForeColor = Color.Red;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            ArrayList arr = Utilities.ConvertListboxToArrInt(lstNumber);
            int sum = CongThuc.TinhTong(arr);
            if (warning_danhsachrong() != -1)
            {
                MessageBox.Show(sum.ToString(), "Tính tổng danh sách");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}