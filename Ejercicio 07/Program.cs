using System;

class Program
{
    static void Main(string[] args)
    {
        // DEFINIR asistencia [5] COMO ENTERO
        int[] asistencia = new int[5];
        bool existeCero = false;
        int indiceModificar, nuevoValor;

        // 1. Registrar la asistencia de cada sesión
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Asistencia sesión {i}: ");
            asistencia[i] = int.Parse(Console.ReadLine());
        }

        // 2. Mostrar todas las asistencias registradas
        Console.WriteLine("\nAsistencias iniciales:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Sesión {i}: {asistencia[i]}");
        }

        // 3. Verificar si alguna sesión tuvo exactamente 0 asistentes
        for (int i = 0; i < 5; i++)
        {
            if (asistencia[i] == 0)
            {
                existeCero = true;
            }
        }

        if (existeCero)
        {
            Console.WriteLine("\nAlerta: existe una sesión con 0 asistentes");
        }
        else
        {
            Console.WriteLine("\nNo hay sesión con 0 asistentes");
        }

        // 4. Permitir modificar una asistencia indicando su índice
        Console.Write("\nIngrese índice a modificar: ");
        indiceModificar = int.Parse(Console.ReadLine());

        // Validación: SI indiceModificar >= 0 Y indiceModificar < 5 ENTONCES
        if (indiceModificar >= 0 && indiceModificar < 5)
        {
            Console.Write("Ingrese nueva asistencia: ");
            nuevoValor = int.Parse(Console.ReadLine());
            asistencia[indiceModificar] = nuevoValor;
        }
        else
        {
            Console.WriteLine("Índice no válido");
        }

        // 5. Mostrar las asistencias actualizadas
        Console.WriteLine("\nAsistencias actualizadas:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Sesión {i}: {asistencia[i]}");
        }
    }
}