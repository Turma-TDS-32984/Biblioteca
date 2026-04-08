using Biblioteca.BibliotecaDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Biblioteca.BibliotecaDBDataSet;

namespace Biblioteca
{
    public partial class Livros : Form
    {
        public Livros()
        {
            InitializeComponent();
            AtualizarLista();
        }
        private void AtualizarLista()
        {
            lboLivros.Items.Clear();
            LivrosTableAdapter LivrosDados = new LivrosTableAdapter();
            var dados = from linha in LivrosDados.GetData()
                        select linha;
            foreach(LivrosRow dado in dados) lboLivros.Items.Add(dado);
        }
        private void limparElementos()
        {
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtEditora.Text = "";
            txtGenero.Text = "";
            txtISBN.Text = "";
            txtQuantidade.Text = "";
        }

        private void lboLivros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboLivros.SelectedItem == null) return;
            LivrosRow livro = lboLivros.SelectedItem as LivrosRow;
            if (livro == null) return;
            btnAjuste.Text = "Atualizar";
            btnAcoes.Text = "Excluir";
            txtTitulo.Text = livro.Titulo;
            txtGenero.Text = livro.Genero;
            txtQuantidade.Text = livro.QuantidadeDisponivel.ToString();
            txtEditora.Text = livro.Editora;
            txtISBN.Text = livro.ISBN;
            txtAutor.Text = livro.Autor;
        }

        private void btnAcoes_Click(object sender, EventArgs e)
        {
            if (btnAcoes.Text == "Excluir")
            {
                if (lboLivros.SelectedItem == null) return;
                LivrosRow livro = lboLivros.SelectedItem as LivrosRow;
                if (livro == null) return;
                LivrosTableAdapter livros = new LivrosTableAdapter();
                livros.Delete(livro.LivroID);
                AtualizarLista();
                limparElementos();
                btnAcoes.Text = "Atualizar Lista";
                btnAjuste.Text = "Cadastrar";
            }
            else
            {
                AtualizarLista();
            }
        }

        private void btnAjuste_Click(object sender, EventArgs e)
        {
            if (btnAjuste.Text == "Cadastrar")
            {
                string titulo = txtTitulo.Text;
                string autor = txtAutor.Text;
                string genero = txtGenero.Text;
                string editora = txtEditora.Text;
                string isbn = txtISBN.Text;
                try
                {
                    int quantidade = int.Parse(txtQuantidade.Text);
                    LivrosTableAdapter livros = new LivrosTableAdapter();
                    livros.Insert(titulo, genero, autor, editora, isbn, quantidade);
                    AtualizarLista();
                    limparElementos();
                } catch
                {
                    MessageBox.Show("Erro de código");
                }
            }
            else
            {
                if (lboLivros.SelectedItem == null)
                {
                    lboLivros.ClearSelected();
                    AtualizarLista();
                    limparElementos();
                    return;
                }
                LivrosRow livro = lboLivros.SelectedItem as LivrosRow;
                if (livro == null) return;
                string titulo = txtTitulo.Text;
                string autor = txtAutor.Text;
                string genero = txtGenero.Text;
                string editora = txtEditora.Text;
                string isbn = txtISBN.Text;
                try
                {
                    int quantidade = int.Parse(txtQuantidade.Text);
                    LivrosTableAdapter livros = new LivrosTableAdapter();
                    livros.Update(livro.LivroID, titulo, genero, autor, editora, isbn, quantidade);
                    AtualizarLista();
                    limparElementos();

                    btnAcoes.Text = "Atualizar Lista";
                    btnAjuste.Text = "Cadastrar";
                }
                catch
                {
                    MessageBox.Show("Erro de código");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lboLivros.ClearSelected();
            AtualizarLista();
            limparElementos();
            btnAcoes.Text = "Atualizar Lista";
            btnAjuste.Text = "Cadastrar";
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            TextBox pesquisa = sender as TextBox;
            if (pesquisa.Text == "")
            {
                AtualizarLista();
                return;
            }
            lboLivros.ClearSelected();
            lboLivros.Items.Clear();
            string textoDigitado = txtPesquisa.Text;
            LivrosTableAdapter dados = new LivrosTableAdapter();
            var livros = from linha in dados.GetData()
                         where linha.Titulo.ToLower()
                                .Contains(textoDigitado.ToLower())
                         select linha;
            foreach(var livro in livros) lboLivros.Items.Add(livro);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Show();
            //hide - Como tratar
            Hide();
        }
    }
}
