using System;

class Program
{
    static void Main(string[] args)
    {
        int[] stock = new int[4];

        // Primer recorrido: registrar el stock inicial
        for (int i = 0; i < stock.Length; i++)
        {
            Console.Write($"Stock del producto {i}: ");
            stock[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Índice a modificar: ");
        int indice = int.Parse(Console.ReadLine());

        // Validamos que el índice esté dentro del rango permitido (0, 1, 2 y 3)
        if (indice >= 0 && indice < stock.Length)
        {
            Console.Write("Nuevo stock: ");
            int nuevo = int.Parse(Console.ReadLine());
            stock[indice] = nuevo; // Se modifica la posición indicada
        }
        else
        {
            Console.WriteLine("Índice no válido");
        }

        Console.WriteLine("\nStock actualizado: ");
        // Segundo recorrido: mostrar el arreglo actualizado
        for (int i = 0; i < stock.Length; i++)
        {
            Console.WriteLine($"Índice {i}: {stock[i]}");
        }
    }
}