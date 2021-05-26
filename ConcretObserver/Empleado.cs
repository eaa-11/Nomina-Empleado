using System;
using System.Collections.Generic;
using System.Text;
using Tarea7.Observer;

namespace Tarea7
{
    class Empleado:IEmpleadoObs
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }
        public double Salario_neto { get; set; }
        public double Consumo_farmacia { get; set; }

        public Empleado()
        {

        }

        public Empleado(Empleado obj)
        {
            this.Id = obj.Id;
            this.Nombre = obj.Nombre;
            this.Puesto = obj.Puesto;
            this.Email = obj.Email;
            this.Salario = obj.Salario;
            this.Salario_neto = obj.Salario_neto;
            this.Consumo_farmacia = obj.Consumo_farmacia;
        }

        public override string ToString()
        {
            return Nombre;
        }
       
        public string Informacion()
        {
            return "\t\tId: " + Id +
                "\n\t\tNombre: " + Nombre +
                "\n\t\tPuesto: " + Puesto +
                "\n\t\tEmail: " + Email +
                "\n\t\tSalario: " + Salario +
                "\n\t\tSalario neto: " + Salario_neto;
        }

        public void Update(SubjectService service)
        {
            this.Salario_neto = this.Salario_neto - service.monto;
            Console.WriteLine("\tAl empleado {0} se descuenta por el plan {1} $. {2}", this, service, service.monto);
        }
    }
}
