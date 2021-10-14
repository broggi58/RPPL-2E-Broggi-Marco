using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private int id;
        private int horasTrabajadas;

        public Persona(string nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public int ID
        {
            get
            {
                return this.id;
            }
        }
        public virtual string Mostrar()
        {
            return (string)this;
        }

        public static implicit operator string(Persona p1)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + p1.Nombre);
            sb.AppendLine("ID:" + p1.ID);

            return sb.ToString();
        }

       
    }
}
