using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FilePrartise
{
    class Program
    {
        public static bool IsFibonacci(int integer)
        {
            int xi_2 = 0, xi_1 = 1, xi = 0;
            while (true)
            {
                xi = xi_1 + xi_2;  
                xi_2 = xi_1;      
                xi_1 = xi;
                if ((integer == xi) || (integer == 0))
                    return true;
                else if (integer < xi)
                    return false;
            }
        }
        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            #region #1
            //uint fibonacci_count = 0;
            //uint prime_count = 0;
            //int[] figures = new int[100];
            //for (int i = 0; i < figures.Length; i++)
            //{
            //    figures[i] = i;
            //}
            //StreamWriter fibonacci = new StreamWriter("Fibonacci.txt", false);
            //StreamWriter prime = new StreamWriter("Prime.txt", false);
            //for (int i = 0; i < figures.Length; i++)
            //{
            //    if (IsFibonacci(figures[i]))
            //    {
            //        fibonacci.WriteLine(figures[i]);
            //        fibonacci_count++;
            //    }
            //    if (IsPrime(figures[i]))
            //    {
            //        prime.WriteLine(figures[i]);
            //        prime_count++;
            //    }

            //}
            //fibonacci.Close();
            //prime.Close();
            //Console.WriteLine("Fibonacci - " + fibonacci_count);
            //Console.WriteLine("Prime - " + prime_count);
            #endregion
            #region #2
            //StreamReader read = new StreamReader("source.txt", Encoding.UTF8);
            //StreamWriter write = new StreamWriter("result.txt",false);
            //string source_text = read.ReadToEnd();
            //Console.WriteLine(source_text);
            //Console.WriteLine("Enter search word:");
            //string search = Console.ReadLine();
            //Console.WriteLine("Enter replacement word:");
            //string replace = Console.ReadLine();
            //string result_text = source_text.Replace(search, replace);
            //Console.WriteLine(result_text);
            //write.WriteLine(result_text);

            //read.Close();
            //write.Close();
            #endregion
            #region #3
            //Console.WriteLine("Enter file path:");
            //StreamReader source = new StreamReader(Console.ReadLine(), Encoding.UTF8);
            //Console.WriteLine("Enter file with ban words:");
            //StreamReader ban_word = new StreamReader(Console.ReadLine(), Encoding.UTF8);

            //string ban = ban_word.ReadToEnd();
            //string text = source.ReadToEnd();
            //string[] ban_array = ban.Split(' ',',');

            //for (int i = 0; i < ban_array.Length; i++)
            //{
            //    text = text.Replace(ban_array[i] + " ", " *** ");
            //}

            //Console.WriteLine(text);
            //source.Close();
            //ban_word.Close();
            #endregion
            #region #4
            //Console.WriteLine("Enter file path:");
            //StreamReader source = new StreamReader(Console.ReadLine(), Encoding.UTF8);
            //string text = source.ReadToEnd();
            //char[] charArray = text.ToCharArray();
            //Array.Reverse(charArray);
            //Console.WriteLine(charArray);
            //StreamWriter reverse = new StreamWriter("reverse.txt", true);
            //reverse.WriteLine(charArray);
            //source.Close();
            //reverse.Close();
            #endregion
            #region #5
            //StreamWriter figures = new StreamWriter("figures.txt",false);
            //Random random= new Random();
            //for (int i = 0; i < 10000; i++)
            //{
            //    figures.WriteLine(random.Next(-99999,99999));
            //}
            //figures.Close();
            //StreamReader figures_read = new StreamReader("figures.txt",Encoding.UTF8);
            //StreamWriter positive = new StreamWriter("positive_figures.txt", false);
            //StreamWriter negative = new StreamWriter("negative_figures.txt", false);
            //uint positive_count = 0, negative_count = 0, twodigit_count = 0, fivedigit_count = 0;
            //int current_figure;
            //String line;
            //while ((line = figures_read.ReadLine()) != null)
            //{
            //    current_figure = Int32.Parse(line);
            //    if (current_figure >= 0)
            //    {
            //        positive.WriteLine(current_figure);
            //        positive_count++;
            //    }
            //    else
            //    {
            //        negative.WriteLine(current_figure);
            //        negative_count++;
            //    }

            //    if((current_figure > 9 && current_figure < 100) || (current_figure < -9 && current_figure > -100))
            //        twodigit_count++;
            //    if ((current_figure > 9999 && current_figure < 100000) || (current_figure < -9999 && current_figure > -100000))
            //        fivedigit_count++;

            //}
            //Console.WriteLine("Positive figures - " + positive_count);
            //Console.WriteLine("Negative figures - " + negative_count);
            //Console.WriteLine("Two-digit figures - " + twodigit_count);
            //Console.WriteLine("Five-digit figures - " + fivedigit_count);

            //figures.Close();
            //positive.Close();
            //negative.Close();
            #endregion


        }



    }
}

