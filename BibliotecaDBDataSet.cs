namespace Biblioteca
{


    partial class BibliotecaDBDataSet
    {
        partial class LivrosRow
        {
            public override string ToString()
            {
                return LivroID.ToString() + "-" + Titulo;
            }
        }
        partial class LivrosDataTable
        {

        }
    }
}