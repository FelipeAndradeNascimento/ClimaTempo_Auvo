using System.ComponentModel.DataAnnotations;

namespace WebPrevisaoTempo.Models
{
    public class clsEstado
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
    }
}

/*
    -----------------------
    Sugestão   Tabela de ‘Estado’
    -----------------------
    •	Id: int (not null e pk)
    •	Nome: string (not null 200)
    •	UF: string (not null 2)
    */
