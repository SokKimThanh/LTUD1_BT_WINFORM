namespace BT8_LISTBOX
{
    partial class BT08
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnClear = new Button();
            lstNumber = new ListBox();
            btnNhap = new Button();
            txtInput = new TextBox();
            groupBox2 = new GroupBox();
            button8 = new Button();
            button7 = new Button();
            btnPow2 = new Button();
            btnPlus2 = new Button();
            btnDeleteFirstTail = new Button();
            btnDelete = new Button();
            btnSum = new Button();
            label1 = new Label();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(lstNumber);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(txtInput);
            groupBox1.Location = new Point(32, 73);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(144, 312);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "ListBox";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(119, 28);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(25, 26);
            btnClear.TabIndex = 3;
            btnClear.Text = "x";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lstNumber
            // 
            lstNumber.Dock = DockStyle.Bottom;
            lstNumber.FormattingEnabled = true;
            lstNumber.ItemHeight = 19;
            lstNumber.Location = new Point(3, 114);
            lstNumber.Margin = new Padding(3, 4, 3, 4);
            lstNumber.Name = "lstNumber";
            lstNumber.Size = new Size(138, 194);
            lstNumber.TabIndex = 2;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(7, 65);
            btnNhap.Margin = new Padding(3, 4, 3, 4);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(130, 29);
            btnNhap.TabIndex = 1;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(7, 28);
            txtInput.Margin = new Padding(3, 4, 3, 4);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(109, 26);
            txtInput.TabIndex = 0;
            txtInput.TextChanged += txtInput_TextChanged;
            txtInput.Enter += txtInput_Enter;
            txtInput.KeyPress += txtInput_KeyPress;
            txtInput.Leave += txtInput_Leave;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(btnPow2);
            groupBox2.Controls.Add(btnPlus2);
            groupBox2.Controls.Add(btnDeleteFirstTail);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnSum);
            groupBox2.Location = new Point(259, 73);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(144, 312);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Xử lý listbox";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button8
            // 
            button8.Location = new Point(7, 265);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(130, 29);
            button8.TabIndex = 6;
            button8.Text = "Số lẻ";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(7, 228);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(130, 29);
            button7.TabIndex = 5;
            button7.Text = "Số chẵn";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // btnPow2
            // 
            btnPow2.Location = new Point(7, 191);
            btnPow2.Margin = new Padding(3, 4, 3, 4);
            btnPow2.Name = "btnPow2";
            btnPow2.Size = new Size(130, 29);
            btnPow2.TabIndex = 4;
            btnPow2.Text = "^2";
            btnPow2.UseVisualStyleBackColor = true;
            btnPow2.Click += btnPow2_Click;
            // 
            // btnPlus2
            // 
            btnPlus2.Location = new Point(7, 149);
            btnPlus2.Margin = new Padding(3, 4, 3, 4);
            btnPlus2.Name = "btnPlus2";
            btnPlus2.Size = new Size(130, 29);
            btnPlus2.TabIndex = 3;
            btnPlus2.Text = "+=2";
            btnPlus2.UseVisualStyleBackColor = true;
            btnPlus2.Click += btnPlus2_Click;
            // 
            // btnDeleteFirstTail
            // 
            btnDeleteFirstTail.Location = new Point(7, 113);
            btnDeleteFirstTail.Margin = new Padding(3, 4, 3, 4);
            btnDeleteFirstTail.Name = "btnDeleteFirstTail";
            btnDeleteFirstTail.Size = new Size(130, 29);
            btnDeleteFirstTail.TabIndex = 2;
            btnDeleteFirstTail.Text = "Xóa đầu đuôi";
            btnDeleteFirstTail.UseVisualStyleBackColor = true;
            btnDeleteFirstTail.Click += btnDeleteFirstTail_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(7, 76);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSum
            // 
            btnSum.Location = new Point(7, 39);
            btnSum.Margin = new Padding(3, 4, 3, 4);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(130, 29);
            btnSum.TabIndex = 0;
            btnSum.Text = "Tổng";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(435, 69);
            label1.TabIndex = 4;
            label1.Text = "ListBox";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(32, 393);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(371, 58);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button9_Click;
            // 
            // BT8_LISTBOX
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 471);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BT8_LISTBOX";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += BT8_LISTBOX_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox lstNumber;
        private Button btnNhap;
        private TextBox txtInput;
        private GroupBox groupBox2;
        private Button button8;
        private Button button7;
        private Button btnPow2;
        private Button btnPlus2;
        private Button btnDeleteFirstTail;
        private Button btnDelete;
        private Button btnSum;
        private Label label1;
        private Button btnExit;
        private Button btnClear;
    }
}