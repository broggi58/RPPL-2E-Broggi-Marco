using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cama : Producto
    {
        private ETamanio tamanio;

        public Cama(ETamanio tam,int id, double precio) : base(id,precio)
        {
            this.tamanio = tam;
        }

        public ETamanio Tamanio
        {
            get
            {
                return this.tamanio;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n** Cama **");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Tamaño : " + this.Tamanio);
            return ToString();
        }


    }
}
