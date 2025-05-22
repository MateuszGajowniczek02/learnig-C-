using System;
using System.Globalization;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;


class calculator
{
    static void dodawanie(int number1, int number2)
    {

        int suma = number1 + number2;
        Console.WriteLine(suma);

    }
    static void odejmowanie(int number1, int number2)
    {
        int roznica = number1 - number2;
        Console.WriteLine(roznica);
    }
    static int mnozenie(int number1, int number2)
    {
        int iloczyn = number1 * number2;
        return iloczyn;
    }
    static void dzielenie(int number1, int number2)
    {

        if (number2 == 0)
        {
            Console.WriteLine("nie dziel przez 0");
        }
        int result = number1 / number2;
        Console.WriteLine(result);
    }



    static void Main(string[] args)
    {
        Console.WriteLine("Podaj numer działania:");
        Console.WriteLine("1. dodawanie");
        Console.WriteLine("2. odejmowanie");
        Console.WriteLine("3. mnożenie");
        Console.WriteLine("4. dzielenie");
        int nrdialania = int.Parse(Console.ReadLine());
        switch (nrdialania)
        {
            case 1:
                {

                    Console.WriteLine("podaj liczby do dodawania");
                    int number1 = int.Parse(Console.ReadLine());
                    int number2 = int.Parse(Console.ReadLine());
                    dodawanie(number1, number2);
                    break;
                }
            case 2:
                {
                    Console.WriteLine("podaj liczby do odjemowania");
                    int number1 = int.Parse(Console.ReadLine());
                    int number2 = int.Parse(Console.ReadLine());
                    odejmowanie(number1, number2);
                    break;
                }
            case 3:
                {
                    Console.WriteLine("podaj liczby do mnozenia");
                    int number1 = int.Parse(Console.ReadLine());
                    int number2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("wynik mnozenia " + mnozenie(number1, number2));
                    break;
                }
            case 4:
                {
                    Console.WriteLine("podaj liczby");
                    int number1 = int.Parse(Console.ReadLine());
                    int number2 = int.Parse(Console.ReadLine());
                    dzielenie(number1, number2);
                    break;
                }

        }
    }
}
