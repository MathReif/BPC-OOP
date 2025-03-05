using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv04
{
    internal class StringStatistics
    {
        private string text;
        private int words = 0;
        private int rows = 0;
        private int sentence = 0;

        public StringStatistics(string text)
        {
            this.text = text;
        }
        public void CountWords()
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ' || text[i] == '\n')
                {
                    words++;
                }
            }
            words++;
            Console.WriteLine("Pocet slov: " + words);
        }
        public void CountRows()
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '\n')
                {
                    rows++;
                }
            }
            rows++;
            Console.WriteLine("Pocet riadkov: " + rows);
        }

        public void CountSentence()
        {
            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i] == '.' && (text[i + 1] == '\n' || i == text.Length || !Char.IsUpper(text[i + 2]))) || text[i] == '!' || text[i] == '?')
                {
                    sentence++;
                }
            }
            Console.WriteLine("Pocet viet: " + sentence);
        }
        public void Longest()
        {
            string[] wordArray = text.Split(new char[] { ' ', '\n', '.', '!', '?', '(', ')', ',' }, StringSplitOptions.RemoveEmptyEntries);
            wordArray = wordArray.OrderByDescending(word => word.Length).ToArray();

            /*int longest = 0;
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > longest)
                {
                    longest = words[i].Length;
                    longer = words[i];
                }
            
            }
                Console.WriteLine("Najdlhsie slova: " + longer)
            */
            Console.WriteLine("Najdlhsie slova: ");
            for (int i = 0; i < wordArray.Length; i++)
            {
                if (wordArray[i].Length == wordArray[0].Length)
                {
                    Console.Write(wordArray[i] + ", ");
                }
            }
            ;
        }
        public void Shortest()
        {
            //string[] wordArray = text.Split(' ');
            string[] wordArray = text.Split(new char[] { ' ', '\n', '.', '!', '?', '(', ')', ',' }, StringSplitOptions.RemoveEmptyEntries);

            wordArray = wordArray.OrderBy(word => word.Length).ToArray();

            //int shortest = int.MaxValue;
            /*
            for (int i = 0; i < wordArray.Length; i++)
            {
                if(wordArray[i].Length < shortest && wordArray[i].Length > 0)
                {
                    shortest = wordArray[i].Length;
                    shorter = wordArray[i];
                }
            }
*/
            Console.WriteLine("\nNajkratsie slova: ");
            for (int i = 0; i < wordArray.Length; i++)
            {
                if (wordArray[i].Length == wordArray[0].Length)
                {
                    Console.Write(wordArray[i] + ", ");
                }
            }

            //Console.WriteLine("Najkratsie slova: "+shorter);
        }
        public void Alphabeticaly()
        {
            string[] wordArray = text.Split(new char[] { ' ', '\n', '.', '!', '?', '(', ')', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(wordArray);
            Console.WriteLine("\nSlova v abecednom poradi: ");
            for (int i = 0; i < wordArray.Length; i++)
            {
                Console.Write(wordArray[i] + ", ");
            }
            Console.WriteLine(); // Add a new line at the end
        }
        public void napis()
        {
            Console.WriteLine(words);
        }
    }
}

