using BT8_LISTBOX;

namespace BT2
{
    public partial class BT06 : Form
    {
        public BT06()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectCountry(object sender, EventArgs e)
        {
            RadioButton radCountry = (RadioButton)sender;

            if (radCountry.Checked == true)
            {
                switch (radCountry.Name)
                {
                    case "radVN":
                        pbCoutry.Image = Utilities.GetImage("Vietnam.jpg", imgListCountry);
                        break;
                    case "radIT":
                        pbCoutry.Image = Utilities.GetImage("Italia.jpg", imgListCountry);
                        break;
                    case "radUS":
                        pbCoutry.Image = Utilities.GetImage("My.jpg", imgListCountry);
                        break;
                    case "radPH":
                        pbCoutry.Image = Utilities.GetImage("Philippine.jpg", imgListCountry);
                        break;
                    default: break;
                }
            }
        }
    }
}