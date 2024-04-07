namespace JogoGourmet.Telas
{
    partial class FormExibirMensagem
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
            BtnSim = new Button();
            btnNao = new Button();
            lblMensagens = new Label();
            SuspendLayout();
            // 
            // BtnSim
            // 
            BtnSim.Location = new Point(86, 110);
            BtnSim.Name = "BtnSim";
            BtnSim.Size = new Size(112, 34);
            BtnSim.TabIndex = 0;
            BtnSim.Text = "Sim";
            BtnSim.UseVisualStyleBackColor = true;
            BtnSim.Click += BtnSim_Click;
            // 
            // btnNao
            // 
            btnNao.Location = new Point(298, 110);
            btnNao.Name = "btnNao";
            btnNao.Size = new Size(112, 34);
            btnNao.TabIndex = 1;
            btnNao.Text = "Não";
            btnNao.UseVisualStyleBackColor = true;
            btnNao.Click += btnNao_Click;
            // 
            // lblMensagens
            // 
            lblMensagens.AutoSize = true;
            lblMensagens.Location = new Point(56, 46);
            lblMensagens.Name = "lblMensagens";
            lblMensagens.Size = new Size(0, 25);
            lblMensagens.TabIndex = 2;
            // 
            // FormExibirMensagem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 182);
            Controls.Add(lblMensagens);
            Controls.Add(btnNao);
            Controls.Add(BtnSim);
            Name = "FormExibirMensagem";
            Text = "FormExibirMensagem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSim;
        private Button btnNao;
        private Label lblMensagens;
    }
}