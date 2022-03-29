using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class MainPrintFile
    {
        public string Word { get; set; }
        public string Excel { get; set; }
        public string Pdf { get; set; }
        public MainPrintFile(Word word,Excel excel,Pdf pdf)
        {
            Word = word.Print();
            Excel = excel.Print();
            Pdf = pdf.Print();
        }
    }
}
