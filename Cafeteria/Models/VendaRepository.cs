using System.Collections.Generic;
using System.Linq;

namespace Cafeteria.Models
{
    public static class VendaRepository
    {
        private static readonly List<Venda> vendas = new();

        public static void Adicionar(Venda venda)
        {
            vendas.Add(venda);
        }

        public static List<Venda> Listar()
        {
            return new List<Venda>(vendas);
        }

        public static decimal TotalVendido()
        {
            return vendas.Sum(v => v.Total);
        }
    }
}