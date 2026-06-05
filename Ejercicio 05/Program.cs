using System;

class Program
{
    static void Main(string[] args)
    {
        // DEFINIR temperaturas [7] COMO REAL
        double[] temperaturas = new double[7];
        // DEFINIR diaEncontrado COMO ENTERO
        int diaEncontrado = -1;

        // PARA i=0 HASTA 6 HACER
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Ingrese temperatura del día {i + 1}: ");
            temperaturas[i] = double.Parse(Console.ReadLine());
        }

        // PARA i=0 HASTA 6 HACER
        for (int i = 0; i < 7; i++)
        {
            // SI temperaturas[i] > 30 Y diaEncontrado == -1 ENTONCES
            if (temperaturas[i] > 30 && diaEncontrado == -1)
            {
                diaEncontrado = i;
            }
        }

        // SI diaEncontrado <> -1 ENTONCES
        if (diaEncontrado != -1)
        {
            Console.WriteLine($"Primera alerta en día {diaEncontrado + 1}");
        }
        else
        {
            Console.WriteLine("No hubo alerta de temperatura");
        }
    }
}