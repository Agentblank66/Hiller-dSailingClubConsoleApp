using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSailingClubClassLibrary
{
    public class EmployeeRepo
    //Her laver vi en "Dictionary" over Employees
    {
        private Dictionary<int, Employee> Employees = new Dictionary<int, Employee>();

        //Her laver vi en Add metode. Vi bruger TryAdd, da 2 ID IKKE må være ens.
        public bool Add(Employee emp)
        {
            Employees.TryAdd(emp.Id, emp);

           return Employees.TryAdd(emp.Id, emp);
        }


        //Her laver vi en Update metode. Vi bruger nedstående metode.
        //Vi laver en “If” statement, da vi skal give employee nye parametre. 
        //ContainsKey bliver anvendt til at søge i dictionary, om den key vi søger efter er valid. ContainsKey har returtypen “Bool”.
        public Employee Update(Employee emp, string newName, int newTlf, string newEmail, string newAddress)
        {
            if (Employees.ContainsKey(emp.Id))
            {
                emp.Name = newName;
                emp.Tlf = newTlf;
                emp.Email = newEmail;
                emp.Address = newAddress;
            }
            return emp;
        }

        //Her laver vi metoden GetEmployee, som gør det muligt for os at søge 
        //efter Employees, ved hjælp af deres "ID".
        public Employee GetEmployee(int id)
        {
            return Employees[id];
        }

        //Her laver vi metoden DeleteEmployee, som gør det muligt for os at søge 
        //efter Employees, ved hjælp af deres "ID", og efterfølgende slette vedkommende.
        public bool DeleteEmployee(int id)
        {
            return Employees.Remove(id);
        }

        //Her laver vi en PrintAll, som gør det muligt at vise ALLE employees.
        public List<Employee> PrintAllEmployees()
        {
            return Employees.Values.ToList();
        }
    }
}
