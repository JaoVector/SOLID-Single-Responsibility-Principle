using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRP.Classes
{
    public class OrdemPedido : IGerenciaEntradas<Pedido>
    {
        private readonly List<Pedido> _pedidos;

        public OrdemPedido()
        {
            _pedidos = new List<Pedido>();
        }

        public void Adiciona(Pedido entry) => _pedidos.Add(entry);
        public void Exclui(int index) => _pedidos.RemoveAt(index);
        public List<Pedido> Lista() => _pedidos;
        public override string ToString() => string.Join(Environment.NewLine, _pedidos.Select(x => $"Nome do Pedido {x.Nome} e Descricao do Pedido {x.Descricao}"));
    }
}