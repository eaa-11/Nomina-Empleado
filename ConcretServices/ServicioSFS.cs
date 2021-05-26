using System;
using System.Collections.Generic;
using System.Text;
using Tarea7.Observer;

namespace Tarea7.ConcretServices
{
    class ServicioSFS:SubjectService
    {
        public ServicioSFS(string nombre) : base(nombre)
        {

        }
        public override void Notificar()
        {
            foreach (Empleado emp in empleados)
            {
                this.monto = 0.0304 * emp.Salario;
                emp.Update(this);
            }
        }
    }
}
