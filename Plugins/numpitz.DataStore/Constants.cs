
namespace Plugins.DataStore.SQLite;

public class Constants
{
    public const string DBFileName = "numpitzSQLite.db3";
    public static string DBPath => Path.Combine(FileSystem.AppDataDirectory, DBFileName);

}
