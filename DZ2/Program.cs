using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


    //1. Створити базовий абстрактний клас.Мінімум 2 властивості
    //2. Створити два дочірніх класи. Мінімум 3 властивості і всі різних типів
    //3. Створити масив (кількість єлементів вказує користувач)
    //4. Дати користувачеві заповнити масив.Користувач має сам обрати який саме клас (з двох дочірніх) він зараз хоче створити.
    //5. Користувач у будь-який момент заповнення масива може переглянути уже заповнені елементи

namespace DZ2
{
    class Program
    {
        abstract class Noob
        {
            public string FirstName { get; }
            public string LastName { get; }

            public Noob()
            {
               Console.WriteLine("Input name :");
               FirstName = Console.ReadLine();
               Console.WriteLine("Input last name :");
               LastName = Console.ReadLine();
            }

            public void Display()
            {
                Console.WriteLine($"Name : {FirstName}\n" +
                                  $"Surname : {LastName}");
            }
        }

        class Student : Noob
        {
            public int Age { get; }
            public string Speciality { get; }
            public short Perspective { get; }

            public Student()
            {
                Console.WriteLine("Input age :");
                Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Write your speciality :");
                Speciality = Console.ReadLine();
                Console.WriteLine("Write your skill :");
                Perspective = Convert.ToInt16(Console.ReadLine());
            }


            public void Display2()
            {
                Display();
                Console.WriteLine($"Status : Student\n" +
                                  $"Age : {Age}\n" +
                                  $"Speciality : {Speciality}\n" +
                                  $"Perspective : {Perspective}");
            }
        }

        class Junior : Noob
        {
            public int YearExp { get; }
            public string MainLang { get; }
            public short Sallary { get; }

            public Junior()
            {
                Console.WriteLine("Input year of expiriense :");
                YearExp = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Write your main lang of development :");
                MainLang = Console.ReadLine();
                Console.WriteLine("Input your sallary :");
                Sallary = Convert.ToInt16(Console.ReadLine());
            }


            public void Display3()
            {
                Display();
                Console.WriteLine($"Status : Junior\n" +
                                  $"Exp(years) : {YearExp}\n" +
                                  $"Language : {MainLang}\n" +
                                  $"Sallary : {Sallary}");
            }
        }




        static void Main(string[] args)
        {
            int N;
            int counter=0;
            char Key;
            Console.WriteLine("Input number of elements :");
            N = Convert.ToInt32(Console.ReadLine());
            Noob[] arr = new Noob[N];
            while (N > 0)
            {
                Console.WriteLine("Select type of noob : student - 1, junior - 2\n" +
                                  "If you want to see all array press 3");
                Key = Convert.ToChar(Console.ReadLine());
                if (Key == '1')
                {
                    arr[counter] = new Student();
                    counter++;
                    N--;
                }
                else if (Key == '2')
                {
                    arr[counter] = new Junior();
                    counter++;
                    N--;
                }
                else if (Key == '3')
                {
                    for (int i = 0; i < counter; i++)
                    {
                        arr[i].Display();
                    }
                }
            }
           
            Console.ReadKey();
        }
    }
}
