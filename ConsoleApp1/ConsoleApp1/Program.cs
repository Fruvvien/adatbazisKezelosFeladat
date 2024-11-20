using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1, "ASd", 12);
            Student student2 = new Student(2, "NemASd", 14);
            Book book1 = new Book(1, "asdBook", "asd");
            Book book2 = new Book(2, "nemAsdBook", "nemAsd");
            Employee employee1 = new Employee(1, "ASDASD", "BossASd");
            Employee employee2 = new Employee(2, "KisASDASD", "NemBossAsd");

            Database<Student> database = new Database<Student>();
            Database<Book> database1 = new Database<Book>();
            Database<Employee> database3 = new Database<Employee>();
            database.AddRecord (student1);
            database.AddRecord (student2);
            database1.AddRecord(book1);
            database1.AddRecord(book2);
            database3.AddRecord(employee1);
            database3.AddRecord(employee2);
            Console.WriteLine(database.ToString());
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(database1.ToString());
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(database3.ToString());
            Console.WriteLine("------------------------------------------------------");


            Console.WriteLine("getrecord: " + database.GetRecord(2)); 
            database.RemoveRecord(2);
            Console.WriteLine ("törlés után megmaradt adat: " + database.ToString());
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("getrecord: " + database1.GetRecord(2));
            database1.RemoveRecord(2);
            Console.WriteLine("törlés után megmaradt adat: " + database1.ToString());
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("getrecord: " + database3.GetRecord(2));
            database3.RemoveRecord(2);
            Console.WriteLine("törlés után megmaradt adat: " + database3.ToString());
            Console.WriteLine("------------------------------------------------------");









        }
    }
}
