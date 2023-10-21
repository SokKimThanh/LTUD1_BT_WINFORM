namespace LTUD1_Tuan2_BT1
{
    partial class BT01
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
            components = new System.ComponentModel.Container();
            txtYourName = new TextBox();
            txtYear = new TextBox();
            lblYourName = new Label();
            label2 = new Label();
            btnShow = new Button();
            btnClear = new Button();
            btnExit = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtYourName
            // 
            txtYourName.Location = new Point(160, 41);
            txtYourName.Margin = new Padding(6, 5, 6, 5);
            txtYourName.Name = "txtYourName";
            txtYourName.Size = new Size(264, 30);
            txtYourName.TabIndex = 0;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(160, 110);
            txtYear.Margin = new Padding(6, 5, 6, 5);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(264, 30);
            txtYear.TabIndex = 1;
            // 
            // lblYourName
            // 
            lblYourName.AutoSize = true;
            lblYourName.Location = new Point(46, 51);
            lblYourName.Margin = new Padding(6, 0, 6, 0);
            lblYourName.Name = "lblYourName";
            lblYourName.Size = new Size(104, 23);
            lblYourName.TabIndex = 2;
            lblYourName.Text = "Your Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 120);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 3;
            label2.Text = "Year of birth";
            // 
            // btnShow
            // 
            btnShow.Location = new Point(46, 179);
            btnShow.Margin = new Padding(6, 5, 6, 5);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 51);
            btnShow.TabIndex = 4;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(160, 179);
            btnClear.Margin = new Padding(6, 5, 6, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 51);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(330, 179);
            btnExit.Margin = new Padding(6, 5, 6, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 51);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // BT01
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 274);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnShow);
            Controls.Add(label2);
            Controls.Add(lblYourName);
            Controls.Add(txtYear);
            Controls.Add(txtYourName);
            Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "BT01";
            StartPosition = FormStartPosition.CenterParent;
            FormClosing += frmMyNameProject_FormClosing;
            Load += frmMyNameProject_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtYourName;
        private TextBox txtYear;
        private Label lblYourName;
        private Label label2;
        private Button btnShow;
        private Button btnClear;
        private Button btnExit;
        private ErrorProvider errorProvider1;
    }
}