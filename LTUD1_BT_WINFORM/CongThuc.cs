using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT8_LISTBOX
{
    public static class CongThuc
    {
        public static string PhuongTrinhBac1(string s, string s1)
        {
            float a, b;
            a = float.Parse(s);
            b = float.Parse(s1);
            if (a == 0)
            {
                if (b == 0)
                {
                    return "vosonghiem";//vosonghiem
                }
                else
                {
                    return "vonghiem";//vonghiem
                }
            }
            else
            {
                return (-b / a).ToString();
            }
        }

        public static int TinhTong(ArrayList arr)
        {
            int sum = 0;
            if (arr.Count > 0)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    string s = arr[i].ToString();
                    sum += int.Parse(s);
                }
            }
            return sum;
        }

        public static void XoaPhanTu()
        {

        }
        public static void XoaDauDuoi()
        {

        }
        public static void Tang2DV()
        {

        }
        public static void BinhPhuong()
        {

        }
        public static void SoChan()
        {

        }
        public static void SoLe()
        {

        }


    }
}
