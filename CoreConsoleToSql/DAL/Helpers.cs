using System.Text;

namespace NetCoreConsoleToSql.DAL
{
    public static class Helpers
    {
        public static string GetSelectString(string db, string table)
        {
            var select = (new StringBuilder().Append("SELECT * FROM [")
                                             .Append(db).Append("].[dbo].[")
                                             .Append(table).Append("]")
                         ).ToString();
            return select;
        }
    }
}