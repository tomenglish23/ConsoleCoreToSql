
namespace NetCoreConsoleToSql.TomTest.Models
{
    public class Emp
    {
        public int    Id { get; set; }
        public string LName { get; set; }
        public string FName  { get; set; }
        public int?    DeptId { get; set; }
        public int?    Salary { get; set; }
        public int?    Months { get; set; }
    }
}