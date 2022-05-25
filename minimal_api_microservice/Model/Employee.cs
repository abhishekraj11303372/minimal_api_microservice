namespace minimal_api_microservice.Model
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string location { get; set; }
    }

    public class EmployeeCollection
    {
        public List<Employee> Employees { get; set; }
        public List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                Name = "Abhishek",
                location = "India",
                Id = "1"
                },
                new Employee()
                {
                Name = "Abhishek",
                location = "India",
                Id = "2"
                },
                new Employee()
                {
                Name = "Abhishek",
                location = "India",
                Id = "3"
                }
            };
        }
    }
}
