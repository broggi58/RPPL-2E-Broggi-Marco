using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class PetShop
    {
        List<Producto> listaProductos;
        LinkedList<Persona> llPersona;
        private int stockMaximo;
        private int maxEmpleados;
        
        public PetShop()
        {
            this.listaProductos = new List<Producto>();
            this.llPersona = new LinkedList<Persona>();
        }

       public string MostrarProductos()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Producto p in listaProductos)
            {
                sb.AppendLine(p.Mostrar());
            }
            return sb.ToString();
        }

        public string MostrarPersonal()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Persona p in llPersona)
            {
                sb.AppendLine(p.Mostrar());
            }
            return sb.ToString();
        }

        public string  MostrarLocal()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.MostrarProductos());
            sb.AppendLine(this.MostrarPersonal());
            return sb.ToString();

        }

        public static PetShop operator + (PetShop local,Producto p)
        {
            foreach(Producto producto in local.listaProductos)
            {
                if(producto==p)
                {
                    return local;
                }
                local.listaProductos.Add(producto);
            }
            return local;
        }

        public static PetShop operator + (PetShop local,Persona p)
        {
            foreach(Persona personal in local.llPersona)
            {
                if(p==personal)
                {
                    return local;
                }
                local.llPersona.AddLast(personal);
                
            }
            return local;
        }

        public static PetShop operator -(PetShop local, Producto p)
        {
            foreach (Producto producto in local.listaProductos)
            {
                if (p == producto)
                {
                    local.listaProductos.Remove(producto);
                    break;
                }
            }

            return local;
        }

        public static PetShop operator -(PetShop local, Persona p)
        {
            foreach (Persona personal in local.llPersona)
            {
                if (personal == p)
                {
                    local.llPersona.Remove(personal);
                    break;
                }
            }

            return local;
        }

        public static bool Vender(PetShop local,Cliente cl,Producto p)
        {
            foreach(Producto producto in local.listaProductos)
            {
                if(p==producto && cl.Dinero>p.Precio)
                {
                    cl.Dinero -= p.Precio;
                    local.listaProductos.Remove(p);
                    return true;
                }
            }
            return false;
        }

        public static Persona Usuario(PetShop local, Persona usuario)
        {
            foreach(Persona p in local.llPersona)
            {
                if(p==usuario)
                {
                    return usuario;
                }
            }
            return null;

        }


    }
}
