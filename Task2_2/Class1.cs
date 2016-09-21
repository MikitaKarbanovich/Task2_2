using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    class WorkWithStrings
    {
        public ArrayList ParseText(string text)
        {
            ArrayList sentences = new ArrayList();
            char[] delimiterChars = {' '};
            System.Console.WriteLine("Original text: '{0}'", text);
            sentences.AddRange(text.Split(delimiterChars));
            return sentences;
        }
        public ArrayList ReadStringFromKeyboard()
        {
            ArrayList sentences = new ArrayList();
            string keyboardInput = "";
            Console.WriteLine("If you want exit, enter exit in new string:");
            while (!keyboardInput.Equals("exit"))
            {
                keyboardInput = Console.ReadLine();
                if (!keyboardInput.Equals("exit"))
                {
                    sentences.Add(keyboardInput);
                }
            }
            return sentences;
        }
        public InfoAboutString CheckWord(ArrayList words)
        {
            int intCounter=0;
            int intSum=0;
            int doubleCounter = 0;
            double doubleSum = 0;
            int intValue;
            double doubleValue;
            double averageOfInts = 0;
            double averageOfDoubles = 0;
            ArrayList intStrings = new ArrayList();
            ArrayList doubleStrings = new ArrayList();
            ArrayList otherStrings = new ArrayList();
            InfoAboutString info = new InfoAboutString();
    
            foreach (string word in words)
            {
                if (int.TryParse(word, out intValue))
                {
                    intStrings.Add(word);
                    intSum+= intValue;
                    intCounter++;
                }
                else if (double.TryParse(word, out doubleValue))
                {
                    doubleStrings.Add(word);
                    doubleSum+= doubleValue;
                    doubleCounter++;
                }
                else
                {
                    otherStrings.Add(word);
                }
            }
            otherStrings.Sort();
            averageOfInts =(double) intSum / (double)intCounter;
            averageOfDoubles = doubleSum / (double)doubleCounter;
            info.AverageOfInts = averageOfInts;
            info.AverageOfDoubles = averageOfDoubles;
            info.IntStrings = intStrings;
            info.DoubleStrings = doubleStrings;
            info.OtherStrings = otherStrings;
            return info;
        }
        public void ConsoleWritter(InfoAboutString info)
        {
            Console.WriteLine("Number of integers: '{0}'", info.IntCounter);
            Console.WriteLine("Integers:".PadLeft(15));
            foreach (string intString in info.IntStrings)
            {
                Console.WriteLine("'{0}'".PadLeft(15), intString);
            }
            Console.WriteLine("Average of integers: '{0:0.##}'".PadLeft(15), info.AverageOfInts);
            Console.WriteLine("Number of doubles: '{0}'", info.DoubleCounter);
            Console.WriteLine("Doubles:".PadLeft(15));
            foreach (string doubleString in info.DoubleStrings)
            {
                Console.WriteLine("'{0}'".PadLeft(15), doubleString);
            }
            Console.WriteLine("Average of doubles: '{0:0.##}'", info.AverageOfDoubles);
            Console.WriteLine("Strings:");
            foreach (string outString in info.OtherStrings)
            {
                Console.WriteLine("{0}", outString);
            }
        }
    }
}
