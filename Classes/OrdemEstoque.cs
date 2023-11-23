using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRP.Classes
{
    public class OrdemEstoque : IGerenciaEntradas<Estoque>
    {
        private readonly List<Estoque> _produtos;

        public OrdemEstoque()
        {
            _produtos = new List<Estoque>();
        }

        public void Adiciona(Estoque entry) => _produtos.Add(entry);
        public void Exclui(int index) => _produtos.RemoveAt(index);
        public List<Estoque> Lista() => _produtos;
        public override string ToString() => string.Join(Environment.NewLine, _produtos.Select(x => $"Nome: {x.Nome}, Quantidade: {x.Quantidade}, Data de Entrada: {x.DataEntrada}"));
    }
}