using System;

namespace Cafeteria.Models
{
    public class Venda
    {
        public string Produto { get; set; } = "";

        public int Quantidade { get; set; }

        public decimal PrecoUnitario { get; set; }

        public DateTime Data { get; set; } = DateTime.Now;

        public decimal Total
        {
            get
            {
                return Quantidade * PrecoUnitario;
            }
        }
    }
}