using System;
using System.Collections;
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
    public partial class BT07 : Form
    {
        public BT07()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT7_COMBOBOX_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thoát hả?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void LietKeCacUocSo(int n)
        {
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
        private int TinhTong(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += i;
            }
            return sum;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(comboBox1.SelectedItem.ToString(), out int selectedItem);

            listBox1.Items.Clear();
            LietKeCacUocSo(selectedItem);
        }
        private int[] ParseArrInt(int n)
        {
            int[] arr = { };
            for (int i = 0; i < n; i++)
            {
                if (listBox1.Items[i] != null)
                {
                    arr[i] = int.Parse(listBox1.Items[i].ToString());
                }
            }
            return arr;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int[] arr = ParseArrInt(listBox1.Items.Count - 1);
            int sum = TinhTong(arr);
            MessageBox.Show("Tổng các ước là: " + sum);
        }

        private void BT7_COMBOBOX_Load(object sender, EventArgs e)
        {

        }
    }
}
