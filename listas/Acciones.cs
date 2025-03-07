using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    internal class Acciones
    {
        public List<Automovil> Listaautomovil = new List<Automovil>();
        Automovil a = new Automovil();

        public void AgregarAuto()
        {
            Console.WriteLine("Marca");
            a.Marca = Console.ReadLine();
            Console.WriteLine("Modelo");
            a.Modelo = Console.ReadLine();
            Console.WriteLine("Año");
            a.Anio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("No De Puertas");
            a.NoPuertas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Color");
            a.Color = Console.ReadLine();

            Listaautomovil.Add(new Automovil(a.Marca,a.Modelo,a.Anio,a.NoPuertas,a.Color));
        }
        public void MostrarAutos()
        {
            foreach (var a in Listaautomovil)
            {
                Console.WriteLine($"La Marca del carro es: {a.Marca}" );
                Console.WriteLine($"El Modelo del carro es: {a.Modelo}");
                Console.WriteLine($"El año del carro es: {a.Anio}");
                Console.WriteLine($"El numero de puertas del carro es: {a.NoPuertas}");
                Console.WriteLine($"El color del carro es: {a.Color}");
            }
        }
        public int ContarAutos()
        { 
            return Listaautomovil.Count;
        }
        public void EliminarAutomovil(string nombremarca)
        {

            var automovil = Listaautomovil.Find(x => x.Marca == nombremarca);

                if (automovil!=null)
                Listaautomovil.Remove(automovil);
                else
                Console.WriteLine("No se encontron el automovil");
            
        }
        public void Actualizar(string nombremarca)
        {

                var a = Listaautomovil.FirstOrDefault(x => x.Marca == nombremarca);

                if (a != null)
                {
                    Console.WriteLine("Ingrese los nuevos datos del automóvil (presione Enter para mantener el valor actual):");

                    Console.Write($"Nueva marca ({a.Marca}): ");
                    string nuevaMarca = Console.ReadLine();
                    a.Marca = string.IsNullOrWhiteSpace(nuevaMarca) ? a.Marca : nuevaMarca;

                    Console.Write($"Nuevo modelo ({a.Modelo}): ");
                    string nuevoModelo = Console.ReadLine();
                    a.Modelo = string.IsNullOrWhiteSpace(nuevoModelo) ? a.Modelo : nuevoModelo;

                    Console.Write($"Nuevo año ({a.Anio}): ");
                    string nuevoAño = Console.ReadLine();
                    a.Anio = int.TryParse(nuevoAño, out int año) ? año : a.Anio;

                    Console.Write($"Nuevo número de puertas ({a.NoPuertas}): ");
                    string nuevasPuertas = Console.ReadLine();
                    a.NoPuertas = int.TryParse(nuevasPuertas, out int noPuertas) ? noPuertas : a.NoPuertas;

                    Console.Write($"Nuevo color ({a.Color}): ");
                    string nuevoColor = Console.ReadLine();
                    a.Color = string.IsNullOrWhiteSpace(nuevoColor) ? a.Color : nuevoColor;

                    Console.WriteLine("Automóvil actualizado correctamente.");
                }
                else
                {
                    Console.WriteLine("No se encontró un automóvil con esa marca.");
                }
            }
    }
}

