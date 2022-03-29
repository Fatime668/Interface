using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Word word = new Word();
            Pdf pdf = new Pdf();
            Excel excel = new Excel();
            MainPrintFile mainPrint = new MainPrintFile(word,excel,pdf);

        }
    }
}
