namespace BT8_LISTBOX
{
    partial class BT02
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
            lblTitle = new Label();
            lblNhapA = new Label();
            lblNhapB = new Label();
            txtNhapA = new TextBox();
            txtNhapB = new TextBox();
            btnGiai = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            errorProvider1 = new ErrorProvider(components);
            txtKetQua = new TextBox();
            lblKetQua = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(240, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(45, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // lblNhapA
            // 
            lblNhapA.AutoSize = true;
            lblNhapA.Location = new Point(53, 43);
            lblNhapA.Name = "lblNhapA";
            lblNhapA.Size = new Size(45, 19);
            lblNhapA.TabIndex = 1;
            lblNhapA.Text = "label2";
            // 
            // lblNhapB
            // 
            lblNhapB.AutoSize = true;
            lblNhapB.Location = new Point(53, 92);
            lblNhapB.Name = "lblNhapB";
            lblNhapB.Size = new Size(45, 19);
            lblNhapB.TabIndex = 2;
            lblNhapB.Text = "label3";
            // 
            // txtNhapA
            // 
            txtNhapA.Location = new Point(53, 63);
            txtNhapA.Name = "txtNhapA";
            txtNhapA.Size = new Size(406, 26);
            txtNhapA.TabIndex = 3;
            // 
            // txtNhapB
            // 
            txtNhapB.Location = new Point(53, 116);
            txtNhapB.Name = "txtNhapB";
            txtNhapB.Size = new Size(406, 26);
            txtNhapB.TabIndex = 4;
            // 
            // btnGiai
            // 
            btnGiai.Location = new Point(53, 247);
            btnGiai.Name = "btnGiai";
            btnGiai.Size = new Size(119, 50);
            btnGiai.TabIndex = 5;
            btnGiai.Text = "button1";
            btnGiai.UseVisualStyleBackColor = true;
            btnGiai.Click += btnGiai_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(194, 247);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(119, 50);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "button2";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(340, 247);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(119, 50);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "button3";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(53, 177);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(406, 26);
            txtKetQua.TabIndex = 9;
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.ForeColor = Color.Crimson;
            lblKetQua.Location = new Point(53, 151);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(45, 19);
            lblKetQua.TabIndex = 8;
            lblKetQua.Text = "label3";
            // 
            // BT02
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 347);
            Controls.Add(txtKetQua);
            Controls.Add(lblKetQua);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnGiai);
            Controls.Add(txtNhapB);
            Controls.Add(txtNhapA);
            Controls.Add(lblNhapB);
            Controls.Add(lblNhapA);
            Controls.Add(lblTitle);
            Name = "BT02";
            Text = "BT2";
            FormClosing += BT02_FormClosing;
            Load += BT02_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblNhapA;
        private Label lblNhapB;
        private TextBox txtNhapA;
        private TextBox txtNhapB;
        private Button btnGiai;
        private Button btnXoa;
        private Button btnThoat;
        private ErrorProvider errorProvider1;
        private TextBox txtKetQua;
        private Label lblKetQua;
    }
}