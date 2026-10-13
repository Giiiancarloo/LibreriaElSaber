using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.TiendaDeportivaCampeon
{
    public class ProductosEntidad
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
