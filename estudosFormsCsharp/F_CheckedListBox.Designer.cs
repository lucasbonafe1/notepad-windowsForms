namespace estudosFormsCsharp
{
    partial class F_CheckedListBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_mostrarSelecionados = new Button();
            clb_transportes = new CheckedListBox();
            btn_limparLista = new Button();
            btn_resetList = new Button();
            tb_novoTransporte = new TextBox();
            btn_adicionarNovoTransporte = new Button();
            SuspendLayout();
            // 
            // btn_mostrarSelecionados
            // 
            btn_mostrarSelecionados.Location = new Point(168, 12);
            btn_mostrarSelecionados.Name = "btn_mostrarSelecionados";
            btn_mostrarSelecionados.Size = new Size(258, 23);
            btn_mostrarSelecionados.TabIndex = 0;
            btn_mostrarSelecionados.Text = "Mostra Selecionados";
            btn_mostrarSelecionados.UseVisualStyleBackColor = true;
            btn_mostrarSelecionados.Click += btn_mostrarSelecionados_Click;
            // 
            // clb_transportes
            // 
            clb_transportes.FormattingEnabled = true;
            clb_transportes.Items.AddRange(new object[] { "Carro", "Avião", "Navio", "Ônibus", "Trem" });
            clb_transportes.Location = new Point(12, 12);
            clb_transportes.Name = "clb_transportes";
            clb_transportes.Size = new Size(150, 184);
            clb_transportes.TabIndex = 1;
            // 
            // btn_limparLista
            // 
            btn_limparLista.Location = new Point(168, 41);
            btn_limparLista.Name = "btn_limparLista";
            btn_limparLista.Size = new Size(258, 23);
            btn_limparLista.TabIndex = 2;
            btn_limparLista.Text = "Limpa";
            btn_limparLista.UseVisualStyleBackColor = true;
            btn_limparLista.Click += btn_limparLista_Click;
            // 
            // btn_resetList
            // 
            btn_resetList.Location = new Point(168, 70);
            btn_resetList.Name = "btn_resetList";
            btn_resetList.Size = new Size(258, 23);
            btn_resetList.TabIndex = 3;
            btn_resetList.Text = "Resetar";
            btn_resetList.UseVisualStyleBackColor = true;
            btn_resetList.Click += btn_resetList_Click;
            // 
            // tb_novoTransporte
            // 
            tb_novoTransporte.Location = new Point(12, 211);
            tb_novoTransporte.Name = "tb_novoTransporte";
            tb_novoTransporte.Size = new Size(120, 23);
            tb_novoTransporte.TabIndex = 4;
            tb_novoTransporte.TextChanged += tb_novoTransporte_TextChanged;
            // 
            // btn_adicionarNovoTransporte
            // 
            btn_adicionarNovoTransporte.Location = new Point(154, 211);
            btn_adicionarNovoTransporte.Name = "btn_adicionarNovoTransporte";
            btn_adicionarNovoTransporte.Size = new Size(277, 23);
            btn_adicionarNovoTransporte.TabIndex = 5;
            btn_adicionarNovoTransporte.Text = "Adicionar";
            btn_adicionarNovoTransporte.UseVisualStyleBackColor = true;
            btn_adicionarNovoTransporte.Click += button1_Click;
            // 
            // F_CheckedListBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 450);
            Controls.Add(btn_adicionarNovoTransporte);
            Controls.Add(tb_novoTransporte);
            Controls.Add(btn_resetList);
            Controls.Add(btn_limparLista);
            Controls.Add(clb_transportes);
            Controls.Add(btn_mostrarSelecionados);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "F_CheckedListBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_CheckedListBox";
            Load += F_CheckedListBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_mostrarSelecionados;
        private CheckedListBox clb_transportes;
        private Button btn_limparLista;
        private Button btn_resetList;
        private TextBox tb_novoTransporte;
        private Button btn_adicionarNovoTransporte;
    }
}