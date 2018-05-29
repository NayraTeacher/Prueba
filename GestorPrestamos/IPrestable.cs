using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPrestamos
{
    interface IPrestable<T>
    {
        bool Prestar(List<T> prestamo);
        bool Renovar(List<T> prestamo);
        bool Devolver(List<T> prestamo);
    }
}
