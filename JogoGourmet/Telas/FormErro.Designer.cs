namespace JogoGourmet.Telas
{
    partial class FormErro
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
            btnOKErro = new Button();
            lblErro = new Label();
            SuspendLayout();
            // 
            // btnOKErro
            // 
            btnOKErro.Location = new Point(194, 106);
            btnOKErro.Name = "btnOKErro";
            btnOKErro.Size = new Size(112, 34);
            btnOKErro.TabIndex = 0;
            btnOKErro.Text = "OK";
            btnOKErro.UseVisualStyleBackColor = true;
            btnOKErro.Click += btnOKErro_Click;
            // 
            // lblErro
            // 
            lblErro.AutoSize = true;
            lblErro.Location = new Point(49, 43);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(0, 25);
            lblErro.TabIndex = 1;
            // 
            // FormErro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 182);
            Controls.Add(lblErro);
            Controls.Add(btnOKErro);
            Name = "FormErro";
            Text = "FormErro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOKErro;
        private Label lblErro;
    }
}