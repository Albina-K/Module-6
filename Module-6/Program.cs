using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

            /*
            object o = null
            Human human = null;
            human.age = 23;
            if (homan != null)
            {
            Console.WriteLine(human.age);

            тоже самое можно записать так:

            Human human = null;
            Console.WriteLine(human?.age);

            в случае, если human будет равен null, то и значение выражения human?.age будет равна null
             */
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

        public int Square()
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

    /*  class Employee
      {
          public Department Department;

      }
    */

    class Department
    {
        public Company Company;
        public City City;
    }

    class Company
    {
        public string Type;
        public string Name;
    }

    class City
    {
        public string Name;
    }


    class Program3
    {
        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();
        }

        static Department GetCurrentDepartment()
        {
            if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
            }
        }
    }
    class Program2
    {

        static void Main(string[] args)
        {
            /*   Employee employee = new Employee();
               string name;
               if (employee != null && employee.Department != null && employee.Department.Company != null)
               {
                   name = employee.Department.Company.Name;
               }
            */

            //как записать тоже самое с использованием ?
            Employee employee = new Employee();
            string name = employee?.Department?.Company?.Name;





            /* объединения - ??.
             возвращает левый операнд если не равен null, иначе — правый.При этом левый операнд должен принимать null.

             object first = null;
            object second = first ?? 100;
             это же работает и с классами
            Human human = null;
            Human nwHuman = human ?? new Human("Дмитрий", 23)
            */


        }

    }
    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if (Load.HasValue && Load > 0)
            {
                Console.WriteLine("В автобусе количество пассажиров {0}", Load.Value);
            }
            else
            {
                Console.WriteLine("Автобус пуст");
            }
        }
    }

    class Car
    {
        public double Fuel;
        public int Mileage;
        public Car()
        {
            Fuel = 50;
            Mileage = 0;
        }

        public void Move()
        {
            Mileage++;
            Fuel -= 0.5;
        }

        public void FillTheCar()
        {
            Fuel = 50;
        }
    }

    class Circle
    {
        public double radius;
    }

    class Square
    {
        public int site;

    }

    class Triangle
    {
        public int a;
        public int b;
        public int c;
        static void Main(string[] args)
        {
            int S = sitea *
        }
    }
    enum TurnDirection
    {
        None = 0,
        Left,
        Right
    }

    class Car2
    {
        private double Fuel;

        private int Mileage;

        private string color;

        private TurnDirection turn;

        public Car2()

        {
            Fuel = 50;
            Mileage = 0;
            color = "red";
        }

        private void Move() 
        {
            Mileage++;
            Fuel -= 0.5;
        }

        private void Turn(TurnDirection direction)
        {
            turn = direction;
        }
        private void FillTheCar() 
        {
            Fuel = 50;
        }

        private string GetColor()
        {
            return color;
        }

        private void ChengeColor(string newColor) 
        {
        if (color != newColor) 
            color = newColor;
        }

        public bool IsTurningLeft()
        { 
            return turn == TurnDirection.Left;
        }
        public bool IsTurningRight() 
        {  
            return turn == TurnDirection.Right;
        }
    }

    class TrafficLight
    {
        private void ChangeColor(string newcolor)
        {
            string color = newcolor;
        }

        public string GetColor() 
        {
            return ChangeColor();
        }
    }

    //свойства
    class User
    {
        private int age;
        private string login;
        private string mail;

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Логин должен быть не менее 3 символов");
                }
                else 
                { 
                    login = value;
                }
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }
            //проверка на содержание символа
            set
            {
                if (!value.Contains ('@'))
                {
                    Console.WriteLine("Неверный формат");
                }
                else
                {
                    login = value;
                }
            }
        }
        //если не нужно иметь особую логику
        class User32
        {
            public string Login { get; private set; }
            public int Age { private get; set; }
        }

        public int Age
        {
            //геттер
            get 
            { 
                return age; 
            } 
            //сеттер
            set 
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                } 
                else    
                {
                age = value;
                }

                
            }
        }
    }

    class Program4
    {
        static void Main(string[] args)
        {
            User user = new User();
            //сеттер
            user.Age = 50;

            //геттер
            Console.WriteLine(user.Age);

            Console.ReadKey();
        }
    }

}


