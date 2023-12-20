using System;

namespace KatoApp
{

    class Program
    {
        static void Main(string[] args)
        {

            //Nadanie zmiennej int wartości
            int liczba = 14;


            //Porównanie zmiennych przy użyciu operatora 
            if (liczba > 0)
            {
                Console.WriteLine(liczba + " jest liczbą dodatnią"); //Wyświetlenie komunikatu, gdy liczba jest dodatnia
            }
            else if (liczba < 0)
            {
                Console.WriteLine(liczba + " jest liczbą ujemną"); //Wyświetlenie komunikatu, gdy liczba jest ujemna
            }
                             
        }

    }


}