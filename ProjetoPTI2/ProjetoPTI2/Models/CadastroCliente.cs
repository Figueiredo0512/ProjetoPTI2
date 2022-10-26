using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProjetoPTI2.Models
{
    [Table("tbCliente")]
    public class CadastroCliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime Dt_cadastro { get; set; }
        public int  TipoLogin { get; set; }
        //Fk_id_endereco int not null,
        //Fk_id_ticket int,
        //Fk_id_login int not null
    }
}
