using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenanAlmeida.Models
{
    public class PagamentoComCheque : TipoDePagamento
    {
        public int Banco { get; set; }
        public string NomeDoBanco { get; set; }
    }
}