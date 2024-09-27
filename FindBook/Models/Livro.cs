using System.ComponentModel;

namespace FindBook.Models
{
    public class Livro
    {
        public int Id { get; set; }

        [DisplayName("Titulo:")]
        public string Titulo { get; set; }

        [DisplayName("Autor:")]
        public string Autor { get; set; }

        [DisplayName("Categoria:")]
        public string Categoria { get; set; }

        [DisplayName("Numero do Rack:")]
        public string NumeroRack { get; set; }

        [DisplayName("Numero de Indentificação:")]
        public string NumeroIndentificacao { get; set; }

        [DisplayName("Disponivel?:")]
        public bool Disponivel { get; set; }
        
        [DisplayName("Data do Aluguel:")]
        public DateTime? DataAluguel { get; set; }

        public int BibliotecaId { get; set; }

        public Biblioteca Biblioteca { get; set; }
    }
}
