using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafo
{
    internal class Grafos
    {
        private int numVertices;
        private LinkedList<int>[] listaAdyacencia;

        public Grafos(int vertices)
        {
            numVertices = vertices;
            listaAdyacencia = new LinkedList<int>[vertices];
            for (int i = 0; i < vertices; i++)
            {
                listaAdyacencia[i] = new LinkedList<int>();
            }
        }

        public void AgregarArista(int origen, int destino)
        {
            listaAdyacencia[origen].AddLast(destino);
            listaAdyacencia[destino].AddLast(origen);
        }

        public void MostrarGrafo()
        {
            for (int i = 0; i < numVertices; i++)
            {
                LinkedList<int> lista = listaAdyacencia[i];
                Console.Write("Vertice " + i + " está conectado a: ");
                foreach (var adyacente in lista)
                {
                    Console.Write(adyacente + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
