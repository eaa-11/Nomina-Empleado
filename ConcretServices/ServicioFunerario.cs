using System;
using System.Collections.Generic;
using System.Text;
using Tarea7.Observer;

namespace Tarea7.Servicios
{
    class ServicioFunerario : SubjectService
    {
        public ServicioFunerario(string nombre):base(nombre)
        {

        }
        public override void Notificar()
        {
            foreach (Empleado emp in empleados)
            {
                if (emp.Salario >= 1000)
                {
                    this.monto = 150;
                }
                emp.Update(this);
            }
        }
    }
}
