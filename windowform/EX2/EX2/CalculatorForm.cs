namespace EX2
{
    public partial class CaculatorForm : Form
    {
        public CaculatorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_num1_KeyPress(object sender, KeyPressEventArgs e)

        {

            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

            {

                e.Handled = true;

            }

        }
        private void btn_cong_Click(object sender, EventArgs e)

        {

            int result = Convert.ToInt32(txt_num1.Text) + Convert.ToInt32(txt_num2.Text);

            txt_result.Text = result.ToString();

        }

        private void btn_tru_Click(object sender, EventArgs e)

        {

            int result = Convert.ToInt32(txt_num1.Text) - Convert.ToInt32(txt_num2.Text);

            txt_result.Text = result.ToString();

        }


        private void btn_nhan_Click(object sender, EventArgs e)

        {

            int result = Convert.ToInt32(txt_num1.Text) * Convert.ToInt32(txt_num2.Text);

            txt_result.Text = result.ToString();

        }

        private void btn_chia_Click(object sender, EventArgs e)

        {

            Double result = Convert.ToDouble(txt_num1.Text) / Convert.ToDouble(txt_num2.Text);

            txt_result.Text = result.ToString();

        }
        private void btn_xoa_Click(object sender, EventArgs e)

        {

            txt_num1.Clear();

            txt_num2.Clear();

            txt_result.Clear();

        }
    }
}
