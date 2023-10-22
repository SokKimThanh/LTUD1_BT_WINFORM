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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BT8_LISTBOX.BT_NANGCAO
{
    public partial class BT18 : Form
    {

        ErrTxt r;//bắt lỗi control textbox
        ErrFrm f;//bắt buộc nhập control(mọi loại)
        TVCayThuMuc cayThuMuc;//Tạo mới cây thư mục
        TNThuMuc thuMuc;
        DanhSachSinhVien arraydata_sv = new DanhSachSinhVien();
        public BT18()
        {
            InitializeComponent();
            r = new ErrTxt(this);
            f = new ErrFrm(this);
            // Cho phép tùy chỉnh vẽ node
            tvSinhVien.DrawMode = TreeViewDrawMode.OwnerDrawText;
            cayThuMuc = new TVCayThuMuc(tvSinhVien);
            thuMuc = new TNThuMuc(cayThuMuc.CreateTreeView());
        }

        private void BT18_Load(object sender, EventArgs e)
        {
            // Tree node basic
            //for (int i = 0; i < "ABCDEFGHIJKLMNOPQRSTUVXYZ".Length; i++)
            //{
            //    TreeNode node = new TreeNode();
            //    node.Name = "ABCDEFGHIJKLMNOPQRSTUVXYZ"[i].ToString();
            //    node.Text = "ABCDEFGHIJKLMNOPQRSTUVXYZ"[i].ToString();
            //    this.tvDanhBa.Nodes.Add(node);
            //} 
        }
        /// <summary>
        /// BT18
        /// </summary>
        public void TestCase1()
        {
            try
            {
                if (txtFullName.Text == string.Empty)
                {
                    txtFullName.Focus();
                    return;
                }
                if (txtPhone.Text == string.Empty)
                {
                    txtPhone.Focus();
                    return;
                }
                // lấy chữ cái đầu tiên trong tên
                string firstLetter = txtFullName.Text.Substring(0, 1);

                // Thêm 1 sinh viên mới
                SinhVien newSV = new SinhVien(txtFullName.Text, txtPhone.Text);

                //duyệt tất cả các node tìm node ứng với chữ cái đầu
                for (int i = 0; i < tvSinhVien.Nodes.Count; i++)
                {
                    // kiểm tra tên bỏ qua phân biệt hoa thường
                    if (firstLetter.ToString().ToLower().CompareTo(tvSinhVien.Nodes[i].Text.ToString().ToLower()) == 0)
                    {
                        // tạo node mới 
                        TreeNode node = thuMuc.AddSinhVienNode(newSV);

                        // tạo tên cho node
                        node.Name = newSV.Id;

                        // tạo giá trị node;
                        node.Text = $"{newSV.Hoten}";

                        // them node mới cho node hiện tại
                        tvSinhVien.Nodes[i].Nodes.Add(node);

                        // mở rộng node hiện tại
                        tvSinhVien.Nodes[i].ExpandAll();
                    }
                }
                txtFullName.Text = string.Empty;
                txtPhone.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                r.LblHint.Text = ex.Message;
                r.PnError.BackColor = ErrColors.mes_black;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text == string.Empty)
                {
                    txtFullName.Focus();
                    return;
                }

                if (txtPhone.Text == string.Empty)
                {
                    txtPhone.Focus();
                    return;
                }

                // Thêm 1 sinh viên mới
                SinhVien newSV = new SinhVien(txtFullName.Text, txtPhone.Text);

                // tạo node mới 
                TreeNode sinhVienNode = thuMuc.AddSinhVienNode(newSV);

                // tạo tên cho node
                sinhVienNode.Name = newSV.Id;

                // tạo giá trị node;
                sinhVienNode.Text = $"{newSV.Hoten}";

                if (thuMuc.LopHocNode == null)
                {
                    r.LblHint.Text = "Vui lòng chọn lớp học";
                    r.PnError.BackColor = ErrColors.mes_black;
                    return;
                }
                // khoa tin hoc
                foreach (TreeNode khoa in tvSinhVien.Nodes)
                {
                    // lớp tin học 
                    bool isSuccess = false;
                    foreach (TreeNode lop in khoa.Nodes)
                    {
                        // Thêm sinh viên vào lớp tin học
                        if (thuMuc.LopHocNode.Text.CompareTo(lop.Text) == 0)
                        {
                            // Thêm sinhVienNode vào LopNode hiện tại
                            thuMuc.LopHocNode.Nodes.Add(sinhVienNode);

                            // Thêm sinhvien vào danh sách sinhvien
                            arraydata_sv.Add(newSV);

                            // reset form
                            txtFullName.Text = string.Empty;
                            txtPhone.Text = string.Empty;
                            isSuccess = true;
                            lop.Expand();
                            break;
                        }
                    }
                    if (isSuccess)
                    {
                        // Thông báo thêm thành công 
                        r.LblHint.Text = "Thêm thành công!";
                        r.PnError.BackColor = ErrColors.mes_success;
                        khoa.ExpandAll();
                        return;// giảm số lần lặp
                    }
                    else
                    {
                        r.LblHint.Text = "Thêm không thành công!";
                        r.PnError.BackColor = ErrColors.mes_error;
                        khoa.Collapse();
                        return;// giảm số lần lặp
                    }
                }
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

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            r.NoSymTextSpacePress(e);
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
            try
            {
                if (ErrFrm.DialogConfirm("Bạn muốn sửa thông tin sinh viên này không?"))
                {
                    return;//no
                }
                SinhVien sv = new SinhVien(txtIDSV.Text, txtFullName.Text, txtPhone.Text);
                //TC1: xóa khi hiển ra id trên textbox 
                arraydata_sv.Update(sv);

                //TC2: Cập nhật node
                thuMuc.UpdateSinhVienNode(sv);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void tvDanhBa_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // chọn mã lớp để liệt kê danh sách sinh viên trong lớp học

            // Thu gọn tất cả các node
            //tvDanhBa.CollapseAll();

            // Mở rộng node được chọn
            //e.Node.Expand();
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Lưu lại cấp sinhvien node để sử dụng id trên lưới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvDanhBa_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Lấy node đã được nhấp
            TreeNode selectedNode = e.Node;

            r.LblHint.Text = selectedNode.Text;

            // khoa tin hoc
            foreach (TreeNode khoa in tvSinhVien.Nodes)
            {
                // lớp tin học  
                foreach (TreeNode lop in khoa.Nodes)
                {
                    //Chỉ tìm thấy lớp
                    //Trả về LopHocNode hiện tại

                    if (lop.Text.CompareTo(selectedNode.Text) == 0)
                    {
                        thuMuc.LopHocNode = e.Node;
                    }
                    //sinhvien
                    foreach (TreeNode sinhvien in lop.Nodes)
                    {
                        // Thêm sinh viên vào lớp tin học
                        if (sinhvien.Name.CompareTo(selectedNode.Name) == 0 && sinhvien.Name != "")
                        {
                            // Lấy giá trị của node 
                            string nodeId = selectedNode.Name;
                            // tìm sinhvien khi được click 
                            SinhVien sv = arraydata_sv.getSinhVienById(nodeId);


                            //hiển thị lên textbox
                            txtFullName.Text = sv.Hoten;
                            txtIDSV.Text = sv.Id;
                            txtPhone.Text = sv.Phone;

                            // Chỉ tìm sinh viên
                            thuMuc.SinhVienNode = e.Node;
                        }
                    }
                }
            }
        }

        private void tvDanhBa_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            // Nếu node đang được chọn, thì tô màu nền và màu chữ
            if ((e.State & TreeNodeStates.Selected) != 0)
            {
                // Tô màu nền cho node
                e.Graphics.FillRectangle(Brushes.Lime, e.Bounds);

                // Vẽ màu chữ cho node
                TextRenderer.DrawText(e.Graphics, e.Node.Text, e.Node.TreeView.Font,
                    e.Bounds, Color.Crimson, TextFormatFlags.VerticalCenter);

            }
            else
            {
                // Vẽ node với màu nền và màu chữ mặc định
                e.DrawDefault = true;

            }
        }

        private void btnDeleteNode_Click(object sender, EventArgs e)
        {
            try
            {
                if (ErrFrm.DialogConfirm("Bạn muốn xóa sinh viên này không?"))
                {
                    return;//no
                }
                SinhVien s = new SinhVien(txtIDSV.Text);
                //TC1: xóa khi hiển ra id trên textbox 
                arraydata_sv.Remove(s);

                //TC2: xóa khi chọn node 
                thuMuc.LopHocNode.Nodes.Remove(thuMuc.SinhVienNode);

                //reset
                txtIDSV.Text = string.Empty;
                txtFullName.Text = string.Empty;
                txtPhone.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Xóa hết các node và các sinh vien trong danh sách sinhvien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAllNode_Click(object sender, EventArgs e)
        {
            try
            {
                if (ErrFrm.DialogConfirm("Bạn muốn xóa tất cả sinh viên ở tất cả các lớp không?"))
                {
                    return;//no
                }

                // xóa danh sách sinh viên
                arraydata_sv.Clear();

                // xóa tất cả node trong lớp
                // khoa tin hoc
                foreach (TreeNode khoa in tvSinhVien.Nodes)
                {
                    // lớp tin học  
                    foreach (TreeNode lop in khoa.Nodes)
                    {
                        lop.Nodes.Clear();//chỉ xóa tất cả sinhvien trong tất cả các lớp của khoa
                    }
                }

                //reset
                txtIDSV.Text = string.Empty;
                txtFullName.Text = string.Empty;
                txtPhone.Text = string.Empty;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                DialogResult result;
                sfd.Title = "sinhvien.txt";
                sfd.Filter = "File text (*.txt)|*.txt";
                result = sfd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // mở browser lên tìm file để lưu
                    string fileName = sfd.FileName;
                    if (arraydata_sv.GhiFileTreeView(fileName, tvSinhVien))
                    {
                        r.LblHint.Text = "Ghi file thành công!";
                        r.PnError.BackColor = ErrColors.mes_success;
                    }
                }
            }
            catch (Exception ex)
            {
                r.PnError.BackColor = ErrColors.mes_error;
                r.LblHint.Text = ex.Message;
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            // mở browser lên tìm file để đọc 
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                // Đọc file 
                if (!arraydata_sv.DocFileTreeView(fileName, tvSinhVien))
                {
                    r.PnError.BackColor = ErrColors.mes_error;
                    r.LblHint.Text = "Không đọc file rỗng!";
                    return;
                }
                // đọc file xong thì hiển thị lên lên view (update listview)
                if (!arraydata_sv.ShowTreeView(tvSinhVien))
                {
                    r.PnError.BackColor = ErrColors.mes_error;
                    r.LblHint.Text = "Không hiển thị được treeview!";
                    return;
                }

                r.PnError.BackColor = ErrColors.mes_success;
                r.LblHint.Text = $"Đọc file thành công! SL: {arraydata_sv.Count()}";


            }
        }
    }
}
