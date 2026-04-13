namespace Biblioteca
{


    partial class BibliotecaDBDataSet
    {
        partial class UsuariosRow
        {
            public override string ToString()
            {
                return UsuarioID.ToString() + "-" + Nome;
            }
        }
        partial class UsuariosDataTable
        {
        }

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