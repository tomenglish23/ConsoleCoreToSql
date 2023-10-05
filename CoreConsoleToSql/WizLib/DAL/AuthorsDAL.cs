using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using NetCoreConsoleToSql.DAL;
using NetCoreConsoleToSql.WizLib.Models;

namespace NetCoreConsoleToSql.WizLib.DAL
{
    public class AuthorsDAL
    {
        private const string DB = "Wizlib2";

        private readonly string _connString;

        public AuthorsDAL(IConfiguration config)
        {
            this._connString = config.GetConnectionString(DB);
        }

        public List<Author> GetAuthors()
        {
            var table = "Authors";
            var lst = new List<Author>();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connString))
                {
                    var select = Helpers.GetSelectString(DB, table);

                    SqlCommand cmd = new SqlCommand(select, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        lst.Add(new Author {
                            Author_Id = rdr.GetInt32("Author_Id"),
                            FirstName = rdr.GetString("FirstName"),
                            LastName  = rdr.GetString("LastName"),
                            BirthDate = rdr.GetDateTime("BirthDate"),
                            Location  = rdr.GetString("Location") });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lst;
        }
    }
}