namespace estudosFormsCsharp
{
    partial class F_SecondForm
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
            tb_mostraTextos = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // tb_mostraTextos
            // 
            tb_mostraTextos.Location = new Point(12, 33);
            tb_mostraTextos.Name = "tb_mostraTextos";
            tb_mostraTextos.Size = new Size(382, 23);
            tb_mostraTextos.TabIndex = 0;
            tb_mostraTextos.TextChanged += tb_mostraTextos_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // F_SecondForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(tb_mostraTextos);
            Name = "F_SecondForm";
            Text = "F_SecondForm";
            FormClosed += F_SecondForm_FormClosed;
            Load += F_SecondForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_mostraTextos;
        private Label label1;
    }
}