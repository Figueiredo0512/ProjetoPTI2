using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel;

namespace ProjetoPTI2.Models
{
    [Table("tbCliente")]
    public class CadastroCliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        [DisplayName("Data de Cadastro")]
        public DateTime Dt_cadastro { get; set; }
        [DisplayName("Tipo de login")]
        public int  TipoLogin { get; set; }
        public string Senha { get; set; }
        //Fk_id_endereco int not null,
        //Fk_id_ticket int,
        //Fk_id_login int not null
    }
}
