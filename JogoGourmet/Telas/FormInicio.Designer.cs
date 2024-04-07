namespace JogoGourmet.Telas
{
    partial class FormInicio
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
            lblTextoInicial = new Label();
            btnIniciar = new Button();
            SuspendLayout();
            // 
            // lblTextoInicial
            // 
            lblTextoInicial.AutoSize = true;
            lblTextoInicial.Location = new Point(134, 39);
            lblTextoInicial.Name = "lblTextoInicial";
            lblTextoInicial.Size = new Size(251, 25);
            lblTextoInicial.TabIndex = 0;
            lblTextoInicial.Text = "Pense em um prato que gosta";
            lblTextoInicial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(198, 95);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(112, 34);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "OK";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 182);
            Controls.Add(btnIniciar);
            Controls.Add(lblTextoInicial);
            Name = "FormInicio";
            Text = "Jogo Gourmet";
            FormClosing += FormInicio_FormClosing;
            FormClosed += FormInicio_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTextoInicial;
        private Button btnIniciar;
    }
}