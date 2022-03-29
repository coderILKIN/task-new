using System;

namespace Task1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Word word = new Word();
            Excel excel = new Excel();
            PDF pdf = new PDF();
            MainPrintFile mainFile = new MainPrintFile(word, excel, pdf);
            Console.WriteLine(mainFile.Word);
            Console.WriteLine(mainFile.Excell);
            Console.WriteLine(mainFile.Pdf);


        }
    }
}
