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
            Abrir();
        }

        private void Salvar()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arq = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write); // manipulação do arquivo txt criado (nome, se está aberto ou deve ser criado, permissão para escrever)
                    StreamWriter streamWriter = new StreamWriter(arq);
                    streamWriter.Flush(); // garante que os dados sejam armazenados no arquivo após a escrita
                    streamWriter.BaseStream.Seek(0, SeekOrigin.Begin); // posiciona o cursor no final da frase escrita no arquivo 
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

        private void Abrir()
        {
            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = @"C:\\Users\\Bonafé\\OneDrive\\Documentos";
            openFileDialog1.Filter = "(*.txt)|*.txt";

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream arq = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader streamReader = new StreamReader(arq);
                    streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    string line = streamReader.ReadLine();

                    while (line != null)
                    {
                        this.richTextBox1.Text += line + "\n";
                        line = streamReader.ReadLine();
                    }

                    streamReader.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro na gravação!" + ex.Message);
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void Copiar()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void Colar()
        {
            richTextBox1.Paste();
        }

        private void btn_copiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void btn_colar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void Negrito()
        {
            string nomeDaFonte = null;
            float tamanhoDaFonte = 0;

            bool negrito = false;

            nomeDaFonte = this.richTextBox1.Font.Name;
            tamanhoDaFonte = this.richTextBox1.Font.Size;
            negrito = this.richTextBox1.Font.Bold;

            if (!negrito)
                this.richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold);
            else
                this.richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Regular);
        }

        private void Italico()
        {
            string nomeDaFonte = null;
            float tamanhoDaFonte = 0;

            bool italico = false;

            nomeDaFonte = this.richTextBox1.Font.Name;
            tamanhoDaFonte = this.richTextBox1.Font.Size;
            italico = this.richTextBox1.Font.Italic;

            if (!italico)
                this.richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Italic);
            else
                this.richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Regular);
        }

        private void Sublinhado()
        {
            string nomeDaFonte = null;
            float tamanhoDaFonte = 0;

            bool sublinhado = false;

            nomeDaFonte = this.richTextBox1.Font.Name;
            tamanhoDaFonte = this.richTextBox1.Font.Size;
            sublinhado = this.richTextBox1.Font.Underline;

            if (!sublinhado)
                this.richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Underline);
            else
                this.richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Regular);
        }

        private void btn_negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void btn_italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void btn_sublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }
    }
}
