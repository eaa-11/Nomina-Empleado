using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea7.Observer
{
    public abstract class SubjectService:ISubjectServices
    {
        public string nombre { get; set; }
        public double monto { get; set; }
        public List<IEmpleadoObs> empleados { get; set; }

        public SubjectService(string _nombre)
        {
            this.nombre = _nombre;
            this.monto = 0;
            this.empleados = new List<IEmpleadoObs>();
        }
        public void Remover(IEmpleadoObs obj)
        {
            if (empleados.Contains(obj))
            {
                this.empleados.Remove(obj);
                Console.WriteLine("\tEmpleado {0} removido del plan {1}", obj, this);
            }
            else
            {
                Console.WriteLine("\tEl empleado {0} no esta suscrito a este plan", obj);
            }
        }

        public abstract void Notificar();

        public void Agregar(IEmpleadoObs obj)
        {
            if (!empleados.Contains(obj))
            {
                this.empleados.Add(obj);
                Console.WriteLine("\tEmpleado {0} suscrito al plan {1}", obj, this);
            }
            else
            {
                Console.WriteLine("\tEl empleado {0} ya esta suscrito al plan {1}", obj, this);
            }
        }
        public override string ToString()
        {
            return $"{nombre}";
        }
    }
}
