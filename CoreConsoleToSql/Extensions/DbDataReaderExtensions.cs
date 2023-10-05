using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace NetCoreConsoleToSql
{
    public static class DbDataReaderExtensions
    {
        //public static int GetInt32(this DbDataReader rdr, string col, int defaultValue)
        //{
        //    return rdr.GetSqlInt32(rdr.GetOrdinal(col)).IsNull ? 0
        //                                                       : rdr.GetInt32(rdr.GetOrdinal(col))
        //}
        // or
        //public static int GetInt32(this DbDataReader rdr, string col, int defaultValue)
        //{
        //    return rdr.GetSqlInt32(rdr.GetOrdinal(col)).IsNull ? defaultValue
        //                                                       : rdr.GetInt32(rdr.GetOrdinal(col))
        //}
    }
}
