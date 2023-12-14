using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenanAlmeida.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<NotaDeVenda>? NotasDeVenda { get; set; }
    }
}