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

namespace BT8_LISTBOX.BT_NANGCAO
{
    public partial class BT18 : Form
    {

        ErrTxt r;//bắt lỗi control textbox
        ErrFrm f;//bắt buộc nhập control(mọi loại)

        public BT18()
        {
            InitializeComponent();
            r = new ErrTxt(this);
            f = new ErrFrm(this);
        }

        private void BT18_Load(object sender, EventArgs e)
        {
            // Tree node basic
            for (int i = 0; i < "ABCDEFGHIJKLMNOPQRSTUVXYZ".Length; i++)
            {
                TreeNode node = new TreeNode();
                node.Name = "ABCDEFGHIJKLMNOPQRSTUVXYZ"[i].ToString();
                node.Text = "ABCDEFGHIJKLMNOPQRSTUVXYZ"[i].ToString();
                this.tvDanhBa.Nodes.Add(node);
            }
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text == string.Empty)
                {
                    txtFullName.Focus();
                    return;
                }
                if (txtLastName.Text == string.Empty)
                {
                    txtLastName.Focus();
                    return;
                }
                // lấy chữ cái đầu tiên trong tên
                string firstLetter = txtFullName.Text.Substring(0, 1);
                //duyệt tất cả các node tìm node ứng với chữ cái đầu
                for (int i = 0; i < tvDanhBa.Nodes.Count; i++)
                {
                    // kiểm tra tên bỏ qua phân biệt hoa thường
                    if (firstLetter.ToString().ToLower().CompareTo(tvDanhBa.Nodes[i].Text.ToString().ToLower()) == 0)
                    {
                        // tạo node mới 
                        TreeNode node = new TreeNode();

                        // tạo tên cho node
                        node.Name = txtFullName.Text + txtLastName.Text;

                        // tạo giá trị node;
                        node.Text = $"{txtFullName.Text}, {txtLastName.Text}";

                        // them node mới cho node hiện tại
                        tvDanhBa.Nodes[i].Nodes.Add(node);

                        // mở rộng node hiện tại
                        tvDanhBa.Nodes[i].ExpandAll();
                    }
                }
                txtFullName.Text = string.Empty;
                txtLastName.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                r.LblHint.Text = ex.Message;
                r.PnError.BackColor = ErrColors.mes_black;
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            r.NoSymNumChange(sender);
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            r.NoSymNumPress(e);
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            string errMessage = "Vui lòng nhập tên";
            if (f.RequiredInput((Control)sender))
            {
                r.LblHint.Text = errMessage;
                r.PnError.BackColor = ErrColors.mes_error;
            }
            else
            {
                r.LblHint.Text = "Nhập ok!";
                r.PnError.BackColor = ErrColors.mes_success;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            r.NoSymNumChange(sender);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            r.NoSymNumPress(e);
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            string errMessage = "Vui lòng nhập họ";
            if (f.RequiredInput((Control)sender))
            {
                r.LblHint.Text = errMessage;
                r.PnError.BackColor = ErrColors.mes_error;
            }
            else
            {
                r.LblHint.Text = "Nhập ok!";
                r.PnError.BackColor = ErrColors.mes_success;
            }
        }

        private void btnEditNode_Click(object sender, EventArgs e)
        {

        }

        private void tvDanhBa_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Vary the response depending on which TreeViewAction triggered the event.
            //switch ((e.Action))
            //{ 
            //    case TreeViewAction.ByKeyboard:
            //        MessageBox.Show("You like the keyboard!");
            //        break;
            //    case TreeViewAction.ByMouse:
            //        MessageBox.Show("You like the mouse!");
            //        break;
            //}

        }
       

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
