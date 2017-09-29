using System;
using System.Windows.Forms;

namespace Reinf
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            
            this.contribuinteTableAdapter.Fill(this.reinfDataSet.contribuinte);
            
            //this.fillpanelTableAdapter.Fill(this.reinfDataSet.fillpanel);
        }

        private void btAtuPainel_Click(object sender, EventArgs e)
        {
            //Verificar se tem XML para Subir, se sim, sobre para e mostra na tabela evtContri
            this.fillpanelTableAdapter.Fill(this.reinfDataSet.fillpanel);
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            //Selecionar na linha a ser enviada
        }
    }
}
