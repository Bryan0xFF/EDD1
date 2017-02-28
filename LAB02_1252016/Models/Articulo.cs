using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAB02_1252016.Models
{
    public class Articulo : IComparable<Articulo>
    {
        public string idProducto { get; set; }
        public string descripcionProd { get; set; }
        public double precio { get; set; }
        public int cantEnInventario { get; set; }

        public Articulo(string idProducto, string descripcionProd, string precio, string cantEnInventario)
        {
            this.idProducto = idProducto;
            this.descripcionProd = descripcionProd;
            this.precio = Convert.ToDouble(precio);
            this.cantEnInventario = Convert.ToInt32(cantEnInventario);
        }

        int IComparable<Articulo>.CompareTo(Articulo other)
        {
            return this.idProducto.CompareTo(other.idProducto);
        }
    }
}