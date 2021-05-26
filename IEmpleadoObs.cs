using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea7.Observer
{
    public interface IEmpleadoObs
    {
        void Update(SubjectService obj);
    }
}
