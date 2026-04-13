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

namespace Biblioteca
{
    public partial class Usuario : Form
    {
        private Form1 formularioPrincipal;
        public Usuario(Form1 form)
        {
            formularioPrincipal = form;
            InitializeComponent();
            UsuariosTableAdapter usuarios = new UsuariosTableAdapter();
            var dados = from linha in usuarios.GetData() select linha;
            foreach (var linha in dados) lboUsuarios.Items.Add(linha);
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
            formularioPrincipal.Show();
        }

        private void Usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            Close();
            formularioPrincipal.Show();
        }
    }
}
