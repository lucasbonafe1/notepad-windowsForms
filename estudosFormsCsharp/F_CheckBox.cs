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
    public partial class F_CheckBox : Form
    {
        List<CheckBox> transp = new List<CheckBox>();

        public F_CheckBox()
        {
            InitializeComponent();

            transp.Add(cb_carro);
            transp.Add(cb_aviao);
            transp.Add(cb_navio);
            transp.Add(cb_onibus);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_transpMarcados_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach (CheckBox t in transp)
            {
                if (t.Checked)
                {
                    txt = t.Text + ", ";
                }
            }
            MessageBox.Show(txt);
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_patinete.Checked)
            {
                MessageBox.Show("Marcado!");
            }
        }

        private void F_CheckBox_Load(object sender, EventArgs e)
        {

        }

        private void cb_aviao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_childrenCheckBox checkBox = new F_childrenCheckBox();
            checkBox.ShowDialog();
        }
    }
}
