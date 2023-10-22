using BT8_LISTBOX.BatLoiControl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace BT8_LISTBOX
{
    internal class DanhSachSinhVien
    {
        /// <summary>
        /// list sách sinh viên
        /// </summary>
        List<SinhVien> list;

        /// <summary>
        /// constructor
        /// </summary>
        public DanhSachSinhVien()
        {
            this.list = new List<SinhVien>();
        }
        /// <summary>
        /// Theem moi 
        /// </summary>
        /// <param name="sinhvien"></param>
        /// <returns></returns>
        public bool Add(SinhVien sinhvien)
        {
            try
            {

                list.Add(sinhvien);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// xóa hết list sách sinh vien
        /// </summary>
        public void Clear()
        {
            list.Clear();
        }

        /// <summary>
        /// xóa đối tượng sinh viên cụ thể
        /// </summary>
        /// <param name="sv"></param>
        /// <returns></returns>
        public bool Remove(string id)
        {
            try
            {
                foreach (SinhVien sinhvien in list)
                {
                    if (sinhvien.Id.CompareTo(id) == 0)
                    {
                        // remove  thoong tin
                        list.Remove(sinhvien);
                        return true;
                    }
                }
                return true;//xoa thanh cong;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;//xoa khong thanh cong;
            }
        }

        /// <summary>
        /// xóa đối tượng sinh viên cụ thể
        /// </summary>
        /// <param name="sv"></param>
        /// <returns></returns>
        public bool Remove(SinhVien sv)
        {
            try
            {
                foreach (SinhVien sinhvien in list)
                {
                    if (sinhvien.Id.CompareTo(sv.Id) == 0)
                    {
                        // remove  thoong tin
                        list.Remove(sinhvien);
                        return true;//xoa thanh cong;
                    }
                }
                return false;//xoa không thanh cong;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;//xoa khong thanh cong;
            }
        }

        /// <summary>
        /// Cập nhật sinh viên
        /// </summary>
        /// <param name="sv"></param>
        /// <returns></returns>
        internal bool Update(SinhVien sv)
        {
            foreach (SinhVien sinhvien in list)
            {
                if (sinhvien.Id.CompareTo(sv.Id) == 0)
                {
                    // udpate thoong tin
                    sinhvien.Hoten = sv.Hoten;
                    sinhvien.Phone = sv.Phone;
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Dem so luong sinh vien trong list sach
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return list.Count();
        }
        /// <summary>
        /// Tìm sinhvien theo id
        /// </summary>
        /// <param name="nodeId"></param>
        /// <returns></returns>
        public SinhVien getSinhVienById(string nodeId)
        {
            // Tìm sinhvien theo id;
            foreach (SinhVien sv in list)
            {
                if (sv.Id.CompareTo(nodeId) == 0)
                {
                    return sv;
                }
            }
            return null;
        }
        /// <summary>
        /// Kiểm tra tồn tại số điện thoại
        /// </summary>
        /// <param name="sv"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool ContainsPhoneNumber(SinhVien sv)
        {
            try
            {
                foreach (SinhVien vien in list)
                {
                    //Kiểm tra trùng số điện thoại
                    if (vien.Id.Equals(sv.Id) && vien.Phone.Equals(sv.Phone))
                    {
                        return true;//phát hiện trùng số điện thoại 
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;//giả sử vẫn chưa trùng sdt
            }
            return false;
        }

        /// <summary>
        /// chuyển đổi thông tin
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private static SinhVien parse(string line)
        {
            string[] arr = line.Split('#');
            SinhVien item = new SinhVien(arr[0], arr[1], arr[2]);

            return item;
        }

        /// <summary>
        /// Đọc file
        /// </summary>
        /// <param name="file_path"></param>
        /// <returns></returns>
        public bool DocFileListView(string file_path = "sinhvien.txt")
        {
            try
            {
                list.Clear();//reset trước khi đọc file
                using (StreamReader reader = new StreamReader(file_path))
                {
                    string line;
                    // đọc hết file nhưng không đọc file rỗng
                    while ((line = reader.ReadLine()) != null)
                    {
                        SinhVien data = parse(line);
                        Add(data);
                    }
                }
                if (list.Count > 0)
                {
                    return true;// add thành công
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;// add không thành công
        }
        /// <summary>
        /// Ghi file
        /// </summary>
        /// <param name="file_path"></param>
        /// <returns></returns>
        public bool GhiFileListView(string file_path = "sinhvien.txt")
        {
            try
            {
                if (File.Exists(file_path))
                {
                    // xóa file đóng luôn stream
                    File.Delete(file_path);
                }

                // tạo file và Mở stream đọc file_path để ghi
                using (StreamWriter writer = new StreamWriter(file_path))
                {
                    // reset list sach dang ky
                    foreach (var item in list)
                    {
                        // ghi tung gia tri cua mang so nguyen vao file 
                        writer.Write(item.InRaFile());
                    }
                }
                // đóng file trả về true
                return true;// ghi thành công 
            }
            catch (Exception ex)
            {
                // Cong viec CATCH
                // thong bao loi o phan TRY
                Console.WriteLine(ex.Message);
                return false;// ghi không thành công 
            }
        }
        /// <summary>
        /// Liệt kê list sach listview sinhvien
        /// </summary>
        /// <param name="lv"></param>
        /// <returns></returns>
        internal bool ShowListView(ListView lv)
        {
            // clear các dòng trong listview truoc khi load arraydata
            lv.Items.Clear();
            try
            {
                //đọc file xong thì ghi lên list view
                for (int i = 0; i < list.Count(); i++)
                {
                    //Khởi tạo
                    ListViewItem item = new ListViewItem();

                    //thêm dữ liệu vào listViewItem
                    item.SubItems[0].Text = list[i].Id;
                    item.SubItems.Add(list[i].Hoten);
                    item.SubItems.Add(list[i].Phone);

                    //thêm dữ liệu vào listView
                    lv.Items.Add(item);
                }
                if (lv.Items.Count > 0)
                {
                    return true;// thêm thành công
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;// thêm không thành công
        }
        /// <summary>
        /// Hiển thị list sách lên treeKhoa view
        /// </summary>
        /// <param name="tvSinhVien"></param>
        /// <returns></returns>
        public bool ShowTreeView(TreeView tvSinhVien)
        {
            return true;
        }
        /// <summary>
        /// Đọc file từ tree view
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="treeKhoa"></param>
        /// <returns></returns>
        internal bool DocFileTreeView(string fileName, TreeView treeKhoa)
        {
            if (!File.Exists(fileName))
            {
                return false;
            }
            bool ketqua = false;// giả sử chưa đọc được file

            // bắt đầu đọc file
            string s = File.ReadAllText(fileName);

            //cắt chuỗi từ file bằng kí tự $
            string[] list = s.Split(new string[] { "$" }, StringSplitOptions.RemoveEmptyEntries);

            //duyệt danh sách để cắt chuỗi
            foreach (string danh in list)
            {
                // cắt chuỗi từ danh sách bằnt kí tự #
                string[] lop = danh.Split(new string[] { "#" }, StringSplitOptions.RemoveEmptyEntries);
                // Tạo treeKhoa node khoa mới
                TreeNode nodeKhoa = new TreeNode(lop[0]);
                // Thêm khoa vào cây thư mục khoa
                treeKhoa.Nodes.Add(nodeKhoa);
                for (int i = 1; i < lop.Length; i++)
                {
                    //node lớp từ node list bằng kí tự *
                    string[] ten = lop[i].Split(new string[] { "*" }, StringSplitOptions.RemoveEmptyEntries);
                    // tạo treenode lớp mới
                    TreeNode nodeLop = new TreeNode(ten[0]);
                    // thêm nodelop vào danh sách khoa
                    nodeKhoa.Nodes.Add(nodeLop);
                    for (int j = 1; j < ten.Length; j++)
                    {
                        // nodeSinhVien từ node lớp thêm vô treenode của lớp
                        TreeNode nodeSinhVien = new TreeNode(ten[j]);
                        nodeLop.Nodes.Add(nodeSinhVien);
                        ketqua = true;//Đọc file thành công
                    }
                }
            }
            return ketqua;//Đọc file không thành công
        }
        /// <summary>
        /// Ghi file từ treeview
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="tree"></param>
        /// <returns></returns>
        internal bool GhiFileTreeView(string fileName, TreeView tree)
        {
            if (!File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Create);
                fs.Close();
            }

            // Đọc file đã có
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                // duyệt hết sinh viên để ghi vào file
                foreach (TreeNode danh in tree.Nodes)
                {
                    sw.Write(danh.Text);
                    foreach (TreeNode Lop in danh.Nodes)
                    {
                        sw.Write("#");
                        sw.Write(Lop.Text);
                        foreach (TreeNode sinhvien in Lop.Nodes)
                        {
                            //ghi lại node id sinh vien(có id )
                            sw.Write("*");
                            sw.Write($"{sinhvien.Name}-{sinhvien.Text}");
                            foreach (TreeNode diachi in sinhvien.Nodes)
                            {
                                sw.Write("!");
                                sw.Write(diachi.Text);
                            }
                        }
                    }
                    sw.Write("#");
                }
            }
            return true;
        }
    }
}
