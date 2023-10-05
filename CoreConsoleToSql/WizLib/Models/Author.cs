using System;

namespace NetCoreConsoleToSql.WizLib.Models
{
    public class Author
    {
        public int      Author_Id { get; set; }
        public string   FirstName { get; set; }
        public string   LastName  { get; set; }
        public DateTime BirthDate { get; set; }
        public string   Location  { get; set; }
    }
}