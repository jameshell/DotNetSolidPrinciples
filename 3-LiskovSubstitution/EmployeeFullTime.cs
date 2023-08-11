namespace Liskov
{
    public class EmployeeFullTime : Employee
    {
        public int _extraHours { get; set; }
        public EmployeeFullTime(string fullname, int hoursWorked, int extrahours) : base(fullname, hoursWorked)
        {
            _extraHours = extrahours;
        }
        public override decimal CalculateSalary ()
        {
            decimal hourValue = 50;
            return hourValue * (HoursWorked + _extraHours);
        } 
    }
}