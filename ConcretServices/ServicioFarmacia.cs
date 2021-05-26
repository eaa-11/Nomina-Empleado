using System;
using System.Collections.Generic;
using System.Text;
using Tarea7.Observer;

namespace Tarea7.Servicios
{
    class ServicioFarmacia : SubjectService
    {
        public ServicioFarmacia(string nombre) : base(nombre)
        {
            
        }
        public override void Notificar()
        {
            foreach (Empleado emp in empleados)
            {
                if (emp.Consumo_farmacia > 0)
                {
                    this.monto = emp.Consumo_farmacia / 2;
                }
                emp.Update(this);
            }
        } 
    }
}
