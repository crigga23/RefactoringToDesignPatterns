using System;

namespace SourceMakingExamples.Core
{
    public class Employee
    {
        public int Salary { get; set; }
        public int Commission { get; set; }
        public int Bonus { get; set; }

        private EmployeeType EmployeeType { get; set; }

        public int GetSalary 
        {
            get { return Salary; }
        }

        public int GetCommission 
        {
            get { return Commission; }
        }

        public int GetBonus 
        {
            get { return Bonus; }
        }

        public Employee(EmployeeType type)
        {
            EmployeeType = type;
        }
    }

    public abstract class EmployeeType
    {
        internal const int ENGINEER = 1;
        internal const int SALESMAN = 2;
        internal const int MANAGER = 3;

        internal abstract int GetEmployeeTypeCode();

        public abstract int CalculatePayAmount(Employee employee);
    }

    public class Engineer : EmployeeType
    {
        internal override int GetEmployeeTypeCode()
        {
            return ENGINEER;
        }

        public override int CalculatePayAmount(Employee employee)
        {
            return employee.GetSalary;
        }
    }

    public class Salesman : EmployeeType
    {
        internal override int GetEmployeeTypeCode()
        {
            return SALESMAN;
        }

        public override int CalculatePayAmount(Employee employee)
        {
            return employee.GetSalary + employee.GetCommission;
        }
    }

    public class Manager : EmployeeType
    {
        internal override int GetEmployeeTypeCode()
        {
            return MANAGER;
        }

        public override int CalculatePayAmount(Employee employee)
        {
            return employee.GetSalary + employee.GetBonus;
        }
    }
}
