using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using NetCoreConsoleToSql.DAL;
using NetCoreConsoleToSql.TomTest.Models;

namespace NetCoreConsoleToSql.TomTest.DAL
{
    public class TomTestDAL
    {
        private const string DB = "TomTest";

        private readonly string _connString;

        public TomTestDAL(IConfiguration config)
        {
            this._connString = config.GetConnectionString(DB);
        }


        public List<Emp> GetEmployees()
        {
            string table = "Emp";
            var lst = new List<Emp>();
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
                        lst.Add(new Emp
                        {
                            Id     = rdr.GetInt32("Id")
                          , LName = rdr.GetString("LName")
                          , FName = rdr.GetString("FName")
                          , DeptId = rdr.GetSqlInt32(rdr.GetOrdinal("DeptId")).IsNull ? 0 : rdr.GetInt32("DeptId")
                          , Salary = rdr.GetSqlInt32(rdr.GetOrdinal("Salary")).IsNull ? 0 : rdr.GetInt32("Salary")
                          , Months = rdr.GetSqlInt32(rdr.GetOrdinal("Months")).IsNull ? 0 : rdr.GetInt32("Months")
                            // See class DbDataReaderExtensions
                        });
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