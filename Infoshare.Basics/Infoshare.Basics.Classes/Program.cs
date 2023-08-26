namespace Infoshare.Basics.Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Stwórz obiekt klasy ProductRepository. Wywołaj na nim metodę Get() i przypisz jej wynik do zmiennej Product product. Wyświetl nazwę produktu.

            
            //2. Stwórz klasę Point
            //Klasa powinna mieć dwie właściwości typu int: X i Y
            //Konstruktor klasy powinien przyjmować na wejściu dwie wartości int x i int y, które powinny zostać przypisane do właściwości X i Y.
            //Klasa Point powinna mieć metodę Sum, która sumuje wartości X oraz Y i zwraca wynik sumowania
            //Stwórz obiekt Point i wywołaj metodę Sum(). Rezultat metody Sum wyświetl na konsoli.


            //3. Stwórz klasę Address
            //Klasa Address powinna mieć właściwości:
            //Country (string)
            //City (string)
            //Street (string)
            //StreetNumber (int)
            //Jeżeli StreetNumber jest większy od 99, to ustaw mu wartość 99 (w setterze), StreetNumber musi posiadać backing field.


            //4. Stwórz klasę Document
            //Klasa powinna mieć właściwości:
            //Title (string) <- posiada tylko getter
            //Body (string) <- posiada tylko getter
            //Owner (string) <- posiada getter i setter
            //Title i Body posiadają backing field
            //Title i Body są ustawiane w konstruktorze na podstawie parametrów podanych na wejściu.


            //5. Napisz klasę Calculator
            //Klasa powinna posiadać dwa pola prywatne definiowane w konstruktorze
            //Number1 (double)
            //Number2 (double)
            //Napisz metody:
            //Sum() <- zsumuj Number1 i Number2 i zwróć wynik
            //Substract()  <- odejmij Number1 od Number2 i zwróć wynik
            //Multiply()  <- pomnóż Number1 razy Number2 i zwróć wynik
            //Divide()  <- podziel Number1 podziel Number2 i zwróć wynik
            //Każda metoda powinna mieć parametr wejściowy typu out string message, do którego wewnątrz metody powinna zostać przypisana wiadomość: "Wywołano metodę XYZ"

            
            //6. Napisz klasę statyczną WelcomeMessager
            //Klasa powinna mieć jedną metodę statyczną GetWelcomeMessage. Metoda powinna mieć jeden parametr wejściowy typu string - name.
            //Metoda powinna zwracać wiadomość "Witamy, {name}"
        }
    }
}