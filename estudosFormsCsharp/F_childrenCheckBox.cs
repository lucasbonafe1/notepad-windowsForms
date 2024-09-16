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
    public partial class F_childrenCheckBox : Form
    {
        public F_CheckBox checkBox;

        public F_childrenCheckBox()
        {
            InitializeComponent();
            try
            {
                checkBox = Application.OpenForms.OfType<F_CheckBox>().FirstOrDefault(); // ofType<F_CheckBox> filtra os formulários abertos e retorna apenas os que são do tipo F_CheckBox e firstOrDefault faz com que retorne o primeiro ou nenhum formulário

                cb_carro.Checked = checkBox.cb_carro.Checked;
                cb_aviao.Checked = checkBox.cb_aviao.Checked;
                cb_navio.Checked = checkBox.cb_navio.Checked;
                cb_onibus.Checked = checkBox.cb_onibus.Checked;
            }
            catch
            {
                MessageBox.Show("Erro ao abrir forms");
            }

        }
        private void F_childrenCheckBox_Load(object sender, EventArgs e)
        {       
        }

        private void cb_carro_CheckedChanged(object sender, EventArgs e)
        {
            checkBox.cb_carro.Checked = cb_carro.Checked;
        }


        private void cb_aviao_CheckedChanged(object sender, EventArgs e)
        {
            checkBox.cb_aviao.Checked = cb_aviao.Checked;
        }

        private void cb_navio_CheckedChanged(object sender, EventArgs e)
        {
            checkBox.cb_navio.Checked = cb_navio.Checked;
        }

        private void cb_onibus_CheckedChanged(object sender, EventArgs e)
        {
            checkBox.cb_onibus.Checked = cb_onibus.Checked;
        }
    }
}
