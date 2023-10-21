namespace BT8_LISTBOX
{
    partial class BT10
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMSSV = new TextBox();
            txtHoTen = new TextBox();
            cboNienKhoa = new ComboBox();
            cboLop = new ComboBox();
            radS1 = new RadioButton();
            radS2 = new RadioButton();
            radS3 = new RadioButton();
            radS4 = new RadioButton();
            btnThoat = new Button();
            chklstMonhoc = new CheckedListBox();
            label7 = new Label();
            btnHuy = new Button();
            btnDangKy = new Button();
            button3 = new Button();
            lblKetQuaChon = new RichTextBox();
            lblHint = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            label1.Size = new Size(379, 44);
            label1.TabIndex = 2;
            label1.Text = "Form Đăng ký môn học";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(38, 63);
            label2.Name = "label2";
            label2.Size = new Size(48, 19);
            label2.TabIndex = 3;
            label2.Text = "MSSV:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(38, 107);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 4;
            label3.Text = "Họ và tên:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(38, 204);
            label4.Name = "label4";
            label4.Size = new Size(35, 19);
            label4.TabIndex = 5;
            label4.Text = "Lớp:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(38, 261);
            label5.Name = "label5";
            label5.Size = new Size(54, 19);
            label5.TabIndex = 6;
            label5.Text = "Học kỳ:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(38, 149);
            label6.Name = "label6";
            label6.Size = new Size(74, 19);
            label6.TabIndex = 7;
            label6.Text = "Niên khóa:";
            // 
            // txtMSSV
            // 
            txtMSSV.Anchor = AnchorStyles.None;
            txtMSSV.Location = new Point(122, 63);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(209, 26);
            txtMSSV.TabIndex = 8;
            txtMSSV.TextChanged += txtMSSV_TextChanged;
            txtMSSV.KeyPress += txtMSSV_KeyPress;
            // 
            // txtHoTen
            // 
            txtHoTen.Anchor = AnchorStyles.None;
            txtHoTen.Location = new Point(122, 104);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(209, 26);
            txtHoTen.TabIndex = 9;
            txtHoTen.TextChanged += txtHoTen_TextChanged;
            txtHoTen.KeyPress += txtHoTen_KeyPress;
            // 
            // cboNienKhoa
            // 
            cboNienKhoa.Anchor = AnchorStyles.None;
            cboNienKhoa.FormattingEnabled = true;
            cboNienKhoa.Location = new Point(122, 146);
            cboNienKhoa.Name = "cboNienKhoa";
            cboNienKhoa.Size = new Size(209, 27);
            cboNienKhoa.TabIndex = 10;
            cboNienKhoa.KeyDown += ComboboxAddData_KeyDown;
            cboNienKhoa.Leave += cboNienKhoa_Leave;
            // 
            // cboLop
            // 
            cboLop.Anchor = AnchorStyles.None;
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(122, 201);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(209, 27);
            cboLop.TabIndex = 11;
            cboLop.KeyDown += ComboboxAddData_KeyDown;
            cboLop.Leave += cboLop_Leave;
            // 
            // radS1
            // 
            radS1.Anchor = AnchorStyles.None;
            radS1.AutoSize = true;
            radS1.Location = new Point(122, 259);
            radS1.Name = "radS1";
            radS1.Size = new Size(31, 23);
            radS1.TabIndex = 12;
            radS1.TabStop = true;
            radS1.Text = "I";
            radS1.UseVisualStyleBackColor = true;
            radS1.CheckedChanged += GetHocKy;
            // 
            // radS2
            // 
            radS2.Anchor = AnchorStyles.None;
            radS2.AutoSize = true;
            radS2.Location = new Point(169, 261);
            radS2.Name = "radS2";
            radS2.Size = new Size(35, 23);
            radS2.TabIndex = 13;
            radS2.TabStop = true;
            radS2.Text = "II";
            radS2.UseVisualStyleBackColor = true;
            radS2.CheckedChanged += GetHocKy;
            // 
            // radS3
            // 
            radS3.Anchor = AnchorStyles.None;
            radS3.AutoSize = true;
            radS3.Location = new Point(229, 259);
            radS3.Name = "radS3";
            radS3.Size = new Size(39, 23);
            radS3.TabIndex = 14;
            radS3.TabStop = true;
            radS3.Text = "III";
            radS3.UseVisualStyleBackColor = true;
            radS3.CheckedChanged += GetHocKy;
            // 
            // radS4
            // 
            radS4.Anchor = AnchorStyles.None;
            radS4.AutoSize = true;
            radS4.Location = new Point(290, 261);
            radS4.Name = "radS4";
            radS4.Size = new Size(40, 23);
            radS4.TabIndex = 15;
            radS4.TabStop = true;
            radS4.Text = "IV";
            radS4.UseVisualStyleBackColor = true;
            radS4.CheckedChanged += GetHocKy;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.Location = new Point(230, 576);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(101, 31);
            btnThoat.TabIndex = 20;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // chklstMonhoc
            // 
            chklstMonhoc.Anchor = AnchorStyles.None;
            chklstMonhoc.FormattingEnabled = true;
            chklstMonhoc.Items.AddRange(new object[] { "LT Windows", "LT Internet", "Mạng máy tính", "UML", "BE1", "FE1", "LTDD1" });
            chklstMonhoc.Location = new Point(122, 293);
            chklstMonhoc.Name = "chklstMonhoc";
            chklstMonhoc.Size = new Size(208, 88);
            chklstMonhoc.TabIndex = 21;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(38, 293);
            label7.Name = "label7";
            label7.Size = new Size(67, 19);
            label7.TabIndex = 22;
            label7.Text = "Môn học:";
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.None;
            btnHuy.Location = new Point(123, 576);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(101, 31);
            btnHuy.TabIndex = 23;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.Anchor = AnchorStyles.None;
            btnDangKy.Location = new Point(13, 576);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(101, 31);
            btnDangKy.TabIndex = 24;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(122, 543);
            button3.Name = "button3";
            button3.Size = new Size(75, 27);
            button3.TabIndex = 25;
            button3.Text = "review";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ReviewCode;
            // 
            // lblKetQuaChon
            // 
            lblKetQuaChon.Anchor = AnchorStyles.None;
            lblKetQuaChon.Location = new Point(122, 387);
            lblKetQuaChon.Name = "lblKetQuaChon";
            lblKetQuaChon.ScrollBars = RichTextBoxScrollBars.Vertical;
            lblKetQuaChon.Size = new Size(209, 150);
            lblKetQuaChon.TabIndex = 27;
            lblKetQuaChon.Text = "";
            // 
            // lblHint
            // 
            lblHint.Anchor = AnchorStyles.None;
            lblHint.AutoSize = true;
            lblHint.ForeColor = Color.Red;
            lblHint.Location = new Point(203, 547);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(89, 19);
            lblHint.TabIndex = 28;
            lblHint.Text = "Control Error";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // BT10
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 638);
            Controls.Add(lblHint);
            Controls.Add(lblKetQuaChon);
            Controls.Add(button3);
            Controls.Add(btnDangKy);
            Controls.Add(btnHuy);
            Controls.Add(label7);
            Controls.Add(chklstMonhoc);
            Controls.Add(btnThoat);
            Controls.Add(radS4);
            Controls.Add(radS3);
            Controls.Add(radS2);
            Controls.Add(radS1);
            Controls.Add(cboLop);
            Controls.Add(cboNienKhoa);
            Controls.Add(txtHoTen);
            Controls.Add(txtMSSV);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BT10";
            Text = "BT10";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMSSV;
        private TextBox txtHoTen;
        private ComboBox cboNienKhoa;
        private ComboBox cboLop;
        private RadioButton radS1;
        private RadioButton radS2;
        private RadioButton radS3;
        private RadioButton radS4;
        private ListBox lstMonHoc;
        private Button button2;
        private Button button1;
        private Button btnThoat;
        private CheckedListBox chklstMonhoc;
        private Label label7;
        private Button btnHuy;
        private Button btnDangKy;
        private Button button3;
        private RichTextBox lblKetQuaChon;
        private Label lblHint;
        private ErrorProvider errorProvider1;
    }
}