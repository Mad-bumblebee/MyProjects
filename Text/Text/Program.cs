using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Program document = new Program();
            document.ReadText();

        }
        public void ReadText()
        {
            int count, max = 0;

            string txt = File.ReadAllText("doc.txt", Encoding.GetEncoding(1251));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Исходный текст : ");
            Console.ResetColor();
            string[] lines = txt.Split(new char[] { '\r', '\n', '.', '!', '?', ' ', ',', '-', ':', '(', ')', '<', '>', '"' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < txt.Length; i++)
            {

                Console.Write(txt[i]);

            }
            Console.Write("\n");
            string word = null;
            string oft = null; ;
            Console.ForegroundColor = ConsoleColor.Yellow;

            List<int> num = new List<int>();
            List<string> words = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {                
                count = 0;
                
                for (int j = -1; j < lines.Length - 1; j++)
                {
                    if (string.Equals(lines[i], lines[j + 1], StringComparison.InvariantCultureIgnoreCase))
                    {
                        word = lines[i];
                        words.Add(word);
                        count++;
                    }                   
                }                

                num.Add(count);

                if (count > max)
                    max = count;

                if (words.Count >= max)
                    oft = word;

                words.Clear();             
                
               // Console.WriteLine("Слово {0} повторяется {1} раз", word.ToUpper(), count);
            }
            Console.Write("\n");
           
            Console.WriteLine("Самое часто встречающееся cлово {0} повторяется {1} раз", oft.ToUpper(), num.Max(), Console.ForegroundColor = ConsoleColor.Red);
            Console.ResetColor();
            
        }

    }
}
