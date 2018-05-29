using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPrestamos
{
    class Libro : Articulo, IPrestable<Libro>
    {
        public string ISBN;
        public string autor;
        public string editorial;

        public Libro(string codigo, string nombre, double precio, string ISBN, string autor, string editorial)
            : base(codigo, nombre, precio)
        {
            
            this.autor = autor;
            this.editorial = editorial;
            if (CheckISBN10(ISBN))
                this.ISBN = ISBN;
            else
                throw new System.Exception();
        }

        public override string ToString()
        {
            return this.nombre + " del Autor: " + this.autor;
        }

        public bool Prestar(List<Libro> pLibros)
        {
            bool res = true;
            if (pLibros.Count >= 5)
                res = false;
            else
            { 
                if (pLibros.Contains(this))                
                    res = false;
                else
                {
                    this.fechaDevolucion = DateTime.Now.AddDays(10);
                    pLibros.Add(this);
                }
            }
            return res;
        }
        public bool Devolver(List<Libro> pLibros)
        {
            //TODO:
            return true;
        }
        public bool Renovar(List<Libro> pLibros)
        {
            //TODO:
            return true;
        }

        public string GetNombre()
        {
            return this.nombre;
        }
        public string GetCodigo()
        {
            return this.codigo;
        }
        public double GetPrecio()
        {
            return this.precio;
        }
        public DateTime GetFechaDevolucion()
        {
            return this.fechaDevolucion;
        }
        public double GetNumRenovaciones()
        {
            return this.numRenovaciones;
        }

        public static bool CheckISBN10(string ISBN)
        {
            if (ISBN.Length != 10)
                return false;
            else
                return true;
        }
    }
}
