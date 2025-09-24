using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dic.en_c
{
    internal class Acciones
    {
        public string Nombre { get; set; }
        public int Matricula { get; set; }

        private Dictionary<int, string> estudiantes = new Dictionary<int, string>();

        public Acciones(string nombre, int matricula)
        {
            Nombre = nombre;
            Matricula = matricula;
        }
        public void mostrarinfo()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Matrícula: {Matricula}");
           
        }
        public void Agregarestudiante()
        {
            
            Console.WriteLine("Ingrese la matrícula del estudiante:");
            int matricula= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del estudiante:");
            string nombre = Console.ReadLine();
            estudiantes.Add(matricula, nombre);

        }

        public void MostrarEstudiantes()
        {
            Console.WriteLine("Lista de estudiantes:");
            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine($"Matrícula: {estudiante.Key}");
                Console.WriteLine($"Nombre: {estudiante.Value}");
            }
        }

        public void BuscarEstudiante()
        {
            Console.WriteLine("Ingrese la matrícula del estudiante a buscar:");
            int matricula = Convert.ToInt32(Console.ReadLine());
            if (estudiantes.TryGetValue(matricula, out string nombre))
            {
                Console.WriteLine($"Estudiante encontrado: Matrícula: {matricula}, Nombre: {nombre}");
            }
            else
            {
                Console.WriteLine("Estudiante no encontrado.");
            }
        }
        public void EliminarEstudiante()
        {
            Console.WriteLine("Ingrese la matrícula del estudiante a eliminar:");
            int matricula = Convert.ToInt32(Console.ReadLine());
            if (estudiantes.Remove(matricula))
            {
                Console.WriteLine("Estudiante eliminado.");
            }
            else
            {
                Console.WriteLine("Estudiante no encontrado.");
            }
        }

        public void ActualizarEstudiante()
        {
            Console.WriteLine("Ingrese la matrícula del estudiante a actualizar:");
            int matricula = Convert.ToInt32(Console.ReadLine());
            if (estudiantes.ContainsKey(matricula))
            {
                Console.WriteLine("Ingrese el nuevo nombre del estudiante:");
                string nuevoNombre = Console.ReadLine();
                estudiantes[matricula] = nuevoNombre;
                Console.WriteLine("Estudiante actualizado.");
            }
            else
            {
                Console.WriteLine("Estudiante no encontrado.");
            }
        }
        public void contarEstudiantes()
        {
            Console.WriteLine($"Número total de estudiantes: {estudiantes.Count}");
        }
        public void Salir()
        {
            Console.WriteLine("Saliendo del programa...");
            Environment.Exit(0);
        }

    }
}
