namespace estudosFormsCsharp
{
    partial class Notepad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
            toolTip1 = new ToolTip(components);
            menuStrip2 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            colarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            desfazerToolStripMenuItem = new ToolStripMenuItem();
            refazerToolStripMenuItem = new ToolStripMenuItem();
            formatarToolStripMenuItem = new ToolStripMenuItem();
            negritoToolStripMenuItem = new ToolStripMenuItem();
            itálicoToolStripMenuItem = new ToolStripMenuItem();
            sublinhadoToolStripMenuItem = new ToolStripMenuItem();
            alinhamentoToolStripMenuItem = new ToolStripMenuItem();
            centralizarToolStripMenuItem = new ToolStripMenuItem();
            esquerdaToolStripMenuItem = new ToolStripMenuItem();
            direitaToolStripMenuItem = new ToolStripMenuItem();
            toolTip2 = new ToolTip(components);
            toolStrip1 = new ToolStrip();
            btn_novo = new ToolStripButton();
            btn_abrir = new ToolStripButton();
            btn_salvar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btn_copiar = new ToolStripButton();
            btn_colar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btn_negrito = new ToolStripButton();
            btn_italico = new ToolStripButton();
            btn_sublinhado = new ToolStripButton();
            btn_fonte = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btn_esquerda = new ToolStripButton();
            btn_center = new ToolStripButton();
            btn_direita = new ToolStripButton();
            notifyIcon1 = new NotifyIcon(components);
            richTextBox1 = new RichTextBox();
            saveFileDialog1 = new SaveFileDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            openFileDialog1 = new OpenFileDialog();
            printDialog2 = new PrintDialog();
            menuStrip2.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, editarToolStripMenuItem, formatarToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(626, 24);
            menuStrip2.TabIndex = 6;
            menuStrip2.Text = "menuStrip2";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, abrirToolStripMenuItem, salvarToolStripMenuItem, imprimirToolStripMenuItem, toolStripMenuItem1, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(180, 22);
            novoToolStripMenuItem.Text = "Novo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(180, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.Size = new Size(180, 22);
            salvarToolStripMenuItem.Text = "Salvar";
            salvarToolStripMenuItem.Click += salvarToolStripMenuItem_Click;
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.Size = new Size(180, 22);
            imprimirToolStripMenuItem.Text = "Imprimir";
            imprimirToolStripMenuItem.Click += imprimirToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copiarToolStripMenuItem, colarToolStripMenuItem, toolStripMenuItem2, desfazerToolStripMenuItem, refazerToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(118, 22);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += btn_copiar_Click;
            // 
            // colarToolStripMenuItem
            // 
            colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            colarToolStripMenuItem.Size = new Size(118, 22);
            colarToolStripMenuItem.Text = "Colar";
            colarToolStripMenuItem.Click += btn_colar_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(115, 6);
            // 
            // desfazerToolStripMenuItem
            // 
            desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            desfazerToolStripMenuItem.Size = new Size(118, 22);
            desfazerToolStripMenuItem.Text = "Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            refazerToolStripMenuItem.Size = new Size(118, 22);
            refazerToolStripMenuItem.Text = "Refazer";
            // 
            // formatarToolStripMenuItem
            // 
            formatarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { negritoToolStripMenuItem, itálicoToolStripMenuItem, sublinhadoToolStripMenuItem, alinhamentoToolStripMenuItem });
            formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            formatarToolStripMenuItem.Size = new Size(67, 20);
            formatarToolStripMenuItem.Text = "Formatar";
            // 
            // negritoToolStripMenuItem
            // 
            negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            negritoToolStripMenuItem.Size = new Size(143, 22);
            negritoToolStripMenuItem.Text = "Negrito";
            negritoToolStripMenuItem.Click += negritoToolStripMenuItem_Click;
            // 
            // itálicoToolStripMenuItem
            // 
            itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            itálicoToolStripMenuItem.Size = new Size(143, 22);
            itálicoToolStripMenuItem.Text = "Itálico";
            itálicoToolStripMenuItem.Click += itálicoToolStripMenuItem_Click;
            // 
            // sublinhadoToolStripMenuItem
            // 
            sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            sublinhadoToolStripMenuItem.Size = new Size(143, 22);
            sublinhadoToolStripMenuItem.Text = "Sublinhado";
            sublinhadoToolStripMenuItem.Click += sublinhadoToolStripMenuItem_Click;
            // 
            // alinhamentoToolStripMenuItem
            // 
            alinhamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { centralizarToolStripMenuItem, esquerdaToolStripMenuItem, direitaToolStripMenuItem });
            alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            alinhamentoToolStripMenuItem.Size = new Size(143, 22);
            alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // centralizarToolStripMenuItem
            // 
            centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            centralizarToolStripMenuItem.Size = new Size(130, 22);
            centralizarToolStripMenuItem.Text = "Centralizar";
            centralizarToolStripMenuItem.Click += centralizarToolStripMenuItem_Click;
            // 
            // esquerdaToolStripMenuItem
            // 
            esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            esquerdaToolStripMenuItem.Size = new Size(130, 22);
            esquerdaToolStripMenuItem.Text = "Esquerda";
            esquerdaToolStripMenuItem.Click += esquerdaToolStripMenuItem_Click;
            // 
            // direitaToolStripMenuItem
            // 
            direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            direitaToolStripMenuItem.Size = new Size(130, 22);
            direitaToolStripMenuItem.Text = "Direita";
            direitaToolStripMenuItem.Click += direitaToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_novo, btn_abrir, btn_salvar, toolStripSeparator2, btn_copiar, btn_colar, toolStripSeparator1, btn_negrito, btn_italico, btn_sublinhado, btn_fonte, toolStripSeparator3, btn_esquerda, btn_center, btn_direita });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(626, 25);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_novo
            // 
            btn_novo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_novo.Image = (Image)resources.GetObject("btn_novo.Image");
            btn_novo.ImageTransparentColor = Color.Magenta;
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(23, 22);
            btn_novo.Text = "Novo";
            btn_novo.Click += btn_novo_Click;
            // 
            // btn_abrir
            // 
            btn_abrir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_abrir.Image = (Image)resources.GetObject("btn_abrir.Image");
            btn_abrir.ImageTransparentColor = Color.Magenta;
            btn_abrir.Name = "btn_abrir";
            btn_abrir.Size = new Size(23, 22);
            btn_abrir.Text = "Abrir";
            btn_abrir.Click += btn_abrir_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_salvar.Image = (Image)resources.GetObject("btn_salvar.Image");
            btn_salvar.ImageTransparentColor = Color.Magenta;
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(23, 22);
            btn_salvar.Text = "Salvar";
            btn_salvar.Click += btn_salvar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btn_copiar
            // 
            btn_copiar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_copiar.Image = (Image)resources.GetObject("btn_copiar.Image");
            btn_copiar.ImageTransparentColor = Color.Magenta;
            btn_copiar.Name = "btn_copiar";
            btn_copiar.Size = new Size(23, 22);
            btn_copiar.Text = "Copiar";
            btn_copiar.Click += btn_copiar_Click;
            // 
            // btn_colar
            // 
            btn_colar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_colar.Image = (Image)resources.GetObject("btn_colar.Image");
            btn_colar.ImageTransparentColor = Color.Magenta;
            btn_colar.Name = "btn_colar";
            btn_colar.Size = new Size(23, 22);
            btn_colar.Text = "Colar";
            btn_colar.Click += btn_colar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btn_negrito
            // 
            btn_negrito.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_negrito.Image = (Image)resources.GetObject("btn_negrito.Image");
            btn_negrito.ImageTransparentColor = Color.Magenta;
            btn_negrito.Name = "btn_negrito";
            btn_negrito.Size = new Size(23, 22);
            btn_negrito.Text = "Negrito";
            btn_negrito.Click += btn_negrito_Click;
            // 
            // btn_italico
            // 
            btn_italico.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_italico.Image = (Image)resources.GetObject("btn_italico.Image");
            btn_italico.ImageTransparentColor = Color.Magenta;
            btn_italico.Name = "btn_italico";
            btn_italico.Size = new Size(23, 22);
            btn_italico.Text = "Italico";
            btn_italico.Click += btn_italico_Click;
            // 
            // btn_sublinhado
            // 
            btn_sublinhado.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_sublinhado.Image = (Image)resources.GetObject("btn_sublinhado.Image");
            btn_sublinhado.ImageTransparentColor = Color.Magenta;
            btn_sublinhado.Name = "btn_sublinhado";
            btn_sublinhado.Size = new Size(23, 22);
            btn_sublinhado.Text = "Sublinhado";
            btn_sublinhado.Click += btn_sublinhado_Click;
            // 
            // btn_fonte
            // 
            btn_fonte.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_fonte.Image = (Image)resources.GetObject("btn_fonte.Image");
            btn_fonte.ImageTransparentColor = Color.Magenta;
            btn_fonte.Name = "btn_fonte";
            btn_fonte.Size = new Size(23, 22);
            btn_fonte.Text = "Fonte";
            btn_fonte.Click += btn_fonte_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // btn_esquerda
            // 
            btn_esquerda.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_esquerda.Image = (Image)resources.GetObject("btn_esquerda.Image");
            btn_esquerda.ImageTransparentColor = Color.Magenta;
            btn_esquerda.Name = "btn_esquerda";
            btn_esquerda.Size = new Size(23, 22);
            btn_esquerda.Text = "Esquerda";
            btn_esquerda.Click += btn_esquerda_Click;
            // 
            // btn_center
            // 
            btn_center.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_center.Image = (Image)resources.GetObject("btn_center.Image");
            btn_center.ImageTransparentColor = Color.Magenta;
            btn_center.Name = "btn_center";
            btn_center.Size = new Size(23, 22);
            btn_center.Text = "Centro";
            btn_center.Click += btn_center_Click;
            // 
            // btn_direita
            // 
            btn_direita.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btn_direita.ForeColor = SystemColors.ControlText;
            btn_direita.Image = (Image)resources.GetObject("btn_direita.Image");
            btn_direita.ImageTransparentColor = Color.Magenta;
            btn_direita.Name = "btn_direita";
            btn_direita.Size = new Size(23, 22);
            btn_direita.Text = "Direita";
            btn_direita.Click += btn_direita_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 52);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(626, 404);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "(*.txt)|*.txt";
            openFileDialog1.InitialDirectory = "C:\\\\Users\\\\Bonafé\\\\OneDrive\\\\Documentos";
            openFileDialog1.Title = "Abrir Arquivo";
            // 
            // printDialog2
            // 
            printDialog2.UseEXDialog = true;
            // 
            // Notepad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(626, 458);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Notepad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notepad Bonafé";
            Load += Form1_Load;
            Leave += sairToolStripMenuItem_Click;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolTip toolTip1;
        private MenuStrip menuStrip2;
        private ToolTip toolTip2;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripMenuItem desfazerToolStripMenuItem;
        private ToolStripMenuItem refazerToolStripMenuItem;
        private ToolStripMenuItem formatarToolStripMenuItem;
        private ToolStripMenuItem negritoToolStripMenuItem;
        private ToolStripMenuItem itálicoToolStripMenuItem;
        private ToolStripMenuItem sublinhadoToolStripMenuItem;
        private ToolStripMenuItem alinhamentoToolStripMenuItem;
        private ToolStripMenuItem centralizarToolStripMenuItem;
        private ToolStripMenuItem esquerdaToolStripMenuItem;
        private ToolStripMenuItem direitaToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private ToolStripButton btn_novo;
        private ToolStripButton btn_abrir;
        private ToolStripButton btn_salvar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btn_copiar;
        private ToolStripButton btn_colar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btn_negrito;
        private ToolStripButton btn_italico;
        private ToolStripButton btn_sublinhado;
        private ToolStripButton btn_fonte;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btn_esquerda;
        private ToolStripButton btn_center;
        private ToolStripButton btn_direita;
        private RichTextBox richTextBox1;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private OpenFileDialog openFileDialog1;
        private ToolStripSeparator toolStripMenuItem2;
        private PrintDialog printDialog2;
    }
}
