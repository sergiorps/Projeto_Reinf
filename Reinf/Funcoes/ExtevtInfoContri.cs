using System;

namespace Reinf.Funcoes
{
    [Serializable]
    public static class ExtevtInfoContri
    {
        public static Models.evtInfoContri CarregarDeArquivoXml(this Models.evtInfoContri contri, string arquivoXml)
        {
            var s = FuncoesXml.ObterNodeDeArquivoXml(typeof(Models.evtInfoContri).Name, arquivoXml);
            return FuncoesXml.XmlStringParaClasse<Models.evtInfoContri>(s);
        }

        public static void SalvarArquivoXml(this Models.evtInfoContri contri, string arquivoXml)
        {
            FuncoesXml.ClasseParaArquivoXml(contri, arquivoXml);
        }
    }
 }