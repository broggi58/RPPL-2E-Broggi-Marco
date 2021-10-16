using System;
using System.Collections;
using System.Text;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private double dineroDisponible;
        private int distancia;
        private EEnvio tipoEnvio;
        Stack carrito;



        public string Nombre
        {
            set
            {
                if (value.Length > 0)
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

        public int Distancia
        {
            set
            {
                if (value > 0 && value < 10)
                {
                    this.distancia = value;
                }
            }
            get
            {
                return this.distancia;
            }
        }

        public Cliente()
        {
            this.carrito = new Stack();
        }
        public Cliente(string nombre, double dinero, int distancia) : this()
        {
            this.Nombre = nombre;
            this.Distancia = distancia;
            this.Dinero = dinero;

        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Dinero Disponible:" + this.Dinero);
            return sb.ToString();
        }

       public static implicit operator double(Cliente cl)
        {
            return cl.Dinero;
        }

        public static double CalcularEnvio(Stack productos)
        {
            foreach (Producto p in productos)
            {
                if(p.)
            }
        }
    }
}
