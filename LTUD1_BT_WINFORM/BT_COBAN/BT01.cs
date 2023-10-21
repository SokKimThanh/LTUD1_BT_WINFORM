using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LTUD1_Tuan2_BT1
{
    public partial class BT01 : Form
    {
        public BT01()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string dob = txtYear.Text;
            if (regexNullValidate() && regexNumberValidate(dob))
            {
                errorProvider1.Clear();
                MessageBox.Show("ok");
            }
        }
        private bool regexBirthdayValidate(string s)
        {
            DateTime result = new DateTime();
            if (!DateTime.TryParse(s, out result))
            {
                errorProvider1.SetError(txtYear, "Chưa nhập đúng định dạng year of birth.");
                return false;
            }
            errorProvider1.Clear();
            return true;
        }

        private bool regexNullValidate()
        {
            var boxes = this.Controls.OfType<TextBox>();
            int errorCount = 0;
            foreach (var box in boxes)
            {
                if ("txtYourName, txtYear".Contains(box.Name) && string.IsNullOrWhiteSpace(box.Text))
                {
                    errorProvider1.SetError(box, "Please fill the required field");
                    errorCount++;
                }
                else
                {
                    errorProvider1.SetError(box, "");
                }
            }

            if (errorCount == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        // code su dung regex tim kiem chuoi con tu input nhap vao
        private bool regexStringValidate(string chuoi)
        {
            string pattern = @"^(1000|[1-9][1-9]{0,2})$";
            Regex myRegex = new Regex(pattern);
            //Nếu chỉ muốn tìm tất cả các số trong một chuỗi, để lấy tất cả các số đó sử dụng Regex.Match
            //Nếu chỉ muốn kiểm tra xem chuỗi có chứa số hay không, sử dụng Regex.IsMatch
            Match m = myRegex.Match(chuoi);
            if (!m.Success)
            {
                string errorMessage = string.Format("Khong tim thay chuoi con {0} o vi tri thu {1} trong chuoi", m.Value, m.Index);
                errorProvider1.SetError(txtYear, errorMessage);
                return false;
            }
            errorProvider1.Clear();
            return true;
        }
        // code regex check so tu 1 den 1000 tu input nhap vao
        public bool regexNumberValidate(string input)
        {
            string pattern = @"^(1000|[1-9][0-9]{0,2})$";
            Regex regex = new Regex(pattern);
            //Nếu chỉ muốn kiểm tra xem chuỗi có chứa số hay không, sử dụng Regex.IsMatch
            if (!regex.IsMatch(input))
            {
                errorProvider1.SetError(txtYear, $"{input} is not a valid number between 1 and 1000.");
                return false;
            }
            errorProvider1.Clear();
            return true;
        }

        private void frmMyNameProject_Load(object sender, EventArgs e)
        {
            this.Text = "         Sok Kim Thanh Project";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    textBox.Clear();
                }
                else if (c is ComboBox)
                {
                    ComboBox comboBox = c as ComboBox;
                    comboBox.SelectedIndex = -1;
                }
                // Thêm các loại điều khiển khác nếu cần
                // quay lại kiểm tra control khác để xóa tiếp 
                // hết xóa được thì sẽ thoát vòng lặp
            }
            txtYourName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //chắc chắn đóng form
            this.Close();
        }

        // chặn đóng form 
        private void frmMyNameProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn đóng form hay không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                // hủy đóng form
                e.Cancel = true;
            }
        }
    }
}