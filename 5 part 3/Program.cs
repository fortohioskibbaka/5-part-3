using System.Runtime.CompilerServices;

namespace _5_part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string president;
            int score = 0;
            string answwer2;
            string answwer3;




            Console.WriteLine("hello today we have a pop quiz i wish you luck");
            Console.WriteLine("number 1 who is the US preident");
            president = Console.ReadLine().ToLower();

            if (president == "joe biden")
            {

                Console.WriteLine("wow 1 for 1 you recive 10 points");

                score = 10;




            }
            Console.WriteLine();
            Console.WriteLine("this is your score " + score);

            Console.WriteLine("second question is   mount everest is the highest mountian in the world   true or false");
            answwer2 = Console.ReadLine().ToLower();

            if (answwer2 == "true")
            {
                Console.WriteLine(" correct wow you are on a roll");
                Console.WriteLine("thats another 10 points");

                score = 20;







            }
            Console.WriteLine("this is your score " + score);
            Console.WriteLine();




            Console.WriteLine("ok on the question 3 lets see what your made of ");

            Console.WriteLine("what is the tallest animal");
            Console.WriteLine(" A lion");
            Console.WriteLine(" B pig");
            Console.WriteLine(" C dog");
            Console.WriteLine(" D giraffe");
            answwer3 = Console.ReadLine().ToLower();
            Console.WriteLine("");
             if (answwer3 == "d")
            {
                Console.WriteLine("good job thats right another 10 points");

                score =  score + 10;




            }
            if (answwer3 == "a")
            {

                Console.WriteLine("nope a lion is not the tallest");


                score = score;


            }
            



            if (answwer3 == "b")
            {

                Console.WriteLine("nope a pig is not the tallest");


                score = score;


            }
           


             if (answwer3 == "c  ")
            {

                Console.WriteLine("nope a dog is not the tallest");


                score = score;


            }
            Console.WriteLine("this is your score  " + score);

        }
    }
}
