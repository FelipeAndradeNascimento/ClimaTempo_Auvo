using System.ComponentModel.DataAnnotations;

namespace WebPrevisaoTempo.Models
{
    public class clsCidade
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EstadoId { get; set; }
    }
}

/*
-----------------------
 Sugestão:  Tabela de ‘Cidade’
-----------------------
•	Id: int (not null e pk)
•	Nome: string (not null 200)
•	EstadoId: int (not null fk)
*/