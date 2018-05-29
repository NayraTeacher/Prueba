using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPrestamos
{
    public abstract class Articulo
    {
        protected string codigo;
        protected string nombre;
        protected double precio;
        protected DateTime fechaDevolucion = DateTime.MaxValue;
        protected int numRenovaciones = 0;

        public Articulo(string codigo, string nombre, double precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
        }

    }
}
