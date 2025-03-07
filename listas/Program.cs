using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    internal class Program
    {
        //Victor Moreno
        private enum Menu
        {
            AgregarAutos = 1, MostrarAutos, ContarAutos, EliminarAutos, Actualizar
        }
        static void Main(string[] args)
        {
           
            Acciones program = new Acciones();
            while (true)
            {
                switch (Men())
                {
                    case Menu.AgregarAutos:
                        program.AgregarAuto();
                        break;
                    case Menu.MostrarAutos:
                        program.MostrarAutos();
                        break;
                    case Menu.ContarAutos:
                        Console.WriteLine(program.ContarAutos());
                        break;
                    case Menu.EliminarAutos:
                        Console.WriteLine("Dame la marca");
                        string Marca = Console.ReadLine();

                        program.EliminarAutomovil(Marca);
                        break;
                    case Menu.Actualizar:
                        Console.WriteLine("¿Qué auto deseas actualizar? (Ingresa la marca)");
                        string Actu = Console.ReadLine();
                        program.Actualizar(Actu);
                        break;

                    default:
                        break;
                }
            }
        }
        static Menu Men()
        {
            Console.WriteLine("¿Qué quieres hacer?");
            Console.WriteLine("1) Agregar Autos");
            Console.WriteLine("2) Mostrar Autos");
            Console.WriteLine("3) Contar Autos");
            Console.WriteLine("4) Eliminar Autos");
            Console.WriteLine("5) Actualizar");
            Menu opc = (Menu) Convert.ToByte(Console.ReadLine());
            return opc;
        }
    }
}
