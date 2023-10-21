using BT8_LISTBOX.BatLoiControl;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT8_LISTBOX
{
    public partial class BT09 : Form
    {
        public BT09()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLopA.Items.Count > 0)
            {
                for (int i = lstLopA.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lstLopA.Items.Remove(lstLopA.SelectedItems[i]);
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (ErrTxt.NoMinMax_TextChanged(txtHoVaTen, 5, 10))
            {
                lstLopA.Items.Add(txtHoVaTen.Text);
            }
        }

        private void BT09_Load(object sender, EventArgs e)
        {
            // chọn nhiều bằng control 
            lstLopA.SelectionMode = SelectionMode.MultiExtended;

            // liệt kê danh sách lớp trong combobox
            cboClass.Items.AddRange(new string[] { "Lớp A", "Lớp B" });
            cboClass.SelectedIndex = 0;
            txtHoVaTen.Focus();

            // xử lý textbox tabindex để không enter ngay lần đầu tiên
            label1.TabIndex = 0;
            txtHoVaTen.TabIndex = 1;
            txtHoVaTen.MaxLength = 30;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Tránh lỗi null khi chưa chọn gì trong list box
            if (lstLopA.SelectedItem != null)
            {
                lstLopB.Items.Add(lstLopA.SelectedItem!.ToString() ?? "");
                lstLopA.Items.Remove(lstLopA.SelectedItem);
            }
            else
            {
                BatLoiListBox.ListBox_ThongBao_ChuaChonItem();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Tránh lỗi null khi chưa chọn gì trong list box
            if (lstLopB.SelectedItem != null)
            {
                lstLopA.Items.Add(lstLopB.SelectedItem!.ToString() ?? "Null");
                lstLopB.Items.Remove(lstLopB.SelectedItem);
            }
            else
            {
                BatLoiListBox.ListBox_ThongBao_ChuaChonItem();
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            if (lstLopA.Items.Count > 0)
            {
                lstLopB.Items.AddRange(lstLopA.Items);
                lstLopA.Items.Clear();
            }
            else
            {
                BatLoiListBox.ListBox_ThongBao_ChuaChonItem();
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (lstLopA.Items.Count > 0)
            {
                lstLopA.Items.AddRange(lstLopB.Items);
                lstLopB.Items.Clear();
            }
            else
            {
                BatLoiListBox.ListBox_ThongBao_ChuaChonItem();
            }
        }

        private void BT09_FormClosing(object sender, FormClosingEventArgs e)
        {
            ErrFrm.FormClosingEvent(sender, e);
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHoVaTen_TextChanged(object sender, EventArgs e)
        {
            ErrTxt.NoNumber_TextChange(e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtHoVaTen_Enter(object sender, EventArgs e)
        {


        }

        private void BT09_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtHoVaTen_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txtHoVaTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ErrTxt.NoMinMax_TextChanged(txtHoVaTen, 5, 30))
                {
                    lstLopA.Items.Add(txtHoVaTen.Text);
                }
            }
        }

        private void txtHoVaTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            ErrTxt.NoNumber_KeyPress(e);
        }
    }
}
