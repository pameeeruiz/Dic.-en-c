using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dic.en_c
{
    internal class Program
    {
        public enum MenuOptions
        {
            AgregarEstudiante = 1,
            MostrarEstudiantes,
            BuscarEstudiante,
            EliminarEstudiante,
            AcutalizarEstudiante,
            ContarEstudiantes,
            Salir
        }
        static void Main(string[] args)
        {
         Acciones acciones = new Acciones("Pamela", 113270);
            acciones.mostrarinfo();

            while (true)
            {
                switch (Menu())
                {
                    case MenuOptions.AgregarEstudiante:
                        acciones.Agregarestudiante();
                        break;
                    case MenuOptions.MostrarEstudiantes:
                        acciones.MostrarEstudiantes();
                        break;
                    case MenuOptions.BuscarEstudiante:
                        acciones.BuscarEstudiante();
                        break;
                    case MenuOptions.EliminarEstudiante:
                        acciones.EliminarEstudiante();
                        break;
                    case MenuOptions.AcutalizarEstudiante:
                        acciones.ActualizarEstudiante();
                        break;
                    case MenuOptions.ContarEstudiantes:
                        acciones.contarEstudiantes();
                        break;
                    case MenuOptions.Salir:
                        acciones.Salir();
                        break;
                    default:
                        break;
                }

            }
        }

        static MenuOptions Menu()
        {
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Agregar estudiante");
            Console.WriteLine("2. Mostrar estudiantes");
            Console.WriteLine("3. Buscar estudiante");
            Console.WriteLine("4. Eliminar estudiante");
            Console.WriteLine("5. Actualizar estudiante ");
            Console.WriteLine("6. Contar estudiantes");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return (MenuOptions)opcion;
        }
    }
}

