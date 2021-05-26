using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tarea7.Observer;

namespace Tarea7.Controller
{
    public class EmpleadoController
    {
        public void crearEmpleado()
        {
            Console.Clear();
            Console.WriteLine("\tCREAR EMPLEADO\n");
            Empleado empleado = new Empleado();
            empleado.Id = MainController.empleados.Count + 1;
            Console.WriteLine("\tId: " + empleado.Id);
            Console.Write("\tNombre: ");
            empleado.Nombre = Console.ReadLine();
            Console.Write("\tPuesto: ");
            empleado.Puesto = Console.ReadLine();
            Console.Write("\tEmail: ");
            empleado.Email = Console.ReadLine();
            Console.Write("\tSalario: ");
            empleado.Salario = Convert.ToDouble(Console.ReadLine());
            empleado.Salario_neto = empleado.Salario;

            MainController.empleados.Add(empleado);
            Console.WriteLine("\n\tEmpleado registrado!!!\n");

            MainController.servicios.ElementAt(0).Agregar(empleado);
            MainController.servicios.ElementAt(1).Agregar(empleado);
        }

        public void consumirFarmacia()
        {
            Console.Clear();
            Console.WriteLine("\tREGISTRO CONSUMIR FARMACIA\n");
            Console.Write("\tId empleado: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (MainController.empleados.Count >= id && id > 0)
            {
                Console.Write("\tMonto: ");
                ((Empleado)MainController.empleados.ElementAt(id - 1)).Consumo_farmacia = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("\tMensaje: El empleado no existe");
            }
        }

        public void mostrarNomina()
        {
            Console.Clear();
            Console.WriteLine("\tNOMINA DE EMPLEADOS\n");
            foreach (Empleado empleado in MainController.empleados)
            {
                empleado.Salario_neto = empleado.Salario;
            }
            foreach (SubjectService service in MainController.servicios)
            {
                Console.WriteLine("\n\t*) Descuentos para el plan {0}:", service);
                service.Notificar();
            }

            Console.WriteLine("\n\tNomina de Empleados");
            foreach (Empleado empleado in MainController.empleados)
            {
                Console.WriteLine("\t*)\n" + empleado.Informacion());
            }
        }
    }
}
