
using BT8_LISTBOX.BatLoiControl;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ComboBox = System.Windows.Forms.ComboBox;
namespace BT8_LISTBOX
{
    public partial class BT10 : Form
    {
        string HK = string.Empty;
        string listMonhoc = string.Empty;
        public BT10()
        {
            InitializeComponent();
            btnDangKy.Enabled = false;// turn off
        }
        private void GetHocKy(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            HK = radioButton.Text;
        }
        private void ReviewCode(object sender, EventArgs e)
        {
            string listMonhoc = "";
            foreach (var item in chklstMonhoc.CheckedItems)
            {
                listMonhoc += item.ToString() + " ,";
            }
            lblKetQuaChon.Text = $"Họ và tên: {txtHoTen.Text} \n Lớp: {cboLop.Text} \n Niên khóa: {cboNienKhoa.Text} \n Học kỳ:  {HK} \n Danh sách môn học đăng ký:{listMonhoc}";

            lblHint.Text = string.Empty;
            if (txtHoTen.Text.Length > 0 && cboLop.Text.Length > 0 && cboNienKhoa.Text.Length > 0 && HK.Length > 0 && listMonhoc.Length > 0)
            {
                btnDangKy.Enabled = true;
            }
        }
        public void ComboboxAddData_KeyDown(object sender, KeyEventArgs e)
        {
            lblHint = ErrCbo.Combobox_Add_Item(sender, e);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            message += lblKetQuaChon.Text;
            MessageBox.Show(message);
            btnDangKy.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = string.Empty;
            txtMSSV.Text = string.Empty;
            cboLop.Items.Clear();
            cboLop.BackColor = Color.White;
            cboNienKhoa.Items.Clear();
            cboNienKhoa.BackColor = Color.White;
            radS1.Checked = false;
            radS2.Checked = false;
            radS3.Checked = false;
            radS4.Checked = false;
            listMonhoc.Normalize();
            lblHint.Text = "Watching error";
            errorProvider1.SetError(txtHoTen, "");
            errorProvider1.SetError(txtMSSV, "");
            errorProvider1.SetError(cboLop, "");
            errorProvider1.SetError(cboNienKhoa, "");
        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {
            lblHint.Text = string.Empty;
            if (ErrTxt.NoSpace_TextChange(sender))
            {
                lblHint.Text += "Không nhập Khoảng trắng";
            }
            else if (ErrTxt.NoSymbol_TextChanged(sender))
            {
                lblHint.Text += "Không nhập kí tự đặc biệt";
            }
            else if (ErrTxt.NoMinMax_TextChanged(sender, 3, 11))
            {
                lblHint.Text += "Không nhập đủ ký tự";
            }
            else
            {
                lblHint.Text = string.Empty;
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            lblHint.Text = string.Empty;
            if (ErrTxt.NoNumber_TextChange(sender))
            {
                lblHint.Text += "Không nhập số";
            }
            else if (ErrTxt.NoSymbol_TextChanged(sender))
            {
                lblHint.Text += "Không nhập kí tự đặc biệt";
            }
            else if (ErrTxt.NoMinMax_TextChanged(sender, 2, 35))
            {

                lblHint.Text += "Không nhập đủ ký tự";
            }
            else
            {
                lblHint.Text = string.Empty;
            }
        }


        private void txtMSSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;//reset

            if (ErrTxt.NoSpace_KeyPress(e))
            {
                e.Handled = true;//2 cái sai dẫn đến sai, 1 trong 2 cái là sai thì nó sai, 2 cái không cái nào sai thì đúng hết 
            }
            else if (ErrTxt.NoSymbol_KeyPress(e))
            {
                e.Handled = true;
            }

            else
            {
                e.Handled = false;//TH đúng hết

            }
        }
        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;//reset

            if (ErrTxt.NoNumber_KeyPress(e))
            {
                e.Handled = true;//2 cái sai dẫn đến sai, 1 trong 2 cái là sai thì nó sai, 2 cái không cái nào sai thì đúng hết 
            }
            else if (ErrTxt.NoSymbol_KeyPress(e))
            {
                e.Handled = true;
            }

            else
            {
                e.Handled = false;//TH đúng hết
            }
        }

        private void cboNienKhoa_Leave(object sender, EventArgs e)
        {
            ErrCbo.SelectedIndex_Required(sender, e);
        }

        private void cboLop_Leave(object sender, EventArgs e)
        {
            ErrCbo.SelectedIndex_Required(sender, e);
        }


    }
}
