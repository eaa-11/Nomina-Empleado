using System;
using System.Collections.Generic;
using System.Text;
using Tarea7.Observer;

namespace Tarea7.Servicios
{
    class ServicioCooperativa : SubjectService
    {
        public ServicioCooperativa(string nombre) : base(nombre)
        { 

        }
        public override void Notificar()
        {
            foreach (Empleado emp in empleados)
            {
                this.monto = 0.08 * emp.Salario;
                emp.Update(this);
            }
        }
    }
}
