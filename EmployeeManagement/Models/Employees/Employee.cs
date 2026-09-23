using EmployeeManagement.Models.Enum;

namespace EmployeeManagement.Models.Employees
{
    public class Employee
    {
        public string EmployeeId {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email {  get; set; }
        public string PhoneNumber {  get; set; }
        public DateTime DateOfBirth {  get; set; }
        public DateTime DateOfJoining {  get; set; }
        public string JobTitle {  get; set; }
        public string Department {  get; set; }
        public EmploymentStatus EmploymentStatus { get; set; }
    }
}
