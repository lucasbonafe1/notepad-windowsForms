using System.Xml.Serialization;

namespace estudosFormsCsharp
{
    public partial class Notepad : Form
    {
        public String num;
        public Notepad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void Salvar()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arq = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter streamWriter = new StreamWriter(arq);
                    streamWriter.Flush();
                    streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    streamWriter.Write(this.richTextBox1.Text);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na gravação!" + ex.Message);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
