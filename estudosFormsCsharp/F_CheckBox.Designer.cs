namespace estudosFormsCsharp
{
    partial class F_CheckBox
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
            cb_carro = new CheckBox();
            cb_aviao = new CheckBox();
            cb_navio = new CheckBox();
            cb_onibus = new CheckBox();
            btn_transpMarcados = new Button();
            cb_patinete = new CheckBox();
            btn_childrenCheckB = new Button();
            SuspendLayout();
            // 
            // cb_carro
            // 
            cb_carro.AutoSize = true;
            cb_carro.Location = new Point(12, 12);
            cb_carro.Name = "cb_carro";
            cb_carro.Size = new Size(55, 19);
            cb_carro.TabIndex = 0;
            cb_carro.Text = "Carro";
            cb_carro.UseVisualStyleBackColor = true;
            // 
            // cb_aviao
            // 
            cb_aviao.AutoSize = true;
            cb_aviao.Location = new Point(12, 37);
            cb_aviao.Name = "cb_aviao";
            cb_aviao.Size = new Size(56, 19);
            cb_aviao.TabIndex = 1;
            cb_aviao.Text = "Avião";
            cb_aviao.UseVisualStyleBackColor = true;
            cb_aviao.CheckedChanged += cb_aviao_CheckedChanged;
            // 
            // cb_navio
            // 
            cb_navio.AutoSize = true;
            cb_navio.Location = new Point(12, 62);
            cb_navio.Name = "cb_navio";
            cb_navio.Size = new Size(57, 19);
            cb_navio.TabIndex = 2;
            cb_navio.Text = "Navio";
            cb_navio.UseVisualStyleBackColor = true;
            cb_navio.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // cb_onibus
            // 
            cb_onibus.AutoSize = true;
            cb_onibus.Location = new Point(12, 87);
            cb_onibus.Name = "cb_onibus";
            cb_onibus.Size = new Size(64, 19);
            cb_onibus.TabIndex = 3;
            cb_onibus.Text = "Ônibus";
            cb_onibus.UseVisualStyleBackColor = true;
            // 
            // btn_transpMarcados
            // 
            btn_transpMarcados.Location = new Point(218, 24);
            btn_transpMarcados.Name = "btn_transpMarcados";
            btn_transpMarcados.Size = new Size(167, 23);
            btn_transpMarcados.TabIndex = 4;
            btn_transpMarcados.Text = "Transportes Marcados";
            btn_transpMarcados.UseVisualStyleBackColor = true;
            btn_transpMarcados.Click += btn_transpMarcados_Click;
            // 
            // cb_patinete
            // 
            cb_patinete.AutoSize = true;
            cb_patinete.Location = new Point(12, 124);
            cb_patinete.Name = "cb_patinete";
            cb_patinete.Size = new Size(69, 19);
            cb_patinete.TabIndex = 5;
            cb_patinete.Text = "Patinete";
            cb_patinete.UseVisualStyleBackColor = true;
            cb_patinete.CheckedChanged += cb_patinete_CheckedChanged;
            // 
            // btn_childrenCheckB
            // 
            btn_childrenCheckB.Location = new Point(218, 62);
            btn_childrenCheckB.Name = "btn_childrenCheckB";
            btn_childrenCheckB.Size = new Size(167, 23);
            btn_childrenCheckB.TabIndex = 6;
            btn_childrenCheckB.TabStop = false;
            btn_childrenCheckB.Text = "Abre children form";
            btn_childrenCheckB.UseVisualStyleBackColor = true;
            btn_childrenCheckB.Click += button1_Click;
            // 
            // F_CheckBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 353);
            Controls.Add(btn_childrenCheckB);
            Controls.Add(cb_patinete);
            Controls.Add(btn_transpMarcados);
            Controls.Add(cb_onibus);
            Controls.Add(cb_navio);
            Controls.Add(cb_aviao);
            Controls.Add(cb_carro);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "F_CheckBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckBox";
            Load += F_CheckBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_transpMarcados;
        private CheckBox cb_patinete;
        public CheckBox cb_carro;
        public CheckBox cb_aviao;
        public CheckBox cb_navio;
        public CheckBox cb_onibus;
        private Button btn_childrenCheckB;
    }
}