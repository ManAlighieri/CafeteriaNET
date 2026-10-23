using System;
using System.Collections.Generic;
using System.Text;

namespace CAFETERIA
{
    public class Pedido
    {
        public const decimal CargoParaLlevar = 5m;

        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public bool ParaLlevar { get; set; }

        public decimal Subtotal => Producto.Precio * Cantidad + (ParaLlevar ? CargoParaLlevar : 0m);

        public Pedido(Producto producto, int cantidad, bool paraLlevar)
        {
            Producto = producto;
            Cantidad = cantidad;
            ParaLlevar = paraLlevar;
        }

    }
}
