using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebPrevisaoTempo.Models
{
    public class clsPrevisao
    {
        [Key]
        public int Id { get; set; }
        public string Clima { get; set; }
        public decimal TemperaturaMinima { get; set; }
        public decimal TemperaturaMaxima { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataPrevisao { get; set; }
        public int CidadeId { get; set; }
    }
}

/*
------------------------------
Sugestão :  Tabela de ‘PrevisaoClima’
------------------------------
•	Id: int (not null e fk)
•	Clima: string (not null 15) Apesar de string deve ser um enumerado
•	TemperaturaMinima: decimal (not null)
•	TemperaturaMaxima: decimal (not null)
•	DataPrevisao: datetime (not null)
•	CidadeId: int (not null e fk)
 */
