using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class EmployeeCreator 
    {
        private string[] MALE_NAMES = { "Иван", "Сергей", "Тарас", "Владимир", "Вячеслав" };
        private string[] MALE_SURNAMES = { "Иванов", "Петров", "Сергеев", "Рябов", "Тимофеев" };
        private string[] FEMALE_NAMES = { "Татьяна", "Анна", "Анастасия", "Елизавета", "Мария" };
        private string[] FEMALE_SURNAMES = { "Морева", "Иващенко", "Сергеева", "Зеленская", "Cтепанова" };

        private Random _randGenerator = new Random();
        public List<Employee> listEmp { get; set; } = new List<Employee>();
        
        
        public void Create(WorkerType workertype, SexType sex, int count)
        {
            Employee emp = null;

            for (int i = 0; i < count; i++)
            {
                switch (workertype)
                {
                    case WorkerType.бригадир:
                        emp = SexType.FEMALE == sex ? new Brigadier(WorkerType.бригадир,
                                                      FEMALE_NAMES[_randGenerator.Next(0, FEMALE_NAMES.Length)],
                                                      FEMALE_SURNAMES[_randGenerator.Next(0, FEMALE_SURNAMES.Length)],
                                                      _randGenerator.Next(1, 45))
                                                      :
                                                      new Brigadier(WorkerType.бригадир,
                                                      MALE_NAMES[_randGenerator.Next(0, MALE_NAMES.Length)],
                                                      MALE_SURNAMES[_randGenerator.Next(0, MALE_SURNAMES.Length)],
                                                      _randGenerator.Next(1, 45));
                        break;
                    case WorkerType.менеджер:
                        emp = SexType.FEMALE == sex ? new Manager(WorkerType.менеджер,
                                                      FEMALE_NAMES[_randGenerator.Next(0, FEMALE_NAMES.Length)],
                                                      FEMALE_SURNAMES[_randGenerator.Next(0, FEMALE_SURNAMES.Length)],
                                                      _randGenerator.Next(1, 45))
                                                      :
                                                      new Manager(WorkerType.менеджер,
                                                      MALE_NAMES[_randGenerator.Next(0, MALE_NAMES.Length)],
                                                      MALE_SURNAMES[_randGenerator.Next(0, MALE_SURNAMES.Length)],
                                                      _randGenerator.Next(1, 45));
                        break;

                    case WorkerType.рабочий:
                        emp = SexType.FEMALE == sex ? new Worker(WorkerType.рабочий,
                                                      FEMALE_NAMES[_randGenerator.Next(0, FEMALE_NAMES.Length)],
                                                      FEMALE_SURNAMES[_randGenerator.Next(0, FEMALE_SURNAMES.Length)],
                                                      _randGenerator.Next(1, 45))
                                                      :
                                                      new Worker(WorkerType.рабочий,
                                                      MALE_NAMES[_randGenerator.Next(0, MALE_NAMES.Length)],
                                                      MALE_SURNAMES[_randGenerator.Next(0, MALE_SURNAMES.Length)],
                                                      _randGenerator.Next(1, 45));
                        break;
                }

                listEmp.Add(emp);
            }
        }
    }
}