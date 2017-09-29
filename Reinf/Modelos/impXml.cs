using System;
using Reinf.Funcoes;

namespace Reinf.Models
{
    public class impXml
    {
        private Models.evtInfoContri _contri;
        public void ImportarXml()
        {
            try
            {
                CarregaArquivoXML();
            }
            catch (Exception ex)
            {
                if (!string.IsNullOrEmpty(ex.Message))
                { }
            }
        }

        private void CarregaArquivoXML()
        {
            var arquivoXml = "C:\\Users\\SERGIO\\Documents\\REINF\\xml_reinf.xml";

            if (!string.IsNullOrWhiteSpace(arquivoXml))
                _contri = new Models.evtInfoContri().CarregarDeArquivoXml(arquivoXml);
        }
    }
}