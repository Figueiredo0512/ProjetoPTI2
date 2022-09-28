using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoPTI2.Models
{
    [Table("tbCliente")]
    public class CadastroCliente
    {
        [Display(Name ="Codigo")]
        public int Id { get; set; }
        public int Nome { get; set; }

    }
}
