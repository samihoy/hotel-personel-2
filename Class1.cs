using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_personel_2
{
    internal class Class1
    {

    }
    public class Person
    {
        public Person(string name, int age, int iD, DateTime startDate, double salary, string department)
        {
            this.name = name;
            this.age = age;
            ID = iD;
            this.startDate = startDate;
            this.salary = salary;
            this.department = department;
        }
        public string name { get; set; }
        public int age { get; set; }
        public int ID { get; set; }
        public DateTime startDate { get; set; }
        public double salary { get; set; }
        public string department { get; set; }

        public virtual void PersonalInfo()
        {
            Console.WriteLine($"Employment informatiom \n {name}\n {age} \n {ID} och \n {salary}");
        }
        public virtual void Introduce()
        {
            Console.WriteLine($"Jag heter \n {name} och är {age} gammal.");
        }
        public virtual void Work()
        {
            Console.WriteLine($"\n{name} gör sitt jobb och arbetar i {department} avdelningen\n");
        }
    }
    public class Manager : Person
    {        
        public Manager(string name, int age, int iD, DateTime startDate, double salary, string department) : base(name, age, iD, startDate, salary, department)
        {
            
        }
        public virtual void HoldMeeting()
        {
            base.Introduce(); // base to call the parent for information 
            Console.WriteLine($"{name} är i ett möte");
        }
        public virtual void PlanBudget()
        {
            base.Work();
            Console.WriteLine($"{name} planerar budgeten");
        }
    }
    public class Employee : Manager
    {
        public string jobtitle { get; set; }
        public Employee(string name, int age, int iD, DateTime startDate, double salary, string department, string jobtitle) : base(name, age, iD, startDate, salary, department)
        {
            this.jobtitle = jobtitle;
        }
        public override void Work()
        {
            base.Work();
            Console.WriteLine($"{name} arbetar som {jobtitle} och gör sitt jobb");
        }
    }
    public class Consult : Person
    {
        public double fee { get; set; }
        public string company { get; set; }

        public string expertise { get; set; }

        public Consult(string name, int age, int iD, DateTime startDate, double salary, double fee, string company, string expertise, string department) : base(name, age, iD, startDate, salary, department)
        {
            this.fee = fee;
            this.company = company;
            this.expertise = expertise;
        }
        public void GiveAdvice()
        {

            Console.WriteLine($"{name} ger råd hur dom kan förbättra sin {expertise} för {fee} i timmen");
        }
    }
    public class Housekeeper: Employee
    {
        public Housekeeper(string name, int age, int iD, DateTime startDate, double salary, string department, string jobtitle) : base(name, age, iD, startDate, salary, department,jobtitle)
        {

        }
        public override void Work()
        {
            base.Work(); 
        }
    }
}
    
