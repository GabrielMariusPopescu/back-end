using DesignPatterns.Business.AdapterPattern.Contracts;
using System.Collections.Generic;

namespace DesignPatterns.Business.AdapterPattern.Services
{
    public class Adapter : IAdapter
    {
        public Adapter(Adaptee adaptee) => this.adaptee = adaptee;

        public List<string> GetEmployees()
        {
            var employeeList = new List<string>();
            var employees = adaptee.GetEmployees();

            foreach (var employee in employees)
                employeeList.AddRange(employee);

            return employeeList;
        }

        //

        private readonly Adaptee adaptee;
    }
}
