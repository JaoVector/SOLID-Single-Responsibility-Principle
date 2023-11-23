using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SRP.Classes
{
    public class Estoque
    {
        public int IdProduto { get; set; }
        public String? Nome { get; set; }
        public String? Descricao { get; set; }
        public int? Quantidade { get; set; }
        public DateTime DataEntrada { get; set; }
    }
}