using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class frmPrincipal: Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void consultasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorioDataSet);

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'consultorioDataSet.Consultas'. Você pode movê-la ou removê-la conforme necessário.
            this.consultasTableAdapter.Fill(this.consultorioDataSet.Consultas);

        }

        private void nome_PacienteLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
