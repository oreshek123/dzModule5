using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace dzModule5
{
    class Program
    {
        private static string URL = "https://Nastya//uuuu";
        static void Main(string[] args)
        {
            #region Zadanie1
            //try
            //{
            //    string someText = "";
            //    HttpWebRequest _httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
            //    using (HttpWebResponse _httpResponse = (HttpWebResponse)_httpWebRequest.GetResponse())
            //    {
            //        using (StreamReader _reader = new StreamReader(_httpResponse.GetResponseStream()))
            //        {
            //            someText = _reader.ReadToEnd();
            //            _reader.Close();
            //        }

            //        _httpResponse.Close();
            //    }

            //    Console.WriteLine(someText);


            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);

            //}
            //finally { Console.ReadLine(); }



            #endregion

            #region Zadanie2

            Zadanie2();

            #endregion

            #region Zadanie3Vizov

            //Zadanie3 zadanie3 = new Zadanie3()
            //{
            //    IsBlocked = true
            //};
            //zadanie3.CatchException(zadanie3);

            #endregion

            #region Zadanie4

            try
            {
                Zadanie4 test = new Zadanie4();
                test.Test();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion

            Console.ReadLine();
        }

        #region Zadanie2
        public static void Zadanie2()
        {
            int[] mass;
            try
            {
                mass = new int[5];
                for (int i = 0; i < 6; i++)
                {
                    Console.Write(mass[i] + " ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Завершение обработки массива");
            }
        }
        #endregion

    }

    #region Zadanie3
    public class Zadanie3
    {
        public int Number { get; set; }
        public int Balance { get; set; }
        public bool IsBlocked { get; set; }

        public static void ThrowException(Zadanie3 zadanie3)
        {
            if (zadanie3.IsBlocked)
            {
                throw new Exception("Аккаунт заблокирован");
            }
        }
        public void CatchException(Zadanie3 zadanie3)
        {
            try
            {
                ThrowException(zadanie3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    #endregion



    #region Zadanie4
    public class People
    {
        public int Answer { get; set; }
        public int Result { get; set; }
    }
    public class Zadanie4
    {
        private People Nastya { get; set; }
        private People Egor { get; set; }
        public int NumberOfTestQuestions { get; set; }
        public Zadanie4()
        {
            Nastya = new People();
            Egor = new People();
        }
        public static void WhoIsBest(People nastya, People egor)
        {
            if (nastya.Result < egor.Result)
            {
                throw new Exception("Nastya is best polubomu");
            }

            Console.WriteLine("Nastya is the best of the best of the best))))");
        }

        public void Test()
        {
            Console.WriteLine("Please enter number of test questoins");
            Int32.TryParse(Console.ReadLine(), out int numberOfTestQuestions);
            NumberOfTestQuestions = numberOfTestQuestions;
            Random random = new Random();
            while (NumberOfTestQuestions != 0)
            {
                int number1 = random.Next(1, 10);
                int number2 = random.Next(1, 10);
                Console.WriteLine($"{number1} + {number2} = ");
                Console.WriteLine("Nastya's turn");
                Nastya.Answer = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Egor's turn");
                Egor.Answer = Int32.Parse(Console.ReadLine());
                if (Nastya.Answer == number1 + number2)
                {
                    Nastya.Result++;
                }
                else if (Egor.Answer == number1 + number2)
                {
                    Egor.Result++;
                }
                NumberOfTestQuestions -= 1;

            }
            WhoIsBest(Nastya, Egor);


        }

        #endregion

    }


    
}
