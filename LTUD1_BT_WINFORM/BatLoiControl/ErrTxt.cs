﻿
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ComboBox = System.Windows.Forms.ComboBox;

namespace BT8_LISTBOX.BatLoiControl
{
    /// <summary>
    /// Phải vừa đổi được màu html sang màu hệ thống, 
    /// phải vừa có màu mặc định để gọi cho lẹ. 
    /// phải vừa dùng được cả trong đầu vào các hàm khác nhau
    /// </summary>
    public struct ErrColors
    {
        //Trong c# cách để thêm 1 màu mới
        //tetradic #E25966 #AAE259 #59E2D5 #9159E2
        public static Color err_txt_required = ColorTranslator.FromHtml("#E25966");// "light red"
        public static Color err_txt_notext = ColorTranslator.FromHtml("#AAE259");// "dark red"
        public static Color err_txt_nonumber = ColorTranslator.FromHtml("#59E2D5");// "light green" 
        public static Color err_txt_nospace = ColorTranslator.FromHtml("#9159E2");// "????" 

        //analogous #E29159 #E29159 #E259AA
        public static Color err_txt_nocontains_exist_item = ColorTranslator.FromHtml("#E29159");// "????" 
        public static Color err_txt_minmax_length = ColorTranslator.FromHtml("#E259AA");// "????" 
        //triadic #E25966 #66E259   #5966E2
        internal static Color err_txt_nosymbol = ColorTranslator.FromHtml("#5966E2");// "????"

        // message color
        public static Color mes_error = ColorTranslator.FromHtml("#DA2E3E");// "light red"        
        public static Color mes_success = ColorTranslator.FromHtml("#94DA2E");// "light green"        
        public static Color mes_warning = ColorTranslator.FromHtml("#FFF767");// "light yellow"      
        public static Color mes_info = ColorTranslator.FromHtml("#2EDACA");// "water"      
        public static Color mes_black = ColorTranslator.FromHtml("#000000");// "black"      
        public static Color mes_white = ColorTranslator.FromHtml("#ffffff");// "white"      
        public static Color mes_purple = ColorTranslator.FromHtml("#742EDA");// "purple"
        public static Color mes_primary = ColorTranslator.FromHtml("#2E3EDA");// "primary blue"      


        public static Color err_lv_listview_back_color = ColorTranslator.FromHtml("#aa0906");// "red brown"
        public static Color Transparent = Color.Transparent;
    }

    public class ErrTxt
    {
        Label lblHint;
        Panel pnError;

        public Label LblHint { get => lblHint; set => lblHint = value; }
        public Panel PnError { get => pnError; set => pnError = value; }

        public ErrTxt(Form frm)
        {
            lblHint = new Label();
            pnError = new Panel();
            //label 
            lblHint.Text = string.Empty;
            LblHint.AutoSize = false;
            LblHint.Dock = DockStyle.Fill;
            LblHint.TextAlign = ContentAlignment.TopCenter;
            LblHint.Font = new Font("Arial", 12);
            LblHint.ForeColor = ErrColors.mes_white;

            //panel 
            PnError.Dock = DockStyle.Top;
            PnError.Height = LblHint.Size.Height;
            PnError.Controls.Add(LblHint);
            frm.Controls.Add(PnError);
        }


        /// <summary>
        /// Chặn nhập số
        /// </summary>
        /// <param name="e"></param>
        /// <returns>Return true if is number</returns>
        public static bool NoNumber_KeyPress(KeyPressEventArgs e)
        {
            Regex regex = new Regex("^[0-9]");
            bool isNumber = regex.IsMatch(e.KeyChar.ToString());
            if (isNumber)
            {
                // Không cho phép gõ tiếp
                return true;
            }
            else
            {
                // Cho phép gõ tiếp
                return false;
            }
        }
        /// <summary>
        /// Không nhập chữ key press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static bool NoText_KeyPress(KeyPressEventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z]");
            bool isText = regex.IsMatch(e.KeyChar.ToString());
            if (isText)
            {
                // Không cho phép gõ tiếp
                return true;
            }
            else
            {
                // Cho phép gõ tiếp
                return false;
            }
        }

