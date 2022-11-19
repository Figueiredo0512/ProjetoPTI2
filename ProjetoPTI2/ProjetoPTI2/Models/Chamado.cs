using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoPTI2.Models
{
    public class Chamado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DisplayName("Título")]
        public string Titulo { get; set; }
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        [DisplayName("Data de abertura")]
        public DateTime Dt_abertura { get; set; } = DateTime.Now;
        [DisplayName("Data de Fechamento")]
        public DateTime Dt_fechamento { get; set; }
        [DisplayName("Resolução")]
        public string Resolucao { get; set; }
        public int Resolvedor { get; set; }
        public int Solicitante { get; set; }



        /*
         create table tbTicket (
        Id_ticket int NOT NULL auto_increment primary key,
        Titulo varchar(255) NOT NULL,
        Descricao text NOT NULL,
        Dt_abertura datetime NOT NULL,
        Dt_fechamento datetime NOT NULL,
        Resolucao text NOT NULL,
        Resolvedor int NOT NULL,
        Solicitante int NOT NULL
        );
        */

    }
}
