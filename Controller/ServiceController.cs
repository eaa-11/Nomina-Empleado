using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tarea7.ConcretServices;
using Tarea7.Servicios;

namespace Tarea7.Controller
{
    public class ServiceController
    {
        public ServiceController()
        {
            MainController.servicios.Add(new ServicioAFP("AFP"));
            MainController.servicios.Add(new ServicioSFS("SFS"));
            MainController.servicios.Add(new ServicioCooperativa("Cooperativa"));
            MainController.servicios.Add(new ServicioFarmacia("Farmacia"));
            MainController.servicios.Add(new ServicioFunerario("Plan funerario"));
        }

        public void desuscribirse()
        {
            Console.Clear();
            Console.WriteLine("\tDESUSCRIPCION A UN PLAN\n");
            Console.Write("\tId empleado: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (MainController.empleados.Count >= id && id > 0)
            {
                Console.WriteLine("\tPlanes: ");
                for (int i = 2; i < MainController.servicios.Count; i++)
                {
                    Console.WriteLine("\t\t{0}. {1}", i, MainController.servicios.ElementAt(i));
                }
                Console.Write("\tSuscribirse a: ");
                int pos_descuento = Convert.ToInt32(Console.ReadLine());
                if (MainController.servicios.Count >= pos_descuento && pos_descuento > 1)
                {
                    MainController.servicios.ElementAt(pos_descuento).Remover(MainController.empleados.ElementAt(id - 1));
                }
                else
                {
                    Console.WriteLine("\tMensaje: El plan no existe");
                }
            }
            else
            {
                Console.WriteLine("\tMensaje: El empleado no existe");
            }
        }

        public void suscribirse()
        {
            Console.Clear();
            Console.WriteLine("\tSUSCRIPCION A UN PLAN\n");
            Console.Write("\tId empleado: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (MainController.empleados.Count >= id && id > 0)
            {
                Console.WriteLine("\tPlanes: ");
                for (int i = 2; i < MainController.servicios.Count; i++)
                {
                    Console.WriteLine("\t\t{0}. {1}", i, MainController.servicios.ElementAt(i));
                }
                Console.Write("\tSuscribirse a: ");
                int pos_descuento = Convert.ToInt32(Console.ReadLine());
                if (MainController.servicios.Count >= pos_descuento && pos_descuento > 1)
                {
                    MainController.servicios.ElementAt(pos_descuento).Agregar(MainController.empleados.ElementAt(id - 1));
                }
                else
                {
                    Console.WriteLine("\tMensaje: El plan no existe");
                }
            }
            else
            {
                Console.WriteLine("\tMensaje: El empleado no existe");
            }
        }
    }
}
