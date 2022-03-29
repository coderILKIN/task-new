using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_
{
    class MainPrintFile
    {
        public string Word { get; set; }
        public string Excell { get; set; }
        public string Pdf { get; set; }





        public MainPrintFile(Word word, Excel excel, PDF pdf)
        {
            Word = word.Print();
            Excell = excel.Print();
            Pdf = pdf.Print();

        }


    }
}
