namespace estudosFormsCsharp
{
    partial class Form1
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
            btn_envio = new Button();
            lb_text = new Label();
            tb_input = new TextBox();
            tb_textWrited = new TextBox();
            btn_mostraForm = new Button();
            SuspendLayout();
            // 
            // btn_envio
            // 
            btn_envio.Location = new Point(174, 58);
            btn_envio.Name = "btn_envio";
            btn_envio.Size = new Size(209, 26);
            btn_envio.TabIndex = 0;
            btn_envio.Text = "Essa parada ai";
            btn_envio.UseVisualStyleBackColor = true;
            btn_envio.Click += button1_Click;
            // 
            // lb_text
            // 
            lb_text.AutoSize = true;
            lb_text.Location = new Point(12, 31);
            lb_text.Name = "lb_text";
            lb_text.Size = new Size(92, 15);
            lb_text.TabIndex = 1;
            lb_text.Text = "Digite um texto:";
            lb_text.Click += lb_text_Click;
            // 
            // tb_input
            // 
            tb_input.Location = new Point(12, 90);
            tb_input.Multiline = true;
            tb_input.Name = "tb_input";
            tb_input.Size = new Size(371, 285);
            tb_input.TabIndex = 2;
            // 
            // tb_textWrited
            // 
            tb_textWrited.Location = new Point(12, 58);
            tb_textWrited.Multiline = true;
            tb_textWrited.Name = "tb_textWrited";
            tb_textWrited.Size = new Size(156, 26);
            tb_textWrited.TabIndex = 3;
            // 
            // btn_mostraForm
            // 
            btn_mostraForm.CausesValidation = false;
            btn_mostraForm.Location = new Point(43, 394);
            btn_mostraForm.Name = "btn_mostraForm";
            btn_mostraForm.Size = new Size(298, 23);
            btn_mostraForm.TabIndex = 4;
            btn_mostraForm.Text = "Mostra Form";
            btn_mostraForm.UseVisualStyleBackColor = true;
            btn_mostraForm.Click += btn_mostraForms;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(393, 429);
            Controls.Add(btn_mostraForm);
            Controls.Add(tb_textWrited);
            Controls.Add(tb_input);
            Controls.Add(lb_text);
            Controls.Add(btn_envio);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Janela do bones";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_envio;
        private Label lb_text;
        private TextBox tb_textWrited;
        public Button btn_mostraForm;
        public TextBox tb_input;
    }
}