        /// <summary>
        /// Cho phép các ký tự số và ký tự điều khiển như backspace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>return true if have symbol</returns>
        internal static bool NoSymbol_KeyPress(KeyPressEventArgs e)
        {
            // Kiểm tra tất cả các ký tự không phải là chữ và số
            Regex regex = new Regex("^[!@#$%^&*()_\\-=*/]");
            bool isSymbol = regex.IsMatch(e.KeyChar.ToString());
            if (isSymbol)
            {
                // Không cho phép gõ tiếp
                return true;
            }
            else
            {
                // Cho phép gõ tiếp
                return false;
            }
        }
        /// <summary>
        /// Ngừng nhập khoảng trắng textbox
        /// </summary>
        /// <param name="sender">Textbox sender</param>
        /// <param name="e">Nhấn xuống event</param>
        /// <returns>Return true if no have space</returns>
        public static bool NoSpace_KeyPress(KeyPressEventArgs e)
        {
            // Kiểm tra xem phím được nhấn có phải là khoảng trắng hay không
            Regex regex = new Regex("^[ ]");
            bool isSpace = regex.IsMatch(e.KeyChar.ToString());
            if (isSpace)
            {
                // Không cho phép gõ tiếp
                return true;
            }
            else
            {   // Cho phép gõ tiếp
                return false;
            }
        }
        /// <summary>
        /// Không nhập số
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>return true if  have number</returns>
        public static bool NoNumber_TextChange(object sender)
        {
            Control c = (Control)sender;
            Regex regex = new Regex("^[0-9]");
            bool isNumber = regex.IsMatch(c.Text.ToString());
            // check input string
            if (isNumber)
            {
                return true;//phat hien nhap number
            }
            // nhap ok!
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Không nhập text
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static bool NoText_TextChange(object sender)
        {
            Control c = (Control)sender;
            Regex regex = new Regex("^[a-zA-Z]");
            bool isText = regex.IsMatch(c.Text.ToString());
            // check input string
            if (isText)
            {
                return true;//phat hien nhap text
            }
            // nhap ok!
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Không nhập symbol !@#$%^&*()_+/*=-
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>return true if no have symbol</returns>
        public static bool NoSymbol_TextChanged(object sender)
        {
            Control c = (Control)sender;
            Regex regex = new Regex("^[!@#$%^&*()_\\-=*/]");
            bool isSymbol = regex.IsMatch(c.Text.ToString());
            // check input string
            if (isSymbol)
            {
                return true;
            }
            // nhap ok!
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Không nhập space
        /// </summary>
        /// <param name="sender"></param>
        /// <returns>true if no space</returns>
        public static bool NoSpace_TextChange(object sender)
        {
            TextBox c = (TextBox)sender;
            Regex regex = new Regex("^[ ]");
            bool isSpace = regex.IsMatch(c.Text.ToString());
            if (isSpace)
            {
                return true;
            }
            // nhap ok!
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Không nhập đủ số lượng kí tự
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>return true if enough length</returns>
        public static bool NoMinMax_TextChanged(object sender, int min = 3, int max = 16)
        {
            Control c = (Control)sender;
            string patern = "a-zA-Z0-9 !@#$%^&*()_+*/-eéèẻẽẹêếềễểệaáàảãạăắằẵẳặâấầẩẫậoóòỏõọơớờỡởợôốồổỗộuúùũủụưứừữửựiíìỉĩịyýỳỷỹỵđEÉÈẺẼẸÊẾỀỄỂỆAÁÀẢÃẠĂẮẰẴẲẶÂẤẦẨẪẬOÓÒỎÕỌƠỚỜỠỞỢÔỐỒỔỖỘUÚÙŨỦỤƯỨỪỮỬỰIÍÌỈĨỊYÝỲỶỸỴĐ";
            Regex regex = new Regex(@"^[" + patern + "]" + "{" + min + "," + max + "}$");
            bool isMinMax = regex.IsMatch(c.Text.ToString());
            if (c.Text.Length < 3 || c.Text.Length > max)
            {
                return false;
            }

            if (isMinMax)
            {
                //Phat hiện nhập chưa đủ kí tự
                return false;
            }
            // nhập ok!
            else
            {
                // nhập chính xác
                return true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool NoMinMax_KeyPress(object sender, int min = 3, int max = 16)
        {
            TextBox c = (TextBox)sender;
            c.MaxLength = max;

            if (c.Text.Length < min)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        internal static void Empty_Control(object sender)
        {
            Control c = (Control)sender;
            c.Text = string.Empty;
        }



        /**
         * usage space
         * Số điện thoại sử dụng nosymnumminmax change được phép có dấu cách ra vd: 0924 964 226
         */
        public void NoSymTextSpaceMinMaxPress(object sender, KeyPressEventArgs e, int max = 16, int min = 3)
        {
            e.Handled = false;
            if (NoSymbol_KeyPress(e))
            {
                e.Handled = true;
                lblHint.Text = "Không nhập ký tự đặc biệt";
                PnError.BackColor = ErrColors.err_txt_nosymbol;
            }
            else if (NoText_KeyPress(e))
            {
                e.Handled = true;
                lblHint.Text = "Không nhập chữ";
                PnError.BackColor = ErrColors.err_txt_notext;

            }
            else if (NoSpace_KeyPress(e))
            {
                e.Handled = true;
                lblHint.Text = "Không nhập khoảng trắng";
                PnError.BackColor = ErrColors.err_txt_nospace;
            }
            else if (NoMinMax_KeyPress(sender, min, max))
            {
                lblHint.Text = "Không nhập đủ hoặc dư số lượng ký tự";
                PnError.BackColor = ErrColors.err_txt_minmax_length;
            }
            else
            {
                lblHint.Text = "Nhập ok!";
                PnError.BackColor = ErrColors.mes_success;
                e.Handled = false;
            }
        }

        public void NoSymTextSpacePress(KeyPressEventArgs e)
        {
            e.Handled = false;
            if (NoSymbol_KeyPress(e))
            {
                e.Handled = true;
                lblHint.Text = "Không nhập ký tự đặc biệt";
                PnError.BackColor = ErrColors.err_txt_nosymbol;
            }
            else if (NoText_KeyPress(e))
            {
                e.Handled = true;
                lblHint.Text = "Không nhập chữ";
                PnError.BackColor = ErrColors.err_txt_notext;

            }
            else if (NoSpace_KeyPress(e))
            {
                e.Handled = true;
                lblHint.Text = "Không nhập khoảng trắng";
                PnError.BackColor = ErrColors.err_txt_nospace;
            }

            else
            {
                lblHint.Text = "Nhập ok!";
                PnError.BackColor = ErrColors.mes_success;
                e.Handled = false;
            }
        }

        public void NoSymTextMinMaxPress(object sender, KeyPressEventArgs e, int max = 16, int min = 3)
        {
            e.Handled = false;
            if (NoSymbol_KeyPress(e))
            {
                e.Handled = true;
                lblHint.Text = "Không nhập ký tự đặc biệt";
                PnError.BackColor = ErrColors.err_txt_nosymbol;
            }
            else if (NoText_KeyPress(e))
            {
                e.Handled = true;
                lblHint.Text = "Không nhập chữ";
                PnError.BackColor = ErrColors.err_txt_notext;

            }
            else if (NoMinMax_KeyPress(sender, min, max))
            {
                lblHint.Text = "Không nhập đủ hoặc dư số lượng ký tự";
                PnError.BackColor = ErrColors.err_txt_minmax_length;
            }
            else
            {
                lblHint.Text = "Nhập ok!";
                PnError.BackColor = ErrColors.mes_success;
                e.Handled = false;
            }
        }

        public void NoSymTextPress(KeyPressEventArgs e)
        {
            e.Handled = false;
            if (NoSymbol_KeyPress(e))
            {
                e.Handled = true;
                lblHint.Text = "Không nhập ký tự đặc biệt";
                PnError.BackColor = ErrColors.err_txt_nosymbol;
            }
            else if (NoText_KeyPress(e))
            {
                e.Handled = true;
                lblHint.Text = "Không nhập chữ";
                PnError.BackColor = ErrColors.err_txt_notext;

            }
            else
            {
                lblHint.Text = "Nhập ok!";
                PnError.BackColor = ErrColors.mes_success;
                e.Handled = false;
            }
        }

        public void NoSymNumMinMaxPress(object sender, KeyPressEventArgs e, int max = 16, int min = 3)
        {
            e.Handled = false;
            if (NoSymbol_KeyPress(e))
            {
                e.Handled = true;
                lblHint.Text = "Không nhập ký tự đặc biệt";
                PnError.BackColor = ErrColors.err_txt_nosymbol;
            }
            else if (NoNumber_KeyPress(e))
            {
                e.Handled = true;
                lblHint.Text = "Không nhập số";
                PnError.BackColor = ErrColors.err_txt_nonumber;

            }
            else if (NoMinMax_KeyPress(sender, min, max))
            {
                lblHint.Text = "Không nhập đủ hoặc dư số lượng ký tự";
                PnError.BackColor = ErrColors.err_txt_minmax_length;
            }
            else
            {
                lblHint.Text = "Nhập ok!";
                PnError.BackColor = ErrColors.mes_success;
                e.Handled = false;
            }
        }

        public void NoSymNumPress(KeyPressEventArgs e)
        {
            e.Handled = false;
            if (NoSymbol_KeyPress(e))
            {
                e.Handled = true;
                lblHint.Text = "Không nhập ký tự đặc biệt";
                PnError.BackColor = ErrColors.err_txt_nosymbol;
            }
            else if (NoNumber_KeyPress(e))
            {
                e.Handled = true;
                lblHint.Text = "Không nhập số";
                PnError.BackColor = ErrColors.err_txt_nonumber;

            }
            else
            {
                e.Handled = false;
                lblHint.Text = "Nhập ok!";
                PnError.BackColor = ErrColors.mes_success;
            }
        }

        public bool NoSymNumSpaceMinMaxChange(object sender, int min = 3, int max = 16)
        {
            Control c = (Control)sender;
            if (NoSymbol_TextChanged(sender))
            {
                return true;
            }
            else if (NoNumber_TextChange(sender))
            {
                return true;
            }
            else if (NoSpace_TextChange(sender))
            {
                return true;
            }
            else if (NoMinMax_TextChanged(sender, min, max))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// No symbol, no number, not enough min max characters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public bool NoSymNumMinMaxChange(object sender, int min = 3, int max = 16)
        {
            Control c = (Control)sender;
            if (NoSymbol_TextChanged(sender))
            {
                return true;
            }
            else if (NoNumber_TextChange(sender))
            {
                return true;
            }
            else if (NoMinMax_TextChanged(sender, min, max))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// No symbol, no number
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public bool NoSymNumChange(object sender)
        {
            Control c = (Control)sender;

            if (NoSymbol_TextChanged(sender))
            {
                return true;
            }
            else if (NoNumber_TextChange(sender))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// No symbol, no text, nospace, not enough min max
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public bool NoSymTextSpaceMinMaxChange(object sender, int min = 3, int max = 16)
        {
            Control c = (Control)sender;
            if (NoSymbol_TextChanged(sender))
            {
                return true;
            }
            else if (NoText_TextChange(sender))
            {
                return true;
            }
            else if (NoSpace_TextChange(sender))
            {
                return true;
            }
            else if (NoMinMax_TextChanged(sender, min, max))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// No symbol, no text, no space
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public bool NoSymTextSpaceChange(object sender)
        {
            Control c = (Control)sender;
            if (NoSymbol_TextChanged(sender))
            {
                return true;
            }
            else if (NoText_TextChange(sender))
            {
                return true;
            }
            else if (NoSpace_TextChange(sender))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool NoSymTextMinMaxChange(object sender, int min = 3, int max = 16)
        {
            Control c = (Control)sender;
            if (NoSymbol_TextChanged(sender))
            {
                return true;
            }
            else if (NoText_TextChange(sender))
            {
                return true;
            }
            else if (NoMinMax_TextChanged(sender, min, max))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool NoSymTextChange(object sender)
        {
            Control c = (Control)sender;
            if (NoSymbol_TextChanged(sender))
            {
                return true;
            }
            else if (NoText_TextChange(sender))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
