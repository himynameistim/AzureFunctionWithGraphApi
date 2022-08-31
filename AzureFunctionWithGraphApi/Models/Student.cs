namespace AzureFunctionWithGraphApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }
}
