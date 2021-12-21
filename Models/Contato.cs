using System.ComponentModel.DataAnnotations;

namespace entregaLohane.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string email { get; set; }
        public int NumeroTelefone { get; set; }
    }
}
