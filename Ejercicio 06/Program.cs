using System;

class Program
{
    static void Main(string[] args)
    {
        // DEFINIR precios [5] COMO REAL
        double[] precios = new double[5];
        double buscado, nuevo;
        int posicion = -1;

        // PARA i=0 HASTA 4 HACER (Carga de datos)
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Precio del producto {i + 1}: ");
            precios[i] = double.Parse(Console.ReadLine());
        }

        Console.Write("Precio a buscar: ");
        buscado = double.Parse(Console.ReadLine());

        // PARA i=0 HASTA 4 HACER (Búsqueda)
        for (int i = 0; i < 5; i++)
        {
            if (precios[i] == buscado)
            {
                posicion = i;
            }
        }

        // SI posicion <> -1 ENTONCES
        if (posicion != -1)
        {
            Console.Write("Ingrese el nuevo precio: ");
            nuevo = double.Parse(Console.ReadLine());
            precios[posicion] = nuevo;
            Console.WriteLine("Precio actualizado");
        }
        else
        {
            Console.WriteLine("Precio no encontrado");
        }

        // Mostrar lista completa
        Console.WriteLine("\nLista de precios:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Índice {i}: {precios[i]}");
        }
    }
}