using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAB02_1252016.Models
{
    public class Articulo : IComparable<Articulo>
    {
        public long idProducto { get; set; }
        public string descripcionProd { get; set; }
        public double precio { get; set; }
        public int cantEnInventario { get; set; }

        int IComparable<Articulo>.CompareTo(Articulo other)
        { 
            return this.idProducto.CompareTo(other.idProducto);
        }
    }
}