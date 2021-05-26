using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea7.Observer
{
    public interface ISubjectServices
    {
        void Agregar(IEmpleadoObs empleado);
        void Remover(IEmpleadoObs empleado);
        void Notificar();
    }
}
