namespace JogoGourmet.Telas
{
    partial class FormIncluirMensagem
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
            btnOkIncluir = new Button();
            btnCancelarIncluir = new Button();
            txtIncluir = new TextBox();
            lblMensagemInclusao = new Label();
            SuspendLayout();
            // 
            // btnOkIncluir
            // 
            btnOkIncluir.Location = new Point(80, 125);
            btnOkIncluir.Name = "btnOkIncluir";
            btnOkIncluir.Size = new Size(112, 34);
            btnOkIncluir.TabIndex = 0;
            btnOkIncluir.Text = "OK";
            btnOkIncluir.UseVisualStyleBackColor = true;
            btnOkIncluir.Click += btnOkIncluir_Click;
            // 
            // btnCancelarIncluir
            // 
            btnCancelarIncluir.Location = new Point(269, 125);
            btnCancelarIncluir.Name = "btnCancelarIncluir";
            btnCancelarIncluir.Size = new Size(112, 34);
            btnCancelarIncluir.TabIndex = 1;
            btnCancelarIncluir.Text = "Cancelar";
            btnCancelarIncluir.UseVisualStyleBackColor = true;
            btnCancelarIncluir.Click += btnCancelarIncluir_Click;
            // 
            // txtIncluir
            // 
            txtIncluir.Location = new Point(50, 69);
            txtIncluir.Name = "txtIncluir";
            txtIncluir.Size = new Size(357, 31);
            txtIncluir.TabIndex = 2;
            // 
            // lblMensagemInclusao
            // 
            lblMensagemInclusao.AutoSize = true;
            lblMensagemInclusao.Location = new Point(46, 23);
            lblMensagemInclusao.Name = "lblMensagemInclusao";
            lblMensagemInclusao.Size = new Size(0, 25);
            lblMensagemInclusao.TabIndex = 3;
            // 
            // FormIncluirMensagem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 182);
            Controls.Add(lblMensagemInclusao);
            Controls.Add(txtIncluir);
            Controls.Add(btnCancelarIncluir);
            Controls.Add(btnOkIncluir);
            Name = "FormIncluirMensagem";
            Text = "FormIncluirMensagem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOkIncluir;
        private Button btnCancelarIncluir;
        private TextBox txtIncluir;
        private Label lblMensagemInclusao;
    }
}