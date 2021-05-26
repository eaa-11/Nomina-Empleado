using System;
using System.Collections.Generic;
using System.Text;
using Tarea7.Observer;

namespace Tarea7.Controller
{
    public class MainController
    {
        public static List<IEmpleadoObs> empleados = new List<IEmpleadoObs>();
        public static List<ISubjectServices> servicios = new List<ISubjectServices>();

        public void menu()
        {
            EmpleadoController empleadoController = new EmpleadoController();
            ServiceController planController = new ServiceController();

            int opcion = 0;

            while (opcion != 6)
            {
                try
                {
                    Console.WriteLine("\tMenu" +
                        "\n\t1) Crear Empleado" +
                        "\n\t2) Suscribirse a un plan" +
                        "\n\t3) Desuscribirse a un plan" +
                        "\n\t4) Registrar consumo de farmacia" +
                        "\n\t5) Calculo de la nomina" +
                        "\n\t6) Salir");
                    Console.Write("\tOpción: ");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            empleadoController.crearEmpleado();
                            break;
                        case 2:
                            planController.suscribirse();
                            break;
                        case 3:
                            planController.desuscribirse();
                            break;
                        case 4:
                            empleadoController.consumirFarmacia();
                            break;
                        case 5:
                            empleadoController.mostrarNomina();
                            break;
                        case 6:
                            Console.WriteLine("\n\n\tSaliendo...");
                            break;
                        default:
                            Console.WriteLine("\n\n\tMensaje: N/A!");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n\n\tError : " + e.Message);
                }
                Console.Write("\n\n\tPresiona una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
