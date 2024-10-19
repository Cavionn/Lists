namespace lists
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
            label1 = new Label();
            txtNome = new TextBox();
            btnAdicionar = new Button();
            txtLista = new TextBox();
            btnExcluir = new Button();
            label2 = new Label();
            txtNovoNome = new TextBox();
            btnAlterar = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 23);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(128, 20);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 31);
            txtNome.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(128, 60);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(150, 34);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtLista
            // 
            txtLista.Location = new Point(293, 23);
            txtLista.Multiline = true;
            txtLista.Name = "txtLista";
            txtLista.ScrollBars = ScrollBars.Both;
            txtLista.Size = new Size(382, 304);
            txtLista.TabIndex = 3;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(128, 100);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(150, 36);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 151);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 5;
            label2.Text = "Novo Nome";
            // 
            // txtNovoNome
            // 
            txtNovoNome.Location = new Point(128, 151);
            txtNovoNome.Name = "txtNovoNome";
            txtNovoNome.Size = new Size(150, 31);
            txtNovoNome.TabIndex = 6;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(128, 188);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(150, 34);
            btnAlterar.TabIndex = 7;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(24, 253);
            button1.Name = "button1";
            button1.Size = new Size(254, 34);
            button1.TabIndex = 8;
            button1.Text = "Ordem Crescente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(24, 293);
            button2.Name = "button2";
            button2.Size = new Size(254, 34);
            button2.TabIndex = 9;
            button2.Text = "Ordem Decrescente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAlterar);
            Controls.Add(txtNovoNome);
            Controls.Add(label2);
            Controls.Add(btnExcluir);
            Controls.Add(txtLista);
            Controls.Add(btnAdicionar);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Button btnAdicionar;
        private TextBox txtLista;
        private Button btnExcluir;
        private Label label2;
        private TextBox txtNovoNome;
        private Button btnAlterar;
        private Button button1;
        private Button button2;
    }
}