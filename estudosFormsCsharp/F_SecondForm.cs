using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudosFormsCsharp
{
    public partial class F_SecondForm : Form
    {
        Form1 f;
        public F_SecondForm(Form1 form1)
        {
            InitializeComponent();
            f = form1;

            tb_mostraTextos.Text = f.tb_input.Text;
        }

        private void F_SecondForm_Load(object sender, EventArgs e)
        {

        }

        private void F_SecondForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.tb_input.Text = tb_mostraTextos.Text;
        }

        private void tb_mostraTextos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
