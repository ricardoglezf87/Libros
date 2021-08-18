using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Libros
{
    public partial class frmNuevo : Form
    {
        private frmLibros _frmLibros;
        public frmLibros frmLibros
        {
            get { return _frmLibros; }
            set { _frmLibros = value; }
        }

        public frmNuevo(frmLibros _Libros)
        {
            InitializeComponent();
            frmLibros = _Libros;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Insertar_Click(object sender, EventArgs e)
        {
            if (!(ExisteLibro()))
            {
                frmLibros.Datos.Libros.AddLibrosRow(Titulo.Text.Replace("'", "''"), Autor.Text.Replace("'", "''"), Editorial.Text.Replace("'", "''"), false, "",Leido.Checked,esPDF.Checked,Genero.Text,fechaLeido.Text,pertenece.Text.Replace("'", "''"));
                frmLibros.Guardar();
                this.Close();
            }
            else
                MessageBox.Show("El Libro ya existe en la colección", "Nuevo Libro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        bool ExisteLibro()
        {
            if (frmLibros.Datos.Libros.Select("Titulo = '" + Titulo.Text.Replace("'", "''") + "' and Autor = '" + Autor.Text.Replace("'", "''") + "' and Editorial = '" + Editorial.Text.Replace("'", "''") + "'").Length == 0)
                return false;
            else
                return true;

        }
    
    }
}