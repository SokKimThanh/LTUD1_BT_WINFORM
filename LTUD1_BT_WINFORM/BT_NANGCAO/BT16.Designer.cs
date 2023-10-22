namespace BT8_LISTBOX.BT_NANGCAO
{
    partial class BT16
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            imageList1 = new ImageList(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            smallToolStripMenuItem = new ToolStripMenuItem();
            detailToolStripMenuItem = new ToolStripMenuItem();
            xóaToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            btnGhiFile = new Button();
            btnDocFile = new Button();
            trackBar1 = new TrackBar();
            btnXoaHet = new Button();
            lvSinhVien = new ListView();
            colIDSV = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnXoa = new Button();
            lblWidth = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPhone = new TextBox();
            txtHoTen = new TextBox();
            txtColWidth = new TextBox();
            btnCapNhat = new Button();
            btnThem = new Button();
            lblIDSinhVien = new Label();
            txtIDSinhVien = new TextBox();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { smallToolStripMenuItem, detailToolStripMenuItem, xóaToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(114, 76);
            // 
            // smallToolStripMenuItem
            // 
            smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            smallToolStripMenuItem.Size = new Size(113, 24);
            smallToolStripMenuItem.Text = "Small";
            smallToolStripMenuItem.Click += smallToolStripMenuItem_Click;
            // 
            // detailToolStripMenuItem
            // 
            detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            detailToolStripMenuItem.Size = new Size(113, 24);
            detailToolStripMenuItem.Text = "Detail";
            detailToolStripMenuItem.Click += detailToolStripMenuItem_Click;
            // 
            // xóaToolStripMenuItem
            // 
            xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            xóaToolStripMenuItem.Size = new Size(113, 24);
            xóaToolStripMenuItem.Text = "Xóa";
            xóaToolStripMenuItem.Click += btnXoa_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGhiFile
            // 
            btnGhiFile.Location = new Point(457, 109);
            btnGhiFile.Name = "btnGhiFile";
            btnGhiFile.Size = new Size(86, 28);
            btnGhiFile.TabIndex = 49;
            btnGhiFile.Text = "Ghi File";
            btnGhiFile.UseVisualStyleBackColor = true;
            btnGhiFile.Click += btnGhiFile_Click;
            // 
            // btnDocFile
            // 
            btnDocFile.Location = new Point(457, 32);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(86, 29);
            btnDocFile.TabIndex = 48;
            btnDocFile.Text = "Đọc File";
            btnDocFile.UseVisualStyleBackColor = true;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.None;
            trackBar1.Location = new Point(155, 167);
            trackBar1.Maximum = 250;
            trackBar1.Minimum = 60;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(154, 45);
            trackBar1.TabIndex = 47;
            trackBar1.Value = 250;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // btnXoaHet
            // 
            btnXoaHet.Anchor = AnchorStyles.None;
            btnXoaHet.Location = new Point(457, 162);
            btnXoaHet.Margin = new Padding(3, 4, 3, 4);
            btnXoaHet.Name = "btnXoaHet";
            btnXoaHet.Size = new Size(86, 29);
            btnXoaHet.TabIndex = 46;
            btnXoaHet.Text = "Xóa Hết";
            btnXoaHet.UseVisualStyleBackColor = true;
            btnXoaHet.Click += btnXoaHet_Click;
            // 
            // lvSinhVien
            // 
            lvSinhVien.BackColor = Color.FromArgb(192, 255, 192);
            lvSinhVien.Columns.AddRange(new ColumnHeader[] { colIDSV, columnHeader1, columnHeader2 });
            lvSinhVien.ContextMenuStrip = contextMenuStrip1;
            lvSinhVien.Dock = DockStyle.Bottom;
            lvSinhVien.FullRowSelect = true;
            lvSinhVien.GridLines = true;
            lvSinhVien.Location = new Point(0, 273);
            lvSinhVien.Margin = new Padding(3, 4, 3, 4);
            lvSinhVien.Name = "lvSinhVien";
            lvSinhVien.Size = new Size(574, 236);
            lvSinhVien.TabIndex = 45;
            lvSinhVien.UseCompatibleStateImageBehavior = false;
            lvSinhVien.View = View.Details;
            lvSinhVien.Click += lvDemo_Click;
            // 
            // colIDSV
            // 
            colIDSV.Text = "ID SinhVien";
            colIDSV.Width = 150;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Họ Tên";
            columnHeader1.Width = 210;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số điện thoại";
            columnHeader2.Width = 210;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.Location = new Point(365, 162);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 29);
            btnXoa.TabIndex = 43;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // lblWidth
            // 
            lblWidth.Anchor = AnchorStyles.None;
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(51, 177);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(95, 19);
            lblWidth.TabIndex = 42;
            lblWidth.Text = "Column width";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(51, 136);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 41;
            label2.Text = "Số Điện thoại";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(51, 92);
            label1.Name = "label1";
            label1.Size = new Size(52, 19);
            label1.TabIndex = 40;
            label1.Text = "Họ Tên";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.None;
            txtPhone.Location = new Point(155, 125);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(194, 26);
            txtPhone.TabIndex = 39;
            txtPhone.Text = "840902123456";
            txtPhone.Click += txtEmpty_Event;
            txtPhone.TextChanged += txtPhone_TextChanged;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtHoTen
            // 
            txtHoTen.Anchor = AnchorStyles.None;
            txtHoTen.Location = new Point(155, 87);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(194, 26);
            txtHoTen.TabIndex = 38;
            txtHoTen.Text = "Sok Kim Thanh";
            txtHoTen.Click += txtEmpty_Event;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            txtHoTen.KeyPress += txtHoTen_KeyPress;
            // 
            // txtColWidth
            // 
            txtColWidth.Anchor = AnchorStyles.None;
            txtColWidth.Enabled = false;
            txtColWidth.Location = new Point(309, 167);
            txtColWidth.Margin = new Padding(3, 4, 3, 4);
            txtColWidth.Name = "txtColWidth";
            txtColWidth.Size = new Size(41, 26);
            txtColWidth.TabIndex = 37;
            txtColWidth.Text = "250";
            txtColWidth.TextChanged += txtColWidth_TextChanged;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.None;
            btnCapNhat.Location = new Point(365, 108);
            btnCapNhat.Margin = new Padding(3, 4, 3, 4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(86, 29);
            btnCapNhat.TabIndex = 36;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += CapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.Location = new Point(365, 32);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 29);
            btnThem.TabIndex = 35;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblIDSinhVien
            // 
            lblIDSinhVien.AutoSize = true;
            lblIDSinhVien.Location = new Point(50, 37);
            lblIDSinhVien.Name = "lblIDSinhVien";
            lblIDSinhVien.Size = new Size(90, 19);
            lblIDSinhVien.TabIndex = 50;
            lblIDSinhVien.Text = "Mã Sinh Viên";
            // 
            // txtIDSinhVien
            // 
            txtIDSinhVien.BackColor = Color.FromArgb(255, 192, 192);
            txtIDSinhVien.BorderStyle = BorderStyle.FixedSingle;
            txtIDSinhVien.Enabled = false;
            txtIDSinhVien.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDSinhVien.ForeColor = Color.Red;
            txtIDSinhVien.Location = new Point(154, 30);
            txtIDSinhVien.Name = "txtIDSinhVien";
            txtIDSinhVien.Size = new Size(194, 39);
            txtIDSinhVien.TabIndex = 51;
            // 
            // BT16
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 509);
            Controls.Add(txtIDSinhVien);
            Controls.Add(lblIDSinhVien);
            Controls.Add(btnGhiFile);
            Controls.Add(btnDocFile);
            Controls.Add(trackBar1);
            Controls.Add(btnXoaHet);
            Controls.Add(lvSinhVien);
            Controls.Add(btnXoa);
            Controls.Add(lblWidth);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(txtHoTen);
            Controls.Add(txtColWidth);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BT16";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BT16";
            FormClosing += BT16_FormClosing;
            Load += BT16_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageList1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem smallToolStripMenuItem;
        private ToolStripMenuItem detailToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button btnGhiFile;
        private Button btnDocFile;
        private TrackBar trackBar1;
        private Button btnXoaHet;
        private ListView lvSinhVien;
        private Button btnXoa;
        private Label lblWidth;
        private Label label2;
        private Label label1;
        private TextBox txtPhone;
        private TextBox txtHoTen;
        private TextBox txtColWidth;
        private Button btnCapNhat;
        private Button btnThem;
        private ColumnHeader colIDSV;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label lblIDSinhVien;
        private TextBox txtIDSinhVien;
        private ToolStripMenuItem xóaToolStripMenuItem;
    }
}