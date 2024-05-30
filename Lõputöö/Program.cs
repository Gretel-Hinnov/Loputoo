using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Lõputöö
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.LINQ");
            Console.WriteLine("2.IfAndElse");
            Console.WriteLine("3.NumberPyramid");
            int valik = Convert.ToInt32(Console.ReadLine());

            switch (valik)
            {

                case 1:
                    ThenAndOrderByLINQ();
                    break;

                case 2:
                    IfAndElse();
                    break;
                case 3:
                    NumberPyramid();
                    break;
            }

        }
        static void IfAndElse()
        {
            try
            {
                using (StreamWriter y = new StreamWriter("C:/Users/opilane/Desktop/Äge fail.txt", true))
                {
                    Console.WriteLine("Kirjuta tekst ja see ilmub failile");
                    string reader = Console.ReadLine();
                    if (reader != "")
                    {
                        y.Write(reader);
                        y.Close();
                    }
                    else
                    {
                        StreamWriter k = new StreamWriter("C:/Users/opilane/Desktop/fail.txt");
                        k.Write(reader);
                        k.Close();
                    }
                }
                using (StreamReader sr = new StreamReader("C:/Users/opilane/Desktop/fail.txt"))
                {
                    string reader = sr.ReadToEnd();
                    Console.WriteLine(reader);
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(":(");
            }
        }

        static void ThenAndOrderByLINQ()
        {
            var thenByResult = PeopleList.peoples
            .OrderBy(p => p.Name)
            .ThenBy(y => y.Age);

            Console.WriteLine("ThenBy järgi");
            foreach (var people in thenByResult)
            {
                Console.WriteLine(people.Name + " " + people.Age);
            }
        }

        static void NumberPyramid()
        {
            Console.WriteLine("Kirjuta numbripüramiidi suurus");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}", j);
                }
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write("{0}", j);
                }

                Console.Write("\n");
            }
        }
    }

}
