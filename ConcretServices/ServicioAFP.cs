using System;
using System.Collections.Generic;
using System.Text;
using Tarea7.Observer;

namespace Tarea7.ConcretServices
{
    class ServicioAFP:SubjectService
    {
        public ServicioAFP(string nombre) : base(nombre)
        {
            
        }
        public override void Notificar()
        {
            foreach (Empleado emp in empleados)
            {
                this.monto = 0.0287 * emp.Salario;
                emp.Update(this);
            }
        } 
    }
}
