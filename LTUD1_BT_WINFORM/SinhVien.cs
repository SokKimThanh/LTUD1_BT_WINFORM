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
        private string hoten;
        private string phone;

        public SinhVien()
        {
            id = Guid.NewGuid().ToString();
        }

        //properties
        public string Id { get => id; set => id = value; }
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
