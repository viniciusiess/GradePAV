namespace gui_cadastro
{
    partial class FrmPessoa
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
            label1 = new Label();
            label2 = new Label();
            edNome = new TextBox();
            edTelefone = new TextBox();
            buOk = new Button();
            buCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 34);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 91);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Telefone:";
            // 
            // edNome
            // 
            edNome.Location = new Point(112, 31);
            edNome.Name = "edNome";
            edNome.Size = new Size(309, 23);
            edNome.TabIndex = 2;
            // 
            // edTelefone
            // 
            edTelefone.Location = new Point(112, 88);
            edTelefone.Name = "edTelefone";
            edTelefone.Size = new Size(309, 23);
            edTelefone.TabIndex = 3;
            // 
            // buOk
            // 
            buOk.DialogResult = DialogResult.OK;
            buOk.Location = new Point(454, 31);
            buOk.Name = "buOk";
            buOk.Size = new Size(75, 23);
            buOk.TabIndex = 4;
            buOk.Text = "Ok";
            buOk.UseVisualStyleBackColor = true;
            buOk.Click += buOk_Click;
            // 
            // buCancelar
            // 
            buCancelar.DialogResult = DialogResult.Cancel;
            buCancelar.Location = new Point(454, 88);
            buCancelar.Name = "buCancelar";
            buCancelar.Size = new Size(75, 23);
            buCancelar.TabIndex = 5;
            buCancelar.Text = "Cancelar";
            buCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 151);
            Controls.Add(buCancelar);
            Controls.Add(buOk);
            Controls.Add(edTelefone);
            Controls.Add(edNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPessoa";
            Text = "FrmPessoa";
            Load += FrmPessoa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox edNome;
        private TextBox edTelefone;
        private Button buOk;
        private Button buCancelar;
    }
}