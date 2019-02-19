using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;


namespace Milky_Way
{
    class Program
    {
        static void Main(string[] args)
        {
            Snowflake snowflake = new Snowflake();
            
            snowflake.CreateFile();
            Thread.Sleep(3000);

            snowflake.ReadFile();

            Console.ReadKey();
           
        }
    }

    class Snowflake
    {
        Random rand = new Random();
        private string namein = "input.txt";
        private string nameout = "output.txt";
                
        public void CreateFile()
        {            
            int N = rand.Next(0, 101);
            string line = N.ToString();

            File.WriteAllText(namein, "Число строк = ", Encoding.GetEncoding (1251));
            File.AppendAllText(namein, line);
            File.AppendAllText(namein, "\n");

            var str = new StreamWriter("input.txt", true);
            
            int num;
            int[,] arr = new int[N, 5];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    num = rand.Next(0, 2);
                    arr[i, j] += num;
                    
                    str.Write(arr[i, j]);
                }
                str.WriteLine();                
            }
            str.Close();
            Console.WriteLine("Файл {0} создан", namein);
                        
        }

        public void ReadFile()
        {
            int count = 0;
            string line = null;
            string[] arr = File.ReadAllLines("input.txt");
            for (int i = 1; i <arr.Length; i++)
            {
                line += arr[i];
            }

      
            foreach (char s in line)
            {
                if (s == '1')
                    count++;
            }

            File.WriteAllText(nameout,"Количество дорог на планете Snowflake = " , Encoding.GetEncoding(1251));
            File.AppendAllText(nameout, Convert.ToString(count));
            Console.WriteLine("Данные считаны из файла {0} и записаны в файл {1} ", namein, nameout);
        }



    }
}

    


