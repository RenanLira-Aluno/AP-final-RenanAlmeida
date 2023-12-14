using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenanAlmeida.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Marca Marca { get; set; }
        public int MarcaId { get; set; }
        public virtual ICollection<Item> Itens { get; set; }
    }
}