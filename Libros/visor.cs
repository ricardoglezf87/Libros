using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Libros
{
    public partial class visor : Form
    {
        public visor()
        {
            InitializeComponent();
        }

        private void visor_Load(object sender, EventArgs e)
        {            
            DataSetXml.ReadXml("Datos.xml");            
            this.reportViewer1.RefreshReport();
        }
    }
}
