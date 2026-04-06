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
        }

        private void Livros_Load(object sender, EventArgs e)
        {

        }
    }
}
