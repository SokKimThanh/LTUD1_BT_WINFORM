using BT8_LISTBOX.BT_NANGCAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BT8_LISTBOX.BatLoiControl
{
    internal class ErrFrm
    {
        /// <summary>
        /// Kiểm tra các lỗi trên form bất kỳ
        /// </summary>
        Form f;
        /// <summary>
        /// Kiểm tra lỗi trên control còn hay mất
        /// </summary>
        ErrorProvider err;
        public Form F { get => f; set => f = value; }
        public ErrorProvider Err { get => err; set => err = value; }

        public ErrFrm(Form form)
        {
            this.f = form;
            this.err = new ErrorProvider();
        }
        /// <summary>
        /// Required field
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static void Required(object sender, ErrorProvider errorProvider, string requiredMessage = "Please fill the required field")
        {
            Control currentControl = (Control)sender;
            if (currentControl != null && currentControl.Text.Length > 0 && requiredMessage.Length > 0)
            {
                errorProvider.SetError(currentControl, requiredMessage);
            }
            else
            {
                errorProvider.SetError(currentControl, "");
            }
        }
        public static bool FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn đóng form hay không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                // hủy đóng form
                e.Cancel = true;
                return false;
            }
            else
            {
                // chạy tiếp this.close
                return true;
            }
        }
        public static bool FormClosingSaveFileEvent(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn cần đóng file trước khi đóng form hay không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                // hủy đóng form
                e.Cancel = true;
                return false;
            }
            else
            {
                // chạy tiếp this.close
                return true;
            }
        }
        /// <summary>
        /// Tạo một danh sách các control (textBox1, textBox2, và textBox3) và lặp lại từng phần tử trong danh sách đó để thiết lập thông báo lỗi cho từng control
        /// </summary>
        /// <param name="controls">List<Control> controls = new List<Control> { textBox1, textBox2, textBox3 }; </param>
        public void ValidateInputs(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                ValidateInput(control);
            }
        }

        public bool ValidateInput(Control control)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                Err.SetError(control, "Vui lòng nhập giá trị hợp lệ.");
                return true;
            }
            else
            {
                Err.SetError(control, "");
                return false;
            }
        }
        /// <summary>
        /// Kiểm tra các lỗi còn tồn tại trên các control
        /// </summary>
        /// <param name="controls"></param>
        /// <returns>Return true if OK, else is not ok Vui lòng nhập giá trị hợp lệ.</returns>
        public bool IsValidateInputs(List<Control> controls)
        {
            for (int i = 0; i < controls.Count; i++)
            {
                if (err.GetError(controls[i]) != "")
                {
                    return false;// phát hiện ra control còn lỗi
                }
            }
            // TH mọi việc ok
            // thực hiện phép tính  
            return true;
        }
    }
}

