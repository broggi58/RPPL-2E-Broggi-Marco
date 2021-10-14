using System;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private double dineroDisponible;
        private int distancia;


        public string Nombre
        {
            set
            {
                if(value.Length>0)
                    this.nombre = value;
            }
            get
            {
                return this.nombre;
            }
        }

        public double Dinero
        {
            set
            {
                if (value >= 0)
                    this.dineroDisponible = value;
            }
            get
            {
                return this.dineroDisponible;
            }
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Dinero Disponible:" + this.Dinero);
            return sb.ToString();
        }

    }
}
