﻿namespace BT8_LISTBOX.BT_NANGCAO
{
    partial class BT18
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnReadFile = new Button();
            btnWriteFile = new Button();
            btnDeleteAllNode = new Button();
            btnDeleteNode = new Button();
            btnEditNode = new Button();
            button2 = new Button();
            txtLastName = new TextBox();
            txtFullName = new TextBox();
            btnExit = new Button();
            tvDanhBa = new TreeView();
            tableLayoutPanel3 = new TableLayoutPanel();
            listView1 = new ListView();
            tableLayoutPanel4 = new TableLayoutPanel();
            button1 = new Button();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tvDanhBa, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(832, 523);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(btnExit, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(249, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 81.6199341F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18.3800621F));
            tableLayoutPanel2.Size = new Size(249, 523);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel5);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin danh bạ";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(btnReadFile, 0, 7);
            tableLayoutPanel5.Controls.Add(btnWriteFile, 0, 6);
            tableLayoutPanel5.Controls.Add(btnDeleteAllNode, 0, 5);
            tableLayoutPanel5.Controls.Add(btnDeleteNode, 0, 4);
            tableLayoutPanel5.Controls.Add(btnEditNode, 0, 3);
            tableLayoutPanel5.Controls.Add(button2, 0, 2);
            tableLayoutPanel5.Controls.Add(txtLastName, 0, 1);
            tableLayoutPanel5.Controls.Add(txtFullName, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 22);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 8;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.Size = new Size(243, 401);
            tableLayoutPanel5.TabIndex = 10;
            // 
            // btnReadFile
            // 
            btnReadFile.Dock = DockStyle.Fill;
            btnReadFile.FlatAppearance.BorderColor = Color.Red;
            btnReadFile.FlatAppearance.CheckedBackColor = Color.Lime;
            btnReadFile.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            btnReadFile.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnReadFile.FlatStyle = FlatStyle.Flat;
            btnReadFile.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnReadFile.Location = new Point(0, 350);
            btnReadFile.Margin = new Padding(0);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(243, 51);
            btnReadFile.TabIndex = 10;
            btnReadFile.Text = "Read File";
            btnReadFile.UseVisualStyleBackColor = true;
            // 
            // btnWriteFile
            // 
            btnWriteFile.Dock = DockStyle.Fill;
            btnWriteFile.FlatAppearance.BorderColor = Color.Red;
            btnWriteFile.FlatAppearance.CheckedBackColor = Color.Lime;
            btnWriteFile.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            btnWriteFile.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnWriteFile.FlatStyle = FlatStyle.Flat;
            btnWriteFile.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnWriteFile.Location = new Point(0, 300);
            btnWriteFile.Margin = new Padding(0);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(243, 50);
            btnWriteFile.TabIndex = 9;
            btnWriteFile.Text = "Write File";
            btnWriteFile.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAllNode
            // 
            btnDeleteAllNode.Dock = DockStyle.Fill;
            btnDeleteAllNode.FlatAppearance.BorderColor = Color.Red;
            btnDeleteAllNode.FlatAppearance.CheckedBackColor = Color.Lime;
            btnDeleteAllNode.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            btnDeleteAllNode.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnDeleteAllNode.FlatStyle = FlatStyle.Flat;
            btnDeleteAllNode.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteAllNode.Location = new Point(0, 250);
            btnDeleteAllNode.Margin = new Padding(0);
            btnDeleteAllNode.Name = "btnDeleteAllNode";
            btnDeleteAllNode.Size = new Size(243, 50);
            btnDeleteAllNode.TabIndex = 8;
            btnDeleteAllNode.Text = "Delete All Node";
            btnDeleteAllNode.UseVisualStyleBackColor = true;
            // 
            // btnDeleteNode
            // 
            btnDeleteNode.Dock = DockStyle.Fill;
            btnDeleteNode.FlatAppearance.BorderColor = Color.Red;
            btnDeleteNode.FlatAppearance.CheckedBackColor = Color.Lime;
            btnDeleteNode.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            btnDeleteNode.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnDeleteNode.FlatStyle = FlatStyle.Flat;
            btnDeleteNode.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteNode.Location = new Point(0, 200);
            btnDeleteNode.Margin = new Padding(0);
            btnDeleteNode.Name = "btnDeleteNode";
            btnDeleteNode.Size = new Size(243, 50);
            btnDeleteNode.TabIndex = 7;
            btnDeleteNode.Text = "Delete Node";
            btnDeleteNode.UseVisualStyleBackColor = true;
            // 
            // btnEditNode
            // 
            btnEditNode.Dock = DockStyle.Fill;
            btnEditNode.FlatAppearance.BorderColor = Color.Red;
            btnEditNode.FlatAppearance.CheckedBackColor = Color.Lime;
            btnEditNode.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            btnEditNode.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnEditNode.FlatStyle = FlatStyle.Flat;
            btnEditNode.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditNode.Location = new Point(0, 150);
            btnEditNode.Margin = new Padding(0);
            btnEditNode.Name = "btnEditNode";
            btnEditNode.Size = new Size(243, 50);
            btnEditNode.TabIndex = 6;
            btnEditNode.Text = "Edit Name";
            btnEditNode.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderColor = Color.Red;
            button2.FlatAppearance.CheckedBackColor = Color.Lime;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            button2.FlatAppearance.MouseOverBackColor = Color.Lime;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(0, 100);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(243, 50);
            button2.TabIndex = 5;
            button2.Text = "Add Name";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.BackColor = SystemColors.GradientActiveCaption;
            txtLastName.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.ForeColor = Color.Crimson;
            txtLastName.Location = new Point(0, 53);
            txtLastName.Margin = new Padding(0);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Phone Number";
            txtLastName.Size = new Size(243, 43);
            txtLastName.TabIndex = 2;
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFullName.BackColor = SystemColors.GradientActiveCaption;
            txtFullName.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.ForeColor = Color.Crimson;
            txtFullName.Location = new Point(0, 3);
            txtFullName.Margin = new Padding(0);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Full Name";
            txtFullName.Size = new Size(243, 43);
            txtFullName.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Fill;
            btnExit.FlatAppearance.BorderColor = Color.Red;
            btnExit.FlatAppearance.CheckedBackColor = Color.Lime;
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            btnExit.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(0, 426);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(249, 97);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // tvDanhBa
            // 
            tvDanhBa.BackColor = Color.FromArgb(192, 255, 192);
            tvDanhBa.Dock = DockStyle.Fill;
            tvDanhBa.Location = new Point(0, 0);
            tvDanhBa.Margin = new Padding(0);
            tvDanhBa.Name = "tvDanhBa";
            tvDanhBa.Size = new Size(249, 523);
            tvDanhBa.TabIndex = 1;
            tvDanhBa.AfterCollapse += tvDanhBa_AfterCollapse;
            tvDanhBa.AfterExpand += tvDanhBa_AfterExpand;
            tvDanhBa.AfterSelect += tvDanhBa_AfterSelect;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(listView1, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(498, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 11.3924046F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 88.6076F));
            tableLayoutPanel3.Size = new Size(334, 523);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(192, 255, 192);
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(0, 59);
            listView1.Margin = new Padding(0);
            listView1.Name = "listView1";
            listView1.Size = new Size(334, 464);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.Controls.Add(button1, 1, 0);
            tableLayoutPanel4.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(334, 59);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatAppearance.CheckedBackColor = Color.Lime;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 255);
            button1.FlatAppearance.MouseOverBackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(233, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(101, 59);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(0);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(0);
            groupBox2.Size = new Size(233, 59);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GradientActiveCaption;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Crimson;
            textBox1.Location = new Point(0, 19);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Name";
            textBox1.Size = new Size(233, 43);
            textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // BT18
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(832, 523);
            Controls.Add(tableLayoutPanel1);
            ForeColor = Color.Crimson;
            Name = "BT18";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BT18 Nhập danh bạ";
            WindowState = FormWindowState.Minimized;
            Load += BT18_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnExit;
        private TreeView tvDanhBa;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private ListView listView1;
        private TableLayoutPanel tableLayoutPanel4;
        private ContextMenuStrip contextMenuStrip1;
        private Button button1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnReadFile;
        private Button btnWriteFile;
        private Button btnDeleteAllNode;
        private Button btnDeleteNode;
        private Button btnEditNode;
        private Button button2;
        private TextBox txtLastName;
        private TextBox txtFullName;
    }
}