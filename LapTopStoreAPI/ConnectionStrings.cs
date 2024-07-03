using Microsoft.Data.SqlClient;

namespace LapTopStoreAPI;

public class ConnectionStrings
{
    public static SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
    {
        DataSource = ".",
        InitialCatalog = "LapTopStore",
        IntegratedSecurity = true,
        TrustServerCertificate = true
    };
}
