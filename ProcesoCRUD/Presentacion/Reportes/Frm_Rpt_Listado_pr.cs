using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesoCRUD.Presentacion.Reportes
{
    public partial class Frm_Rpt_Listado_pr : Form
    {
        public Frm_Rpt_Listado_pr()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Listado_pr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS_Reportes.USP_LISTADO_PR' table. You can move, or remove it, as needed.
            this.USP_LISTADO_PRTableAdapter.Fill(this.DS_Reportes.USP_LISTADO_PR,cTexto:txt_01.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
