using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaExpression
{
    public class Employee
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> eList = new List<Employee>();

            eList.Add(new Employee { ID =1, firstName = "Joe", lastName = "B" });
            eList.Add(new Employee { ID =2, firstName = "Ali", lastName = "A" });
            eList.Add(new Employee { ID =3, firstName = "James", lastName = "S" });
            eList.Add(new Employee { ID =4, firstName = "Guy", lastName = "B" });
            eList.Add(new Employee { ID =5, firstName = "Joe", lastName = "C" });
            eList.Add(new Employee { ID =6, firstName = "Molly", lastName = "X" });
            eList.Add(new Employee { ID =7, firstName = "Don", lastName = "C" });
            eList.Add(new Employee { ID =8, firstName = "Adam", lastName = "S" });
            eList.Add(new Employee { ID =9,firstName = "Ben", lastName = "T" });


            for(int i = 0; i < eList.Count; i++)
            {
                if(eList[i].firstName == "Joe")
                {
                    Console.WriteLine(eList[i].firstName + " " + eList[i].lastName + " " + eList[i].ID );
                    
                }

            }

            Console.WriteLine("---Now with the lambda method---");


            List<Employee> newList = eList.Where(x => x.ID >= 5).ToList();
            foreach(Employee employee in newList)
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.ID);

            }

            Console.ReadLine();
        }
    }
}
