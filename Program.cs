using System;
using System.Globalization;
using System.Collections.Generic;

namespace Curso
{
    class Program
    {
        static void Main()
        {

            Console.Write("How many employees will be registred? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> Employees = new List<Funcionario>();
    
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n Employees #{0}: ", i + 1);
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employees.Add(new Funcionario(id, nome, salario));
            }

            Console.Write("\nEnter employee ID that will have salary increase: ");
            int searchID = int.Parse(Console.ReadLine());

            Funcionario emp = Employees.Find(x => x.ID == searchID);

            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                emp.Aumento(percentage);
            }
            else
            {
                Console.WriteLine("That id not founded!");
            }

            Console.WriteLine("Update List:");
            foreach (Funcionario obj in Employees)
            {
                Console.WriteLine(obj);
            }

            Console.Read();
        }
    }
}
