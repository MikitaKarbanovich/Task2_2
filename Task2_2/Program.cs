using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoAboutString info = new InfoAboutString();
            WorkWithStrings wws = new WorkWithStrings();
            ArrayList text = new ArrayList();
            ArrayList words = new ArrayList();
            text = wws.ReadStringFromKeyboard();
            foreach (string sentence in text)
            {
                words=wws.ParseText(sentence);
                info = wws.CheckWord(words);
                wws.ConsoleWritter(info);
            }
        }
    }
}
