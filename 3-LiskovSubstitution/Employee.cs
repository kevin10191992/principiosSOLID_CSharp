namespace Liskov
{
    public abstract class Employee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
        // public int ExtraHours {get;set;} esta propiedad no deberia estar aqui, debe estar en donde se usa

        public Employee(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public abstract decimal CalculateSalary();

        //  No debe estar aqui porque el salario se calcula diferente para cada tipo de empleado
        //public virtual decimal CalculateSalary (bool IsFullTime)
        //{   
        //    decimal hourValue = IsFullTime ? 50 : 40;
        //    return hourValue * (HoursWorked + ExtraHours);
        //} 
    }
}