namespace Biblioteca
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lboLivros = new System.Windows.Forms.ListBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAjuste = new System.Windows.Forms.Button();
            this.btnAcoes = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite o genero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Digite o editora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Digite a quantidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Digite o ISBN:";
            // 
            // lboLivros
            // 
            this.lboLivros.FormattingEnabled = true;
            this.lboLivros.ItemHeight = 16;
            this.lboLivros.Location = new System.Drawing.Point(309, 78);
            this.lboLivros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lboLivros.Name = "lboLivros";
            this.lboLivros.Size = new System.Drawing.Size(260, 196);
            this.lboLivros.TabIndex = 6;
            this.lboLivros.SelectedIndexChanged += new System.EventHandler(this.lboLivros_SelectedIndexChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(29, 33);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(273, 22);
            this.txtTitulo.TabIndex = 7;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(29, 78);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(273, 22);
            this.txtAutor.TabIndex = 8;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(29, 119);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(273, 22);
            this.txtGenero.TabIndex = 9;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(29, 162);
            this.txtEditora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(273, 22);
            this.txtEditora.TabIndex = 10;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(29, 210);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(273, 22);
            this.txtQuantidade.TabIndex = 11;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(29, 255);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(273, 22);
            this.txtISBN.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Livros";
            // 
            // btnAjuste
            // 
            this.btnAjuste.Location = new System.Drawing.Point(29, 283);
            this.btnAjuste.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjuste.Name = "btnAjuste";
            this.btnAjuste.Size = new System.Drawing.Size(128, 23);
            this.btnAjuste.TabIndex = 14;
            this.btnAjuste.Text = "Cadastrar";
            this.btnAjuste.UseVisualStyleBackColor = true;
            this.btnAjuste.Click += new System.EventHandler(this.btnAjuste_Click);
            // 
            // btnAcoes
            // 
            this.btnAcoes.Location = new System.Drawing.Point(164, 283);
            this.btnAcoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAcoes.Name = "btnAcoes";
            this.btnAcoes.Size = new System.Drawing.Size(139, 23);
            this.btnAcoes.TabIndex = 15;
            this.btnAcoes.Text = "Atualizar Lista";
            this.btnAcoes.UseVisualStyleBackColor = true;
            this.btnAcoes.Click += new System.EventHandler(this.btnAcoes_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(309, 283);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(260, 23);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar seleção";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Pesquisar livro:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(311, 32);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(258, 22);
            this.txtPesquisa.TabIndex = 18;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(30, 314);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(539, 23);
            this.btnUsuario.TabIndex = 19;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 349);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAcoes);
            this.Controls.Add(this.btnAjuste);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lboLivros);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Livros";
            this.Text = "Livros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lboLivros;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAjuste;
        private System.Windows.Forms.Button btnAcoes;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnUsuario;
    }
}

