
using SQLite;

namespace Plugins.DataStore.SQLite;

public class ModelRepository //: IModelRepository
{
    //private SQLiteAsyncConnection _database;
    //public ModelRepository()
    //{
    //    _database = new SQLiteAsyncConnection(Constants.DBPath);
    //    _database.CreateTableAsync<Model>();
    //}

    //public async Task AddModelAsync(Model model)
    //    => await _database.InsertAsync(model);

    //public async Task<List<Model>> GetModelAsync(string filter)
    //{
    //    return await _database.QueryAsync<Model>(@"
    //        SELECT *
    //        FROM Model
    //        WHERE
    //            Name LIKE ? OR
    //            Email LIKE ? OR
    //            Phone Like ? OR
    //            Address Like ?",
    //            $"{filter}%",
    //            $"{filter}%",
    //            $"{filter}%",
    //            $"{filter}%");
    //}
}
