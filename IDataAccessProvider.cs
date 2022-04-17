namespace inventory.DataAccess
{
    public interface IDataAccessProvider
    {
        void Register(User user);
        void UpdateUserRecord(User user);
        User GetUserRecord(string id);
        List<User> GetUserRecords();
    }
}
