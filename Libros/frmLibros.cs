using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Libros
{
    public partial class frmLibros : Form
    {

        #region "Propiedades"

        private const string RutaBaseDatos = "Datos.xml";
        public DataSetXml Datos;
        private string Consulta;        
        private ComboBox combo;


        #endregion

        #region "Eventos"

        public frmLibros()
        {
            InitializeComponent();
            CrearControlesGrid();
            CrearEventos();
        }

        private void Libros_Load(object sender, EventArgs e)
        {
            Datos = new DataSetXml();
            Datos.ReadXml(RutaBaseDatos);
            Consulta = "1 = 1";
            IniciarGrid();
            PropiedadesDataGrid();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            frmNuevo frm = new frmNuevo(this);

            frm.ShowDialog();
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            BorrarSelecionados();
        }

        private void DatosLibros_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            PropiedadesDataGrid();
            combo.Visible = false;            
        }

        private void Libros_FormClosing(object sender, FormClosingEventArgs e)
        {
            Datos.WriteXml(RutaBaseDatos);
        }

        void Filtrar(object sender, EventArgs e)
        {


            if ((LeidoNo.Checked) && (LeidoSi.Focused))
            {
                LeidoNo.Checked = false;
            }
            else if ((LeidoSi.Checked) && (LeidoNo.Focused))
            {
                LeidoSi.Checked = false;
            }

            if ((pdfNo.Checked) && (Pdfsi.Focused))
            {
                pdfNo.Checked = false;
            }
            else if ((Pdfsi.Checked) && (pdfNo.Focused))
            {
                Pdfsi.Checked = false;
            }

            Consulta = "1 = 1";

            if (Titulo.Text != string.Empty)
            {
                Consulta = Consulta + " and Titulo like '%" + Titulo.Text.Replace("'", "''") + "%'";
            }

            if (Autor.Text != string.Empty)
            {
                Consulta = Consulta + " and Autor like '%" + Autor.Text.Replace("'", "''") + "%'";
            }

            if (Editorial.Text != string.Empty)
            {
                Consulta = Consulta + " and Editorial like '%" + Editorial.Text.Replace("'", "''") + "%'";
            }

            if (Genero.SelectedItem == null)
            {
                Genero.SelectedItem = "";
            }

            if (Genero.SelectedItem.ToString() != string.Empty)
            {
                Consulta = Consulta + " and Genero like '" + Genero.SelectedItem.ToString() + "%'";
            }

            if (pertenece.Text != string.Empty)
            {
                Consulta = Consulta + " and pertenece like '%" + pertenece.Text.Replace("'", "''") + "%'";
            }


            if (LeidoNo.Checked)
            {
                Consulta = Consulta + " and Leido = 0";
            }
            else if (LeidoSi.Checked)
            {
                Consulta = Consulta + " and Leido = 1";
            }

            if (pdfNo.Checked)
            {
                Consulta = Consulta + " and espdf = 0";
            }
            else if (Pdfsi.Checked)
            {
                Consulta = Consulta + " and espdf = 1";
            }
            Guardar();
        }

        void cambioCombo(object sender, EventArgs e)
        {
            DatosLibros.CurrentCell.Value = combo.SelectedItem.ToString();
        }

        private void DatosLibros_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                combo.SelectedItem = DatosLibros.CurrentCell.Value;
                Rectangle tempRect = DatosLibros.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                combo.Location = tempRect.Location;
                combo.Width = tempRect.Width;
                combo.Visible = true;
            }
        }

        #endregion

        #region "Funciones"

        void PropiedadesDataGrid()
            {                                                
                Datos.Libros.DefaultView.RowFilter=Consulta;
                DatosLibros.DataSource = Datos.Libros;                
                DatosLibros.Columns[0].Visible = false;            
                DatosLibros.Columns[1].Width = 150;                
                DatosLibros.ClearSelection();                                
            }

        void IniciarGrid()
        {
            //Propiedades del Grid

            DatosLibros.BorderStyle = BorderStyle.None;
            DatosLibros.AllowUserToResizeRows = false;
            DatosLibros.RowHeadersVisible = false;
            DatosLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DatosLibros.AllowUserToAddRows = false;
            DatosLibros.AllowUserToDeleteRows = false;

            //Visuales

            DatosLibros.EnableHeadersVisualStyles = false;
            DatosLibros.BackgroundColor = Color.White;
            DatosLibros.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;

            DatosLibros.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            DatosLibros.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;

            DatosLibros.RowsDefaultCellStyle.SelectionBackColor = Color.LightYellow;
            DatosLibros.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightYellow;
            DatosLibros.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            DatosLibros.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;
        }

        void BorrarSelecionados()
        {
            if ((MessageBox.Show("Esta Seguro que desea Borrar los libros Seleccionados¿?¿?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) && (DatosLibros.SelectedRows.Count != 0))
            {
                int[] IDs = new int[DatosLibros.SelectedRows.Count];

                for (int i = 0; i < DatosLibros.SelectedRows.Count; i++)
                {
                    IDs[i] = (int)DatosLibros.SelectedRows[i].Cells[0].Value;
                }

                DatosLibros.DataSource = null;

                foreach (int ID in IDs)
                {
                    Datos.Libros.Rows.Remove(Datos.Libros.Select("ID= " + ID)[0]);
                }

                Guardar();
            }
        }

        public void Guardar()
        {
            Datos.AcceptChanges();
            PropiedadesDataGrid();
        }

        void CrearEventos()
        {
            this.LeidoNo.CheckedChanged += new System.EventHandler(this.Filtrar);
            this.LeidoSi.CheckedChanged += new System.EventHandler(this.Filtrar);
            this.Pdfsi.CheckedChanged += new System.EventHandler(this.Filtrar);
            this.pdfNo.CheckedChanged += new System.EventHandler(this.Filtrar);
            this.Genero.SelectedIndexChanged += new System.EventHandler(this.Filtrar);
            this.pertenece.TextChanged += new System.EventHandler(this.Filtrar);
            this.Editorial.TextChanged += new System.EventHandler(this.Filtrar);
            this.Autor.TextChanged += new System.EventHandler(this.Filtrar);
            this.Titulo.TextChanged += new System.EventHandler(this.Filtrar);
            this.DatosLibros.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(DatosLibros_CellBeginEdit);
            this.DatosLibros.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosLibros_CellEndEdit);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Libros_FormClosing);
            this.Load += new System.EventHandler(this.Libros_Load);
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);            
            this.combo.SelectedValueChanged += new EventHandler(cambioCombo);
        }             

        void CrearControlesGrid()
        {
            this.combo = new ComboBox();
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.combo.Items.AddRange(new object[] {
            "",
            "Romanticas",
            "Vampiricas",
            "Suspense",
            "Terror",
            "Arlequin",
            "Cocina",
            "Oeste"});
            this.combo.Visible = false;
            this.DatosLibros.Controls.Add(combo);
        }

        #endregion

        private void ListadoLibros_Click(object sender, EventArgs e)
        {
            visor vi = new visor();
            vi.ShowDialog();
            vi.Dispose();
        }

      
    }
}