using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public enum WorkerType { рабочий, бригадир, менеджер };
    public enum SexType { MALE, FEMALE };
    public class Employee
    {
        public WorkerType Position { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Experience { get; private set; }
        public virtual void DoWork()
        {
            Console.WriteLine("I am doing something");
        }

        public virtual void Unique_duites()
        {

            Console.WriteLine("I am doing something unique");

        }

        public Employee(WorkerType workertype, string name, string surname, int experience)
        {
            Position = workertype;
            Name = name;
            Surname = surname;
            Experience = experience;
        }


    }
    class Worker : Employee
    {
        public Worker(WorkerType workertype, string name, string surname, int experienc) : base(workertype, name, surname, experienc)
        {
        }
        public override void DoWork()
        {
            Console.WriteLine("Я выпускаю продукцию");
        }
    }

    class Manager : Employee
    {

        public Manager(WorkerType workertype, string name, string surname, int experienc) : base(workertype, name, surname, experienc)
        {

        }
        public override void DoWork()
        {
            Console.WriteLine("Я собираю заказы");
        }

        public override void Unique_duites()
        {
            string[] a = {
                "Изготовить топливный отсек",
                "Cоздать макет ракеты",
                "Обработать материал",
                "Строить",
                "Пиструпить изготовлению волшебного зелья",
                "Запустить раке"
            };

            Console.WriteLine($"Я даю вам задание: {a[new Random().Next(0, a.Length)]}");
        }
    }

    class Brigadier : Employee
    {
        public Brigadier(WorkerType workertype, string name, string surname, int experienc) : base(workertype, name, surname, experienc)
        {

        }
        public override void DoWork()
        {
            Console.WriteLine("Я занимаюсь закупкой материалов");
        }
    }
}
