namespace EX3
{
    public partial class CheckedChanged : Form
    {
        public CheckedChanged()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn_sothich_Click(object sender, EventArgs e)

        {

            string str = "";

            if (chkbox_muasam.Checked == true)

            {

                str = chkbox_muasam.Text + "\n";

            }

            if (chkbox_nghenhac.Checked == true)

            {

                str = str + chkbox_nghenhac.Text + "\n";

            }

            if (chkbox_thethao.Checked == true)

            {

                str = str + chkbox_thethao.Text + "\n";

            }

            if (chkbox_xemphim.Checked == true)

            {

                str = str + chkbox_xemphim.Text + "\n";

            }

            if (chxbox_dulich.Checked == true)

            {

                str = str + chxbox_dulich.Text;

            }



            if (str.Length > 0)

            {

                MessageBox.Show("Sở thích của bạn là: \n" + str);

            }

            else

            {

                MessageBox.Show("Không có sở thích nào bạn chọn!!");

            }
        }

            private void btn_mauthich_Click(object sender, EventArgs e)

        {

            string str = "";

            if (rdbtn_do.Checked == true)

            {

                str = rdbtn_do.Text + "\n";

            }

            if (rdbtn_trang.Checked == true)

            {

                str = rdbtn_trang.Text + "\n";

            }

            if (rdbtn_tim.Checked == true)

            {

                str = rdbtn_tim.Text + "\n";

            }

            if (rdbtn_trang.Checked == true)

            {

                str = rdbtn_trang.Text + "\n";

            }

            if (rdbtn_vang.Checked == true)

            {

                str = rdbtn_vang.Text;

            }
            if (rdbtn_hong.Checked == true)

            {

                str = rdbtn_hong.Text;

            }



            if (str.Length > 0)

            {

                MessageBox.Show("Màu bạn thích là: \n" + str);

            }

            else

            {

                MessageBox.Show("Không có màu nào bạn chọn!!");

            }

        }

    }
}

