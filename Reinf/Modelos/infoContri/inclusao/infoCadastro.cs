namespace Reinf.Models
{
    public class infoCadastro
    {
        public string classTrib { get; set; }
        public string indEscrituracao { get; set; }
        public string indDesoneracao { get; set; }
        public string indAcordoIsenMulta { get; set; }
        public string indSitPJ { get; set; }
        public contato contato { get; set; }
        public softHouse softHouse { get; set; }
        public infoEFR infoEFR { get; set; }
    }
}