using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BT8_LISTBOX
{
    internal class TNThuMuc
    {
        TreeView treeView;
        TreeNode lophocNode;
        TreeNode sinhVienNode;

        public TNThuMuc(TreeView tv)
        {
            this.TreeView = tv;
        }

        public TreeView TreeView { get => treeView; set => treeView = value; }
        public TreeNode LopHocNode { get => lophocNode; set => lophocNode = value; }
        public TreeNode SinhVienNode { get => sinhVienNode; set => sinhVienNode = value; }

        /// <summary>
        /// Thêm 1 node vào tree view
        /// </summary>
        /// <param name="list"></param>
        public TreeNode AddSinhVienNode(SinhVien sv)
        {
            TreeNode node = new TreeNode();
            node.Name = sv.Id.ToString();
            node.Text = $"{sv.Hoten}";
            return node;
        }
        /// <summary>
        /// update SinhVienNode hien tai
        /// </summary>
        /// <param name="sv"></param>
        internal void UpdateSinhVienNode(SinhVien sv)
        {
            sinhVienNode.Name = sv.Id.ToString();
            sinhVienNode.Text = $"{sv.Hoten}";
        }
    }
}
