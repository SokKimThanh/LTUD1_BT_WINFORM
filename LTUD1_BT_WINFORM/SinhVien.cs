using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BT8_LISTBOX
{
    internal class SinhVien
    {
        // variable
        private string id;//auto
        private string hoten = "Sok Kim Thanh";
        private string phone = "090123456789";

        public SinhVien()
        {
            id = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Dùng để so sánh khi xóa sinhvien
        /// </summary>
        /// <param name="id"></param>
        /// <param name="hoten"></param>
        /// <param name="phone"></param>
        public SinhVien(string id)
        {
            this.id = id;
        }

        /// <summary>
        /// Dùng để parse đọc ghi file
        /// </summary>
        /// <param name="id"></param>
        /// <param name="hoten"></param>
        /// <param name="phone"></param>
        public SinhVien(string id, string hoten, string phone)
        {
            this.id = id;
            this.hoten = hoten;
            this.phone = phone;
        }

        public SinhVien(string hoten, string phone)
        {
            id = Guid.NewGuid().ToString();
            this.hoten = hoten;
            this.phone = phone;
        }

        //properties
        public string Id { get => id; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Phone { get => phone; set => phone = value; }

        //methods cs0144: override method parrent
        public override string ToString()
        {
            return $"{hoten} {phone}";
        }

        public string InRaFile()
        {
            return $"{Id}#{Hoten}#{Phone}\n";
        }
    }
}
