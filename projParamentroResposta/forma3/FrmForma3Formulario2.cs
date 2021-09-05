using System;
using System.Windows.Forms;

namespace projParamentroResposta.forma3
{
    public partial class FrmForma3Formulario2 : Form
    {
        public string Parametro 
        {
            set { txtParametroRecebido.Text = value; }
        }
        public string Resposta 
        {
            get { return txtRespostaDevolver.Text; } 
        }
        public FrmForma3Formulario2()
        {
            InitializeComponent();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
