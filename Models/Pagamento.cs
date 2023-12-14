using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenanAlmeida.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public DateTime DataLimite { get; set; }
        public bool Pago { get; set; }
        public NotaDeVenda NotaDeVenda { get; set; }
        public int NotaDeVendaId { get; set; }
    }
}