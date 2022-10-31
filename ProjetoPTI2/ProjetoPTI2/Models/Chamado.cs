using System;

namespace ProjetoPTI2.Models
{
    public class Chamado
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Dt_abertura { get; set; }
        public DateTime Dt_fechamento { get; set; }
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
