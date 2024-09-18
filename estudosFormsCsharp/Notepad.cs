using System.Xml.Serialization;

namespace estudosFormsCsharp
{
    public partial class Notepad : Form
    {
        StringReader leitura = null;

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
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arq = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write); // manipulação do arquivo txt criado (nome, se está aberto ou deve ser criado, permissão para escrever)
                    StreamWriter streamWriter = new StreamWriter(arq);

                    streamWriter.Flush(); // garante que os dados sejam armazenados no arquivo após a escrita
                    streamWriter.BaseStream.Seek(0, SeekOrigin.Begin); // posiciona o cursor no final da frase escrita no arquivo 
                    streamWriter.Write(richTextBox1.Text);
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream arq = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader streamReader = new StreamReader(arq);
                    string line = streamReader.ReadLine();

                    while (line != null)
                    {
                        richTextBox1.Text += line;
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
                richTextBox1.Copy();
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

        private void AlterarFonte(FontStyle estilo)
        {
            string nomeDaFonte = richTextBox1.SelectionFont.Name;
            float tamanhoDaFonte = richTextBox1.SelectionFont.Size;

            // Começa sempre regular
            FontStyle novoEstilo = FontStyle.Regular;

            // Mantem os estilos que ja estão aplicados
            if (richTextBox1.SelectionFont.Bold)
                novoEstilo |= FontStyle.Bold;

            if (richTextBox1.SelectionFont.Italic)
                novoEstilo |= FontStyle.Italic;

            if (richTextBox1.SelectionFont.Underline)
                novoEstilo |= FontStyle.Underline;

            // Aplica o novo estilo ao existente (remove se já estiver aplicado)
            if (novoEstilo.HasFlag(estilo))
                novoEstilo &= ~estilo;
            else
                novoEstilo |= estilo; 

            richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, novoEstilo);
        }

        private void btn_negrito_Click(object sender, EventArgs e)
        {
            AlterarFonte(FontStyle.Bold);
        }

        private void btn_italico_Click(object sender, EventArgs e)
        {
            AlterarFonte(FontStyle.Italic);
        }

        private void btn_sublinhado_Click(object sender, EventArgs e)
        {
            AlterarFonte(FontStyle.Underline);
        }

        private void btn_fonte_Click(object sender, EventArgs e)
        {
            string nomeDaFonte = richTextBox1.SelectionFont.Name;
            float tamanhoDaFonte = richTextBox1.SelectionFont.Size;

            richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Regular);
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarFonte(FontStyle.Bold);
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarFonte(FontStyle.Italic);
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarFonte(FontStyle.Underline);
        }

        private void AlinharEsquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void AlinharCentro()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void AlinharDireita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void btn_esquerda_Click(object sender, EventArgs e)
        {
            AlinharEsquerda();
        }

        private void btn_center_Click(object sender, EventArgs e)
        {
            AlinharCentro();
        }

        private void btn_direita_Click(object sender, EventArgs e)
        {
            AlinharDireita();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharEsquerda();
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharCentro();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinharDireita();
        }

        private void Imprimir()
        {
            printDialog1.Document = printDocument1;

            string text = richTextBox1.Text;
            leitura = new StringReader(text);

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPagina = 0;
            float PosY = 0;
            int cont = 0;
            string linha = null;

            float margemEsquerda = e.MarginBounds.Left - 50;
            float margemSuperior = e.MarginBounds.Top - 50;

            if (margemEsquerda > 5)
            {
                margemEsquerda = 20;
            }

            if (margemSuperior < 5)
            {
                margemSuperior = 20;
            }

            Font fonte = richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);

            linhasPagina = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);
            linha = leitura.ReadLine();

            while (cont < linhasPagina)
            {
                PosY = (margemSuperior + (cont + fonte.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, fonte, pincel, margemEsquerda, PosY, new StringFormat());

                cont++;
                linha = leitura.ReadLine();
            }

            e.HasMorePages = linha != null ? true : false;

            pincel.Dispose();
        }
    }
}
