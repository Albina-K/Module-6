using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6
{
    class Human
    {
        //поля класса
        public string name;
        public int age;

        //метод класса
        public void Greetings()
        {
            Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
        }

        //конструктор 1 без параметров
        public Human()
        {
            name = "Неизвестно";
            age = 20;
        }

        //конструктор 2 с параметром для того, чтобы присвоить имя
        public Human(string n)
        {
            name = n;
            age = 20;
        }

        //конструктор 3 с двумя параметрами для имени и возраста
        public Human(string n, int a)
        {
            name = n;
            age = 20;
        }
    }

    struct Animal
    {
        //поля структуры
        public string type;
        public string name;
        public int age;

        //метод структуры
        public void Info()
        {
            Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
        }
    }

    class Program

    {
        static void Main(string[] args) 
        {
        Human human = new Human();
            human.Greetings();

            human = new Human("Дмитрий");
            human.Greetings();

            human = new Human("Дмитрий", 23);
            human.Greetings();
/*
            human.name = "test";        
            human.age = 5;
            human.Greetings();
*/

            Console.ReadKey();
        }

    }

    class Pen

    {
        public string color;
            public int cost;
        //конструктор без  параметров
        public Pen()
        {
            color = "Черный";
            cost = 100;

        }

        //конструктор с двумя параметрами
        public Pen(string penColor, int PenCost)
        {
            color = penColor;
            cost = PenCost;
        }


    }

    class Rectangle
    { 
       public int a;
       public int b;

        public int Square( )
        {
            return a * b;
        }

        public Rectangle(int first, int second) 
        {
            a = first;
            b = second;
        }

        public Rectangle(int site)
        {
           a = site;
            b = site;
            
        }

        public Rectangle()
        {
            a = 6;
            b = 4;
        }



    }
}
