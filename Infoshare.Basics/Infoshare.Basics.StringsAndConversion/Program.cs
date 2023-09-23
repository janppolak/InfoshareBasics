namespace Infoshare.Basics.StringsAndConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string expectedName = "Adam";
            //string input = "adam";
            //if (expectedName.ToLower() == input.ToLower())
            //{

            ////}

            ////1. Zamień wszystkie litery w poniższym tekście na małe litery.

            //string txt1 = "Ala Ma kota";
            //txt1.ToLower();
            //Console.WriteLine(txt1);

            ////2. Zamień wszystkie litery w poniższym tekście na wielkie litery.

            string txt2 = "Ala Ma kota";
            txt2.ToUpper();

            Console.WriteLine(txt2);


            ////3. Usuń niepotrzebne spacje z początku i z końca tekstu.

            //string txt3 = "  Ala Ma kota  ";
            //string txt4 = txt3.Trim();

            //Console.WriteLine(txt4);

            ////4. Zwróć z poniższego tekstu fragment o długości 6 znaków, zaczynający się od 16 znaku poniższego tekstu
            ////Mówiąc prościej: pomiń pierwsze 16 znaków tekstu i zwróć kolejne 6 znaków

            //string txt5 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco";
            //string txt6 = txt5.Substring(16, 6);
            //Console.WriteLine(txt6);


            ////5. Zwróć fragment tekstu zaczynający się od litery 'd'
            //string txt9 = "Lorem ipsum dolor sit amet";
            //int number = txt9.IndexOf("d");
            //string txt10 = txt9.Substring(number);
            //Console.WriteLine(txt10);;

            ////6. Zastąp wszystkie spacje w tekście znakiem '-'

            //string txt7 = "Lorem ipsum dolor sit amet, consectetur";
            //string txt8 = txt7.Replace(" ", "-");
            //Console.WriteLine(txt8);


            //7. Parzyste słowa w zdaniu, zapisanym w tablicy string, zamień na wielkie litery. Następnie złącz wszystkie wyrazy w zdaniu i rozdziel słowa spacjami.

            string[] strings = { "To", "jest", "krótkie", "zdanie" };

            for (int i = 0; i < strings.Length; i++)
            {
                if (i % 2 == 0)
                {
                    strings[i] = strings[i].ToUpper();
                }
            }

            Console.WriteLine(string.Join(' ', strings));


            //foreach (var item in strings)
            //{
            //    if (counter % 2 == 0)
            //    {
            //        item.ToUpper();
            //    }


            //    string newText = string.Join(" ", item2);
            //    Console.WriteLine(item2);
            //    counter++;
            //}

            //8. Na wejściu (z konsoli) przyjmij zmienną n (typu int), będzie ona oznaczała liczbę ciągów znakowych podanych przez użytkownika w kolejnych liniach.
            //W kolejnych obiegach pętli przyjmij (z konsoli) dowolny ciąg znaków. Jeżeli ciąg znaków będzie się składał z samych białych znaków (np. same spacje),
            //to zwróć na konsoli wiadomość "PUSTO", inaczej usuń wszystkie białe znaki z początku i końca ciągu znaków i zwróć tak przetworzony tekst z powrotem na konsoli.

            //int.TryParse(Console.ReadLine(), out var loopCounter);;

            //for (int i = 0; i < loopCounter; i++)
            //{
            //    var input = Console.ReadLine();
            //    if (string.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("Pusto");
            //    }
            //    else
            //    {
            //        string trimmedString = input.Trim();

            //        Console.WriteLine(trimmedString);
            //    }
            //}


            //DODATKOWE
            //1. Zamień co drugą literę w słowie na wielką literę
            string text7 = "bardzodlugieslowo";

            //2. Na wejściu (z konsoli) przyjmij zmienną n (typu int), będzie ona oznaczała liczbę słów podanych przez użytkownika w kolejnych liniach.
            //Jeżeli słowo składa się z samych wielkich liter to zwróć tekst: TRUE, w innym przypadku zwróć: FALSE

            //3. Napisz program, który wyciągnie ze zdania fragment zaczynający się od słowa 'smok' a kończący się słowem 'grozny'
            string text8 = "Ten smok byl bardzo grozny i kazdy sie go bal";
        }
    }
}