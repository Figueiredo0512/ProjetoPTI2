using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Drawing2D;

namespace ProjetoPTI2.Models
{
    [Table("tbFuncionario")]
    public class CadastroFuncionario
    {
        public int Id { get; set; }
        public int Matricula { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime Dt_Contratacao { get; set; }
        public string Email { get; set; }
        public int TipoLogin { get; set; }

        /*
Id_funcionario INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
Matricula int NOT NULL,
Cpf varchar(12) not null,
Nome varchar(100) not null,
Dt_contratacao date not null,
email varchar(100),
telefone varchar(20),
TipoLogin int not null,
Fk_id_cargo int not null,
Fk_id_ticket int,
Fk_id_login int not null
);
        */
    }
}
