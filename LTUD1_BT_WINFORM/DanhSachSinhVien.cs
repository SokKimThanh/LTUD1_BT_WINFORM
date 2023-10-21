using BT8_LISTBOX.BatLoiControl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BT8_LISTBOX
{
    internal class DanhSachSinhVien
    {
        /// <summary>
        /// danh sách sinh viên
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

        // xóa hết
        public void Clear()
        {
            list.Clear();
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
        /// Dem so luong sinh vien trong danh sach
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return list.Count();
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
            SinhVien item = new SinhVien();
            item.Id = arr[0];
            item.Hoten = arr[1];
            item.Phone = arr[2];
            return item;
        }

        /// <summary>
        /// Đọc file
        /// </summary>
        /// <param name="file_path"></param>
        /// <returns></returns>
        public bool DocFile(string file_path = "sinhvien.txt")
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
        public bool GhiFile(string file_path = "sinhvien.txt")
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
                    // reset danh sach dang ky
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
        /// Liệt kê danh sach listview sinhvien
        /// </summary>
        /// <param name="lv"></param>
        /// <returns></returns>
        internal bool Show(ListView lv)
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

    }
}
