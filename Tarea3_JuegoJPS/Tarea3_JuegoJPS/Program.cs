using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tarea_3_JuepoJPS
{
    class Program
    {
        static void Main()
        {
            using (var db = new TP3Context())
            {
                bool continuar = true;

                while (continuar)
                {
                    Console.Write("Escriba el nombre del producto: ");
                    string nombre = Console.ReadLine();

                    DateTime fecha = DateTime.Now;
                    var producto = new Producto
                    {
                        Nombre = nombre,
                        FechaHora = fecha,
                        Numeros = new List<Numero>()
                    };

                    int cantidad;
                    do
                    {
                        Console.Write("Cantidad de números aleatorios a generar: ");
                    } while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad <= 0);

                    bool permitirRepetidos = true;
                    if (cantidad <= 100)
                    {
                        Console.Write("¿Los números se pueden repetir? (s/n): ");
                        string respuesta = Console.ReadLine().ToLower();
                        permitirRepetidos = respuesta == "s";
                    }

                    List<int> generados = new List<int>();
                    Random rnd = new Random();

                    for (int i = 1; i <= cantidad; i++)
                    {
                        int numero;
                        do
                        {
                            numero = rnd.Next(0, 100);
                        } while (!permitirRepetidos && generados.Contains(numero));

                        generados.Add(numero);
                        producto.Numeros.Add(new Numero { Orden = i, Num = numero });
                    }

                    db.Productos.Add(producto);
                    db.SaveChanges();

                    Console.Write("¿Desea agregar otro producto? (s/n): ");
                    continuar = Console.ReadLine().ToLower() == "s";
                }

                Console.WriteLine("\n--- Productos guardados en la base de datos ---\n");

                var productos = db.Productos.OrderBy(p => p.FechaHora).ToList();

                foreach (var p in productos)
                {
                    Console.WriteLine($"{p.ProductoId}. {p.Nombre} - {p.FechaHora}");

                    var numeros = db.Numeros
                                    .Where(n => n.ProductoId == p.ProductoId)
                                    .OrderBy(n => n.Orden)
                                    .ToList();

                    foreach (var n in numeros)
                    {
                        Console.WriteLine($"  {n.NumeroId}. [{n.Orden}] {n.Num}");
                    }
                }

                Console.WriteLine("\nPrograma finalizado. Presione Enter para salir.");
                Console.ReadLine();
            }
        }
    }
}

