namespace gui_cadastro
{
    partial class FrmCadastroPessoa
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
            dgvPessoa = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPessoa).BeginInit();
            SuspendLayout();
            // 
            // dgvPessoa
            // 
            dgvPessoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPessoa.Location = new Point(38, 29);
            dgvPessoa.MultiSelect = false;
            dgvPessoa.Name = "dgvPessoa";
            dgvPessoa.ReadOnly = true;
            dgvPessoa.RowTemplate.Height = 25;
            dgvPessoa.Size = new Size(566, 388);
            dgvPessoa.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(639, 29);
            button1.Name = "button1";
            button1.Size = new Size(121, 32);
            button1.TabIndex = 1;
            button1.Text = "Incluir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(639, 67);
            button2.Name = "button2";
            button2.Size = new Size(121, 32);
            button2.TabIndex = 2;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(639, 105);
            button3.Name = "button3";
            button3.Size = new Size(121, 32);
            button3.TabIndex = 3;
            button3.Text = "Consultar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(639, 143);
            button4.Name = "button4";
            button4.Size = new Size(121, 32);
            button4.TabIndex = 4;
            button4.Text = "Excluir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(639, 385);
            button5.Name = "button5";
            button5.Size = new Size(121, 32);
            button5.TabIndex = 5;
            button5.Text = "Fechar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // FrmCadastroPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvPessoa);
            Name = "FrmCadastroPessoa";
            Text = "Cadastro do Contato";
            Load += FrmCadastroPessoa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPessoa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPessoa;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}