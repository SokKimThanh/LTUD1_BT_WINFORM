using BT8_LISTBOX.BatLoiControl;
using BT8_LISTBOX.BT_NANGCAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT8_LISTBOX
{
    public partial class BT05 : Form
    {
        ErrFrm f;
        List<Control> controlList;
        ErrTxt r;
        public BT05()
        {
            InitializeComponent();
            f = new ErrFrm(this);
            r = new ErrTxt(this);
        }

        private void BT05_Load(object sender, EventArgs e)
        {
            controlList = new List<Control> { textBox1, textBox2, comboBox1 };
        }

        private void Input_Enter(object sender, EventArgs e)
        {
            f.ValidateInputs(controlList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f.IsValidateInputs(controlList))
            {
                r.LblHint.Text = "Nhập OK!";
                r.PnError.BackColor = Color.Green;
            }
            else
            {
                r.LblHint.Text = "Vui lòng nhập giá trị hợp lệ.";
                r.PnError.BackColor = Color.Red;
            }
        }
    }
}
