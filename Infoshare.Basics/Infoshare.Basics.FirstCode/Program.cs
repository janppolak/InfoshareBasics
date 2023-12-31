﻿using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace Infoshare.Basics.FirstCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Przypisz do zmiennej typu int dowolną liczbę i wyświetl ją na konsoli w formacie "Twoja szczesliwa liczba to X"

            int number = 10;

            Console.WriteLine($"Your lucky number is: {number}");

            //2. Przypisz do dwóch zmiennych typu int dwie dowolne liczby. Jedna zmienna powinna się nazywać number, druga luckyNumber.
            //Jeżeli liczba number jest taka sama jak luckyNumber zwróć: Bingo, wygrales!
            //Jeżeli liczby się różnią zwróć: Sprobuj ponownie!

            int numberExercise2 = 5;
            int luckyNumberExercise2 = 10;

            if (numberExercise2 == luckyNumberExercise2)
            {
                Console.WriteLine("Bingo, you won!");
            }
            else
            {
                Console.WriteLine("Try again!");
            }


            //3. Przypisz do zmiennej typu int dowolną liczbę oznaczającą wiek.
            //Jeżeli liczba jest większa lub równa 18, wyświetl: Jestes dorosly.
            //Jezeli liczba jest mniejsza od 18, ale większa lub równa 0, wyświetl: Jestes dzieckiem
            //Inaczej wyświetl: Błąd

            var age = 34;

            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else if (age < 18 && age <= 0)
            {
                Console.WriteLine("You are a child.");
            }
            else
            {
                Console.WriteLine("Incorrect input.");
            }

            //4. Przypisz do zmiennej typu int dowolną liczbę oznaczającą wiek.
            //Przypisz do zmiennej typu char literę 'K', lub 'M' oznaczającą płeć.
            //Jeżeli wiek jest większy lub równy 18 i płeć jest K wyświetl: Jestes kobieta
            //Jeżeli wiek jest większy lub równy 18 i płeć jest M wyświetl: Jestes mezczyzna
            //Jezeli liczba jest mniejsza od 18, ale większa lub równa 0, wyświetl: Jestes dzieckiem
            //Inaczej wyświetl: Błąd

            var ageExercise4 = 15;
            var gender = 'K';

            if (ageExercise4 >= 18)
            {
                if (gender == 'M')
                {
                    Console.WriteLine("You are a male.");
                }
                else if (gender == 'K')
                {
                    Console.WriteLine("You are a female.");
                }
            }
            else if (ageExercise4 < 18 && ageExercise4 >= 0)
            {
                Console.WriteLine("You are a child.");
            }
            else
            {
                Console.WriteLine("Incorrect input.");
            }


            //5. Napisz prosty kalkulator, obsługiwany za pomocą pętli switch. Na wejściu podaj liczby (double) a i b oraz znak (char) sign.
            //W zależności od wartości znaku (sign), wykonaj powiązaną operację i przypisz jej rezultat do zmiennej result.
            //Dostępne operacje: +,-,/,*

            //double inputA = 1;
            //double inputB = 6;

            //char choosenOperator;

            //do
            //{
            //    Console.Write("Insert operator: +, -, / or *: ");
            //    char.TryParse(Console.ReadLine(), out choosenOperator);
            //} while (choosenOperator != '+' && choosenOperator != '-' && choosenOperator != '*' && choosenOperator != '/');


            //var calculateResult = Calculate(choosenOperator, inputA, inputB);
            //DisplayResult(calculateResult);

            //static double Calculate(char op, double inputA, double inputB)
            //{
            //    switch (op)
            //    {
            //        case '+': return inputA + inputB;
            //        case '-': return inputA - inputB;
            //        case '/': return inputA / inputB;
            //        case '*': return inputA * inputB;
            //        default: throw new ArgumentException("Invalid operator: {0}");
            //    }
            //}

            //static void DisplayResult(double result)
            //{
            //    Console.WriteLine($"The result is: {result}");
            //}


            //6. Napisz prosty program do naliczania rabatów w sklepie.
            //Do zmiennej decimal price jest przypisana cena produktu.
            //Do zmiennej int discount jest przypisana liczba z przedziału od 1-100 oznaczająca procent zniżki
            //Do zmiennej string promoCode jest przypisany kod promocyjny
            //Jeżeli kod promocyjny jest równy "DISCOUNT10" albo "BLACKFRIDAY20" zniżka powinna zostać naliczona
            //W innym wypadku zniżka nie powinna zostać naliczona

            //decimal price = 100m;
            //int discount = 20;
            //string promoCode = "BLACKFRIDAY20";

            //if (promoCode == "DISCOUNT10")
            //{
            //    price = price - price * ((decimal)discount / 100);
            //}


            //Console.WriteLine($"Promo price = {price}");



            //7. Napisz prosty program wyliczający podwyżki dla pracowników firmy.
            //int efficiency oznacza efektywność pracownika.
            //float salary oznacza obecną pensję
            //jeżeli efektywność pracownika jest w przedziale od 0 do 100 to podwyżka nie jest naliczana
            //jeżeli efektywność pracownika jest w przedziale od 101 do 125 to podwyżka wynosi 10%
            //jeżeli efektywność pracownika jest w przedziale od 126 do 150 to podwyżka wynosi 15%
            //jeżeli efektywność pracownika jest powyżej 151 to podwyżka wynosi 20%
            //wynikiem jest pensja po podwyżce

            //int efficiency = 120;
            //float salary = 5000f;

            //if (efficiency > 100 && efficiency <= 125)
            //{
            //    salary = salary * 1.1f;
            //}
            //else if (efficiency > 125 && efficiency <= 150)
            //{
            //    salary = salary * 1.15f;
            //}
            //else if (efficiency > 150)
            //{
            //    salary = salary * 1.2f;
            //}

            //Console.WriteLine(salary);

            //8. Napisz kalkulator BMI. Na wejściu otrzymujesz 2 wartości:
            //decimal weight
            //decimal height
            //Wzór na wyliczenie BMI to: weight/(height^2)
            //W zależności od wyliczonej wartości zwróć:
            // "niedowaga" gdy BMI < 18.5
            // "waga prawidłowa" gdy BMI >= 18.5 i BMI <= 24.9
            // "nadwaga" gdy BMI > 24.9 i BMI <= 29.9
            // "otyłość" gdy BMI > 29.9

            decimal weight = 91.5m;
            decimal height = 1.8m;
            //decimal BMI = weight * decimal.Parse(Math.Pow(2, 2));
            decimal BMI = weight / (height * height); // czy jest jakiś ładnieszy sposób na zrobienie potęgi? Nie czaję, dlaczego nie można zrobić tego jak w linijce wyżej.

            if (BMI < 18.5M)
            {
                Console.WriteLine("Niedowaga");
            }
            else if (BMI >= 18.5M && BMI <= 24.9M)
            {
                Console.WriteLine("Waga prawidłowa");
            }
            else if (BMI > 24.9M && BMI <= 29.9M)
            {
                Console.WriteLine("Nadwaga");
            }
            else
            {
                Console.WriteLine("Otyłość");
            }

            //DODATKOWE
            //1. Papier kamień nożyce. Na wejściu przyjmij dwie wartości typu char, dopuszczalne wartości to
            //p - papier
            //k - kamień
            //n - nożyce
            //Jako wynik podaj rezultat rozgrywki. Jeżeli wygrywa gracz pierwszy zwróć "w1", jeżeli drugi - "w2", a przypadku remisu zwróć "r"

            //Console.Write("Wybierz: P, K lub N: ");
            //char.TryParse(Console.ReadLine(), out char input);

            //Console.Write("Ponownie wybierz: P, K lub N: ");
            //char.TryParse(Console.ReadLine(), out char input2);

            //if (input == 'P' && input2 == 'K' || input2 == 'P' && input == 'K')
            //{
            //    Console.WriteLine("Papier wygrywa");
            //}
            //else if (input == 'N' && input2 == 'K' || input2 == 'N' && input == 'K')
            //{
            //    Console.WriteLine("Kamień wygrywa");
            //}
            //else if (input == 'P' && input2 == 'N' || input2 == 'P' && input == 'N')
            //{
            //    Console.WriteLine("Nożyce wygrywają");
            //}
            //else
            //{
            //    Console.WriteLine("Remis");
            //}


            //2. Policz powierzchnię bryły o wymiarach x,y,z. Jeżeli którykolwiek z wymiarów jest mniejszy bądź równy 0, zwróć komunikat: "BLAD!"

            var a = 10;
            var b = 0;
            var c = 10;

            if (a != 0 && b != 0 && c != 0)
            {
                var volume = a * b * c;
                Console.WriteLine(volume);
            }
            else
            {
                Console.WriteLine("error");
            }

            //3. Sprawdź czy trójkąt jest prostokątny. Na wejściu podane są liczby a, b, c. Wyznacz która długość jest najdłuższa i skorzystaj z wzoru a^2 + b^2 = c^2,
            // Jeżeli trójkąt jest prostokątny to zwróć 'T', inaczej zwróć 'F'

            // nie czaję

            //4. Na wejściu przyjmij dwie wartości typu int: x i y, są to długości boków prostokąta. Jeżeli boki są równe zwróć "kwadrat", jeżeli nie zwróć "prostokat"
        }
    }
}