using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Tarefa
    {
        public DateTime DataEntrega { get; set; }
        public string Descricao { get; set; }
        public bool Entregue { get; set; }
        public int Id { get; set; }
        public byte Nota { get; set; }
        public string Tipo { get; set; }
        public string Titulo { get; set; }

        
    }
}