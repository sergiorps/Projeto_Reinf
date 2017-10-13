using System;
using System.Windows.Forms;
using Reinf.Funcoes;
using Reinf.Models;
using System.Reflection;
using System.IO;

namespace Reinf
{
    public partial class formPrincipal : Form
    {
        private evtInfoContri _reinf;
        private readonly string _path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
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


        private void btnLerXML_Click(object sender, EventArgs e)
        {

            try
            {
                CarregaArquivoReinf();
                ExibeReinf();
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(ex.Message)) ;
                    /*Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButton.OK);*/
            }
        }

            private void ExibeReinf()
            {
                _reinf.SalvarArquivoXml(_path + @"\tmp.xml");
                webXML.Navigate(_path + @"\tmp.xml");
                //TabItemNfe.IsSelected = true;
            }

            private void CarregaArquivoReinf()
            {
                var arquivoXml = Diversas.BuscarArquivoXml();

                if (!string.IsNullOrWhiteSpace(arquivoXml))
                    _reinf = new evtInfoContri().CarregarDeArquivoXml(arquivoXml);
            }
    }
}
