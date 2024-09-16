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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_transportes.Text);
        }

        private void tb_transportes_TextChanged(object sender, EventArgs e)
        {
            tb_transportes.Text = cb_transportes.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_dataCopiada.Text = dtp_data.Text;
        }
    }
}
