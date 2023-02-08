using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class Company : Manager, Admin
    {
        int hra;
        string empId, staffId;
        int avgSalary;

        public Company() { }
        public Company(string empId, int hra, int avgSalary)
        {
            Console.WriteLine("Employee Details:");
            this.hra = hra;
            this.empId = empId;
            this.avgSalary = avgSalary;
            Console.WriteLine(this.empId + " " + this.hra + " " + this.avgSalary);
        }
        public Company(string empId, string staffId, int hra, int avgSalary)
        {
            Console.WriteLine("Staff Details:");
            this.empId = empId;
            this.hra = hra;
            this.staffId = staffId;
            this.avgSalary = avgSalary;
            Console.WriteLine(this.staffId + " " + this.empId + " " + this.hra + " " + this.avgSalary);
        }

        static void validateAdmin(int age)
        {
            if (age < 30)
            {
                throw new InvalidAdminException("Sorry, Age must be greater than 30,to be Admin");
            }
        }
      

      


         public void Manage(List<string> managers)
        {
            Console.WriteLine("Managers are: ");
            foreach (var i in managers)
            {
                Console.WriteLine(" " + i);
            }
        }

         public void ManagerLogin()
        {
            Console.WriteLine("Manager LoginDetails");
        }

        static void Main(string[] args)
        {

            try
            {
                validateAdmin(25);
            }
            catch (InvalidAdminException e)
            {
                Console.WriteLine(e.Message);
            }

            //Polymorphism
            Company obj = new Company("100", 4000, 40000);
            Company obj1 = new Company("12", "102", 4000, 5000);

            //List
            var Managers = new List<String>() { "Mahesh", "Mike" };
            var admins = new List<String>() { "Jack", "Rohan" };
            Manager managerObj = new Company();
            managerObj.ManagerLogin();
            managerObj.Manage(Managers);

            Admin AdminObj = new Company();
            AdminObj.AdminDetails();
            AdminObj.LoginAdmin(admins);
        
        }

        public void LoginAdmin(List<string> admins)
        {
            Console.WriteLine("Admins are: ");
            foreach (var i in admins)
            {
                Console.WriteLine(" " + i);
            }
        }

        public void AdminDetails()
        {
            Console.WriteLine("Admin Details ");
        }
    }  
}
