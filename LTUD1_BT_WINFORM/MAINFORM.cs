using BT2;
using BT8_LISTBOX.BatLoiControl;
using LTUD1_Tuan2_BT1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BT8_LISTBOX
{
    public partial class MAINFORM : Form
    {
        public MAINFORM()
        {
            InitializeComponent();
        }


        private void MAINFORM_Load(object sender, EventArgs e)
        {
            ErrTxt r = new ErrTxt(this);
            r.LblHint.Text = "hello";
            MenuStrip ms;
            // window menu
            string[] arrMainMenu = { "Hệ thống", "Bài tập", "Nhập", "In" };

            // sub menu
            string[] arrSubmenuBaiTap = { "BT01", "BT02", "BT03", "BT04", "BT05", "BT06", "BT07", "BT08", "BT09", "BT10", "BT11" };
            string[] arrSubmenuHeThong = { "Đăng nhập", "Thoát" };
            string[] arrSubmenuNhap = { "submenu item 1", "sub 2", "sub3" };
            string[] arrSubmenuIn = { "in item 1", "in sub 2", "in sub3" };

            // Tạo menu và gắn menu
            CreateMenu(out ms, arrMainMenu);

            // Gắn submenu vào menu
            AddRangeSubmenu(ref ms, arrSubmenuBaiTap, WINDOW_MENU_INDEX.BaiTap, new EventHandler(listViewCheckExistForm_Click));
            AddRangeSubmenu(ref ms, arrSubmenuHeThong, WINDOW_MENU_INDEX.HeThong, new EventHandler(listViewCheckExistForm_Click));
            AddRangeSubmenu(ref ms, arrSubmenuNhap, WINDOW_MENU_INDEX.Nhap, new EventHandler(MenuNhap_Click));
            AddRangeSubmenu(ref ms, arrSubmenuIn, WINDOW_MENU_INDEX.In, new EventHandler(MenuIn_Click));
            bool loginSuccess = true;
            if (loginSuccess == false)
            {
                ms.Items[WINDOW_MENU_INDEX.BaiTap].Enabled = false;
                ms.Items[WINDOW_MENU_INDEX.Nhap].Enabled = false;
                ms.Items[WINDOW_MENU_INDEX.In].Enabled = false;
            }
            else
            {
                ms.Items[WINDOW_MENU_INDEX.BaiTap].Enabled = true;
                ms.Items[WINDOW_MENU_INDEX.Nhap].Enabled = true;
                ms.Items[WINDOW_MENU_INDEX.In].Enabled = true;
            }
        }

        private struct WINDOW_MENU_INDEX
        {
            public int index;
            public static int HeThong = 0;
            public static int BaiTap = 1;
            public static int Nhap = 2;
            public static int In = 3;
        }
        public void MenuIn_Click(object sender, EventArgs e)
        {
            // chuyen man hinh theo ten da chon
            ToolStripMenuItem menuStrip = (ToolStripMenuItem)sender;
            // thong mess đã click menu 
            // Thực hiện hành động khi newItem được nhấp
            MessageBox.Show("Bạn đã nhấp vào " + menuStrip.Text);
        }
        public void MenuNhap_Click(object sender, EventArgs e)
        {
            // chuyen man hinh theo ten da chon
            ToolStripMenuItem menuStrip = (ToolStripMenuItem)sender;
            // thong mess đã click menu 
            // Thực hiện hành động khi newItem được nhấp
            MessageBox.Show("Bạn đã nhấp vào " + menuStrip.Text);
        }

        public void AddRangeSubmenu(ref MenuStrip ms, string[] arrSubmenu, int index, EventHandler e)
        {
            ToolStripMenuItem parrentMenu = (ToolStripMenuItem)ms.Items[index];
            ToolStripItem[] tsi = new ToolStripItem[] { };
            foreach (string s in arrSubmenu)
            {
                Array.Resize(ref tsi, tsi.Length + 1);
                // Tạo một ToolStripMenuItem mới 
                ToolStripMenuItem subMenuWindow = new ToolStripMenuItem(s);
                // Thêm sự kiện Click cho subMenuWindow
                subMenuWindow.Click += e;
                tsi[tsi.Length - 1] = subMenuWindow;// add new menu vao phan tu cuoi cung
            }
            parrentMenu.DropDownItems.AddRange(tsi);
        }

        public void CreateMenu(out MenuStrip ms, string[] arrMainMenu)
        {
            //Ho tro tạo menu
            ms = new MenuStrip();
            ToolStripMenuItem[] tsmi = new ToolStripMenuItem[] { };
            foreach (string s in arrMainMenu)
            {
                Array.Resize(ref tsmi, tsmi.Length + 1);
                ToolStripMenuItem menuWindow = new ToolStripMenuItem(s);
                tsmi[tsmi.Length - 1] = menuWindow;// add new menu vao phan tu cuoi cung
            }
            ms.Items.AddRange(tsmi);
            ms.Dock = DockStyle.Top;
            this.Controls.Add(ms);
        }

        public bool OpenExistingForm(object sender, EventArgs e)
        {
            Form formMoiTao = (Form)sender;
            Form formDangMo = Application.OpenForms[formMoiTao!.Name];
            if (formDangMo != null)
            {
                // show from dang mở  
                formDangMo.Focus();
                return false;// ton tai thi focus
            }
            else
            {
                formMoiTao.MdiParent = this;

                // show form moi
                formMoiTao.Show();
                return true;// khong ton tai thi tao moi
            }
        }
        private void listViewCheckExistForm_Click(object sender, EventArgs e)
        {
            // chuyen man hinh theo ten da chon
            ToolStripMenuItem menuStrip = (ToolStripMenuItem)sender;
            // Thực hiện hành động khi newItem được nhấp
            //MessageBox.Show("Bạn đã nhấp vào " + menuStrip.Text);

            switch (menuStrip.Text)
            {
                case "BT01":
                    OpenExistingForm(new BT11(), e);
                    break;
                case "BT02":
                    OpenExistingForm(new BT02(), e);
                    break;
                case "BT03":
                    OpenExistingForm(new BT03(), e);
                    break;
                case "BT04":
                    OpenExistingForm(new BT04(), e);
                    break;
                case "BT05":
                    OpenExistingForm(new BT05(), e);
                    break;
                case "BT06":
                    OpenExistingForm(new BT06(), e);
                    break;
                case "BT07":
                    OpenExistingForm(new BT07(), e);
                    break;
                case "BT08":
                    OpenExistingForm(new BT08(), e);
                    break;
                case "BT09":
                    OpenExistingForm(new BT09(), e);
                    break;
                case "BT10":
                    OpenExistingForm(new BT10(), e);
                    break;
                case "BT11":
                    OpenExistingForm(new BT11(), e);
                    break;
                case "Đăng nhập":
                    Form dangnhap = new DangNhap();
                    dangnhap.ShowDialog();
                    break;
                case "Thoát":
                    // Kiểm tra xem form có muốn đóng không
                    FormClosingEventArgs ee = new FormClosingEventArgs(CloseReason.ApplicationExitCall, true);
                    if (ErrFrm.FormClosingEvent(sender, ee))
                    {
                        // Đóng form
                        this.Close();
                    }
                    break;
                default: break;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
