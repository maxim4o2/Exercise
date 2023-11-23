using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)

        {
            //Две променливи, на които задаваме стойности.//
            string name = "Maxim";
            int a = 17;

            //Правим проверка дали int a>18, ако е да, да се изпише "Пълнолетен",ако ли не да се изпише "Непълнолетен".//
            if (a > 18)
            {
                Console.WriteLine("Пълнолетен");
            }
            else
            {
                Console.WriteLine("Непълнолетен");
            }

            //Правим цикллична конструкция ,която да добавя +1 към променливата, докато променливата стане >=10.//
            for (int i = 0; i <= 10; i = i + 1)
            {
                Console.WriteLine(i);
            }

            //Декларираме масиви със стойности - "Зелен", "Син", "Червен". Променяме "Син" на "Жълт". С foreach цикъл изписваме всички елементи.//
            string[] colors = { "Зелен", "Син", "Червен" };
            colors[1] = "Жълт";
            foreach (string el in colors)
            {
                Console.WriteLine(el);
            }

            //Декларираме празен масив с място за 5 елемента//

            string[] colors2 = new string[5];

            Spawn();
            Sayhello(Console.ReadLine());
            Sum(2, 4);
        }
        public static void Spawn()
        {
            Console.WriteLine("Аз съм функция");
        }
        public static void Sayhello(string name)
        {
           
            Console.WriteLine("ZDR " + name);
        }
        public static int Sum(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }
       
        
    }
}
