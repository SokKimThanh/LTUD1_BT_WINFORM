using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BT8_LISTBOX
{
    internal class TVCayThuMuc
    {
        // Tạo một danh sách các giá trị cho các node
        List<string> nodeData = new List<string> { "THTH5A", "THTH5B", "THTH5C" };

        // Tạo một TreeNode mới
        TreeNode parentNode = new TreeNode("Khoa Tin Học");

        // Tạo một ImageList mới
        ImageList imageList;

        // Tạo một TreeView mới
        TreeView treeView = new TreeView();

        /// <summary>
        /// cập nhật lại TreeView;
        /// </summary>
        public TVCayThuMuc(TreeView tv)
        {
            this.TreeView = tv;
            // Cho phép tùy chỉnh vẽ node
            this.TreeView.DrawMode = TreeViewDrawMode.OwnerDrawText;
        }


        /// <summary>
        /// Thêm hình vào 1 treeview mới hoàn toàn
        /// </summary>
        /// <param name="imageList"></param>
        public TVCayThuMuc(ImageList imageList)
        {
            // Thêm hình ảnh vào ImageList
            this.ImageList = imageList;

            // Đặt ImageList của TreeView
            this.TreeView.ImageList = imageList;

            // Cho phép tùy chỉnh vẽ node
            this.TreeView.DrawMode = TreeViewDrawMode.OwnerDrawText;

        }

        /// <summary>
        /// Thêm hình vào 1 tree view đã tồn tại
        /// </summary>
        /// <param name="tv"></param>
        /// <param name="imageList"></param>
        public TVCayThuMuc(TreeView tv, ImageList imageList)
        {
            // Thêm hình ảnh vào ImageList
            this.ImageList = imageList;

            // Cập nhật một TreeView đã có
            this.TreeView = tv;

            // Đặt ImageList của TreeView
            this.TreeView.ImageList = imageList;

            // Cho phép tùy chỉnh vẽ node
            this.TreeView.DrawMode = TreeViewDrawMode.OwnerDrawText;
        }

        /// <summary>
        /// Cập nhật lại 1 tree view với đầy đủ các thuộc tính mới và nội dung mới
        /// </summary>
        /// <param name="tv"></param>
        /// <param name="imageList">Hình ảnh cho mỗi TreeNode</param>
        /// <param name="parentNode">TreeNode đầu tiên của TreeView</param>
        /// <param name="nodeValues">TreeNode kế tiếp của parentNode</param>
        public TVCayThuMuc(TreeView tv, ImageList imageList, TreeNode parentNode, List<string> nodeValues)
        {
            // Thêm hình ảnh vào ImageList
            this.ImageList = imageList;

            // Tạo một TreeNode mới
            this.ParentNode = parentNode;

            // Tạo một ImageList mới
            this.NodeData = nodeValues;

            // Tạo một TreeView mới
            this.TreeView = tv;

            // Đặt ImageList của TreeView
            this.TreeView.ImageList = imageList;

            // Cho phép tùy chỉnh vẽ node
            this.TreeView.DrawMode = TreeViewDrawMode.OwnerDrawText;
        }

        public List<string> NodeData { get => nodeData; set => nodeData = value; }
        public TreeNode ParentNode { get => parentNode; set => parentNode = value; }
        public ImageList ImageList { get => imageList; set => imageList = value; }
        public TreeView TreeView { get => treeView; set => treeView = value; }

        /// <summary>
        /// Tạo một TreeView
        /// </summary>
        /// <returns>return a TreeView</returns>
        public TreeView CreateTreeView()
        {
            // Thêm từng giá trị trong danh sách vào parentNode
            foreach (string value in NodeData)
            {
                ParentNode.Nodes.Add(value);
                // Đặt ImageIndex của node
                ParentNode.ImageIndex = 0; // Chỉ số của hình ảnh trong ImageList
            }

            // Thêm parentNode vào TreeView
            TreeView.Nodes.Add(ParentNode);

            // return a treeview
            return TreeView;
        }


        private void treeView_DrawNode(object sender, DrawTreeNodeEventArgs e)
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
    }
}
