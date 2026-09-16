using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGestionFacturas_DAS.Entidades
{
    internal class Factura
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string ClienteNombre { get; set; } = string.Empty;
        public string ClienteDocumento { get; set; } = string.Empty;
        public string Estado { get; set; } = "Emitida";
        public decimal Total { get; set; }

        public decimal CalcularTotal(IReadOnlyList<FacturaDetalle> detalles)
        {
            decimal total = 0;
            foreach (FacturaDetalle detalle in detalles)
            {
                total += detalle.CalcularSubtotal();
            }
            return total;
        }
    }
}
