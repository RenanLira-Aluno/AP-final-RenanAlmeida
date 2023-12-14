using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenanAlmeida.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int Percentual { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }

        public NotaDeVenda? NotaDeVenda { get; set; }
        public int? NotaDeVendaId { get; set; }
    }
}