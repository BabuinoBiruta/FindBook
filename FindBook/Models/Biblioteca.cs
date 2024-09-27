using System.ComponentModel;

namespace FindBook.Models
{
    public class Biblioteca
    {
        public int Id { get; set; }

        [DisplayName("Razão Social:")]
        public string RazaoSocial { get; set; }

        [DisplayName("Nome:")]
        public string Nome { get; set; }

        [DisplayName("CNPJ:")]
        public string CNPJ { get; set; }

        [DisplayName("Inscrição Estadual:")]
        public string InscricaoEstadual { get; set; }

        [DisplayName("Telefone:")]
        public string Telefone { get; set; }

        [DisplayName("Endereço:")]
        public string Endereco { get; set; }

        [DisplayName("E-mail:")]
        public string Email { get; set; }

        [DisplayName("WebSite:")]
        public string Website { get; set; }

        [DisplayName("Responsavel:")]
        public string Responsavel { get; set; }

        [DisplayName("Horário de Funcionamento:")]
        public string HorarioFuncionamento { get; set; }

        [DisplayName("Tipo de Acervo:")]
        public string TipoAcervo { get; set; }

        [DisplayName("Capacidade de Acervo:")]
        public int CapacidadeAcervo { get; set; }
    }
}
