using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            //Создаем экземпляр класса, который будет генерировать Employee
            EmployeeCreator employeeCreator = new();
            EmployeeCreator employee = employeeCreator;

            //Создаем жен WorkerType.бригадир
            employee.Create(WorkerType.бригадир, SexType.FEMALE, 10);

            //Создаем жен WorkerType.менеджер
            employee.Create(WorkerType.менеджер, SexType.FEMALE, 10);

            //Создаем жен WorkerType.рабочий
            employee.Create(WorkerType.рабочий, SexType.FEMALE, 10);


            //Создаем муж WorkerType.бригадир
            employee.Create(WorkerType.бригадир, SexType.MALE, 5);

            //Создаем муж WorkerType.менеджер
            employee.Create(WorkerType.менеджер, SexType.MALE, 5);

            //Создаем муж WorkerType.рабочий
            employee.Create(WorkerType.рабочий, SexType.MALE, 5);

            Console.WriteLine("Cписок сотрудников компании:\n\n\r");

            //ВЫВОДИМ РЕЗУЛЬТАТ ПОСЛЕ ВСЕХ МАНИПУЛЯЦИЙ
            foreach (Employee item in employee.listEmp)
            {

                //Отображаем все значения
                Console.WriteLine($" Имя: {item.Name}\n\rДолжнолсть:{item.Position}\n\rФамилия: {item.Surname}\n\rСтаж работы:{item.Experience}\n\r");
            }

            Console.Read();

        }
    }
}

