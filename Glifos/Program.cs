using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grafos grafo = new Grafos(5);

            grafo.AgregarArista(0, 1);
            grafo.AgregarArista(0, 4);
            grafo.AgregarArista(1, 2);
            grafo.AgregarArista(1, 3);
            grafo.AgregarArista(1, 4);
            grafo.AgregarArista(2, 3);
            grafo.AgregarArista(3, 4);

            grafo.MostrarGrafo();

            Console.ReadLine();
        }
    }
}
