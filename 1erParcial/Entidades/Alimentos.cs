using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Alimento : Producto
    {
        private EMarca marca;
       
        public Alimento (EMarca marca,int id,double precio) : base(id,precio)
        {
            this.marca = marca;
            
        }

        public EMarca Marca
        {
            get
            {
                return this.marca;
            }
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n** Alimento **");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Marca: " + this.Marca);

            return sb.ToString();

        }


    }
}
