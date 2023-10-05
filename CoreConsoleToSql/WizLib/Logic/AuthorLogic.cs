using Microsoft.Extensions.Configuration;
using System;

using NetCoreConsoleToSql.WizLib.DAL;

namespace NetCoreConsoleToSql.WizLib.Logic
{
    public class AuthorLogic
    {
        private IConfiguration _config;

        public AuthorLogic(IConfiguration config) 
        { 
            _config = config;
        }

        public void ShowAuthors()
        {
            var dal = new AuthorsDAL(_config);
            var lst = dal.GetAuthors();
            Console.WriteLine("   ID  " + 
                              "First".PadRight(8) + 
                              "Last".PadRight(9) + 
                              "Birth Date".PadRight(13) + 
                              "Location");
            Console.WriteLine(" ____  " + 
                              "_____".PadRight(8) + 
                              "____".PadRight(9) + 
                              "__________".PadRight(13) + 
                              "________");

            lst.ForEach(i => {
                Console.WriteLine(
                    $"{i.Author_Id}".PadLeft(5) + "  " +
                    $"{i.FirstName}".PadRight(8) +
                    $"{i.LastName}".PadRight(9) +
                    $"{i.BirthDate.ToShortDateString()}".PadRight(13) +
                    $"{i.Location}" ); });
        }
    }
}