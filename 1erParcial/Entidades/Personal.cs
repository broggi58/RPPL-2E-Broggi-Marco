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
        private string contra;
        private int id;
        private int horasTrabajadas;

        public Persona(string nombre, int id,int horas,string contra)
        {
            this.nombre = nombre;
            this.id = id;
            this.horasTrabajadas = horas;
            this.contra = contra;
        }

        public string Nombre
        {
            set
            {
                if(value.Length>0)
                {
                    this.nombre = value;
                }
            }
            get
            {
                return this.nombre;
            }
        }
        public string Contra
        {
            set
            {
                if (value.Length > 0)
                {
                    this.contra = value;
                }
            }
            get
            {
                return this.contra;
            }
        }
        public int ID
        {
            get
            {
                return this.id;
            }
        }

        public int Horas
        {
            set
            {
                if(value>0)
                {
                    this.horasTrabajadas = value;
                }
            }
            get
            {
                return this.horasTrabajadas;
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
            sb.AppendLine("Horas trabajadas:" + p1.Horas);

            return sb.ToString();
        }

       
    }
}
