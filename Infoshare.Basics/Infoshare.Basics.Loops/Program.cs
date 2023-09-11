using System.Reflection.Metadata;

namespace Infoshare.Basics.Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Liczba n oznacza ilość kolejnych liczb do wyświetlenia
            //Wyświetl w pętli liczby od 1 do n

            //var n = 10;

            //for (int i = n; i < 50; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //2. Liczby n i m oznaczają przedział <n,m>
            //Wyświetl w pętli liczby od n do m

            //var n = 10;
            //var m = 20;

            //for (int i = n; i < m; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //3. Napisz program wyliczający silnię.

            //int number = 1;
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine(number);
            //    number *= i;

            //}


            //4. Napisz program, który będzie przyjmował na wejściu dowolny ciąg znaków, tak długo aż zostanie podany znak 'e'

            //string input;

            //do
            //{
            //    input = Console.ReadLine();
            //} while (input != "e");



            //5. Napis program, który będzie pobierał z konsoli dowolne liczby, tak długo aż podana zostanie liczba nieparzysta.

            //int input;

            //do
            //{
            //    int.TryParse(Console.ReadLine(), out input);
            //} while (input % 2 == 0);


            //6. Napisz program, który wyświetli listę imion z tablicy
            //Zadeklaruj tablicę z imionami: Marcin, Alicja, Marek, Weronika, Mateusz

            //string[] names = { "Marcin", "Alicja", "Marek", "Weronika", "Mateusz" };

            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}

            //7. Napisz program, który na wejściu dostanie tablicę liczb: 1,7,4,3,2,2,5,8,1
            //Dla każdej liczby dokonaj sprawdzenia:
            //Jeżeli poprzednia liczba w tablicy jest mniejsza od bieżącej liczby, wyświetl "M"
            //Jeżeli poprzednia liczba w tablicy jest większa od bieżącej liczby, wyświetl "W"
            //Jeżeli poprzednia liczba w tablicy jest równa bieżącej liczbie, wyświetl "R"
            //Przyjmijmy, że dla pierwszej liczby w tablicy, liczbą poprzednią jest 0

            //int previousNumber = 0;

            //int[] numbers = { 1, 7, 4, 3, 2, 2, 5, 8, 1 };
            //foreach (var item in numbers)
            //{
            //    if (previousNumber < item)
            //    {
            //        Console.WriteLine("M");
            //    }
            //    else if (previousNumber > item)
            //    {
            //        Console.WriteLine("W");
            //    }
            //    else
            //    {
            //        Console.WriteLine("R");
            //    }
            //    previousNumber = item;
            //}

            //8. Napisz program, który na wejściu przyjmie liczbę n, oznaczającą ilość obiegów pętli
            //W każdym obiegu pętli podaj jedną liczbę i dodaj ją do zmiennej sum
            //Chodzi o wyliczenie sumy wszystkich podanych liczb w pętli

            //Console.Write("Insert number: ");
            //int.TryParse(Console.ReadLine(), out int userInput);

            //int sum = 0;
            //for (int i = 0; i < userInput; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out int num);
            //    sum += num;
            //    Console.WriteLine($"Current sum: {sum}");
            //}

            //9. Napisz program, który na wejściu przyjmie liczbę n, oznaczającą ilość obiegów pętli
            //W każdym obiegu pętli podaj jedną liczbę i:
            //Jeżeli jest parzysta to dodaj ją do zmiennej result
            //Jeżeli jest nieparzysta to odejmij ją od zmiennej result
            //Na koniec wyświetl result na konsoli

            //Console.Write("Insert number: ");
            //int.TryParse(Console.ReadLine(), out int userInput);

            //int sum2 = 0;
            //for (int i = 0; i < userInput; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out int num2);
            //    if (num2 % 2 == 0)
            //    {
            //        sum2 += num2;
            //    }
            //    else
            //    {
            //        sum2 -= num2;
            //    }
            //}
            //Console.WriteLine($"Sum: {sum2}");

            //10. Napisz program, który wyświetli tabliczkę mnożenia dla liczb w zakresie o 1 do 10
            // 1 2 3 4....
            // 2 4 6 8....
            // 3 6 9 12...
            //...


            for (int j = 1; j <= 10; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    var result = j * i;
                    Console.Write($"{result} ");

                }
                Console.WriteLine();
            }



            //DODATKOWE
            //1. Napisz program do liczenia procentu składanego
            //Na wejściu podaj:
            //kwotę (double)
            //procent 1-100
            //ilość lat
            //Wylicz procent składany dla podanych danych

            //2. Napisz program, który na wejściu przyjmie liczbę n, oznaczającą ilość obiegów pętli
            //W każdym obiegu pętli podaj jedną liczbę
            //Na koniec programu wyświetl największą z podanych liczb

            //3. Na wejściu podaj liczbę n oznaczającą liczbę operacji.
            //W pętli podaj n dowolnych liczb. (dodatnich, bądź ujemnych)
            //Jako wynik programu zwróć dwie wartości:
            //Ilość podanych liczb dodatnich (bądź równych 0)
            //Ilość podanych liczb ujemnych

            //4. Napisz program symulujący sklep.
            //Na wejściu podaj liczbę n oznaczającą liczbę operacji
            //Następnie w pętli podawaj:
            //operation - znak operacji 'S' - sprzedaż, 'Z' - zakup
            //amount - kwota otrzymana bądź wydana
            //Jeżeli wykonywana jest operacja sprzedaży, to konto sklepu jest zasilane kwotą 'amount'
            //Jeżeli wykonywana jest operacja zakupu (asortymentu z magazynu), to z konta jest odejmowana kwota 'amount'
            //Po wykonaniu wszystkich obiegów pętli zwracane jest końcowe saldo sklepu
        }
    }
}