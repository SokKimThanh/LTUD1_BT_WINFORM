namespace BT2
{
    partial class BT06
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BT06));
            label1 = new Label();
            radVN = new RadioButton();
            radUS = new RadioButton();
            radIT = new RadioButton();
            radPH = new RadioButton();
            pbCoutry = new PictureBox();
            groupBox1 = new GroupBox();
            imgListCountry = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pbCoutry).BeginInit();
            groupBox1.SuspendLayout();
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
            label1.Size = new Size(536, 44);
            label1.TabIndex = 1;
            label1.Text = "Danh sách quốc kỳ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // radVN
            // 
            radVN.AutoSize = true;
            radVN.Location = new Point(40, 25);
            radVN.Name = "radVN";
            radVN.Size = new Size(80, 23);
            radVN.TabIndex = 2;
            radVN.TabStop = true;
            radVN.Text = "VietNam";
            radVN.UseVisualStyleBackColor = true;
            radVN.CheckedChanged += selectCountry;
            // 
            // radUS
            // 
            radUS.AutoSize = true;
            radUS.Location = new Point(40, 71);
            radUS.Name = "radUS";
            radUS.Size = new Size(53, 23);
            radUS.TabIndex = 3;
            radUS.TabStop = true;
            radUS.Text = "USA";
            radUS.UseVisualStyleBackColor = true;
            radUS.CheckedChanged += selectCountry;
            // 
            // radIT
            // 
            radIT.AutoSize = true;
            radIT.Location = new Point(40, 119);
            radIT.Name = "radIT";
            radIT.Size = new Size(64, 23);
            radIT.TabIndex = 4;
            radIT.TabStop = true;
            radIT.Text = "Italian";
            radIT.UseVisualStyleBackColor = true;
            radIT.CheckedChanged += selectCountry;
            // 
            // radPH
            // 
            radPH.AutoSize = true;
            radPH.Location = new Point(40, 166);
            radPH.Name = "radPH";
            radPH.Size = new Size(86, 23);
            radPH.TabIndex = 5;
            radPH.TabStop = true;
            radPH.Text = "Philippine";
            radPH.UseVisualStyleBackColor = true;
            radPH.CheckedChanged += selectCountry;
            // 
            // pbCoutry
            // 
            pbCoutry.Location = new Point(268, 47);
            pbCoutry.Name = "pbCoutry";
            pbCoutry.Size = new Size(256, 256);
            pbCoutry.TabIndex = 6;
            pbCoutry.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radPH);
            groupBox1.Controls.Add(radIT);
            groupBox1.Controls.Add(radUS);
            groupBox1.Controls.Add(radVN);
            groupBox1.Location = new Point(12, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(170, 207);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Coutry";
            // 
            // imgListCountry
            // 
            imgListCountry.ColorDepth = ColorDepth.Depth8Bit;
            imgListCountry.ImageStream = (ImageListStreamer)resources.GetObject("imgListCountry.ImageStream");
            imgListCountry.TransparentColor = Color.Transparent;
            imgListCountry.Images.SetKeyName(0, "Italia.jpg");
            imgListCountry.Images.SetKeyName(1, "My.jpg");
            imgListCountry.Images.SetKeyName(2, "Philippine.jpg");
            imgListCountry.Images.SetKeyName(3, "Vietnam.jpg");
            // 
            // BT06
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 309);
            Controls.Add(groupBox1);
            Controls.Add(pbCoutry);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BT06";
            Text = "Country flag";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbCoutry).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private RadioButton radVN;
        private RadioButton radUS;
        private RadioButton radIT;
        private RadioButton radPH;
        private PictureBox pbCoutry;
        private GroupBox groupBox1;
        private ImageList imgListCountry;
    }
}