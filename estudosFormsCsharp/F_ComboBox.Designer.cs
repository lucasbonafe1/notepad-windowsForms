namespace estudosFormsCsharp
{
    partial class F_ComboBox
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
            cb_transportes = new ComboBox();
            btn_mostrarSelecionados = new Button();
            button2 = new Button();
            button3 = new Button();
            tb_transportes = new TextBox();
            button4 = new Button();
            dtp_data = new DateTimePicker();
            tb_dataCopiada = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // cb_transportes
            // 
            cb_transportes.FormattingEnabled = true;
            cb_transportes.Items.AddRange(new object[] { "Carro", "Avião", "Navio", "Onibus", "Trem" });
            cb_transportes.Location = new Point(3, 98);
            cb_transportes.Name = "cb_transportes";
            cb_transportes.Size = new Size(477, 23);
            cb_transportes.TabIndex = 0;
            // 
            // btn_mostrarSelecionados
            // 
            btn_mostrarSelecionados.Location = new Point(3, 156);
            btn_mostrarSelecionados.Name = "btn_mostrarSelecionados";
            btn_mostrarSelecionados.Size = new Size(477, 23);
            btn_mostrarSelecionados.TabIndex = 1;
            btn_mostrarSelecionados.Text = "Mostrar Selecionados";
            btn_mostrarSelecionados.UseVisualStyleBackColor = true;
            btn_mostrarSelecionados.Click += btn_mostrarSelecionados_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 127);
            button2.Name = "button2";
            button2.Size = new Size(240, 23);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(242, 127);
            button3.Name = "button3";
            button3.Size = new Size(238, 23);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // tb_transportes
            // 
            tb_transportes.Location = new Point(131, 216);
            tb_transportes.Name = "tb_transportes";
            tb_transportes.Size = new Size(211, 23);
            tb_transportes.TabIndex = 4;
            tb_transportes.TextChanged += tb_transportes_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(172, 245);
            button4.Name = "button4";
            button4.Size = new Size(131, 24);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // dtp_data
            // 
            dtp_data.Location = new Point(12, 12);
            dtp_data.Name = "dtp_data";
            dtp_data.Size = new Size(272, 23);
            dtp_data.TabIndex = 6;
            // 
            // tb_dataCopiada
            // 
            tb_dataCopiada.Location = new Point(12, 41);
            tb_dataCopiada.Name = "tb_dataCopiada";
            tb_dataCopiada.Size = new Size(272, 23);
            tb_dataCopiada.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(321, 14);
            button1.Name = "button1";
            button1.Size = new Size(130, 23);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // F_ComboBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 283);
            Controls.Add(button1);
            Controls.Add(tb_dataCopiada);
            Controls.Add(dtp_data);
            Controls.Add(button4);
            Controls.Add(tb_transportes);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_mostrarSelecionados);
            Controls.Add(cb_transportes);
            Name = "F_ComboBox";
            Text = "F_ComboBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_transportes;
        private Button btn_mostrarSelecionados;
        private Button button2;
        private Button button3;
        private TextBox tb_transportes;
        private Button button4;
        private DateTimePicker dtp_data;
        private TextBox tb_dataCopiada;
        private Button button1;
    }
}