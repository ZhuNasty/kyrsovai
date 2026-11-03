using Microsoft.Data.SqlClient;

namespace AdmissionApp
{
    public static class Db
    {
        public static string ConnectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AdmissionDB;Integrated Security=True";
    }
}