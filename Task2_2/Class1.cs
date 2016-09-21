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
            char[] delimiterChars = { ' '};
            System.Console.WriteLine("Original text: '{0}'", text);
            sentences.AddRange(text.Split(delimiterChars));
            return sentences;
        }
        public ArrayList ReadStringFromKeyboard()
        {
            ArrayList sentences = new ArrayList();
            string keyboardInput = "";
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
        public void CheckWord(ArrayList words)
        {
            int intCounter=0;
            int intSum=0;
            int doubleCounter = 0;
            double doubleSum = 0;
            int intValue;
            double doubleValue;
            double averageOfInts = 0;
            double averageOfDoubles = 0;
            ArrayList otherStrings = new ArrayList();
            foreach (string word in words)
            {
                if (int.TryParse(word, out intValue))
                {

                    intSum+= intValue;
                    intCounter++;
                }
                else if (double.TryParse(word, out doubleValue))
                {
                    doubleSum+= doubleValue;
                    doubleCounter++;
                }
                else
                {
                    otherStrings.Add(word);
                    otherStrings.Sort();
                }
            }
            averageOfInts=(double) intSum / (double)intCounter;
            averageOfDoubles = doubleSum / (double)doubleCounter;
            Console.WriteLine("Number of integers: '{0}'", intCounter);
            Console.WriteLine("Average of integers: '{0:0.##}'".PadRight(15), averageOfInts);
            Console.WriteLine("Number of doubles: '{0}'", doubleCounter);
            Console.WriteLine("Average of doubles: '{0:0.##}'", averageOfDoubles);
            Console.WriteLine(otherStrings);

        }
    }
}
