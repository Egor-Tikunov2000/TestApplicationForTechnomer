namespace TexnomerSiteInfo;
namespace TestApplicationForTechnomer;
public static class ConnectionStrings {

    string sqlCon = "Host = localhost; Port = 5432; Database = TaskManager; Username = postgres; Password = s5!sz52x";
    public static void ConnectionInfo()
    {
        NpgsqlConnection sqlConection = new NpgsqlConnection(sqlCon);
        sqlConection.Open();
        NpgsqlCommand command = new NpgsqlCommand();
        command.Connection = sqlConection;
        sqlConection.Close();

    }

    
}