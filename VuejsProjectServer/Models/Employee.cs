namespace VuejsProjectServer.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public Department Department { get; set; }
        public DateTime DateofJoining { get; set; }
        public string PhotoFileName { get; set; }
    }
}
