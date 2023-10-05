using Microsoft.Extensions.Configuration;
using System;

using NetCoreConsoleToSql.TomTest.DAL;

namespace NetCoreConsoleToSql.TomTest.Logic
{
    public class EmpLogic
    {
        private IConfiguration _config;

        public EmpLogic(IConfiguration config) 
        { 
            _config = config;
        }

        public void ShowEmployees()
        {
            var dal = new TomTestDAL(_config);
            var lst = dal.GetEmployees();
            Console.WriteLine("   ID  " +
                              "Last".PadRight(9) +
                              "First".PadRight(8) +
                              "Dept ID".PadLeft(7) +
                              "Salary".PadLeft(9) +
                              "Months".PadLeft(9));
            Console.WriteLine("_____  " + 
                              "____".PadRight(9) + 
                              "_____".PadRight(8) +
                              "_______".PadLeft(7) +
                              "_____".PadLeft(9) +
                              "______".PadLeft(9));

            lst.ForEach(i => {
                Console.WriteLine(
                      $"{i.Id}".PadLeft(5) + "  "
                    + $"{i.LName}".PadRight(9)
                    + $"{i.FName}".PadRight(8)
                    + $"{i.DeptId}".PadLeft(7)  // should check for null here?
                    + $"{i.Salary}".PadLeft(9)
                    + $"{i.Months}".PadLeft(9)
                    ); });
        }
    }
}