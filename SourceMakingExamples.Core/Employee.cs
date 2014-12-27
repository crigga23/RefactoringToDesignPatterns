using System;

namespace SourceMakingExamples.Core
{
    public class Employee
    {
        public int Salary { get; set; }
        public int Commission { get; set; }
        public int Bonus { get; set; }

        private EmployeeType EmployeeType { get; set; }

        public Employee(EmployeeType type)
        {
            EmployeeType = type;
        }

        public int CalculatePayAmount()
        {
            switch (GetTypeCode())
            {
                case EmployeeType.ENGINEER:
                    return Salary;
                case EmployeeType.SALESMAN:
                    return Salary + Commission;
                case EmployeeType.MANAGER:
                    return Salary + Bonus;
            }

            throw new Exception("This type of employee does not exist");
        }

        public int GetTypeCode()
        {
            return EmployeeType.GetEmployeeTypeCode();
        }
    }

    public abstract class EmployeeType
    {
        public const int ENGINEER = 1;
        public const int SALESMAN = 2;
        public const int MANAGER = 3;

        public abstract int GetEmployeeTypeCode();
    }

    public class Engineer : EmployeeType
    {
        public override int GetEmployeeTypeCode()
        {
            return ENGINEER;
        }
    }

    public class Salesman : EmployeeType
    {
        public override int GetEmployeeTypeCode()
        {
            return SALESMAN;
        }
    }

    public class Manager : EmployeeType
    {
        public override int GetEmployeeTypeCode()
        {
            return MANAGER;
        }
    }
}
