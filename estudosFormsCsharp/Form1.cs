namespace estudosFormsCsharp
{
    public partial class Form1 : Form
    {
        public String num;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_textWrited.Text == "")
            {
                MessageBox.Show("DIGITE UM TEXTO POR FAVOR.");
                tb_textWrited.Focus();
                return;
            }
            tb_input.Text = tb_textWrited.Text + ", ";

            tb_textWrited.Clear();
            tb_textWrited.Focus();

        }

        private void btn_mostraForms(object sender, EventArgs e)
        {

            F_SecondForm secondForm = new F_SecondForm(this);
            secondForm.ShowDialog();

        }

        private void lb_text_Click(object sender, EventArgs e)
        {

        }

        private void tb_textWrited_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
