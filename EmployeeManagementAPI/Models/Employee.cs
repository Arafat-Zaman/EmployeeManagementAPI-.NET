namespace EmployeeManagementAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }  // Primary Key
        public string Name { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }
}
