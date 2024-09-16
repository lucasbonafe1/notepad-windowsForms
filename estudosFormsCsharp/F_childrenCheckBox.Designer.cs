
namespace estudosFormsCsharp
{
    partial class F_childrenCheckBox
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
            cb_onibus = new CheckBox();
            cb_navio = new CheckBox();
            cb_aviao = new CheckBox();
            cb_carro = new CheckBox();
            SuspendLayout();
            // 
            // cb_onibus
            // 
            cb_onibus.AutoSize = true;
            cb_onibus.Location = new Point(12, 90);
            cb_onibus.Name = "cb_onibus";
            cb_onibus.Size = new Size(64, 19);
            cb_onibus.TabIndex = 7;
            cb_onibus.Text = "Ônibus";
            cb_onibus.UseVisualStyleBackColor = true;
            cb_onibus.CheckedChanged += cb_onibus_CheckedChanged;
            // 
            // cb_navio
            // 
            cb_navio.AutoSize = true;
            cb_navio.Location = new Point(12, 65);
            cb_navio.Name = "cb_navio";
            cb_navio.Size = new Size(57, 19);
            cb_navio.TabIndex = 6;
            cb_navio.Text = "Navio";
            cb_navio.UseVisualStyleBackColor = true;
            cb_navio.CheckedChanged += cb_navio_CheckedChanged;
            // 
            // cb_aviao
            // 
            cb_aviao.AutoSize = true;
            cb_aviao.Location = new Point(12, 40);
            cb_aviao.Name = "cb_aviao";
            cb_aviao.Size = new Size(56, 19);
            cb_aviao.TabIndex = 5;
            cb_aviao.Text = "Avião";
            cb_aviao.UseVisualStyleBackColor = true;
            cb_aviao.CheckedChanged += cb_aviao_CheckedChanged;
            // 
            // cb_carro
            // 
            cb_carro.AutoSize = true;
            cb_carro.Location = new Point(12, 15);
            cb_carro.Name = "cb_carro";
            cb_carro.Size = new Size(55, 19);
            cb_carro.TabIndex = 4;
            cb_carro.Text = "Carro";
            cb_carro.UseVisualStyleBackColor = true;
            cb_carro.CheckedChanged += cb_carro_CheckedChanged;
            // 
            // F_childrenCheckBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 240);
            Controls.Add(cb_onibus);
            Controls.Add(cb_navio);
            Controls.Add(cb_aviao);
            Controls.Add(cb_carro);
            Name = "F_childrenCheckBox";
            Text = "CheckBox 2";
            Load += F_childrenCheckBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cb_onibus;
        private CheckBox cb_navio;
        private CheckBox cb_aviao;
        private CheckBox cb_carro;
    }
}