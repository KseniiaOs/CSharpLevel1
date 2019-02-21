using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace QuestionaryL1
//{
//    class Programm

//    {
//        static void Main()
//        {
//            Console.WriteLine("First Name:");
//            string fn = Console.ReadLine();

//            Console.WriteLine("Second Name:");
//            string sn = Console.ReadLine();

//            Console.WriteLine("Your Age:");
//            int age = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Height:");
//            double height = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Weight:");
//            double weight = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine(fn + " " + sn + " " + age + " " + height + " " + weight);
//            Console.ReadKey();

//        }
//    }

//}



//namespace QuestionaryL2
//{
//    public class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("First Name:");
//            string fn = Console.ReadLine();
//            Console.WriteLine("Second Name:");
//            string sn = Console.ReadLine();
//            Console.WriteLine("Your Age:");
//            int age = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Height:");
//            double height = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Weight:");
//            double weight = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine(String.Format("Your applicationa was accepted as {0} {1} {2} {3} {4}", fn, sn, age, height, weight));
//            Console.ReadKey();

//        }

//    }




    namespace QuestionaryL3
{ 
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("First Name:");
            string fn = Console.ReadLine();
            Console.WriteLine("Second Name:");
            string sn = Console.ReadLine();
            Console.WriteLine("Your Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Height:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Your applicationa was accepted as {fn} {sn} {age} {height} {weight}");
            Console.ReadKey();

        }

    }
}


