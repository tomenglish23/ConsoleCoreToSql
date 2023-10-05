using Microsoft.Extensions.Configuration;
using System;

using NetCoreConsoleToSql.TomTest.Logic;
using NetCoreConsoleToSql.WizLib.Logic;

namespace NetCoreConsoleToSql.Logic
{
    public static class Tests
    {
        public static void RunAllTests(IConfiguration config)
        {
            TestTomTest(config);
            TestAuthors(config);
        }

        static void TestTomTest(IConfiguration config)
        {
            Console.WriteLine("Test TomTest\n");

            var empLogic = new EmpLogic(config);
            empLogic.ShowEmployees();

            Console.WriteLine("\nPress any key to stop.");
            Console.ReadKey();
        }

        static void TestAuthors(IConfiguration config)
        {
            Console.WriteLine("Test Authors\n");

            var authorLogic = new AuthorLogic(config);
            authorLogic.ShowAuthors();

            Console.WriteLine("\nPress any key to stop.");
            Console.ReadKey();
        }
    }
}
