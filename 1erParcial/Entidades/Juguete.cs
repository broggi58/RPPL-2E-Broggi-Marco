using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Juguete : Producto
    {
        private ETipo tipo;
        public Juguete(ETipo tipo, int id, double precio) : base(id,precio)
        {
            this.tipo = tipo;
        }

        public ETipo Tipo
        {
            get
            {
                return this.tipo;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n** Juguete**");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Tipo:" + this.Tipo);
            return base.Mostrar();
        }

    }
}
