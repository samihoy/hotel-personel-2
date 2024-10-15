using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_personel_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> personallista2 = new List<Person>();

            List<Person> personallista = new List<Person>
            {   new Person("Erik", 35, 298492, new DateTime(2019, 12, 04), 46000, "basement people"),
                new Manager("Bossman", 67, 234492, new DateTime(2019, 12, 04), 36000, "managment"),
                new Employee("Eva", 30, 267692, new DateTime(2019, 12, 04), 36000, "managment", "receptionist"),
                new Consult("Anna", 23, 234292, new DateTime(2019, 12, 04), 36000, 1500,"no department", "Hotell Experterna AB", "logistik"),
                new Housekeeper("Elin", 32, 26764, new DateTime(2019, 12, 04), 36000, "cleaning", "cleaner")

            };

            Person anställdx = new Person("Erik", 35, 267492, new DateTime(2019, 12, 04), 36.000, "basement people");
 
            Manager chef = new Manager("Bossman", 67, 267492, new DateTime(2019, 12, 04), 36.000, "managment");

            Employee anstäldz = new Employee("Eva", 30, 267492, new DateTime(2019, 12, 04), 36.000, "managment", "receptionist");
            
            Consult anställdv = new Consult("Anna", 23, 267492, new DateTime(2019, 12, 04), 36.000, 1500,"no department" ,"Hotell Experterna AB", "logistik");
            
            Housekeeper anstäldj = new Housekeeper("Elin", 32, 267492, new DateTime(2019, 12, 04), 36.000, "cleaning", "cleaner");
            

            personallista2.Add(anställdx);
            personallista2.Add(chef);
            personallista2.Add(anstäldz);
            personallista2.Add(anställdv);
            personallista2.Add(anstäldj);

            foreach (var item in personallista)
            {

                item.Work();
            }
            anställdv.GiveAdvice();

            double avrageage = personallista.Average(x=>x.age);
            double avragesalery = personallista.Average(y => y.salary);
            Console.WriteLine($"{avrageage} is the avrage age of your emploeys");
            Console.WriteLine($"{avragesalery} is the avrage salery of your emploeys");




            double i = 0;
            double z = 0;

            foreach (var item in personallista)
            {
                i++;
                z += item.age;

            }

            double yy = z / i;
            Console.WriteLine(yy);






        }
    }
}
