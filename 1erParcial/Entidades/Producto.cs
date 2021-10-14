using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        private int id;
        private double precio;


        public Producto (int id,double precio)
        {
            this.id = id;
            this.precio = precio;
        }

        public int ID
        {
            get
            {
                return this.id;
            }
               
        }

        public double Precio
        {
            get
            {
                return this.precio;
            }
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ID: " + this.ID);
            sb.AppendLine("Precio: " + this.Precio);

            return sb.ToString();
        }

        public static bool operator ==(Producto p1,Producto p2)
        {
            return (p1.ID == p2.ID);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1.ID == p2.ID);
        }

    }
}
