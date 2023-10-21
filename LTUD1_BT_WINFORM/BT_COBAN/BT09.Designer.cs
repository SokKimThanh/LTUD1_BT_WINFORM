namespace BT8_LISTBOX
{
    partial class BT09
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
            label1 = new Label();
            label2 = new Label();
            txtHoVaTen = new TextBox();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnKetThuc = new Button();
            groupBox1 = new GroupBox();
            lstLopA = new ListBox();
            groupBox2 = new GroupBox();
            lstLopB = new ListBox();
            btnAdd = new Button();
            btnAddAll = new Button();
            btnRemove = new Button();
            btnRemoveAll = new Button();
            cboClass = new ComboBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(529, 44);
            label1.TabIndex = 0;
            label1.Text = "Danh sách sinh viên";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 351);
            label2.Name = "label2";
            label2.Size = new Size(69, 19);
            label2.TabIndex = 1;
            label2.Text = "Họ và tên";
            label2.Click += label2_Click;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(133, 348);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(382, 26);
            txtHoVaTen.TabIndex = 2;
            txtHoVaTen.TextChanged += txtHoVaTen_TextChanged;
            txtHoVaTen.Enter += txtHoVaTen_Enter;
            txtHoVaTen.KeyDown += txtHoVaTen_KeyDown;
            txtHoVaTen.KeyPress += txtHoVaTen_KeyPress;
            txtHoVaTen.MouseDown += txtHoVaTen_MouseDown;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(408, 426);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(107, 36);
            btnCapNhat.TabIndex = 3;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(405, 275);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(107, 36);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(22, 275);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(107, 36);
            btnKetThuc.TabIndex = 5;
            btnKetThuc.Text = "Kết thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstLopA);
            groupBox1.Location = new Point(22, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 210);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lớp A";
            // 
            // lstLopA
            // 
            lstLopA.Dock = DockStyle.Fill;
            lstLopA.FormattingEnabled = true;
            lstLopA.ItemHeight = 19;
            lstLopA.Location = new Point(3, 22);
            lstLopA.Name = "lstLopA";
            lstLopA.Size = new Size(194, 185);
            lstLopA.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstLopB);
            groupBox2.Location = new Point(315, 59);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 210);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lớp B";
            // 
            // lstLopB
            // 
            lstLopB.Dock = DockStyle.Fill;
            lstLopB.FormattingEnabled = true;
            lstLopB.ItemHeight = 19;
            lstLopB.Location = new Point(3, 22);
            lstLopB.Name = "lstLopB";
            lstLopB.Size = new Size(194, 185);
            lstLopB.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(248, 99);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(43, 36);
            btnAdd.TabIndex = 8;
            btnAdd.Text = ">";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnAddAll
            // 
            btnAddAll.Location = new Point(248, 141);
            btnAddAll.Name = "btnAddAll";
            btnAddAll.Size = new Size(43, 36);
            btnAddAll.TabIndex = 9;
            btnAddAll.Text = ">>";
            btnAddAll.UseVisualStyleBackColor = true;
            btnAddAll.Click += btnAddAll_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(248, 183);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(43, 36);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.Location = new Point(248, 225);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new Size(43, 36);
            btnRemoveAll.TabIndex = 11;
            btnRemoveAll.Text = "<<";
            btnRemoveAll.UseVisualStyleBackColor = true;
            btnRemoveAll.Click += btnRemoveAll_Click;
            // 
            // cboClass
            // 
            cboClass.FormattingEnabled = true;
            cboClass.Location = new Point(133, 380);
            cboClass.Name = "cboClass";
            cboClass.Size = new Size(382, 27);
            cboClass.TabIndex = 12;
            cboClass.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 388);
            label3.Name = "label3";
            label3.Size = new Size(96, 19);
            label3.TabIndex = 13;
            label3.Text = "Danh sách lớp";
            // 
            // BT09
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 477);
            Controls.Add(label3);
            Controls.Add(cboClass);
            Controls.Add(btnRemoveAll);
            Controls.Add(btnRemove);
            Controls.Add(btnAddAll);
            Controls.Add(btnAdd);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(txtHoVaTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BT09";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BT9";
            FormClosing += BT09_FormClosing;
            Load += BT09_Load;
            KeyPress += BT09_KeyPress;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHoVaTen;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnKetThuc;
        private GroupBox groupBox1;
        private ListBox lstLopA;
        private GroupBox groupBox2;
        private ListBox lstLopB;
        private Button btnAdd;
        private Button btnAddAll;
        private Button btnRemove;
        private Button btnRemoveAll;
        private ComboBox cboClass;
        private Label label3;
    }
}