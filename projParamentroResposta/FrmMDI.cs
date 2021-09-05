using projParamentroResposta.forma1;
using projParamentroResposta.forma2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projParamentroResposta
{
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void forma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmForma1Formulario1 frm = new FrmForma1Formulario1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void forma2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmForma2Formulario1 frm = new FrmForma2Formulario1();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
